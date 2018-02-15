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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sPORTNUTRITIONDataSet);

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPORTNUTRITIONDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.sPORTNUTRITIONDataSet.Payment);

        }

        private void newRecord_Click(object sender, EventArgs e)
        {
            paymentBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            paymentBindingSource.EndEdit();
            paymentTableAdapter.Update(sPORTNUTRITIONDataSet);
        }
    }
}
