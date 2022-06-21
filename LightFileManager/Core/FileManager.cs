using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LightFileManager.Core
{
    public class FileManager
    {
        public Drives Drives { get; set; }

        public string Path { get; set; }

        public DirectoryInfo ViewDirectory { get; set; }

        private ListView _viewListView;
        // icons
        private List<ImageList> _viewImagelist;

        private Buffer _buffer;

        public FileManager(ListView view, 
                           ImageList viewImg, 
                           ImageList viewImgLarge)
        {
            _buffer = new Buffer();
            Drives = new Drives();
            Path = Drives.Disks[0].Name;
            Directory.SetCurrentDirectory(Path);

            _viewListView = view;

            //---------------------------------------------
            _viewImagelist = new List<ImageList>(2)
            {
                viewImg,
                viewImgLarge
            };

            //---------------------------------------------

            ViewDirectory = new DirectoryInfo(Path);

            SetUpListView();
            }

        public void SetUpListView()
        {
            var imgList   = _viewImagelist;
            var listView  = _viewListView;
            var directory = ViewDirectory;

            imgList[0].Images.Clear();
            imgList[1].Images.Clear();
            listView.Items.Clear();

            // Arrow up
            int i = 0;
            if (directory.Parent != null)
            {
                listView.Items.Add(new ListViewItem("..", i++) { Tag = "Folder" });
                imgList[0].Images.Add(Images.arrowUp);
                imgList[1].Images.Add(Images.arrowUp);
            }

            int index = i;
            // Directories
            if (directory.GetDirectories().Length > 0)
            {
                imgList[0].Images.Add(Images.folder);
                imgList[1].Images.Add(Images.folder);

                foreach (var dir in directory.GetDirectories())
                {
                    listView.Items.Add(dir.Name, index);
                    listView.Items[i].Tag = "Folder";
                    listView.Items[i].SubItems.Add("");
                    listView.Items[i].SubItems.Add("<Папка>");
                    listView.Items[i++].SubItems.Add(dir.CreationTime.ToShortDateString());
                }
                index++;
            }
           
            // Files
            foreach (var file in directory.GetFiles())
            {
                imgList[0].Images.Add(Icon.ExtractAssociatedIcon(file.FullName)?.ToBitmap() ?? throw new InvalidOperationException());
                imgList[1].Images.Add(Icon.ExtractAssociatedIcon(file.FullName)?.ToBitmap() ?? throw new InvalidOperationException());

                listView.Items.Add(file.Name, index++);
                listView.Items[i].Tag = "File";
                listView.Items[i].SubItems.Add(file.Extension);
                listView.Items[i].SubItems.Add(file.Length.ToString());
                listView.Items[i++].SubItems.Add(file.CreationTime.ToShortDateString());
            }
        }

        public void ChangeViewMode(string mode)
        {
            var tmp = _viewListView;
            tmp.View = (View)Enum.Parse(typeof(View), mode);
        }

        public void ItemDoubleClick(object sender)
        {
            var tmp = sender as ListView;
            try
            {
                switch ((string)tmp.FocusedItem.Tag)
                {
                    case "File":
                        Process.Start(tmp.FocusedItem.Text);
                        break;
                    case "Folder":
                        ChangeDirectory(tmp.FocusedItem.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ChangeDirectory(string newPath)
        {
            var tmp = new DirectoryInfo(newPath);
            tmp.GetFiles();
            

                ViewDirectory = tmp;
            

            Directory.SetCurrentDirectory(newPath);
            SetUpListView();
        }

        public void CreateFolder(string name)
        {
            if (name.Length < 1)
                throw new ArgumentException("Слишком короткое название!");
            else if (Directory.Exists(name))
                throw new ArgumentException("Папка с таким именем уже существует!");

            Directory.CreateDirectory(name);
        }

        public void CreateFile(string name)
        {
            if (name.Length < 1)
                throw new ArgumentException("Слишком короткое название!");
            else if (File.Exists(name))
                throw new ArgumentException("Файл с таким именем уже существует!");

            FileStream fs = new FileStream(name, FileMode.CreateNew, FileAccess.Write, FileShare.Inheritable);
            fs.Close();
        }
        
        public void DeleteFiles()
        {
            var listView = _viewListView;

            int index;
            foreach (ListViewItem item in listView.SelectedItems)
            {
                if (item.Text == @"..")
                    continue;
                else if ((item.Tag as string) == "Folder")
                    Directory.Delete(item.Text, true);
                else if ((item.Tag as string) == "File")
                    File.Delete(item.Text);

                index = _viewListView.Items.IndexOf(item);
                _viewListView.Items.RemoveAt(index);
            }
        }

        public object GetSelectedItem()
        {
            var listView = _viewListView;
            var sourcePath = ViewDirectory.FullName;

            if (listView.SelectedItems.Count == 0)
                return null;
            var item = listView.SelectedItems[0];

            if ((item.Tag as string) == "Folder")
                return new DirectoryInfo(sourcePath + "\\" + item.Text);
            else if ((item.Tag as string) == "File")
                return new FileInfo(sourcePath + "\\" + item.Text);

            return null;
        }

        public string[] GetSelectedItemsPath()
        {
            var listView = _viewListView;
            var sourcePath = ViewDirectory.FullName;
            var path = new List<string>();

            foreach (ListViewItem item in listView.SelectedItems)
            {
                if (item.Text == @"..")
                    continue;
                path.Add(sourcePath + "\\" + item.Text);
            }

            return path.ToArray();
        }

        public void CopyFiles()
        {
            _buffer.Type = TransferType.Copy;
            SetFilesToBuffer();
        }

        public void PasteFiles()
        {
            var sourcePath = ViewDirectory.FullName;

            string dir = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(sourcePath);

            if (_buffer.Type == TransferType.Copy)
            {
                foreach (var item in _buffer.GetFiles())
                {
                    try { File.Copy(item, System.IO.Path.GetFileName(item)); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                foreach (var item in _buffer.GetFolders())
                {
                    try { CopyFolder(new DirectoryInfo(item), Directory.GetCurrentDirectory()); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    finally { Directory.SetCurrentDirectory(sourcePath); }
                }
            }
            else
            {
                foreach (var item in _buffer.GetFiles())
                {
                    try { File.Move(item, System.IO.Path.GetFileName(item)); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

                foreach (var item in _buffer.GetFolders())
                {
                    try { Directory.Move(item, System.IO.Path.GetFileName(item)); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            Directory.SetCurrentDirectory(dir);
        }

        public void CutFiles()
        {
            _buffer.Type = TransferType.Cut;
            SetFilesToBuffer();
        }

        public void SetFilesToBuffer(string[] path)
        {
            _buffer.Clear();
            _buffer.Type = TransferType.Copy;

            foreach (var item in path)
            {
                if (File.Exists(item))
                    _buffer.AddFile(item);
                else if (Directory.Exists(item))
                    _buffer.AddFolder(item);
            }
        }

        private void SetFilesToBuffer()
        {
            _buffer.Clear();
            var listView =  _viewListView;
            var sourcePath = ViewDirectory.FullName;

            foreach (ListViewItem item in listView.SelectedItems)
            {
                if ((item.Tag as string) == "Folder")
                    _buffer.AddFolder(sourcePath + "\\" + item.Text);
                else if ((item.Tag as string) == "File")
                    _buffer.AddFile(sourcePath + "\\" + item.Text);
            }
        }

        private void CopyFolder(DirectoryInfo from, string to)
        {
            try
            {
                Directory.SetCurrentDirectory(to);
                Directory.CreateDirectory(from.Name);
                Directory.SetCurrentDirectory(from.Name);

                ArrayList current = new ArrayList();
                current.AddRange(from.GetFiles());
                current.AddRange(from.GetDirectories());

                foreach (var i in current)
                {
                    if (i is FileInfo)
                    {
                        (i as FileInfo).CopyTo($"{Directory.GetCurrentDirectory()}\\{(i as FileInfo).Name}");
                    }
                    else
                    {
                        CopyFolder(i as DirectoryInfo, Directory.GetCurrentDirectory());
                        Directory.SetCurrentDirectory("..");
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
