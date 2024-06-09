namespace Lab05
{
    partial class Bai03
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDinhKem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(495, 29);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(212, 20);
            this.txtPass.TabIndex = 9;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(88, 140);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(619, 278);
            this.txtBody.TabIndex = 10;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(88, 114);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(619, 20);
            this.txtSubject.TabIndex = 11;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(129, 74);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(276, 20);
            this.txtTo.TabIndex = 12;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(129, 29);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(276, 20);
            this.txtFrom.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(25, 19);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(49, 75);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDinhKem
            // 
            this.btnDinhKem.Location = new System.Drawing.Point(632, 77);
            this.btnDinhKem.Name = "btnDinhKem";
            this.btnDinhKem.Size = new System.Drawing.Size(75, 23);
            this.btnDinhKem.TabIndex = 14;
            this.btnDinhKem.Text = "Đính kèm";
            this.btnDinhKem.UseVisualStyleBackColor = true;
            this.btnDinhKem.Click += new System.EventHandler(this.btnDinhKem_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 437);
            this.Controls.Add(this.btnDinhKem);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Name = "Bai03";
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDinhKem;
    }
}