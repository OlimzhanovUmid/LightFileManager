namespace LightFileManager.Forms
{
    partial class SearchDialogBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderbrowserbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.startsearchbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchresultslsbx = new System.Windows.Forms.ListBox();
            this.folderbrowserdlg = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.folderbrowserbtn);
            this.panel1.Controls.Add(this.cancelbtn);
            this.panel1.Controls.Add(this.startsearchbtn);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.searchresultslsbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 306);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Искать файлы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Место поиска:";
            // 
            // folderbrowserbtn
            // 
            this.folderbrowserbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.folderbrowserbtn.BackgroundImage = global::LightFileManager.Images.folder;
            this.folderbrowserbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.folderbrowserbtn.FlatAppearance.BorderSize = 0;
            this.folderbrowserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderbrowserbtn.Location = new System.Drawing.Point(413, 2);
            this.folderbrowserbtn.Name = "folderbrowserbtn";
            this.folderbrowserbtn.Size = new System.Drawing.Size(27, 26);
            this.folderbrowserbtn.TabIndex = 7;
            this.folderbrowserbtn.Text = "\r\n";
            this.folderbrowserbtn.UseVisualStyleBackColor = true;
            this.folderbrowserbtn.Click += new System.EventHandler(this.folderbrowserbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelbtn.Location = new System.Drawing.Point(460, 32);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(126, 24);
            this.cancelbtn.TabIndex = 8;
            this.cancelbtn.Text = "Отмена";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // startsearchbtn
            // 
            this.startsearchbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startsearchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startsearchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startsearchbtn.Location = new System.Drawing.Point(460, 3);
            this.startsearchbtn.Name = "startsearchbtn";
            this.startsearchbtn.Size = new System.Drawing.Size(126, 24);
            this.startsearchbtn.TabIndex = 9;
            this.startsearchbtn.Text = "Начать поиск";
            this.startsearchbtn.UseVisualStyleBackColor = true;
            this.startsearchbtn.Click += new System.EventHandler(this.startsearchbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(99, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(99, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 20);
            this.textBox1.TabIndex = 6;
            // 
            // searchresultslsbx
            // 
            this.searchresultslsbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchresultslsbx.BackColor = System.Drawing.Color.DarkGray;
            this.searchresultslsbx.FormattingEnabled = true;
            this.searchresultslsbx.Location = new System.Drawing.Point(11, 62);
            this.searchresultslsbx.Name = "searchresultslsbx";
            this.searchresultslsbx.Size = new System.Drawing.Size(601, 225);
            this.searchresultslsbx.TabIndex = 10;
            this.searchresultslsbx.DoubleClick += new System.EventHandler(this.searchresultslsbx_DoubleClick);
            // 
            // SearchDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 306);
            this.Controls.Add(this.panel1);
            this.Name = "SearchDialogBox";
            this.Text = "SearchDialogBox";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox searchresultslsbx;
        private System.Windows.Forms.Button folderbrowserbtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button startsearchbtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderbrowserdlg;
    }
}