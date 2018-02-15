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
    public partial class BrandForm : Form
    {
        public BrandForm()
        {
            InitializeComponent();
        }

        private void brandsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brandsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sPORTNUTRITIONDataSet);

        }

        private void Brands_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPORTNUTRITIONDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.sPORTNUTRITIONDataSet.Brands);

        }

        private void newRecord_Click(object sender, EventArgs e)
        {
            brandsBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            brandsBindingSource.EndEdit();
            brandsTableAdapter.Update(sPORTNUTRITIONDataSet);
        }
    }
}
