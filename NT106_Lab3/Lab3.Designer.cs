namespace NT106_Lab3
{
    partial class Form1
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
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnVD = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(46, 178);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(159, 89);
            this.btnB1.TabIndex = 0;
            this.btnB1.Text = "BÀI 1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnVD
            // 
            this.btnVD.Location = new System.Drawing.Point(46, 32);
            this.btnVD.Name = "btnVD";
            this.btnVD.Size = new System.Drawing.Size(159, 89);
            this.btnVD.TabIndex = 1;
            this.btnVD.Text = "VD";
            this.btnVD.UseVisualStyleBackColor = true;
            this.btnVD.Click += new System.EventHandler(this.btnVD_Click);
            // 
            // btnQ
            // 
            this.btnQ.Location = new System.Drawing.Point(46, 323);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(159, 89);
            this.btnQ.TabIndex = 2;
            this.btnQ.Text = "THOÁT";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(238, 178);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(159, 89);
            this.btnB2.TabIndex = 3;
            this.btnB2.Text = "BÀI 2";
            this.btnB2.UseVisualStyleBackColor = true;
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(434, 178);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(159, 89);
            this.btnB3.TabIndex = 4;
            this.btnB3.Text = "BÀI 3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnVD);
            this.Controls.Add(this.btnB1);
            this.Name = "Form1";
            this.Text = "LAB 03";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnVD;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
    }
}

