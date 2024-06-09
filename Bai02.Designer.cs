namespace Lab05
{
    partial class Bai02
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lvEmail = new System.Windows.Forms.ListView();
            this.rtbEmailDetail = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 19);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(549, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(92, 57);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(549, 20);
            this.txtPass.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(669, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 55);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lvEmail
            // 
            this.lvEmail.HideSelection = false;
            this.lvEmail.Location = new System.Drawing.Point(25, 111);
            this.lvEmail.Name = "lvEmail";
            this.lvEmail.Size = new System.Drawing.Size(749, 183);
            this.lvEmail.TabIndex = 4;
            this.lvEmail.UseCompatibleStateImageBehavior = false;
            // 
            // rtbEmailDetail
            // 
            this.rtbEmailDetail.Location = new System.Drawing.Point(25, 300);
            this.rtbEmailDetail.Name = "rtbEmailDetail";
            this.rtbEmailDetail.Size = new System.Drawing.Size(749, 230);
            this.rtbEmailDetail.TabIndex = 5;
            this.rtbEmailDetail.Text = "";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.rtbEmailDetail);
            this.Controls.Add(this.lvEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListView lvEmail;
        private System.Windows.Forms.RichTextBox rtbEmailDetail;
    }
}