namespace NT106_Lab3
{
    partial class frmB1_Client
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
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbMess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(67, 53);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(372, 31);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "127.0.0.1";
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(510, 53);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(119, 31);
            this.tbPort.TabIndex = 1;
            this.tbPort.Text = "8080";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMess
            // 
            this.tbMess.Location = new System.Drawing.Point(71, 146);
            this.tbMess.Multiline = true;
            this.tbMess.Name = "tbMess";
            this.tbMess.Size = new System.Drawing.Size(558, 91);
            this.tbMess.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(510, 272);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(120, 50);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmB1_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 346);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMess);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIP);
            this.Name = "frmB1_Client";
            this.Text = "B1_Client";
            this.Load += new System.EventHandler(this.frmB1_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
    }
}