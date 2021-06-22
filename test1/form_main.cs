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
        form_Sign_up form_Sign_Up = new form_Sign_up();
        public form_main(form_Sign_up form)
        {
            InitializeComponent();
            form_Sign_Up = form;
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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn đăng xuất không!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;
            Close();
        }



        private void btinput_Click(object sender, EventArgs e)
        {
            us_input1.Visible = true;
            us_input1.BringToFront();
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            
            
            namelb.Text = "Xin Chào " + form_Sign_Up.name;
            us_input1.Visible = false;
            us_output1.Visible = false;
            add_suppliers1.Visible = false;
            add_product1.Visible = false;
            add_categories1.Visible = false;
            us_statistical_b11.Visible = false;
            us_product_warehouse1.Visible = false;
            us_customer1.Visible = false;
            
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
            us_statistical1.display();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void btstatical_Click(object sender, EventArgs e)
        {
            us_statistical_b11.Visible = true;
            us_statistical_b11.BringToFront();

        }

        private void warehouse_Click(object sender, EventArgs e)
        {
            us_product_warehouse1.Visible = true;
            us_product_warehouse1.BringToFront();
            us_product_warehouse1.display();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            us_customer1.Visible = true;
            us_customer1.BringToFront();
            
        }
        //show user
        public string id;
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            id = form_Sign_Up.id;
            Add.users users = new Add.users(this);
            users.ShowDialog();
        }
    }
}
