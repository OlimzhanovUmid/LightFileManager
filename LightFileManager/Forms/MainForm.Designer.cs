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
            this.components = new System.ComponentModel.Container();
            this.maincontainer = new System.Windows.Forms.SplitContainer();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.tabstbctrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menumnstrp = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMode = new System.Windows.Forms.ToolStripMenuItem();
            this.statstrip = new System.Windows.Forms.StatusStrip();
            this.maintoolstrip = new System.Windows.Forms.ToolStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.List1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Details1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeIcons1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.maincontainer)).BeginInit();
            this.maincontainer.Panel1.SuspendLayout();
            this.maincontainer.Panel2.SuspendLayout();
            this.maincontainer.SuspendLayout();
            this.tabstbctrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menumnstrp.SuspendLayout();
            this.maintoolstrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maincontainer
            // 
            this.maincontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maincontainer.BackColor = System.Drawing.Color.DarkGray;
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
            this.maincontainer.Size = new System.Drawing.Size(1009, 476);
            this.maincontainer.SplitterDistance = 298;
            this.maincontainer.TabIndex = 0;
            // 
            // tvFiles
            // 
            this.tvFiles.BackColor = System.Drawing.Color.DarkGray;
            this.tvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tvFiles.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tvFiles.Location = new System.Drawing.Point(0, 0);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(298, 476);
            this.tvFiles.TabIndex = 0;
            // 
            // tabstbctrl
            // 
            this.tabstbctrl.Controls.Add(this.tabPage1);
            this.tabstbctrl.Controls.Add(this.tabPage2);
            this.tabstbctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabstbctrl.Location = new System.Drawing.Point(0, 0);
            this.tabstbctrl.Margin = new System.Windows.Forms.Padding(0);
            this.tabstbctrl.Name = "tabstbctrl";
            this.tabstbctrl.Padding = new System.Drawing.Point(0, 0);
            this.tabstbctrl.SelectedIndex = 0;
            this.tabstbctrl.Size = new System.Drawing.Size(707, 476);
            this.tabstbctrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(699, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(699, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // menumnstrp
            // 
            this.menumnstrp.BackColor = System.Drawing.Color.Transparent;
            this.menumnstrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ViewMode});
            this.menumnstrp.Location = new System.Drawing.Point(0, 0);
            this.menumnstrp.Name = "menumnstrp";
            this.menumnstrp.Size = new System.Drawing.Size(1009, 24);
            this.menumnstrp.TabIndex = 1;
            this.menumnstrp.Text = "Menu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.файлToolStripMenuItem.Text = "Файлы";
            // 
            // ViewMode
            // 
            this.ViewMode.BackColor = System.Drawing.Color.DarkGray;
            this.ViewMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.List1,
            this.Details1,
            this.LargeIcons1});
            this.ViewMode.Name = "ViewMode";
            this.ViewMode.Size = new System.Drawing.Size(39, 20);
            this.ViewMode.Text = "Вид";
            // 
            // statstrip
            // 
            this.statstrip.Location = new System.Drawing.Point(0, 531);
            this.statstrip.Name = "statstrip";
            this.statstrip.Size = new System.Drawing.Size(1009, 22);
            this.statstrip.TabIndex = 3;
            this.statstrip.Text = "statusStrip1";
            // 
            // maintoolstrip
            // 
            this.maintoolstrip.BackColor = System.Drawing.Color.Transparent;
            this.maintoolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton6});
            this.maintoolstrip.Location = new System.Drawing.Point(0, 24);
            this.maintoolstrip.MinimumSize = new System.Drawing.Size(0, 0);
            this.maintoolstrip.Name = "maintoolstrip";
            this.maintoolstrip.Padding = new System.Windows.Forms.Padding(0);
            this.maintoolstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.maintoolstrip.Size = new System.Drawing.Size(1009, 25);
            this.maintoolstrip.TabIndex = 2;
            this.maintoolstrip.Text = "toolStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(182, -1);
            this.textBox1.MinimumSize = new System.Drawing.Size(2, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(515, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.MaximumSize = new System.Drawing.Size(125, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 21);
            this.panel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.Silver;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageList3;
            this.listView1.Location = new System.Drawing.Point(0, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(699, 430);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ItemDragEvent);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropEvent);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterEvent);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(61, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LightFileManager.Images.refresh;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.RefreshFiles);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LightFileManager.Properties.Resources.copy;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.CopyFiles);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::LightFileManager.Images.paste;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.PasteFiles);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::LightFileManager.Images.delete;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.DeleteFiles);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::LightFileManager.Properties.Resources.search;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.SearchFile);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::LightFileManager.Images.notepad;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.OpenNotepad);
            // 
            // List1
            // 
            this.List1.Image = global::LightFileManager.Images.list;
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(164, 22);
            this.List1.Tag = "List";
            this.List1.Text = "Список";
            this.List1.Click += new System.EventHandler(this.ChangeViewMode);
            // 
            // Details1
            // 
            this.Details1.Image = global::LightFileManager.Images.details;
            this.Details1.Name = "Details1";
            this.Details1.Size = new System.Drawing.Size(164, 22);
            this.Details1.Tag = "Details";
            this.Details1.Text = "Таблица";
            this.Details1.Click += new System.EventHandler(this.ChangeViewMode);
            // 
            // LargeIcons1
            // 
            this.LargeIcons1.Image = global::LightFileManager.Images.largeIcons;
            this.LargeIcons1.Name = "LargeIcons1";
            this.LargeIcons1.Size = new System.Drawing.Size(164, 22);
            this.LargeIcons1.Tag = "LargeIcon";
            this.LargeIcons1.Text = "Крупные значки";
            this.LargeIcons1.Click += new System.EventHandler(this.ChangeViewMode);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1009, 553);
            this.Controls.Add(this.statstrip);
            this.Controls.Add(this.maintoolstrip);
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
            this.tabPage1.ResumeLayout(false);
            this.menumnstrp.ResumeLayout(false);
            this.menumnstrp.PerformLayout();
            this.maintoolstrip.ResumeLayout(false);
            this.maintoolstrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer maincontainer;
        private System.Windows.Forms.MenuStrip menumnstrp;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMode;
        private System.Windows.Forms.StatusStrip statstrip;
        private System.Windows.Forms.ToolStrip maintoolstrip;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.TabControl tabstbctrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.ToolStripMenuItem List1;
        private System.Windows.Forms.ToolStripMenuItem Details1;
        private System.Windows.Forms.ToolStripMenuItem LargeIcons1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
    }
}

