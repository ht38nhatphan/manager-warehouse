using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class form_Sign_up : Form
    {
        dataservices mydatasevices;
        public form_Sign_up()
        {
            InitializeComponent();
        }
        
        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thoát không!", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;
            Application.ExitThread();
        }
     

        public string name,Pass,id;
        private void button1_Click(object sender, EventArgs e)
        {
            //bảo mật md5
            Pass = md5.GetMD5(md5.GetMD5(txtpass.Text));
            //kiểm tra tài khoản mật khẩu có đúng không
            string sql = string.Format("select * from Users where UserName =N'{0}' and Password =N'{1}'", txtname.Text, Pass);
            DataTable tb = mydatasevices.RunQuery(sql);
            if (tb.Rows.Count > 0)
            {
                name = txtname.Text;
                id = tb.Rows[0]["UserID"].ToString();
                form_main form_Main = new form_main(this);
                form_Main.ShowDialog();
            }
            else
            {
                messagebox.Warning("Tài khoản hoặc mật khẩu không chính xác");
                return;
            }
        }

        private void form_Sign_up_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
        }
    }
}
