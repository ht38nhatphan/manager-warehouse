using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.usercontrol
{
    public partial class add_categories : UserControl
    {
        public bool cheak = false;
        public string name,note;
        //cheak click all 
        int cheakall;
        public add_categories()
        {
            InitializeComponent();
        }
        private dataservices mydatasevices;
        private DataTable mydatatable;
        private void btadd_Click_1(object sender, EventArgs e)
        {
            cheak = false;
            Add.Add_category add_Category = new Add.Add_category(this);
            add_Category.cheak1(cheak,name,note);
            add_Category.ShowDialog();
        }

        private void btsearch_Click_1(object sender, EventArgs e)
        {
            if (cheakall == 1)
            {
                Connect();
            }
            else
            {
                string sql = "select * from Categories where  CategoryName like N'" + txtname.Text + "%'";
                mydatatable = mydatasevices.RunQuery(sql);
                bunifuCustomDataGrid1.DataSource = mydatatable;
            }
            

        }
        
        private void btedit_Click(object sender, EventArgs e)
        {
            cheak = true;
            Add.Add_category add_Category = new Add.Add_category(this);
            add_Category.cheak1(cheak,name,note);
            add_Category.ShowDialog();
        }
        

        private void add_categories_Load(object sender, EventArgs e)
        {
            cheak = false;
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            Connect();
        }


        public void Connect()
        {
            string sql = "select * from Categories ";
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid1.DataSource = mydatatable;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chắc chắn loại sản phẩm này không?", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            //Sua
            int r = bunifuCustomDataGrid1.CurrentRow.Index;
            mydatatable.Rows[r].Delete();
            //Update database
            mydatasevices.Update(mydatatable);
        }

        private void cb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_all.Checked == true)
            {
                cheakall = 1;
                txtname.Clear();
            }
            else
            {
                cheakall = 0;
                txtname.Clear();
            }
           
        }

        private void bunifuCustomDataGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            name = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            note = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
