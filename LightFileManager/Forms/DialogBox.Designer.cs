﻿namespace LightFileManager.Forms
{
    partial class DialogBox
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
            this.dialboxtbx = new System.Windows.Forms.TextBox();
            this.okbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dialboxtbx
            // 
            this.dialboxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dialboxtbx.BackColor = System.Drawing.Color.Silver;
            this.dialboxtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dialboxtbx.Location = new System.Drawing.Point(16, 15);
            this.dialboxtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dialboxtbx.Name = "dialboxtbx";
            this.dialboxtbx.Size = new System.Drawing.Size(317, 22);
            this.dialboxtbx.TabIndex = 0;
            // 
            // okbtn
            // 
            this.okbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbtn.Location = new System.Drawing.Point(125, 50);
            this.okbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(100, 28);
            this.okbtn.TabIndex = 1;
            this.okbtn.Text = "Ок";
            this.okbtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(233, 50);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(100, 28);
            this.cancelbtn.TabIndex = 2;
            this.cancelbtn.Text = "Назад";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(349, 94);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.dialboxtbx);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DialogBox";
            this.Text = "DialogBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dialboxtbx;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}