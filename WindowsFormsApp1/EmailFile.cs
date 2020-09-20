using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class EmailFile : Form
    {
        public EmailFile()
        {
            InitializeComponent();
        }

        private void EmailFile_Load(object sender, EventArgs e)
        {
            defaultCredentialsCheck.CheckState = CheckState.Checked;
        }

        private void defaultCredentialsCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (defaultCredentialsCheck.Checked)
            {
                senderEmail.Text = "galacsoftwarepruebav@gmail.com";
                senderPassword.Text = "galac123";

                senderEmail.ReadOnly = true;
                senderPassword.ReadOnly = true;
            }
            else
            {
                senderEmail.ReadOnly = false;
                senderPassword.ReadOnly = false;

                senderEmail.Text = String.Empty;
                senderPassword.Text = String.Empty;
            }
        }

        private void sendEmail_Click(object sender, EventArgs e)
        {
            string targetAddress = targetEmail.Text;
            string senderAddress = senderEmail.Text;
            string password = senderPassword.Text;

            try
            {
                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                email.From = new MailAddress(senderAddress);
                email.To.Add(targetAddress);
                email.Subject = "Prueba de desarrollo - Victor Zambrano - Galac Software";
                email.Body = "Archivo de texto";

                Attachment attachment;
                attachment = new Attachment(System.IO.Directory.GetCurrentDirectory() + "\\Palabras.txt");
                email.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(senderAddress, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);
                MessageBox.Show("Correo enviado", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }        
    }
}
