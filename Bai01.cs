using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Cấu hình SMTP server
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                smtpClient.Port = 25; 
                smtpClient.EnableSsl = false; // true nếu SMTP server yêu cầu SSL
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network; 
                smtpClient.UseDefaultCredentials = false; // Không sử dụng thông tin xác thực mặc định của hệ thống

                // Lấy thông tin của email từ các textbox
                string mailfrom = txtFrom.Text.ToString().Trim();
                string mailto = txtTo.Text.ToString().Trim();
                string password = txtPass.Text.ToString().Trim();

                // NetworkCredential sẽ lưu trữ thông tin username và password để dùng cho việc xác thực
                var basicCredential = new NetworkCredential(mailfrom, password);

                // Thiết lập thông tin xác thực cho SmtpClient để xác thực với máy chủ SMTP
                smtpClient.Credentials = basicCredential;

                using (MailMessage message = new MailMessage())
                {
                    try
                    {
                        MailAddress fromAddress = new MailAddress(mailfrom);
                        message.From = fromAddress;
                        message.Subject = txtSubject.Text.ToString().Trim();
                        message.Body = txtBody.Text.ToString().Trim();
                        message.IsBodyHtml = true; // Email có thể chứa HTML
                        message.To.Add(mailto);

                        // Gửi email
                        smtpClient.Send(message);
                        MessageBox.Show("Gửi thành công!");

                        // Gửi thành công thì cho cấc textbox thành trống để phục vụ cho lần nhập tới
                        txtFrom.Text = "";
                        txtTo.Text = "";
                        txtPass.Text = "";
                        txtSubject.Text = "";
                        txtBody.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi gửi mail. Lỗi: {ex.Message}");
                    }
                }
            }
        }
    }
}
