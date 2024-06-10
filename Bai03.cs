using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai03 : Form
    {
        private string attachedFilePath = "";

        public Bai03()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(txtFrom.Text);
                mail.To.Add(txtTo.Text);
                mail.Subject = txtSubject.Text;
                mail.Body = txtBody.Text;

                if (!string.IsNullOrEmpty(attachedFilePath))
                {
                    Attachment attachment = new Attachment(attachedFilePath);
                    mail.Attachments.Add(attachment);
                }

                SmtpServer.Port = 587; // Sử dụng cổng TLS
                SmtpServer.Credentials = new NetworkCredential(txtFrom.Text, txtPass.Text);
                SmtpServer.EnableSsl = true; // Bật SSL

                SmtpServer.Send(mail);
                MessageBox.Show("Gửi mail thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi mail: " + ex.Message);
            }
        }

        private void btnDinhKem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedFilePath = openFileDialog.FileName;
                    MessageBox.Show("Đính kèm tệp thành công");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đính kèm tệp: " + ex.Message);
            }
        }
    }
}
