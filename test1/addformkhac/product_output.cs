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
    public partial class product_output : Form
    {
        public product_output()
        {
            InitializeComponent();
        }
        public bool  cheak = true;
        private dataservices mydatasevices;
        private DataTable mydatatable;
        public string productname,fistname,id;
        public string namecategory, nameunit, namesupplier,price,quantity;

        ////khai báo biến có tham số trỏ tới đối tượng customer
        customer customer = new customer();
        public product_output(customer customera)
        {
            InitializeComponent();
            customer = customera;

        }

        //add combox
        private void addcombox()
        {

            ////add colum in combobox
            for (int i = 0; i < txt.Length; i++)
            {
                txtcategoryproduct.Items.Add(txt[i]);
            }

        }
        //loat
        private void product_output_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            addcombox();
            display();
        }
        //khai báo biến tên để lọc
        string producta;
        private void txtcategoryproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            //truy vấn theo tên
            string sql = "select a.ProductName,b.CategoryName,d.CompanyName,c.NameUnit,a.Description from Products a join Categories b on a.CategoryID = b.CategoryID join Unit c on c.UnitID = a.UnitID join Suppliers d on d.SupplierID = a.SupplierID";
            mydatatable = mydatasevices.RunQuery(sql);
            //deacare map
            var map = new Dictionary<string, string>();
            for (int i = 0; i < mydatatable.Columns.Count - 1; i++)
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
                    producta = pair.Value;
                    return;
                }
            }
        }
        //layidpr
        public int layidpr()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select ProductID from Products a join Categories b " +
                "on a.CategoryID = b.CategoryID " +
                "join Suppliers c on c.SupplierID = a.SupplierID " +
                "join Unit d on d.UnitID = a.UnitID " +
                "where CategoryName =N'{0}' and ProductName =N'{1}' and NameUnit =N'{2}'and CompanyName =N'{3}'", namecategory, productname, nameunit, namesupplier);
            DataTable dt = mydatasevices.RunQuery(sql);
            int id = Convert.ToInt32(dt.Rows[0]["ProductID"].ToString());
            return id;
        }
        //display
        public void display()
        {
            string sql = "select a.ProductName,c.CategoryName,e.CompanyName,d.NameUnit,b.Quantity,b.OutputPrice,a.Description from Products a join Warehouse b on a.ProductID = b.ProductID join Categories c on c.CategoryID = a.CategoryID join Unit d on d.UnitID = a.UnitID join Suppliers e on e.SupplierID = a.SupplierID";
            mydatatable = mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid1.DataSource = mydatatable;
        }

        private void bunifuCustomDataGrid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cheak = false;
            //lay custome
            fistname = customer.firstname;
            id = customer.id;
            Add.Add_output add_Input = new Add.Add_output(this);
            add_Input.ShowDialog();
        }

        //lưu dữ liệu khi click vào
        private void bunifuCustomDataGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            productname = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            namecategory = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            namesupplier = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            nameunit = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            quantity = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            price = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        string[] txt = { "Tên Sản Phẩm", "Tên Loại Sản Phẩm", "Tên Nhà Cung Cấp", "Tên Đơn Vị Tính" };
        //search
        private void btsearch_Click(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            DataTable tb;
            string sql;
            sql = string.Format("select a.ProductName,c.CategoryName,e.CompanyName,d.NameUnit,b.Quantity,b.OutputPrice,a.Description from Products a join Warehouse b on a.ProductID = b.ProductID join Categories c on c.CategoryID = a.CategoryID join Unit d on d.UnitID = a.UnitID join Suppliers e on e.SupplierID = a.SupplierID where {0} like N'{1}%'", producta, txtinput.Text);
            tb = mydatasevices.RunQuery(sql);
            //nếu không tìm thấy in ra cảnh báo
            if (tb.Rows.Count == 0)
            {
                DialogResult dr = MessageBox.Show("Không tìm thấy danh sách bạn cần tìm, nếu bạn muốn thêm mới thì hãy nhấn có", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //nếu nhấn k thoát
                if (dr == System.Windows.Forms.DialogResult.No) return;
               
            }
            else
            {
                //update lên lưới
                bunifuCustomDataGrid1.DataSource = tb;
            }
        }
        //close
        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
