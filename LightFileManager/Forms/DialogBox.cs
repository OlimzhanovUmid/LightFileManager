using System.Windows.Forms;

namespace LightFileManager.Forms
{
    public partial class DialogBox : Form
    {
        public string TextBox { get => dialboxtbx.Text; }

        public DialogBox(string text, string cancelbtnName, string okbtnName)
        {
            InitializeComponent();
            this.Name = text;
            cancelbtn.Text = cancelbtnName;
            okbtn.Text = okbtnName;
        }
    }
}
