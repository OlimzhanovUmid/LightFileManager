using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightFileManager.Core;

namespace LightFileManager.Forms
{
    public partial class SearchDialogBox : Form
    {
        private Searcher _searcher;
        private IFormData _parentForm;

        public SearchDialogBox(IFormData f)
        {
            InitializeComponent();
            startsearchbtn.Enabled = false;
            _searcher = new Searcher();
            _parentForm = f;
        }

        private async void StartSearch()
        {
            await Task.Factory.StartNew(() => {

                try
                {
                    _searcher.Search(new DirectoryInfo(textBox1.Text), textBox2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (_searcher.Results.Count == 0)
                {
                    MessageBox.Show(@"Ничего не найдено!", @"Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                searchresultslsbx.Items.AddRange(_searcher.Results.ToArray());
            });
        }

        private void startsearchbtn_Click(object sender, EventArgs e)
        {
            searchresultslsbx.Items.Clear();
            _searcher.Clear();

            StartSearch();
        }

        private void folderbrowserbtn_Click(object sender, EventArgs e)
        {
            if (!(folderbrowserdlg.ShowDialog() == DialogResult.OK))
                return;

            textBox1.Text = folderbrowserdlg.SelectedPath;
            startsearchbtn.Enabled = true;

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchresultslsbx_DoubleClick(object sender, EventArgs e)
        {
            var item = searchresultslsbx.SelectedItem as string;

            if (File.Exists(item))
            {
                if (item != null) Process.Start(item);
            }
            else if (Directory.Exists(item))
            {
                try
                {
                    _parentForm.ChangeDirectory(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }
    }
}
