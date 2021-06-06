using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.Add
{
    public partial class add_supplier : Form
    {
        bool cheak;
        string fname, lname, address, phone, mail;
        usercontrol.add_suppliers frmsup;
        private dataservices mydataservices;
        //declare keet noio 2 class
        public add_supplier(usercontrol.add_suppliers add_Suppliers)
        {
            InitializeComponent();
            frmsup = add_Suppliers;
        }
        //close
        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void inputdata(bool c,string f,string l,string a,string s,string e)
        {
            fname = f;
            lname = l;
            address = a;
            phone = s;
            mail = e;
            cheak = c;
        }
        private void add_supplier_Load(object sender, EventArgs e)
        {
            
            if (cheak == true)
            {
                txtaddress.Text = address;
                txtcompany.Text = fname;
                txtemail.Text = mail;
                txtnamecopany.Text = lname;
                txtphone.Text = phone;
            }
        }
        public void cleartext()
        {
            txtaddress.Clear();
            txtcompany.Clear();
            txtemail.Clear();
            txtnamecopany.Clear();
            txtphone.Clear();
        }

        //save
        private void btsave_Click(object sender, EventArgs e)
        {
            
            mydataservices = new dataservices();
            DataTable mydatatable = new DataTable();
            //Check trung ten
            if (fname != txtcompany.Text.Trim())
            {
                string sql = string.Format("select * from Suppliers where CompanyName = N'{0}'", txtcompany.Text);
                mydatatable = mydataservices.RunQuery(sql);
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
            if (cheak == false)
            {

                string sql = string.Format("insert into Suppliers(CompanyName,ContactName,Address,Phone,Email) values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", txtcompany.Text, txtnamecopany.Text, txtaddress.Text, txtphone.Text, txtemail.Text);
                //insert data
                mydataservices.RunQuery(sql);
                //clear data in txt
                cleartext();
                //display in luoi
                messagebox.Information("Đã Thêm Thành Công!");
                frmsup.display();
            }
            else
            {
                
                string sql = string.Format("update Suppliers set CompanyName = N'{0}',ContactName = N'{1}',Address = N'{2}',Phone = N'{3}',Email = N'{4}' where CompanyName = N'{5}'", txtcompany.Text, txtnamecopany.Text, txtaddress.Text, txtphone.Text, txtemail.Text, fname);
                //update data
                mydataservices.RunQuery(sql);
                frmsup.display();
                //close app
                messagebox.Information("Đã Cập Nhật Thành Công!");
                Close();
                


            }

        }
    }
}
