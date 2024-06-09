using System;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;
using HtmlAgilityPack;

namespace Lab05
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            this.lvEmail.SelectedIndexChanged += new System.EventHandler(this.lvEmail_SelectedIndexChanged);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Thêm các cột vào ListView
            lvEmail.Columns.Add("Email", 300);
            lvEmail.Columns.Add("From", 250);
            lvEmail.Columns.Add("Thời gian", 200);
            lvEmail.View = View.Details;
            lvEmail.Items.Clear(); // Xóa các mục cũ nếu có

            // Lấy thông tin đăng nhập từ người dùng
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();
            string ipAddress = "192.168.56.1"; // Thay bằng địa chỉ IP của máy chủ IMAP
            int port = 993; // Theo Mdaemon là 993 cho IMAP với SSL/TLS

            try
            {
                using (var client = new ImapClient())
                {
                    // Bỏ qua kiểm tra chứng chỉ SSL 
                    client.ServerCertificateValidationCallback = (s, c, h, validationErrors) => true;

                    // Kết nối tới máy chủ IMAP
                    client.Connect(ipAddress, port, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(email, password);

                    // Chọn hộp thư INBOX
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    // Đọc các email
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);

                        // Thêm email vào ListView
                        var listViewItem = new ListViewItem(new[]
                        {
                            message.Subject,
                            message.From.ToString(),
                            message.Date.DateTime.ToString()
                        });

                        listViewItem.Tag = message; // Lưu trữ toàn bộ message vào Tag để sử dụng sau
                        lvEmail.Items.Add(listViewItem);
                    }

                    // Ngắt kết nối
                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng nhập hoặc đọc email thất bại. Lỗi: {ex.Message}");
            }
        }

        private void lvEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmail.SelectedItems.Count > 0)
            {
                var selectedItem = lvEmail.SelectedItems[0];
                var message = selectedItem.Tag as MimeMessage;

                if (message != null)
                {
                    rtbEmailDetail.Text = GetMessageBody(message);
                }
            }
        }

        private string GetMessageBody(MimeMessage message)
        {
            if (message.TextBody != null)
            {
                return message.TextBody;
            }
            else if (message.HtmlBody != null)
            {
                return ConvertHtmlToPlainTextUsingHtmlAgilityPack(message.HtmlBody);
            }
            else if (message.Body is Multipart multipart)
            {
                foreach (var part in multipart)
                {
                    if (part is TextPart textPart)
                    {
                        if (textPart.IsHtml)
                            return ConvertHtmlToPlainTextUsingHtmlAgilityPack(textPart.Text);
                        else
                            return textPart.Text;
                    }
                }
            }
            return "Không có nội dung văn bản.";
        }

        private string ConvertHtmlToPlainTextUsingHtmlAgilityPack(string html)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            // Chuyển đổi các thực thể HTML sang ký tự thực
            return HtmlEntity.DeEntitize(doc.DocumentNode.InnerText);
        }
    }
}
