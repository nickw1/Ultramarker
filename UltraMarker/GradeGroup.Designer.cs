﻿namespace UltraMarker
{
    partial class GradeGroup
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1047, 652);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(101, 688);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 23);
            this.printbutton.TabIndex = 1;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Cursor = System.Windows.Forms.Cursors.No;
            this.savebutton.Location = new System.Drawing.Point(210, 688);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 2;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(331, 688);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(75, 23);
            this.editbutton.TabIndex = 3;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(466, 688);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 4;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(616, 688);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 5;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // GradeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 723);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "GradeGroup";
            this.Text = "GradeGroup";
            this.Load += new System.EventHandler(this.GradeGroup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}