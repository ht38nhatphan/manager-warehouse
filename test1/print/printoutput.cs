using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.print
{
    public partial class printoutput : Form
    {
        public printoutput()
        {
            InitializeComponent();
        }

        private void printoutput_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'outputxsd.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.outputxsd.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
