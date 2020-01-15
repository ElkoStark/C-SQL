namespace Pharmacy
{
    partial class CreateType
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateTypeName = new System.Windows.Forms.TextBox();
            this.btnCreateType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag Type Name";
            // 
            // txtCreateTypeName
            // 
            this.txtCreateTypeName.Location = new System.Drawing.Point(121, 73);
            this.txtCreateTypeName.Name = "txtCreateTypeName";
            this.txtCreateTypeName.Size = new System.Drawing.Size(177, 20);
            this.txtCreateTypeName.TabIndex = 1;
            // 
            // btnCreateType
            // 
            this.btnCreateType.Location = new System.Drawing.Point(121, 115);
            this.btnCreateType.Name = "btnCreateType";
            this.btnCreateType.Size = new System.Drawing.Size(177, 23);
            this.btnCreateType.TabIndex = 2;
            this.btnCreateType.Text = "Add Drag Type";
            this.btnCreateType.UseVisualStyleBackColor = true;
            this.btnCreateType.Click += new System.EventHandler(this.btnCreateType_Click);
            // 
            // CreateType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 282);
            this.Controls.Add(this.btnCreateType);
            this.Controls.Add(this.txtCreateTypeName);
            this.Controls.Add(this.label1);
            this.Name = "CreateType";
            this.Text = "CreateType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateTypeName;
        private System.Windows.Forms.Button btnCreateType;
    }
}