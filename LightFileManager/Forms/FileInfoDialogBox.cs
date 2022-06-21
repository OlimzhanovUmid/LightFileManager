using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LightFileManager.Forms
{
    public partial class FileInfoDialogBox : Form
    {
        public string FileName { get => filenametbx.Text; }

        public FileInfoDialogBox(FileInfo fileInfo)
        {
            InitializeComponent();
            var fileInfo1 = fileInfo;

            filepbx.BackgroundImage = Icon.ExtractAssociatedIcon(fileInfo.FullName)?.ToBitmap();
            filenametbx.Text = fileInfo1.Name;
            locationLabel.Text = Path.GetDirectoryName(fileInfo1.FullName);
            createdLabel.Text = fileInfo1.CreationTime.ToLongDateString();
            editedLabel.Text = fileInfo1.LastWriteTime.ToLongDateString();
            openedLabel.Text = fileInfo1.LastAccessTime.ToLongDateString();
            typeLabel.Text = Path.GetExtension(fileInfo.FullName);
            sizeLabel.Text = $@"{fileInfo.Length / Math.Pow(1024, 2): 0.00} МБ.";

            if (fileInfo1.Attributes.HasFlag(FileAttributes.Hidden))
                ishiddenchbx.CheckState = CheckState.Checked;

            if (fileInfo1.Attributes.HasFlag(FileAttributes.ReadOnly))
                onlyreadingchbx.CheckState = CheckState.Checked;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
