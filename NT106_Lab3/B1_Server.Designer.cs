namespace NT106_Lab3
{
    partial class frmB1_Server
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
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tbPort = new System.Windows.Forms.TextBox();
            this.rtbMess = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(79, 71);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(132, 31);
            this.tbPort.TabIndex = 0;
            this.tbPort.Text = "8080";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbMess
            // 
            this.rtbMess.Location = new System.Drawing.Point(78, 145);
            this.rtbMess.Name = "rtbMess";
            this.rtbMess.ReadOnly = true;
            this.rtbMess.Size = new System.Drawing.Size(651, 298);
            this.rtbMess.TabIndex = 1;
            this.rtbMess.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(593, 62);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(136, 39);
            this.btnListen.TabIndex = 3;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // frmB1_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 520);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMess);
            this.Controls.Add(this.tbPort);
            this.Name = "frmB1_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "B1_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.RichTextBox rtbMess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListen;
    }
}