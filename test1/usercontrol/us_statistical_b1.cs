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
    public partial class us_statistical_b1 : UserControl
    {
        private dataservices mydatasevices;
        private DataTable mydatatable;
        public us_statistical_b1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //thông kê doanh thu ước tính lãi
        private void btsearch_Click(object sender, EventArgs e)
        {
            //tong nhap theo ngày
            string sql = string.Format("select sum(a.InputPrice*b.Quantity)as Tongnhap from Warehouse a join OutputDetails b on a.ProductID = b.ProductID join Output c on c.OutputID = b.OutputID where c.OutputDate between convert(date, ('{0}')) and convert(date,('{1}'))",txtdatedt.Text,txtdatedt_1.Text);
            //tong xuat theo ngày
            string sql1 = string.Format("select sum(a.OutputPrice*b.Quantity)as Tongxuat from Warehouse a join OutputDetails b on a.ProductID = b.ProductID join Output c on c.OutputID = b.OutputID where c.OutputDate between convert(date, ('{0}')) and convert(date,('{1}'))", txtdatedt.Text, txtdatedt_1.Text);

            DataTable tb1 = mydatasevices.RunQuery(sql);

            DataTable tb2 = mydatasevices.RunQuery(sql1);
            int tongnhap = 0;
            int tongxuat = 0;
            //doanh thu tinh theo tong xuat - tong nhap
            if (tb1.Rows[0]["Tongnhap"].ToString() == "")
            {
                tongnhap = 0;
            }
            if(tb2.Rows[0]["Tongxuat"].ToString() == "")
            {
                tongxuat = 0;
            }
            else
            {
                tongnhap = Convert.ToInt32(tb1.Rows[0]["Tongnhap"].ToString());
                tongxuat = Convert.ToInt32(tb2.Rows[0]["Tongxuat"].ToString());
            }
            int doanhthu = 0;
            double tlphantram = 0,a=0,b=0;
            if (tongxuat == 0)
            {
                doanhthu = 0;
                tlphantram = 0;
            }
            else
            {
                doanhthu = tongxuat - tongnhap;
                a = Convert.ToDouble(tongxuat);
                b = Convert.ToDouble(doanhthu);
                //tính tỉ lệ % = doanh thu / tong xuat * 100
                //tlphantram = (float)(doanhthu / tongxuat);
                tlphantram = b / a*100;
                //Lấy về số nguyên thứ 2
            }
            
            sum_ban.Text = ": " +tongxuat.ToString();
            sum_nhap.Text = ": " + tongnhap.ToString();
            lai.Text = ": " + doanhthu.ToString();
            laitl.Text = ": " + String.Format("{0:0.0#}", tlphantram) + "%"; 
            
        }

        private void us_statistical_b1_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
        }

        private void tk_Click(object sender, EventArgs e)
        {
            string sql="", sql1="";
            if(txtcategory.Text == "Khách Hàng")
            {
                sql = string.Format("create or alter view thongkekh as select Sum(a.OutputPrice * b.Quantity) - sum(a.InputPrice * b.Quantity) as spdoanhthu, Sum(a.OutputPrice * b.Quantity) as giaxuat, b.CustomerID from Warehouse a join OutputDetails b on a.ProductID = b.ProductID join Output c on c.OutputID = b.OutputID where c.OutputDate between convert(date, ('{0}')) and convert(date, ('{1}')) group by b.CustomerID", txtdatel.Text, txtdatel1.Text);
                sql1 = string.Format("select b.FirstName as N'Tên Khách Hàng',a.spdoanhthu as N'Doanh Thu Theo Sản Phẩm',cast((a.spdoanhthu/a.giaxuat)*100 as nvarchar(max)) + '%' as N'Chiếm %' from thongkekh a join Customers b on a.CustomerID = b.CustomerID  order by spdoanhthu desc");

                  
            }
            else if(txtcategory.Text =="Nhà Cung Cấp")
            {
                sql = string.Format(" create or alter view thongkencc as select Sum(a.OutputPrice*b.Quantity)- sum(a.InputPrice*b.Quantity)as spdoanhthu,Sum(a.OutputPrice*b.Quantity) as giaxuat,d.SupplierID from Warehouse a join OutputDetails b on a.ProductID = b.ProductID join Output c on c.OutputID = b.OutputID join Products d on d.ProductID = a.ProductID where c.OutputDate between convert(date, ('{0}')) and convert(date,('{1}')) group by d.SupplierID", txtdatel.Text, txtdatel1.Text);
                sql1 = string.Format("select b.CompanyName as N'Tên Nhà Cung Cấp',a.spdoanhthu as N'Doanh Thu Theo Sản Phẩm',cast((a.spdoanhthu/a.giaxuat)*100 as nvarchar(max)) + '%' as N'Chiếm %' from thongkencc a join Suppliers b on a.SupplierID = b.SupplierID  order by spdoanhthu desc");

            }
            else if(txtcategory.Text== "Loại Sản Phẩm")
            {
                sql = string.Format("create or alter view thongkeloaisp as select Sum(a.OutputPrice*b.Quantity)- sum(a.InputPrice*b.Quantity)as spdoanhthu,Sum(a.OutputPrice*b.Quantity) as giaxuat,d.CategoryID from Warehouse a join OutputDetails b on a.ProductID = b.ProductID join Output c on c.OutputID = b.OutputID join Products d on d.ProductID = a.ProductID where c.OutputDate between convert(date, ('{0}')) and convert(date,('{1}')) group by d.CategoryID", txtdatel.Text, txtdatel1.Text);
                sql1 = string.Format("select b.CategoryName as N'Tên Loại Sản Phẩm',a.spdoanhthu as N'Doanh Thu Theo Sản Phẩm',cast((a.spdoanhthu/a.giaxuat)*100 as nvarchar(max)) + '%' as N'Chiếm %' from thongkenloaisp a join Categories b on a.CategoryID =b.CategoryID  order by spdoanhthu desc");

            }
            else if(txtcategory.Text =="Sản Phẩm")
            {
                sql = string.Format("create or alter view thongkesp as select Sum(a.OutputPrice*b.Quantity)- sum(a.InputPrice*b.Quantity)as spdoanhthu,Sum(a.OutputPrice*b.Quantity) as giaxuat,a.ProductID from Warehouse a join OutputDetails b on a.ProductID = b.ProductID join Output c on c.OutputID = b.OutputID where c.OutputDate between convert(date, ('{0}')) and convert(date,('{1}')) group by a.ProductID", txtdatel.Text, txtdatel1.Text);
                sql1 = string.Format("select b.ProductName as N'Tên Sản Phẩm',a.spdoanhthu as N'Doanh Thu theo Sản Phẩm',cast((a.spdoanhthu/a.giaxuat)*100 as nvarchar(max)) + '%' as N'Chiếm %' from thongkesp a join Products b on a.ProductID = b.ProductID  order by spdoanhthu desc");
            }
            //chạy view
            mydatasevices.RunQuery(sql);
            mydatatable = new DataTable();
            //them dưa liệu vào table
            mydatatable = mydatasevices.RunQuery(sql1);
            //them lên lưới
            bunifuCustomDataGrid2.DataSource = mydatatable;


        }
    }
}
