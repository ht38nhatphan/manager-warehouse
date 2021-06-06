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
    public partial class add_product : UserControl
    {
        public add_product()
        {
            InitializeComponent();
        }
        private dataservices mydatasevices;
        private DataTable mydatatable;
        public bool cheack;
        public string  namecategory, nameunit, namesupplier,nameproduct, note;
        private bool cheakall = false;
        //add
        private void btadd_Click(object sender, EventArgs e)
        {
            cheack = false;
            //declare đối tượng add_product
            Add.add_product add_Product = new Add.add_product(this);
            add_Product.inputdata(nameproduct, namecategory, nameunit, namesupplier, note, cheack);
            // hiện thị lên form
            add_Product.ShowDialog();
        }
        //lấy thông số khi click trong datagriview
        private void bunifuCustomDataGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            nameproduct = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            namecategory = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            namesupplier = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            nameunit = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            note = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        //lấy id để xoá
        private int layidpr()
        {

             mydatasevices = new dataservices();
             string sql = string.Format("select ProductID from Products a join Categories b " +
                 "on a.CategoryID = b.CategoryID " +
                 "join Suppliers c on c.SupplierID = a.SupplierID " +
                 "join Unit d on d.UnitID = a.UnitID " +
                 "where CategoryName =N'{0}' and ProductName =N'{1}' and NameUnit =N'{2}'and CompanyName =N'{3}'", namecategory, nameproduct, nameunit, namesupplier);
             DataTable dt = mydatasevices.RunQuery(sql);
             int id = Convert.ToInt32(dt.Rows[0]["ProductID"].ToString());
             return id;

        }
        //delete
        private void btdelete_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Chắc chắn xoá sản phẩm này không?", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            //Sua
            int r = bunifuCustomDataGrid1.CurrentRow.Index;
            string sql = string.Format("Delete from Products where ProductID ={0}",layidpr());
            mydatasevices.RunQuery(sql);
            display();
        }
        //reset
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            display();
        }
        //clear text
        void clear()
        {
            txtcategoryproduct.Text = "";
            txtinput.Clear();
        }
        //all click
        private void gunaMediumCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //click in all cheakall=true
            
            cheakall = true;
            clear();
           
        }
        //khai báo biến đem dữ liệu vào combobox
        string[] txt = { "Tên Sản Phẩm","Tên Loại Sản Phẩm", "Tên Nhà Cung Cấp", "Tên Đơn Vị Tính" };
        //khai báo biến tên để lọc
        string product;
        //add vào combobox
        private void addcombox()
        {

            ////add colum in combobox
            for (int i = 0; i < txt.Length; i++)
            {
                txtcategoryproduct.Items.Add(txt[i]);
            }

        }
        //lấy ra dữ liệu để tìm
        private void txtcategoryproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            //truy vấn theo tên
            string sql = "select a.ProductName,b.CategoryName,d.CompanyName,c.NameUnit,a.Description from Products a join Categories b on a.CategoryID = b.CategoryID join Unit c on c.UnitID = a.UnitID join Suppliers d on d.SupplierID = a.SupplierID";
            mydatatable = mydatasevices.RunQuery(sql);
            //deacare map
            var map = new Dictionary<string, string>();
            for (int i = 0; i < mydatatable.Columns.Count-1; i++)
            {
                //add key and values in map
                map.Add(txt[i], mydatatable.Columns[i].ToString());

            }
            //duyêt map
            foreach (var pair in map)
            {
                //nếu tồn tại tên thì trả về tên trong db
                if (txtcategoryproduct.Text == pair.Key)
                {
                    product = pair.Value;
                    return;
                }
            }
        }

        //display
        public void display()
        {
            string sql = "select a.ProductName,b.CategoryName,d.CompanyName,c.NameUnit,a.Description from Products a join Categories b on a.CategoryID = b.CategoryID join Unit c on c.UnitID = a.UnitID join Suppliers d on d.SupplierID = a.SupplierID";
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid1.DataSource = mydatatable;
            

        }
        //search
        private void btsearch_Click_1(object sender, EventArgs e)
        {
            if(cheakall == true)
            {
                clear();
                display();
                cheakall = false;
            }
            else
            {
                mydatasevices = new dataservices();
                DataTable tb;
                string sql;
                sql =string.Format( "select a.ProductName,b.CategoryName,d.CompanyName,c.NameUnit,a.Description from Products a join Categories b on a.CategoryID = b.CategoryID join Unit c on c.UnitID = a.UnitID join Suppliers d on d.SupplierID = a.SupplierID where {0} like N'{1}%'",product,txtinput.Text);
                tb = mydatasevices.RunQuery(sql);
                //nếu không tìm thấy in ra cảnh báo
                if (tb.Rows.Count == 0)
                {
                    messagebox.Warning("Không tìm thấy danh sách bạn cần tìm!");
                    return;
                }

                //update lên lưới
                bunifuCustomDataGrid1.DataSource = tb;
               
            }
        }
        

        //load
        private void add_product_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            display();
            addcombox();
        }
        //edit
        private void btedit_Click(object sender, EventArgs e)
        {
            cheack = true;
            //declare đối tượng add_product
            Add.add_product add_Product = new Add.add_product(this);
            add_Product.inputdata(nameproduct, namecategory, nameunit, namesupplier, note, cheack);
            // hiện thị lên form
            add_Product.ShowDialog();
        }
    }
}
