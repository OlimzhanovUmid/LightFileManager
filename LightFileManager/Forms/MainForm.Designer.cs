namespace LightFileManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.maincontainer = new System.Windows.Forms.SplitContainer();
            this.tabstbctrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menumnstrp = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statstrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tvFiles = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.maincontainer)).BeginInit();
            this.maincontainer.Panel1.SuspendLayout();
            this.maincontainer.Panel2.SuspendLayout();
            this.maincontainer.SuspendLayout();
            this.tabstbctrl.SuspendLayout();
            this.menumnstrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // maincontainer
            // 
            this.maincontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maincontainer.Location = new System.Drawing.Point(0, 52);
            this.maincontainer.Name = "maincontainer";
            // 
            // maincontainer.Panel1
            // 
            this.maincontainer.Panel1.Controls.Add(this.tvFiles);
            // 
            // maincontainer.Panel2
            // 
            this.maincontainer.Panel2.Controls.Add(this.tabstbctrl);
            this.maincontainer.Size = new System.Drawing.Size(902, 476);
            this.maincontainer.SplitterDistance = 263;
            this.maincontainer.TabIndex = 0;
            // 
            // tabstbctrl
            // 
            this.tabstbctrl.Controls.Add(this.tabPage1);
            this.tabstbctrl.Controls.Add(this.tabPage2);
            this.tabstbctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabstbctrl.Location = new System.Drawing.Point(0, 0);
            this.tabstbctrl.Name = "tabstbctrl";
            this.tabstbctrl.SelectedIndex = 0;
            this.tabstbctrl.Size = new System.Drawing.Size(635, 476);
            this.tabstbctrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menumnstrp
            // 
            this.menumnstrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menumnstrp.Location = new System.Drawing.Point(0, 0);
            this.menumnstrp.Name = "menumnstrp";
            this.menumnstrp.Size = new System.Drawing.Size(902, 24);
            this.menumnstrp.TabIndex = 1;
            this.menumnstrp.Text = "Menu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлToolStripMenuItem.Text = "Файлы";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // statstrip
            // 
            this.statstrip.Location = new System.Drawing.Point(0, 531);
            this.statstrip.Name = "statstrip";
            this.statstrip.Size = new System.Drawing.Size(902, 22);
            this.statstrip.TabIndex = 3;
            this.statstrip.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(902, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tvFiles
            // 
            this.tvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tvFiles.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tvFiles.Location = new System.Drawing.Point(0, 0);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(263, 476);
            this.tvFiles.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 553);
            this.Controls.Add(this.statstrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.maincontainer);
            this.Controls.Add(this.menumnstrp);
            this.MainMenuStrip = this.menumnstrp;
            this.Name = "MainForm";
            this.Text = "Main";
            this.maincontainer.Panel1.ResumeLayout(false);
            this.maincontainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maincontainer)).EndInit();
            this.maincontainer.ResumeLayout(false);
            this.tabstbctrl.ResumeLayout(false);
            this.menumnstrp.ResumeLayout(false);
            this.menumnstrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer maincontainer;
        private System.Windows.Forms.TabControl tabstbctrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menumnstrp;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statstrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView tvFiles;
    }
}

