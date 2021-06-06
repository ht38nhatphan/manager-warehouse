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
    public partial class Add_category : Form
    {
        //declare connect form add_categories
        usercontrol.add_categories frmcategir;
       

        public Add_category(usercontrol.add_categories add_Categories)
        {

            InitializeComponent();
            frmcategir = add_Categories;
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            Close();

        }
        
        //cheack choose edit or new
        bool cheak = false;
        string name,note;
        public void cheak1(bool a,string n,string nt)
        {
            cheak = a;
            name = n;
            note = nt;
        }
        private dataservices dataservices;
        //update in griview

        void updateinform()
        {
            frmcategir.Connect();
        }
        private void btsave_Click(object sender, EventArgs e)
        {

            dataservices = new dataservices();
            DataTable dataTable = new DataTable();
            //kiem tra trung ten
            if (name != txtcategory.Text.Trim())
            {
                string sql = string.Format("select * from Categories where CategoryName = N'{0}'", txtcategory.Text);
                dataTable = dataservices.RunQuery(sql);
                if (dataTable.Rows.Count > 0)
                {
                    messagebox.Warning("Loại Sản Phẩm Này Đã Tồn Tại Mời Nhập Lại!");
                    return;
                }
            }
            if (cheack_the_case.IsEmpty(txtcategory.Text, "Tên loại sản phẩm") == true) {
                return;
            }
            if (cheak == false)
            {
                
                DataRow dataRow = dataTable.NewRow();
                dataRow["CategoryName"] = txtcategory.Text;
                dataRow["Description"] = txtnote.Text;
                dataTable.Rows.Add(dataRow);
                //update database
                dataservices.Update(dataTable);
                txtcategory.Clear();
                txtnote.Clear();
                messagebox.Information("Đã Thêm Thành Công!");
                updateinform();
                

            }
            else
            {
                string sql = "update Categories set CategoryName = N'" + txtcategory.Text + "',Description = N'" + txtnote.Text + "' where CategoryName = N'" + name + "'";
                dataservices.RunQuery(sql);
                txtcategory.Clear();
                txtnote.Clear();
                messagebox.Information("Đã Cập Nhật Thành Công!");
                updateinform();
                Close();

            }
            

        }

        private void Add_category_Load(object sender, EventArgs e)
        {
            if (cheak == true)
            {
                //add date up textbox
                txtcategory.Text = name;
                txtnote.Text = note;
            }
           


        }
    }
}
