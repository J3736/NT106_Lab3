namespace NT106_Lab3
{
    partial class frmVd1_Server
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
            this.lstMes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstMes
            // 
            this.lstMes.HideSelection = false;
            this.lstMes.Location = new System.Drawing.Point(40, 49);
            this.lstMes.Name = "lstMes";
            this.lstMes.Size = new System.Drawing.Size(705, 359);
            this.lstMes.TabIndex = 0;
            this.lstMes.UseCompatibleStateImageBehavior = false;
            this.lstMes.View = System.Windows.Forms.View.List;
            this.lstMes.SelectedIndexChanged += new System.EventHandler(this.lstMes_SelectedIndexChanged);
            // 
            // frmVd1_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMes);
            this.Name = "frmVd1_Server";
            this.Text = "UDP Server";
            this.Load += new System.EventHandler(this.Vd1_Server_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstMes;
    }
}