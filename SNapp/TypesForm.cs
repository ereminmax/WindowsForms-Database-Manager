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
    public partial class TypesForm : Form
    {
        public TypesForm()
        {
            InitializeComponent();
        }

        private void typesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.typesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sPORTNUTRITIONDataSet);

        }

        private void TypesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPORTNUTRITIONDataSet.Types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.sPORTNUTRITIONDataSet.Types);

        }

        private void newRecord_Click(object sender, EventArgs e)
        {
            typesBindingSource.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            typesBindingSource.EndEdit();
            typesTableAdapter.Update(sPORTNUTRITIONDataSet);
        }
    }
}
