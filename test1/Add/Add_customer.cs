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
    public partial class Add_customer : Form
    {
        public Add_customer()
        {
            InitializeComponent();
        }
        //this đến đối tượng us_customer
        usercontrol.us_customer us_Customer = new usercontrol.us_customer();
        public Add_customer(usercontrol.us_customer us_)
        {
            InitializeComponent();
            us_Customer = us_;
        }
        private dataservices Dataservices;
        DataTable DataTable;
        private void btdelete_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }
        //display
        private void display()
        {
            Dataservices = new dataservices();
            DataTable = new DataTable();
            string sql = "select a.FirstName,a.LastName,a.Address,a.Phone,a.Email from Customers a";
            DataTable = Dataservices.RunQuery(sql);
            bunifuCustomDataGrid2.DataSource = DataTable;
        }
        //kiểm tra trùng số điện thoại
        bool cheaksdt(string n)
        {
            Dataservices = new dataservices();
            DataTable = new DataTable();
            string sql = string.Format("select a.FirstName,a.LastName,a.Address,a.Phone,a.Email from Customers a where a.Phone = N'{0}'",n);
            DataTable = Dataservices.RunQuery(sql);
            if (DataTable.Rows.Count > 0)
            {
                messagebox.Warning("Số điện thoại này đã có trong dữ liệu");
                return true;
            }
            else
            {
                return false;
            }
        }
        //save
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //cheak diều kiện rỗng
            if (cheack_the_case.IsEmpty(txtfirstname.Text, "Tên") == true) return;
            if (cheack_the_case.IsEmpty(txtfirstname.Text, "Họ và tên lót") == true) return;
            if (cheack_the_case.IsEmpty(txtfirstname.Text, "Địa chỉ") == true) return;
            if (cheack_the_case.IsEmpty(txtfirstname.Text, "Số điện Thoại") == true) return;
            if (cheack_the_case.IsEmpty(txtfirstname.Text, "Email") == true) return;
            //cheack sdt
            if (cheack_the_case.IsPhoneInvalid(txtphone.Text) == false) return;
            //cheak email
            if (cheack_the_case.IsEmailInvalid(txtemail.Text) == false) return;
            //cheak trùng số điện thoại
            if (cheaksdt(txtphone.Text) == true) return;
            //query
            //nếu trong cheak = false thì them dữ liẹu theo bảng us_customer
            string s = txtfirstname.Text;
            string l = txtlastname.Text;
            if(s.IndexOf("'") >0)
            {
                s = addchuoi(s);
            }
            if (l.IndexOf("'") > 0)
            {
                l = addchuoi(l);
            }
            if (us_Customer.cheak == false)
            {
                string sql = string.Format("Update Customers set FirstName = N'{0}',LastName=N'{1}',Address=N'{2}',Phone=N'{3}',Email=N'{4}' WHERE CustomerID = {5} ", s, l, txtadderss.Text, txtphone.Text, txtemail.Text,us_Customer.id);
                Dataservices.RunQuery(sql);
                messagebox.Information("Cập nhật khách hàng thành công");
                display();
            }
            //them dữ liệu
            else 
            {
                string sql = string.Format("Insert into Customers(FirstName,LastName,Address,Phone,Email)  values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')", s, l, txtadderss.Text, txtphone.Text, txtemail.Text);
                Dataservices.RunQuery(sql);
                messagebox.Information("Thêm khách hàng thành công");
                display();
            }
           
           
            
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
        private void Add_customer_Load(object sender, EventArgs e)
        {
            if(us_Customer.cheak == false)
            {
                txtadderss.Text = us_Customer.address;
                txtemail.Text = us_Customer.email;
                txtfirstname.Text = us_Customer.firstname;
                txtlastname.Text = us_Customer.lastname;
                txtphone.Text = us_Customer.phone;
                txtfirstname.Focus();
            }
            //ket nối đến csdl
            Dataservices = new dataservices();
            if (Dataservices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            display();

        }

        private void label4_Click(object sender, EventArgs e)
        {

            addformkhac.customer customer = new addformkhac.customer();
            //nếu trong form uscontrol customer thì thoát
            if (us_Customer.cheak == true || us_Customer.cheak == false)
            {
                Close();
            }
            //còn không phải thì vào lại trang customer
            else
            {
                Close();
                customer.ShowDialog();
            }
            
        }
    }
}
