using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.addformkhac
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }
        //khai báo biến có tham số trỏ tới đối tượng customer
        //Add.Add_output add = new Add.Add_output();
        //public customer(Add.Add_output add_)
        //{
        //    InitializeComponent();
        //    add 
        //}
        private dataservices mydatasevices;
        private DataTable mydatatable;
        public string firstname, id;

        private void bunifuCustomDataGrid2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            firstname = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();
            id= bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void display()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select a.FirstName,a.LastName,a.Address,a.Phone,a.Email,a.CustomerID from Customers a";
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid2.DataSource = mydatatable;
        }
        private void customer_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            addcombox();
            display();
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
                category_customer.Items.Add(txt[i]);
            }

        }
        //search
        private void btsearch_Click(object sender, EventArgs e)
        {
            string ns = name_search.Text;
            mydatasevices = new dataservices();
            DataTable customertable = new DataTable();
            string sql;
            if(customera== "FirstName")
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
                    Close();
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
        private void category_customer_SelectedIndexChanged(object sender, EventArgs e)
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
                if (category_customer.Text == pair.Key)
                {
                    customera = pair.Value;
                    return;
                }
            }
        }
        //chuyer den form san pham
        private void bunifuCustomDataGrid2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            product_output product_ = new product_output(this);
            product_.ShowDialog();
        }

        private void bunifuCustomDataGrid2_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            firstname =  bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();
            id = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void bunifuCustomDataGrid2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
