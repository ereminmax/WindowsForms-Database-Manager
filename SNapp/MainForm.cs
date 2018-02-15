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
    }
}
