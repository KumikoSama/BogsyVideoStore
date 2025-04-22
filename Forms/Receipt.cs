using BogsyVideoStore.Classes;
using BogsyVideoStore.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.ReportingServices.Interfaces;
using MimeKit;
using System.IO;

namespace BogsyVideoStore.Forms
{
    public partial class Receipt : Form
    {
        bool isPenaltyFee;

        public Receipt(bool isPenaltyFee)
        {
            InitializeComponent();
            this.isPenaltyFee = isPenaltyFee;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.reportViewerReceipt.RefreshReport();
            Utility.GenerateReceipt(reportViewerReceipt, isPenaltyFee);
        }

        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalTransaction.TotalAmount = 0;
            GlobalTransaction.Payment = 0;
            GlobalTransaction.Change = 0;
            GlobalTransaction.TransactionList.Clear();
        }

        //private void btnSendToEmail_Click(object sender, EventArgs e)
        //{
        //    //LocalReport report = new LocalReport();
        //    //report.ReportPath = "TransactionReceipt.rdlc"; 

        //    //byte[] pdfBytes = report.Render("PDF"); 

        //    //var email = new MimeMessage();
        //    //email.From.Add(new MailboxAddress("Elisha Laud", "elilaud23@gmail.com"));
        //    //email.To.Add(new MailboxAddress("Zero Four", "zerof740@gmail.com"));
        //    //email.Subject = "Report PDF Attached";

        //    //var attachment = new MimePart("application", "pdf")
        //    //{
        //    //    Content = new MimeContent(new MemoryStream(pdfBytes)),
        //    //    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
        //    //    FileName = "Report.pdf"
        //    //};

        //    //var client = new SmtpClient();
        //    //client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
        //    //client.Authenticate("elilaud23@gmail.com", "lrcf tmun brqh ninm");
        //    //email.Body = new Multipart("mixed") { new TextPart("plain") { Text = "See attached report." }, attachment };
        //    //client.Send(email);
        //    //client.Disconnect(true);

        //    //MessageBox.Show("✅ Email Sent!");
        //}
    }
}
