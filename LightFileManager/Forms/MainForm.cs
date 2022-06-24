using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using LightFileManager.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using LightFileManager.Core;

namespace LightFileManager
{

    public partial class MainForm : Form, IFormData
    {
        private FileManager _fileManager;
        private DialogBox _dlgBox;
        private SearchDialogBox _searchDlgBox;
        private DirectoryInfoDialogBox _dirInfoDlgBox;
        private FileInfoDialogBox _fileInfoDlgBox;
        public MainForm()
        {
            InitializeComponent();
            _dlgBox = new DialogBox("Введите имя", "Отмена", "Ок");

            dirView.GotFocus += ViewGotFocus;

            dirView.ItemActivate += ListViewDoubleClick;

            _fileManager = new FileManager(dirView, imageList1, imageList2);

            dirpathtbx.Text = _fileManager.ViewDirectory.FullName;

            diskscmbx.Items.AddRange(_fileManager.Drives.Disks.ToArray());

            diskscmbx.SelectedIndex = 0;

            diskscmbx.SelectedIndexChanged += DiskscmbxSelectedValueChanged;
            for (int i = 0; i < diskscmbx.Items.Count; i++)
            {
                var root = new TreeNode() {Text = diskscmbx.Items[i].ToString(), Tag = diskscmbx.Items[i].ToString() };
                tvFiles.Nodes.Add(root);
                Build(root);
            }
            UpdateLabels();
            tabHistory.Add("");



        }

        private void UpdateLabels()
        {
            dirpathtbx.Text = _fileManager.ViewDirectory.FullName;

            disksizelb.Text = $"{_fileManager.Drives.Disks[diskscmbx.SelectedIndex].AvailableFreeSpace / Math.Pow(1024, 3): 0.00} ГБ / " +
                          $"{_fileManager.Drives.Disks[diskscmbx.SelectedIndex].TotalSize / Math.Pow(1024, 3): 0.00} ГБ";
        }
        private void ListViewDoubleClick(object sender, EventArgs e)
        {
            _fileManager.ItemDoubleClick(sender);
            UpdateLabels();
        }

        private void ChangeViewMode(object sender, EventArgs e)
        {
            _fileManager.ChangeViewMode(((sender as ToolStripMenuItem).Tag as string));
        }
        private void OpenNotepad(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }
        private void RefreshFiles(object sender, EventArgs e)
        {
            _fileManager.SetUpListView();
        }
        private void DiskscmbxSelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _fileManager.ChangeDirectory(_fileManager.Drives.Disks[diskscmbx.SelectedIndex].Name);
                UpdateLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateFolder(object sender, EventArgs e)
        {
            if (!(_dlgBox.ShowDialog() == DialogResult.OK))
                return;

            try
            {
                _fileManager.CreateFolder(_dlgBox.TextBox);
                RefreshFiles(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateFile(object sender, EventArgs e)
        {
            if (!(_dlgBox.ShowDialog() == DialogResult.OK))
                return;

            try
            {
                _fileManager.CreateFile(_dlgBox.TextBox);
                RefreshFiles(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteFiles(object sender, EventArgs e)
        {
            if (!(MessageBox.Show("Вы действительно хотите удалить эти объекты?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes))
                return;

            try
            {
                _fileManager.DeleteFiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CopyFiles(object sender, EventArgs e)
        {
            _fileManager.CopyFiles();
        }
        private void CutFiles(object sender, EventArgs e)
        {
            _fileManager.CutFiles();
        }
        private void PasteFiles(object sender, EventArgs e)
        {
            _fileManager.PasteFiles();
            _fileManager.SetUpListView();
        }
        private void SearchFile(object sender, EventArgs e)
        {
            try
            {
                _searchDlgBox = new SearchDialogBox(this);
                _searchDlgBox.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ChangeDirectory(string newPath)
        {
            _fileManager.ChangeDirectory(newPath);
        }
        private void InfoDialogBox(object sender, EventArgs e)
        {
            var tmp = _fileManager.GetSelectedItem();

            if (tmp is FileInfo)
            {
                _fileInfoDlgBox = new FileInfoDialogBox(tmp as FileInfo);
                _fileInfoDlgBox.Show();

                /*if (!(_fileInfoDlgBox.ShowDialog() == DialogResult.OK))
                    return;*/
            }
            else if (tmp is DirectoryInfo)
            {
                _dirInfoDlgBox = new DirectoryInfoDialogBox(tmp as DirectoryInfo);
                _dirInfoDlgBox.Show();

                /*if (!(_dirInfoDlgBox.ShowDialog() == DialogResult.OK))
                    return;*/
            }
        }
        private void ItemDragEvent(object sender, ItemDragEventArgs e)
        {
            var path = _fileManager.GetSelectedItemsPath();
            (sender as ListView).DoDragDrop(path, DragDropEffects.Copy);
        }
        private void ViewGotFocus(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory(_fileManager.ViewDirectory.FullName);
        }
        private void DragEnterEvent(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void DragDropEvent(object sender, DragEventArgs e)
        {
            string[] path;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                path = e.Data.GetData(DataFormats.FileDrop) as String[];
            }
            else
            {
                path = e.Data.GetData(typeof(string[])) as String[];
            }

            if (!(MessageBox.Show($"Вы действительно хотите скопировать {path.Length} элементов?", "Копирование", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                return;

            _fileManager.SetFilesToBuffer(path);

            if ((sender as ListView).Name == "listView1")
                _fileManager.PasteFiles();

            _fileManager.SetUpListView();
        }
        private void tvFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Build(e.Node);
        }
        private void Build(TreeNode parent)
        {
            var path = parent.Tag as string;
            parent.Nodes.Clear();

            try
            {
                //create dirs
                foreach (var dir in Directory.GetDirectories(path))
                {
                    var node = new TreeNode(Path.GetFileName(dir), new[] { new TreeNode("...") }) { Tag = dir };
                    parent.Nodes.Add(node);
                }

                ////create files
                //foreach (var file in Directory.GetFiles(path))
                //{
                //    var node = new TreeNode(Path.GetFileName(file), 1, 1) { Tag = file };
                //    parent.Nodes.Add(node);
                //}
            }
            catch
            {
                //oops, no access...
            }
        }

        private void tvFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            Build(e.Node);
            dirpathtbx.Text = e.Node.Tag as string;
            ChangeDirectory(dirpathtbx.Text);
        }
        List<string> tabHistory = new List<string>();
        private void Addtabpage_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage();
            foreach (Control control in tabstbctrl.SelectedTab.Controls)
            {
                tabPage.Controls.Add(control);
            }
            tabstbctrl.TabPages.Add(tabPage);
            tabstbctrl.SelectedIndex += 1;
        }

        private void Deletetabpage_Click(object sender, EventArgs e)
        {
            Control[] controls = new Control[tabstbctrl.SelectedTab.Controls.Count];
            foreach (Control control in tabstbctrl.SelectedTab.Controls)
            {
                controls[0] = control;
            }
            int selectedTab = tabstbctrl.SelectedIndex-1;
            tabstbctrl.TabPages.Remove(tabstbctrl.SelectedTab);
            tabstbctrl.TabPages[selectedTab].Controls.AddRange(controls);
            tabstbctrl.SelectedIndex = selectedTab;
        }

        private void tabstbctrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabHistory.Add(dirpathtbx.Text);
            Control[] controls = new Control[1];
            for (int i = 0; i < tabstbctrl.TabPages.Count; i++)
            {
                if (tabstbctrl.TabPages[i].Controls.Count != 0)
                {
                    foreach (Control control in tabstbctrl.TabPages[i].Controls)
                    {
                        controls[0] = control;
                    }
                }
            }
            tabstbctrl.SelectedTab.Controls.AddRange(controls);
        }

        private void dirpathtbx_DoubleClick(object sender, EventArgs e)
        {
            ChangeDirectory(dirpathtbx.Text);
        }

        private void tabctrlstrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (tabstbctrl.TabPages.Count == 1)
                Deletetabpage.Enabled = false;
            else
                Deletetabpage.Enabled = true;
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
