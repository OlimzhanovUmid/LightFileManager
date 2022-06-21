namespace LightFileManager.Forms
{
    partial class FileInfoDialogBox
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
            this.fileinfpan = new System.Windows.Forms.Panel();
            this.okbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.onlyreadingchbx = new System.Windows.Forms.CheckBox();
            this.ishiddenchbx = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openedLabel = new System.Windows.Forms.Label();
            this.editedLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filepbx = new System.Windows.Forms.PictureBox();
            this.filenametbx = new System.Windows.Forms.TextBox();
            this.fileinfpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filepbx)).BeginInit();
            this.SuspendLayout();
            // 
            // fileinfpan
            // 
            this.fileinfpan.BackColor = System.Drawing.Color.DarkGray;
            this.fileinfpan.Controls.Add(this.okbtn);
            this.fileinfpan.Controls.Add(this.cancelbtn);
            this.fileinfpan.Controls.Add(this.onlyreadingchbx);
            this.fileinfpan.Controls.Add(this.ishiddenchbx);
            this.fileinfpan.Controls.Add(this.label4);
            this.fileinfpan.Controls.Add(this.openedLabel);
            this.fileinfpan.Controls.Add(this.editedLabel);
            this.fileinfpan.Controls.Add(this.sizeLabel);
            this.fileinfpan.Controls.Add(this.label8);
            this.fileinfpan.Controls.Add(this.label7);
            this.fileinfpan.Controls.Add(this.label5);
            this.fileinfpan.Controls.Add(this.createdLabel);
            this.fileinfpan.Controls.Add(this.label3);
            this.fileinfpan.Controls.Add(this.locationLabel);
            this.fileinfpan.Controls.Add(this.label2);
            this.fileinfpan.Controls.Add(this.typeLabel);
            this.fileinfpan.Controls.Add(this.label1);
            this.fileinfpan.Controls.Add(this.filepbx);
            this.fileinfpan.Controls.Add(this.filenametbx);
            this.fileinfpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileinfpan.Location = new System.Drawing.Point(0, 0);
            this.fileinfpan.Name = "fileinfpan";
            this.fileinfpan.Size = new System.Drawing.Size(461, 279);
            this.fileinfpan.TabIndex = 7;
            // 
            // okbtn
            // 
            this.okbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okbtn.Location = new System.Drawing.Point(272, 240);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(81, 27);
            this.okbtn.TabIndex = 21;
            this.okbtn.Text = "ОК";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelbtn.Location = new System.Drawing.Point(359, 240);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(81, 27);
            this.cancelbtn.TabIndex = 22;
            this.cancelbtn.Text = "Отмена";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // onlyreadingchbx
            // 
            this.onlyreadingchbx.AutoSize = true;
            this.onlyreadingchbx.Enabled = false;
            this.onlyreadingchbx.Location = new System.Drawing.Point(311, 202);
            this.onlyreadingchbx.Name = "onlyreadingchbx";
            this.onlyreadingchbx.Size = new System.Drawing.Size(121, 17);
            this.onlyreadingchbx.TabIndex = 19;
            this.onlyreadingchbx.Text = "Только для чтения";
            this.onlyreadingchbx.UseVisualStyleBackColor = true;
            // 
            // ishiddenchbx
            // 
            this.ishiddenchbx.AutoSize = true;
            this.ishiddenchbx.Enabled = false;
            this.ishiddenchbx.Location = new System.Drawing.Point(311, 180);
            this.ishiddenchbx.Name = "ishiddenchbx";
            this.ishiddenchbx.Size = new System.Drawing.Size(72, 17);
            this.ishiddenchbx.TabIndex = 20;
            this.ishiddenchbx.Text = "Скрытый";
            this.ishiddenchbx.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Атрибуты:";
            // 
            // openedLabel
            // 
            this.openedLabel.AutoSize = true;
            this.openedLabel.Location = new System.Drawing.Point(308, 151);
            this.openedLabel.Name = "openedLabel";
            this.openedLabel.Size = new System.Drawing.Size(61, 13);
            this.openedLabel.TabIndex = 7;
            this.openedLabel.Text = "25.09.2018";
            // 
            // editedLabel
            // 
            this.editedLabel.AutoSize = true;
            this.editedLabel.Location = new System.Drawing.Point(308, 125);
            this.editedLabel.Name = "editedLabel";
            this.editedLabel.Size = new System.Drawing.Size(61, 13);
            this.editedLabel.TabIndex = 8;
            this.editedLabel.Text = "25.09.2018";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(308, 73);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(84, 13);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "Идет подсчет...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Открыт: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Изменен: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Размер: ";
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(308, 99);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(61, 13);
            this.createdLabel.TabIndex = 13;
            this.createdLabel.Text = "25.09.2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Создан:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(308, 47);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(22, 13);
            this.locationLabel.TabIndex = 15;
            this.locationLabel.Text = "C:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Расположение:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(308, 21);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(21, 13);
            this.typeLabel.TabIndex = 17;
            this.typeLabel.Text = ".txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип файла:";
            // 
            // filepbx
            // 
            this.filepbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.filepbx.ErrorImage = null;
            this.filepbx.Location = new System.Drawing.Point(3, 63);
            this.filepbx.Name = "filepbx";
            this.filepbx.Size = new System.Drawing.Size(128, 110);
            this.filepbx.TabIndex = 1;
            this.filepbx.TabStop = false;
            // 
            // filenametbx
            // 
            this.filenametbx.BackColor = System.Drawing.Color.Silver;
            this.filenametbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filenametbx.Enabled = false;
            this.filenametbx.Location = new System.Drawing.Point(3, 37);
            this.filenametbx.Name = "filenametbx";
            this.filenametbx.Size = new System.Drawing.Size(128, 20);
            this.filenametbx.TabIndex = 0;
            // 
            // FileInfoDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 279);
            this.Controls.Add(this.fileinfpan);
            this.Name = "FileInfoDialogBox";
            this.Text = "FileInfoDialogBox";
            this.fileinfpan.ResumeLayout(false);
            this.fileinfpan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filepbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fileinfpan;
        private System.Windows.Forms.CheckBox onlyreadingchbx;
        private System.Windows.Forms.CheckBox ishiddenchbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label openedLabel;
        private System.Windows.Forms.Label editedLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox filepbx;
        private System.Windows.Forms.TextBox filenametbx;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}