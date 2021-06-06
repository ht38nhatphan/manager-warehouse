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
    public partial class printinput : Form
    {
        public printinput()
        {
            InitializeComponent();
        }
        string date;
        //lay date 
        public void laydate(string d)
        {
            date = d;
        }
        private void printinput_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KHO_HANGDataSet.input_date' table. You can move, or remove it, as needed.
            this.input_dateTableAdapter.Fill(this.qL_KHO_HANGDataSet.input_date,Convert.ToDateTime(date));
            this.reportViewer1.RefreshReport();
        }

       
    }
}
