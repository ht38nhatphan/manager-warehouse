using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        //private void btunit_Click(object sender, EventArgs e)
        //{
        //    add_unit1.Visible = true;
        //    add_unit1.BringToFront();
        //}

        //private void form_main_Load_1(object sender, EventArgs e)
        //{
        //    add_unit1.Visible = false;
        //    add_suppliers1.Visible = false;
        //    add_categories1.Visible = false;
        //    add_product1.Visible = false;
        //    us_input1.Visible = false;
        //}


        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btinput_Click(object sender, EventArgs e)
        {
            us_input1.Visible = true;
            us_input1.BringToFront();
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            us_input1.Visible = false;
            us_output1.Visible = false;
            add_suppliers1.Visible = false;
            add_product1.Visible = false;
            add_categories1.Visible = false;
        }

        private void btoutput_Click(object sender, EventArgs e)
        {
            us_output1.Visible = true;
            us_output1.BringToFront();

        }

        private void btsupplier_Click(object sender, EventArgs e)
        {
            add_suppliers1.Visible = true;
            add_suppliers1.BringToFront();
        }

        private void btproduct_Click(object sender, EventArgs e)
        {
            add_product1.Visible = true;
            add_product1.BringToFront();
        }

        private void btcategorie_Click(object sender, EventArgs e)
        {
            add_categories1.Visible = true;
            add_categories1.BringToFront();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            us_statistical1.Visible = true;
            us_statistical1.BringToFront();
        }
    }
}
