namespace LightFileManager.Forms
{
    partial class DirectoryInfoDialogBox
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
            this.infopan = new System.Windows.Forms.Panel();
            this.okbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.onlyredingchbx = new System.Windows.Forms.CheckBox();
            this.folderpbx = new System.Windows.Forms.PictureBox();
            this.ishiddenchbx = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filesCountLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dirtypelb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dirnametbx = new System.Windows.Forms.TextBox();
            this.infopan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderpbx)).BeginInit();
            this.SuspendLayout();
            // 
            // infopan
            // 
            this.infopan.BackColor = System.Drawing.Color.DarkGray;
            this.infopan.Controls.Add(this.okbtn);
            this.infopan.Controls.Add(this.cancelbtn);
            this.infopan.Controls.Add(this.onlyredingchbx);
            this.infopan.Controls.Add(this.folderpbx);
            this.infopan.Controls.Add(this.ishiddenchbx);
            this.infopan.Controls.Add(this.label4);
            this.infopan.Controls.Add(this.filesCountLabel);
            this.infopan.Controls.Add(this.sizeLabel);
            this.infopan.Controls.Add(this.label7);
            this.infopan.Controls.Add(this.label5);
            this.infopan.Controls.Add(this.createdLabel);
            this.infopan.Controls.Add(this.label3);
            this.infopan.Controls.Add(this.locationLabel);
            this.infopan.Controls.Add(this.label2);
            this.infopan.Controls.Add(this.dirtypelb);
            this.infopan.Controls.Add(this.label1);
            this.infopan.Controls.Add(this.dirnametbx);
            this.infopan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infopan.Location = new System.Drawing.Point(0, 0);
            this.infopan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infopan.Name = "infopan";
            this.infopan.Size = new System.Drawing.Size(568, 298);
            this.infopan.TabIndex = 1;
            // 
            // okbtn
            // 
            this.okbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okbtn.Location = new System.Drawing.Point(328, 250);
            this.okbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(108, 33);
            this.okbtn.TabIndex = 4;
            this.okbtn.Text = "ОК";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelbtn.Location = new System.Drawing.Point(444, 250);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(108, 33);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Отмена";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // onlyredingchbx
            // 
            this.onlyredingchbx.AutoSize = true;
            this.onlyredingchbx.Enabled = false;
            this.onlyredingchbx.Location = new System.Drawing.Point(387, 222);
            this.onlyredingchbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.onlyredingchbx.Name = "onlyredingchbx";
            this.onlyredingchbx.Size = new System.Drawing.Size(151, 20);
            this.onlyredingchbx.TabIndex = 3;
            this.onlyredingchbx.Text = "Только для чтения";
            this.onlyredingchbx.UseVisualStyleBackColor = true;
            // 
            // folderpbx
            // 
            this.folderpbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.folderpbx.ErrorImage = null;
            this.folderpbx.Location = new System.Drawing.Point(4, 78);
            this.folderpbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.folderpbx.Name = "folderpbx";
            this.folderpbx.Size = new System.Drawing.Size(171, 135);
            this.folderpbx.TabIndex = 1;
            this.folderpbx.TabStop = false;
            // 
            // ishiddenchbx
            // 
            this.ishiddenchbx.AutoSize = true;
            this.ishiddenchbx.Enabled = false;
            this.ishiddenchbx.Location = new System.Drawing.Point(387, 192);
            this.ishiddenchbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ishiddenchbx.Name = "ishiddenchbx";
            this.ishiddenchbx.Size = new System.Drawing.Size(86, 20);
            this.ishiddenchbx.TabIndex = 3;
            this.ishiddenchbx.Text = "Скрытый";
            this.ishiddenchbx.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Атрибуты:";
            // 
            // filesCountLabel
            // 
            this.filesCountLabel.AutoSize = true;
            this.filesCountLabel.Location = new System.Drawing.Point(383, 158);
            this.filesCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesCountLabel.Name = "filesCountLabel";
            this.filesCountLabel.Size = new System.Drawing.Size(106, 16);
            this.filesCountLabel.TabIndex = 2;
            this.filesCountLabel.Text = "Идет подсчет...";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(383, 127);
            this.sizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(106, 16);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Идет подсчет...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Содержит: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Размер: ";
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(383, 92);
            this.createdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(69, 16);
            this.createdLabel.TabIndex = 2;
            this.createdLabel.Text = "25.09.2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Создан:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(383, 58);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(23, 16);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "C:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Расположение:";
            // 
            // dirtypelb
            // 
            this.dirtypelb.AutoSize = true;
            this.dirtypelb.Location = new System.Drawing.Point(383, 23);
            this.dirtypelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dirtypelb.Name = "dirtypelb";
            this.dirtypelb.Size = new System.Drawing.Size(121, 16);
            this.dirtypelb.TabIndex = 2;
            this.dirtypelb.Text = "Папка с файлами";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип:";
            // 
            // dirnametbx
            // 
            this.dirnametbx.BackColor = System.Drawing.Color.Silver;
            this.dirnametbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dirnametbx.Enabled = false;
            this.dirnametbx.Location = new System.Drawing.Point(4, 46);
            this.dirnametbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dirnametbx.Name = "dirnametbx";
            this.dirnametbx.Size = new System.Drawing.Size(170, 22);
            this.dirnametbx.TabIndex = 0;
            // 
            // DirectoryInfoDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 298);
            this.Controls.Add(this.infopan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DirectoryInfoDialogBox";
            this.Text = "DirectoryInfoDialogBox";
            this.infopan.ResumeLayout(false);
            this.infopan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderpbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infopan;
        private System.Windows.Forms.CheckBox onlyredingchbx;
        private System.Windows.Forms.CheckBox ishiddenchbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label filesCountLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dirtypelb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox folderpbx;
        private System.Windows.Forms.TextBox dirnametbx;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}