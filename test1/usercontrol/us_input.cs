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
    public partial class us_input : UserControl
    {
        public us_input()
        {
            InitializeComponent();
        }

        private dataservices mydatasevices;
        private DataTable mydatatable;
        public bool cheack = true;
        public string nameproduct, namecategory, namesupplier, date, quantity, inputprice, outputprice, note,unit;
        public int idiput;
        private bool cheakall = false;
        //display
        public void display()
        {
            mydatasevices = new dataservices();
            string sql = "select c.ProductName,e.CategoryName,d.CompanyName,a.InputDate,b.Quantity,b.InputPrice,b.OutputPrice,b.Note,NameUnit " +
                "from Input a join InputDetails b " +
                "on a.InputID = b.InputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID";
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid2.DataSource = mydatatable;
        }
        //search
        //khai báo biến đem dữ liệu vào combobox
        string[] txt = { "Tên Sản Phẩm", "Tên Loại Sản Phẩm", "Tên Nhà Cung Cấp", "Tên Đơn Vị Tính" };
        //khai báo biến tên để lọc
        string input_data;
        //add vào combobox
        private void addcombox()
        {

            ////add colum in combobox
            for (int i = 0; i < txt.Length; i++)
            {
                txtcategory.Items.Add(txt[i]);
            }

        }
        //in tổng tiền 
        public string sumdetall(int a)
        {
            mydatasevices = new dataservices();
            DataTable mydatatable1 = new DataTable();
            //tổng toàn bộ doanh thu
            if (a == 1)
            {
                string sql = "select sum(Quantity*InputPrice) as tongtien " +
                "from Input a join InputDetails b " +
                "on a.InputID = b.InputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID";
                mydatatable1 = mydatasevices.RunQuery(sql);
            }
            if (a == 2)
            {
                string sql = string.Format("select sum(Quantity*InputPrice) as tongtien " +
              "from Input a join InputDetails b " +
              "on a.InputID = b.InputID " +
              "join Products c on c.ProductID = b.ProductID " +
              "join Suppliers d on d.SupplierID = c.SupplierID " +
              "join Categories e on e.CategoryID = c.CategoryID " +
              "join Unit f on f.UnitID = c.UnitID where InputDate = convert(date,('{0}'))", txtdate.Text);
                mydatatable1= mydatasevices.RunQuery(sql);
            }
            if (a == 3)
            {
                string sql = string.Format("select sum(Quantity*InputPrice) as tongtien " +
               "from Input a join InputDetails b " +
               "on a.InputID = b.InputID " +
               "join Products c on c.ProductID = b.ProductID " +
               "join Suppliers d on d.SupplierID = c.SupplierID " +
               "join Categories e on e.CategoryID = c.CategoryID " +
               "join Unit f on f.UnitID = c.UnitID where InputDate = convert(date,('{0}')) and {1} like N'{2}%'", txtdate.Text, input_data, txtinput.Text);
                mydatatable1 = mydatasevices.RunQuery(sql);
            }
            return mydatatable1.Rows[0]["tongtien"].ToString();

        }
        private void btsearch_Click(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            if(txtcategory.Text == "")
            {
                string sql = string.Format("select c.ProductName,e.CategoryName,d.CompanyName,a.InputDate,b.Quantity,b.InputPrice,b.OutputPrice,b.Note,NameUnit " +
              "from Input a join InputDetails b " +
              "on a.InputID = b.InputID " +
              "join Products c on c.ProductID = b.ProductID " +
              "join Suppliers d on d.SupplierID = c.SupplierID " +
              "join Categories e on e.CategoryID = c.CategoryID " +
              "join Unit f on f.UnitID = c.UnitID where InputDate = convert(date,('{0}'))", txtdate.Text);
                mydatatable = mydatasevices.RunQuery(sql);
                txt_total_amount.Text = sumdetall(2);
            }
            else
            {
                string sql = string.Format("select c.ProductName,e.CategoryName,d.CompanyName,a.InputDate,b.Quantity,b.InputPrice,b.OutputPrice,b.Note,NameUnit " +
               "from Input a join InputDetails b " +
               "on a.InputID = b.InputID " +
               "join Products c on c.ProductID = b.ProductID " +
               "join Suppliers d on d.SupplierID = c.SupplierID " +
               "join Categories e on e.CategoryID = c.CategoryID " +
               "join Unit f on f.UnitID = c.UnitID where InputDate = convert(date,('{0}')) and {1} like N'{2}%'", txtdate.Text, input_data, txtinput.Text);
                mydatatable = mydatasevices.RunQuery(sql);
                //nếu không tìm thấy in ra cảnh báo
                if (mydatatable.Rows.Count == 0)
                {
                    messagebox.Warning("Không tìm thấy danh sách bạn cần tìm!");
                    return;
                }
                txt_total_amount.Text = sumdetall(3);
                clear_data();
            }
            bunifuCustomDataGrid2.DataSource = mydatatable;
        }
        //lấy dũ liêu ra để tìm
        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            mydatasevices = new dataservices();
            //truy vấn theo tên
            string sql = "select a.ProductName,b.CategoryName,d.CompanyName,c.NameUnit,a.Description from Products a join Categories b on a.CategoryID = b.CategoryID join Unit c on c.UnitID = a.UnitID join Suppliers d on d.SupplierID = a.SupplierID";
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
                    input_data = pair.Value;
                    return;
                }
            }
        }
        //clear data
        private void clear_data()
        {
            txtinput.Clear();
            txtcategory.Items.Clear();
        }
       
        //print
        private void btprint_Click(object sender, EventArgs e)
        {
            
            print.printinput printiput = new print.printinput();
            printiput.laydate(txtdate.Text);
            printiput.ShowDialog();
        }
        //click in category
        private void txtcategory_Click(object sender, EventArgs e)
        {
            // click vào add combobox vào
            addcombox();
        }

        //load
        private void us_input_Load_1(object sender, EventArgs e)
        {

            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            display();
            txt_total_amount.Text = sumdetall(1);
        }
        //lấy id input lọc theo ngày
        public int id_iput()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select * from Input where InputDate = '{0}'", date);
            DataTable dt = mydatasevices.RunQuery(sql);
            return Convert.ToInt32(dt.Rows[0]["InputID"].ToString());
        }
        private void bunifuCustomDataGrid2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            nameproduct = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();
            namecategory = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();
            namesupplier = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[2].Value.ToString();
            date = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[3].Value.ToString();
            quantity = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[4].Value.ToString();
            inputprice = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[5].Value.ToString();
            outputprice = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[6].Value.ToString();
            note = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[7].Value.ToString();
            unit = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[8].Value.ToString();
            idiput = id_iput();

        }

        //input
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            //cheack = false;
            addformkhac.product product = new addformkhac.product();
            product.ShowDialog();
            display();
            
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            cheack = false;
            Add.Add_input add_Input = new Add.Add_input(this);
            add_Input.ShowDialog();
        }
        //lấy idiputdetails
        public int id_details()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select InputDetailID from InputDetails a join Input b on a.InputID = b.InputID join Products c on c.ProductID = a.ProductID join Suppliers d on d.SupplierID = c.SupplierID join Categories e on e.CategoryID = c.CategoryID join Unit f on f.UnitID = c.UnitID  " +
               "where NameUnit = N'{0}' and ProductName = N'{1}' and CategoryName = N'{2}' and CompanyName = N'{3}' and a.InputPrice = {4}", unit, nameproduct, namecategory, namesupplier, inputprice);
            DataTable n = mydatasevices.RunQuery(sql);
            return (int)n.Rows[0]["InputDetailID"];
        }
        private void btdelete_Click(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            DialogResult dr = MessageBox.Show("Chắc chắn xoá sản phẩm này không?", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            string sql = string.Format("delete from InputDetails where InputDetailID = {0}", id_details());
            mydatasevices.RunQuery(sql);
            display();

        }
        //reset
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            display();
            txt_total_amount.Text = sumdetall(1);
        }
    }
}
