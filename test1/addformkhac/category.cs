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
    public partial class category : Form
    {
        Add.add_product frmproduct = new Add.add_product();
        public category(Add.add_product add_Product)
        {
            InitializeComponent();
            frmproduct = add_Product;
        }
        private dataservices dataservices;
        private void category_Load(object sender, EventArgs e)
        {

        }

        private void btsave_Click(object sender, EventArgs e)
        {

            dataservices = new dataservices();
            DataTable dataTable = new DataTable();
            //kiem tra trung ten
            if (true)
            {
                string sql = string.Format("select * from Categories where CategoryName = N'{0}'", txtcategory.Text);
                dataTable = dataservices.RunQuery(sql);
                if (dataTable.Rows.Count > 0)
                {
                    messagebox.Warning("Loại Sản Phẩm Này Đã Tồn Tại Mời Nhập Lại!");
                    return;
                }
            }
            if (cheack_the_case.IsEmpty(txtcategory.Text, "Tên loại sản phẩm") == true)
            {
                return;
            }

                DataRow dataRow = dataTable.NewRow();
                dataRow["CategoryName"] = txtcategory.Text;
                dataRow["Description"] = txtnote.Text;
                dataTable.Rows.Add(dataRow);
                //update database
                dataservices.Update(dataTable);
                txtcategory.Clear();
                txtnote.Clear();
                messagebox.Information("Đã Thêm Thành Công!");

            frmproduct.addcombobox();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
