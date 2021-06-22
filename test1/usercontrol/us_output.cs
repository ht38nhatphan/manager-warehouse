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
    public partial class us_output : UserControl
    {
        public us_output()
        {
            InitializeComponent();
        }

        //private void btadd_Click(object sender, EventArgs e)
        //{
        //    form_Customer cr = new form_Customer();
        //    cr.ShowDialog();
        //}
        private dataservices mydatasevices;
        private DataTable mydatatable;
        //kiểm tra nhập hay sửa
        public bool cheack = false;
        public string namecustomer, nameproduct, namecategory, namesupplier, date, quantity, outputprice, note, unit;

        //search
        //khai báo biến đem dữ liệu vào combobox
        string[] txt = {"Tên Khách Hàng","Tên Sản Phẩm", "Tên Loại Sản Phẩm", "Tên Nhà Cung Cấp", "Tên Đơn Vị Tính" };
        //khai báo biến tên để lọc
        string output_data;
        //add vào combobox
        private void addcombox()
        {

            ////add colum in combobox
            for (int i = 0; i < txt.Length; i++)
            {
                txtcategory.Items.Add(txt[i]);
            }

        }

        private void txtdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            //truy vấn theo tên
            string sql = "select f.FirstName, a.ProductName,b.CategoryName,d.CompanyName,c.NameUnit from Products a join Categories b on a.CategoryID = b.CategoryID join Unit c on c.UnitID = a.UnitID join Suppliers d on d.SupplierID = a.SupplierID join OutputDetails e on e.ProductID = a.ProductID join Customers f on f.CustomerID = e.CustomerID";
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
                    output_data = pair.Value;
                    return;
                }
            }
        }
        //lấy idproduct
        public int layidpr()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select ProductID from Products a join Categories b " +
                "on a.CategoryID = b.CategoryID " +
                "join Suppliers c on c.SupplierID = a.SupplierID " +
                "join Unit d on d.UnitID = a.UnitID " +
                "where CategoryName =N'{0}' and ProductName =N'{1}' and NameUnit =N'{2}'and CompanyName =N'{3}'", namecategory, nameproduct, unit, namesupplier);
            DataTable dt = mydatasevices.RunQuery(sql);
            int id = Convert.ToInt32(dt.Rows[0]["ProductID"].ToString());
            return id;
        }
        private void bunifuCustomDataGrid2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            namecustomer = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameproduct = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();
            namecategory = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[2].Value.ToString();
            namesupplier = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[3].Value.ToString();
            unit = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[4].Value.ToString();
            quantity = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[5].Value.ToString();
            outputprice = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[6].Value.ToString();
            note = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        //in tổng tiền 
        public string sumdetall(int a)
        {
            mydatasevices = new dataservices();
            DataTable mydatatable1 = new DataTable();
            //tổng toàn bộ doanh thu
            if (a == 1)
            {
                string sql = "select sum(b.Quantity*OutputPrice) as tongtien " +
                "from Output a join OutputDetails b " +
                "on a.OutputID = b.OutputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID " +
                "join Warehouse g on g.ProductID = c.ProductID";
                mydatatable1 = mydatasevices.RunQuery(sql);
            }
            if (a == 2)
            {

                string sql = string.Format("select sum(b.Quantity*OutputPrice) as tongtien " +
              "from Output a join OutputDetails b " +
              "on a.OutputID = b.OutputID " +
              "join Products c on c.ProductID = b.ProductID " +
              "join Suppliers d on d.SupplierID = c.SupplierID " +
              "join Categories e on e.CategoryID = c.CategoryID " +
              "join Unit f on f.UnitID = c.UnitID join Warehouse g on g.ProductID = c.ProductID where OutputDate = convert(date,('{0}'))", txtdate.Text);
                mydatatable1 = mydatasevices.RunQuery(sql);
            }
            if (a == 3)
            {
                string sql = string.Format("select sum(b.Quantity*OutputPrice) as tongtien " +
               "from Output a join OutputDetails b " +
               "on a.OutputID = b.OutputID " +
               "join Products c on c.ProductID = b.ProductID " +
               "join Suppliers d on d.SupplierID = c.SupplierID " +
               "join Categories e on e.CategoryID = c.CategoryID " +
               "join Unit f on f.UnitID = c.UnitID join Warehouse g on g.ProductID = c.ProductID where OutputDate = convert(date,('{0}')) and {1} like N'{2}%'", txtdate.Text, output_data, txtoutput.Text);
                mydatatable1 = mydatasevices.RunQuery(sql);
            }
            return mydatatable1.Rows[0]["tongtien"].ToString();

        }
        //reser
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            display();
            txt_total_amount.Text = sumdetall(1);
        }
        //delete
        private void btdelete_Click(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            DialogResult dr = MessageBox.Show("Chắc chắn xoá sản phẩm này không?", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            string sql = string.Format("delete from OutputDetails where OutputDetailID = {0}", id_details());
            mydatasevices.RunQuery(sql);
            display_date();
        }
        //lấy idiputdetails
        public int id_details()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select OutputDetailID from Products a join Categories b on a.CategoryID = b.CategoryID join Unit c on c.UnitID = a.UnitID join Suppliers d on d.SupplierID = a.SupplierID join OutputDetails e on e.ProductID = a.ProductID join Customers f on f.CustomerID = e.CustomerID join Output g on g.OutputID = e.OutputID where a.ProductName = N'{0}' and CategoryName =N'{1}' and f.FirstName = N'{2}' and g.OutputDate = N'{3}'", nameproduct, namecategory, namecustomer, txtdate.Text);
            DataTable n = mydatasevices.RunQuery(sql);
            return (int)n.Rows[0]["OutputDetailID"];
        }
        //print
        private void btprint_Click(object sender, EventArgs e)
        {
            print.printoutput printoutput = new print.printoutput();

            printoutput.ShowDialog();
        }

        //edit
        private void btedit_Click_1(object sender, EventArgs e)
        {
            cheack = true;
            Add.Add_output add_Output = new Add.Add_output(this);
            add_Output.ShowDialog();
            display_date();
            txt_total_amount.Text = sumdetall(2);
        }
        
        // display theo ngày
         private void display_date()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select g.FirstName, c.ProductName,e.CategoryName,d.CompanyName,NameUnit,b.Quantity,j.OutputPrice,a.OutputDate,b.Note " +
                "from Output a join OutputDetails b " +
                "on a.OutputID = b.OutputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID " +
                "join Customers g on g.CustomerID = b.CustomerID " +
                "join Warehouse j on j.ProductID = b.ProductID where OutputDate = convert(date,('{0}'))",txtdate.Text);
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid2.DataSource = mydatatable;
        }
        //display all
        private void display()
        {
            mydatasevices = new dataservices();
            string sql = "select g.FirstName, c.ProductName,e.CategoryName,d.CompanyName,NameUnit,b.Quantity,j.OutputPrice,a.OutputDate,b.Note " +
                "from Output a join OutputDetails b " +
                "on a.OutputID = b.OutputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID " +
                "join Customers g on g.CustomerID = b.CustomerID " +
                "join Warehouse j on j.ProductID = b.ProductID";
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid2.DataSource = mydatatable;
        }
       

        //lấy id output lọc theo ngày
        public int id_iput()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select * from Output where OutputDate = '{0}'", date);
            DataTable dt = mydatasevices.RunQuery(sql);
            return Convert.ToInt32(dt.Rows[0]["OutputID"].ToString());
        }
        
        private void btedit_Click(object sender, EventArgs e)
        {
           
        }
        //search
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            if (txtcategory.Text == "")
            {
                //tìm kiếm theo ngày
                string sql = string.Format("select g.FirstName, c.ProductName,e.CategoryName,d.CompanyName,NameUnit,b.Quantity,j.OutputPrice,a.OutputDate,b.Note " +
                "from Output a join OutputDetails b " +
                "on a.OutputID = b.OutputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID " +
                "join Customers g on g.CustomerID = b.CustomerID " +
                "join Warehouse j on j.ProductID = b.ProductID where OutputDate = convert(date,('{0}'))", txtdate.Text);
                mydatatable = mydatasevices.RunQuery(sql);
                txt_total_amount.Text = sumdetall(2);
            }
            else
            {
                //tìm kiếm theo loại
                string sql = string.Format("select g.FirstName, c.ProductName,e.CategoryName,d.CompanyName,NameUnit,b.Quantity,j.OutputPrice,a.OutputDate,b.Note " +
                "from Output a join OutputDetails b " +
                "on a.OutputID = b.OutputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID " +
                "join Customers g on g.CustomerID = b.CustomerID " +
                "join Warehouse j on j.ProductID = b.ProductID where OutputDate = convert(date,('{0}')) and {1} like N'{2}%'", txtdate.Text,output_data,txtoutput.Text);
                mydatatable = mydatasevices.RunQuery(sql);
                //nếu không tìm thấy in ra cảnh báo
                if (mydatatable.Rows.Count == 0)
                {
                    messagebox.Warning("Không tìm thấy danh sách bạn cần tìm!");
                    return;
                }
                txt_total_amount.Text = sumdetall(3);
            }
            bunifuCustomDataGrid2.DataSource = mydatatable;
        }
        //load
        private void us_output_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            display_date();
            addcombox();
        }
        //add
        private void btadd_Click(object sender, EventArgs e)
        {
            //cheack = false;
            addformkhac.customer customer = new addformkhac.customer();
            customer.ShowDialog();
            //show hàng mới lên
            display_date();
            txt_total_amount.Text = sumdetall(2);
        }
        
    }
}
