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
    public partial class us_statistical : UserControl
    {
        private dataservices mydatasevices;
        private DataTable mydatatable;
        public us_statistical()
        {
            InitializeComponent();
        }
        //tong phiếu nhập
        public string input()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select count(*) as tong from InputDetails";
            mydatatable = mydatasevices.RunQuery(sql);
            return mydatatable.Rows[0]["tong"].ToString();
        }
        //tong phiếu xuất
        public string output()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select count(*) as tong from OutputDetails";
            mydatatable = mydatasevices.RunQuery(sql);
            return mydatatable.Rows[0]["tong"].ToString();
        }
        //tong phiếu Khách hàng
        public string customer()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select count(*) as tong from Customers";
            mydatatable = mydatasevices.RunQuery(sql);
            return mydatatable.Rows[0]["tong"].ToString();
        }
        //tong nha cung cấp
        public string suplies()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select count(*) as tong from Suppliers";
            mydatatable = mydatasevices.RunQuery(sql);
            return mydatatable.Rows[0]["tong"].ToString();
        }
        //tong san phâm trong kho
        public string warehouse()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select count(*) as tong from Warehouse";
            mydatatable = mydatasevices.RunQuery(sql);
            return mydatatable.Rows[0]["tong"].ToString();
        }
        //show input
        private void showinput()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select top 5 c.ProductName,NameUnit,e.CategoryName,d.CompanyName,a.InputDate,b.Quantity,b.InputPrice,b.OutputPrice,b.Note from Input a join InputDetails b " +
                "on a.InputID = b.InputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID" +
                " join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID order by InputDetailID desc";
            mydatatable = mydatasevices.RunQuery(sql);
            inth.DataSource = mydatatable;
        }
        //show output
        private void showoutput()
        {
            mydatasevices = new dataservices();
            mydatatable = new DataTable();
            string sql = "select top 5 g.FirstName, c.ProductName,e.CategoryName,NameUnit,b.Quantity,j.OutputPrice,a.OutputDate,b.Note " +
                "from Output a join OutputDetails b " +
                "on a.OutputID = b.OutputID " +
                "join Products c on c.ProductID = b.ProductID " +
                "join Suppliers d on d.SupplierID = c.SupplierID " +
                "join Categories e on e.CategoryID = c.CategoryID " +
                "join Unit f on f.UnitID = c.UnitID " +
                "join Customers g on g.CustomerID = b.CustomerID " +
                "join Warehouse j on j.ProductID = c.ProductID order by OutputDetailID desc";
            mydatatable = mydatasevices.RunQuery(sql);
            outp.DataSource = mydatatable;
        }
        public void display()
        {
            txtcustomer.Text = customer();
            txtinput.Text = input();
            txtoutput.Text = output();
            txtsupplier.Text = suplies();
            txtprouct.Text = warehouse();
            showinput();
            showoutput();
        }
        private void us_statistical_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            display();
        }
    }
}
