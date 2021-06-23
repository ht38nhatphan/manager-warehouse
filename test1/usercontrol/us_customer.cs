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
    public partial class us_customer : UserControl
    {
        public us_customer()
        {
            InitializeComponent();
        }
        private dataservices mydatasevices;
        private DataTable mydatatable;
        public string firstname,lastname,address,phone,email, id;
        public bool cheak = true;
        //hiển thị
        private void display()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select a.FirstName,a.LastName,a.Address,a.Phone,a.Email,a.CustomerID from Customers a";
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid2.DataSource = mydatatable;
        }
        //thêm
        private void btadd_Click(object sender, EventArgs e)
        {
            cheak = true;
            Add.Add_customer add_Customer = new Add.Add_customer(this);
            add_Customer.ShowDialog();
            display();
        }
        //sửa
        private void btedit_Click(object sender, EventArgs e)
        {
            cheak = false;
            Add.Add_customer add_Customer = new Add.Add_customer(this);
            add_Customer.ShowDialog();
            display();
        }
        //xoá
        private void btdelete_Click(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            DialogResult dr = MessageBox.Show("Chắc chắn xoá khách hàng này không?", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            string sql = string.Format("delete from Customers where CustomerID = {0}",id );
            mydatasevices.RunQuery(sql);
            display();
        }
        //show all
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            display();
        }
        //load
        private void us_customer_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            addcombox();
            display();
            
        }
        //lấy tên theo từng mục
        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            //truy vấn theo tên
            string sql = "select a.FirstName,a.Phone,a.LastName,a.Email from Customers a";
            mydatatable = mydatasevices.RunQuery(sql);
            //deacare map
            var map = new Dictionary<string, string>();
            for (int i = 0; i < mydatatable.Columns.Count - 1; i++)
            {
                //add key and values in map
                map.Add(txt[i], mydatatable.Columns[i].ToString());

            }
            //duyêt map
            foreach (var pair in map)
            {
                //nếu tồn tại tên thì trả về tên trong db
                if (txtcategory.Text == pair.Key)
                {
                    customera = pair.Value;
                    return;
                }
            }
        }

        //láy dữ liệu của dòng
        private void bunifuCustomDataGrid2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            firstname = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();
            lastname = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();
            address = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[2].Value.ToString();
            phone = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[3].Value.ToString();
            email = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[4].Value.ToString();
            id = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
        //khai báo biến tên để lọc
        string customera;
        string[] txt = { "Tên khách hàng", "Số điện thoại", "Họ Và Tên Lót", "Email" };
        //add combox
        private void addcombox()
        {

            ////add colum in combobox
            for (int i = 0; i < txt.Length; i++)
            {
                txtcategory.Items.Add(txt[i]);
            }

        }
        //tìm kiếm
        private void btsearch_Click(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            DataTable customertable = new DataTable();
            string sql;
            string ns = txtinput.Text;
            if (customera == "FirstName")
            {
                ns = addchuoi(ns);
            }
            sql = string.Format("select a.FirstName,a.LastName,a.Address,a.Phone,a.Email,a.CustomerID from Customers a where {0} like N'{1}%'", customera, ns);
            customertable = mydatasevices.RunQuery(sql);
            //nếu không tìm thấy in ra cảnh báo
            if (customertable.Rows.Count == 0)
            {
                DialogResult dr = MessageBox.Show("Không tìm thấy danh sách bạn cần tìm, nếu bạn muốn thêm mới thì hãy nhấn có", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //nếu nhấn k thoát
                if (dr == System.Windows.Forms.DialogResult.No) return;
                //nếu nhấn có chuyển đến trang thêm mới
                else
                {
                    Add.Add_customer add_Product = new Add.Add_customer();
                    add_Product.ShowDialog();

                }
            }
            bunifuCustomDataGrid2.DataSource = customertable;
        }
        //sửa chuỗi nếu có nháy
        private string addchuoi(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].ToString() == "'")
                {
                    a = a.Insert(i, "'");
                    i = i + 2;
                }
            }


            return a;
        }
    }
}
