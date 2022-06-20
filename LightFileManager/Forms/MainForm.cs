using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightFileManager.Core;

namespace LightFileManager
{
    public partial class MainForm : Form
    {
        private FileManager _fileManager;
        public MainForm()
        {
            InitializeComponent();
            //create root
            var drives = _fileManager.Drives.Disks.ToArray();
            for (int i = 0; i < drives.Length; i++)
            {
                var root = new TreeNode() {Text = "C:", Tag = "c:\\"};
                tvFiles.Nodes.Add(root);
                Build(root);
            }
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

                //create files
                foreach (var file in Directory.GetFiles(path))
                {
                    var node = new TreeNode(Path.GetFileName(file), 1, 1) { Tag = file };
                    parent.Nodes.Add(node);
                }
            }
            catch
            {
                //oops, no access...
            }
        }

        private void tvFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Build(e.Node);
        }
    }
}
