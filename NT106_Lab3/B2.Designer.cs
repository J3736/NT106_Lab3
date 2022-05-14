namespace NT106_Lab3
{
    partial class frmB2
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
            this.btnListen = new System.Windows.Forms.Button();
            this.rtbMess = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnListen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListen.Location = new System.Drawing.Point(653, 32);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(103, 51);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = false;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // rtbMess
            // 
            this.rtbMess.Location = new System.Drawing.Point(50, 102);
            this.rtbMess.Name = "rtbMess";
            this.rtbMess.ReadOnly = true;
            this.rtbMess.Size = new System.Drawing.Size(706, 368);
            this.rtbMess.TabIndex = 1;
            this.rtbMess.Text = "";
            // 
            // frmB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.rtbMess);
            this.Controls.Add(this.btnListen);
            this.Name = "frmB2";
            this.Text = "BÀI 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.RichTextBox rtbMess;
    }
}