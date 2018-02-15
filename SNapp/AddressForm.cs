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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void addressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sPORTNUTRITIONDataSet);

        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPORTNUTRITIONDataSet.Address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.sPORTNUTRITIONDataSet.Address);

        }

        private void newRecord_Click(object sender, EventArgs e)
        {
            addressBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            addressBindingSource.EndEdit();
            addressTableAdapter.Update(sPORTNUTRITIONDataSet);
        }
    }
}
