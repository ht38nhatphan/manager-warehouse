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
    public partial class Supplier : Form
    {
        private dataservices mydataservices;
        public Supplier()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void cleartext()
        {
            txtaddress.Clear();
            txtcompany.Clear();
            txtemail.Clear();
            txtnamecopany.Clear();
            txtphone.Clear();
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            mydataservices = new dataservices();
            DataTable mydatatable = new DataTable();
            //Check trung ten
            if (true)
            {
                string sql1 = string.Format("select * from Suppliers where CompanyName = N'{0}'", txtcompany.Text);
                mydatatable = mydataservices.RunQuery(sql1);
                if (mydatatable.Rows.Count > 0)
                {
                    messagebox.Warning("Loại Sản Phẩm Này Đã Tồn Tại Mời Nhập Lại!");
                    return;
                }
            }
            ////cheak điều kiện text box không được để trống
            if (cheack_the_case.IsEmpty(txtcompany.Text, "Tên nhà cung cấp không được để trống!") == true) return;
            if (cheack_the_case.IsEmpty(txtnamecopany.Text, "Tên người đại diện không được để trống!") == true) return;
            if (cheack_the_case.IsEmpty(txtaddress.Text, "Tên địa chỉ không được để trống!") == true) return;
            if (cheack_the_case.IsEmpty(txtphone.Text, "Số điện thoại không được để trống!") == true) return;
            if (cheack_the_case.IsEmpty(txtemail.Text, "Tên email không được để trống!") == true) return;

            //check các điều kiện khác
            if (cheack_the_case.IsEmailInvalid(txtemail.Text) == false) return;
            //nếu cheak == false thêm 
            string sql = string.Format("insert into Suppliers(CompanyName,ContactName,Address,Phone,Email) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", txtcompany.Text, txtnamecopany.Text, txtaddress.Text, txtphone.Text, txtemail.Text);
            //insert data
            mydataservices.RunQuery(sql);
            //clear data in txt
            cleartext();
            //display in luoi
            messagebox.Information("Đã Thêm Thành Công!");

        }
    }
}
