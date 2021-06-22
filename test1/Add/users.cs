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
    public partial class users : Form
    {
        dataservices mydatasevices;
        public users()
        {
            InitializeComponent();
        }
        form_main Form_Main = new form_main();
        public users(form_main form_)
        {
            InitializeComponent();
            Form_Main = form_;
        }
        string na, fulln, ps;
        public void display()
        {
            string sql = string.Format("select * from Users where UserID = {0}", Convert.ToInt32(Form_Main.id));
            DataTable tb = mydatasevices.RunQuery(sql);
            na = tb.Rows[0]["UserName"].ToString();
            fulln = tb.Rows[0]["FullName"].ToString();
            ps = tb.Rows[0]["Password"].ToString();
            
        }
        private void users_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            display();
            name.Text = na;
            fullname.Text = fulln;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            string psss = md5.GetMD5(md5.GetMD5(txtpasscu.Text));
            string psssm = md5.GetMD5(md5.GetMD5(txtpassmoi.Text));
            if (cheack_the_case.IsEmpty(txtpassmoi.Text, "Mật khẩu mới không được để trống ") == true) return;
            if (cheack_the_case.IsEmpty(txtpasscu.Text, "Mật khẩu cũ không được để trống ") == true) return;
            if (cheack_the_case.IsEmpty(xacnhanpass.Text, "Xác nhận mật khẩu không được để trống ") == true) return;
            if (psss != ps)
            {
                messagebox.Warning("Mật khẩu cũ chưa chính xác");
            }
            else if(txtpassmoi.Text != xacnhanpass.Text)
            {
                messagebox.Warning("Xác nhận mật khẩu chưa chính xác");
            }
            else if(psss == psssm)
            {
                messagebox.Warning("Mật khẩu mới không trùng với mật khẩu mới");
            }
            else
            {
                string sql = string.Format("Update Users set Password = N'{0}' where UserID = {1}", psssm, Convert.ToInt32(Form_Main.id));
                mydatasevices.RunQuery(sql);
                messagebox.Information("Xác nhận mật khẩu thành công!");
                txtpassmoi.Clear();
                txtpasscu.Clear();
                xacnhanpass.Clear();
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
