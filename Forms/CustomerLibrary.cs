using BogsyVideoStore.Classes;
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
    public partial class CustomerLibrary : Form
    {
        public CustomerLibrary()
        {
            InitializeComponent();
            datagridCustomers.DataSource = Utility.LoadData("LoadCustomerInfo");
        }
    }
}
