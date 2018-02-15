using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNapp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypesForm typesForm = new TypesForm();
            typesForm.Show();
        }

        private void brandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandForm brandForm = new BrandForm();
            brandForm.Show();
        }

        private void addresesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            addressForm.Show();
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
        }
    }
}
