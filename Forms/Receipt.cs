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
using System.Windows.Forms;

namespace BogsyVideoStore.Forms
{
    public partial class Receipt : Form
    {
        int totalAmount;
        bool isPenaltyFee;

        public Receipt(bool isPenaltyFee, int totalAmount = 0)
        {
            InitializeComponent();
            this.totalAmount = totalAmount;
            this.isPenaltyFee = isPenaltyFee;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.reportViewerReceipt.RefreshReport();
            this.BringToFront();

            if (!isPenaltyFee)
                Utility.GenerateReceipt(reportViewerReceipt, totalAmount);
            else
                GeneratePenaltyFeeReceipt();
        }

        private void GeneratePenaltyFeeReceipt()
        {
            reportViewerReceipt.LocalReport.DataSources.Clear();

            ReportDataSource reportDataSource = new ReportDataSource("Receipt", ReceiptList.Receipts);
            reportViewerReceipt.LocalReport.ReportPath = "PenaltyFeeReceipt.rdlc";
            reportViewerReceipt.LocalReport.DataSources.Add(reportDataSource);

            ReportParameter reportParameter = new ReportParameter("TotalAmount", ReceiptModel.TotalAmount.ToString());
            reportViewerReceipt.LocalReport.SetParameters(reportParameter);

            reportViewerReceipt.RefreshReport();
            reportViewerReceipt.Refresh();
        }
    }
}
