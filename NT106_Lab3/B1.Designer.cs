namespace NT106_Lab3
{
    partial class frmB1
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
            this.btnCl = new System.Windows.Forms.Button();
            this.btnSv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCl
            // 
            this.btnCl.Location = new System.Drawing.Point(26, 23);
            this.btnCl.Name = "btnCl";
            this.btnCl.Size = new System.Drawing.Size(221, 77);
            this.btnCl.TabIndex = 0;
            this.btnCl.Text = "Client";
            this.btnCl.UseVisualStyleBackColor = true;
            this.btnCl.Click += new System.EventHandler(this.btnCl_Click);
            // 
            // btnSv
            // 
            this.btnSv.Location = new System.Drawing.Point(330, 23);
            this.btnSv.Name = "btnSv";
            this.btnSv.Size = new System.Drawing.Size(221, 77);
            this.btnSv.TabIndex = 1;
            this.btnSv.Text = "Server";
            this.btnSv.UseVisualStyleBackColor = true;
            this.btnSv.Click += new System.EventHandler(this.btnSv_Click);
            // 
            // frmB1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 118);
            this.Controls.Add(this.btnSv);
            this.Controls.Add(this.btnCl);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "frmB1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCl;
        private System.Windows.Forms.Button btnSv;
    }
}