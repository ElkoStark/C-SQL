﻿namespace Pharmacy
{
    partial class DeleteType
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
            this.cmbDeleteType = new System.Windows.Forms.ComboBox();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDeleteType
            // 
            this.cmbDeleteType.FormattingEnabled = true;
            this.cmbDeleteType.Location = new System.Drawing.Point(51, 54);
            this.cmbDeleteType.Name = "cmbDeleteType";
            this.cmbDeleteType.Size = new System.Drawing.Size(240, 21);
            this.cmbDeleteType.TabIndex = 0;
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Location = new System.Drawing.Point(110, 103);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(120, 45);
            this.btnDeleteType.TabIndex = 1;
            this.btnDeleteType.Text = "Delete Drag Type";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // DeleteType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 293);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.cmbDeleteType);
            this.Name = "DeleteType";
            this.Text = "DeleteType";
            this.Load += new System.EventHandler(this.DeleteType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeleteType;
        private System.Windows.Forms.Button btnDeleteType;
    }
}