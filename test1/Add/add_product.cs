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
    public partial class add_product : Form
    {

        //declare keet noio 2 class
        usercontrol.add_product frmproduct = new usercontrol.add_product();
        addformkhac.product frminput = new addformkhac.product();
        public add_product(usercontrol.add_product add_Product)
        {
            InitializeComponent();
            frmproduct = add_Product;
        }
        //khởi tạo biến không tham số
        public add_product()
        {
        }
        public add_product(addformkhac.product add_Input)
        {
            InitializeComponent();
            frminput = add_Input;
        }
        bool cheak = false;
        private dataservices mydataservices;
        private DataTable tbcategory, tbunit, tbsupplier;
        public string nameproduct, namecategory, nameunit, namesupplier, note;

        private void bntunit_Click(object sender, EventArgs e)
        {
            Add.add_unit add_Unit = new Add.add_unit();
            add_Unit.ShowDialog();
            addcombobox();
        }

        private void bntsupplier_Click(object sender, EventArgs e)
        {
            addformkhac.Supplier supplier = new addformkhac.Supplier();
            supplier.ShowDialog();
            addcombobox();
        }

        //click add category
        private void bntcategory_Click(object sender, EventArgs e)
        {
            addformkhac.category category = new addformkhac.category(this);
            category.ShowDialog();

        }
        void clear()
        {
            txtproduct.Clear();
            txtnote.Clear();
            //cmcategory.ResetText();
            //cmsupplier.ResetText();
            //cmunit.ResetText();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void inputdata(string p, string c, string u, string s, string n, bool ch)
        {
            nameproduct = p;
            namecategory = c;
            namesupplier = s;
            nameunit = u;
            note = n;
            cheak = ch;

        }
        
        private void add_product_Load(object sender, EventArgs e)
        {
            addcombobox();
            if(cheak == true)
            {
                //add in txt
                txtproduct.Text = nameproduct;
                txtnote.Text = note;
                cmcategory.Text = namecategory;
                cmsupplier.Text = namesupplier;
                cmunit.Text = nameunit;
            }
        }
        public void addcombobox()
        {
            dataservices mydataservices1 = new dataservices();
            //add cmb loại sản phẩm
            string sql = "select * from Categories ";
            tbcategory = mydataservices1.RunQuery(sql);
            cmcategory.DataSource = tbcategory;
            cmcategory.DisplayMember = "CategoryName";
            cmcategory.ValueMember = "CategoryID";
            //add cmb nhà cung cấp
            string sql1 = "select * from Suppliers ";
            tbsupplier = mydataservices1.RunQuery(sql1);
            cmsupplier.DataSource = tbsupplier;
            cmsupplier.DisplayMember = "CompanyName";
            cmsupplier.ValueMember = "SupplierID";
            //add cbm đơn vị tính
            string sql2 = "select * from Unit";
            tbunit = mydataservices1.RunQuery(sql2);
            cmunit.DataSource = tbunit;
            cmunit.DisplayMember = "NameUnit";
            cmunit.ValueMember = "UnitID";


        }
        //lấy id product để sửa
        public int layid() { 
            mydataservices = new dataservices();
            string sql = string.Format("select ProductID from Products a join Categories b " +
                "on a.CategoryID = b.CategoryID " +
                "join Suppliers c on c.SupplierID = a.SupplierID " +
                "join Unit d on d.UnitID = a.UnitID " +
                "where CategoryName =N'{0}' and ProductName =N'{1}' and NameUnit =N'{2}'and CompanyName =N'{3}'", namecategory, nameproduct, nameunit, namesupplier);
            DataTable dt = mydataservices.RunQuery(sql);
            int id = Convert.ToInt32( dt.Rows[0]["ProductID"].ToString());
             return id;
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            mydataservices = new dataservices();
            //cheak lặp dữ liêu trong db
            if (cheak==false || cheak==true&& nameproduct != txtproduct.Text.Trim() && namecategory != cmcategory.Text.Trim()&& namesupplier != cmsupplier.Text.Trim()&& nameunit != cmunit.Text.Trim())
            {
                mydataservices = new dataservices();
                string sql = string.Format("select * from Products a join Categories b " +
                "on a.CategoryID = b.CategoryID " +
                "join Suppliers c on c.SupplierID = a.SupplierID " +
                "join Unit d on d.UnitID = a.UnitID " +
                "where CategoryName =N'{0}' and ProductName =N'{1}' and NameUnit =N'{2}'and CompanyName =N'{3}'",cmcategory.Text , txtproduct.Text, cmunit.Text, cmsupplier.Text);
                DataTable datattb = mydataservices.RunQuery(sql);
                if (datattb.Rows.Count > 0)
                {
                    messagebox.Warning("Đã có tên sản phẩm này rồi, xin mời nhập lại!");
                    return;
                }
                
            }
            if (cheack_the_case.IsEmpty(txtproduct.Text, "Tên sản phẩm") == true) return; 
            //lay id của từng thuộc tính trong cmb
            int idcategory = Convert.ToInt32(cmcategory.SelectedValue.ToString()), idunit = Convert.ToInt32(cmunit.SelectedValue.ToString()), idsupplicer = Convert.ToInt32(cmsupplier.SelectedValue.ToString());
            //add
            if (cheak == false)
            {
                string sql = string.Format("insert into Products(SupplierID,UnitID,CategoryID,ProductName,Description) values ({0},{1},{2},N'{3}',N'{4}')", idsupplicer, idunit, idcategory, txtproduct.Text, txtnote.Text);
                mydataservices.RunQuery(sql);
                messagebox.Information("Đã thêm Thành Công!");
                //nếu cheak của bảng input == false thì cập nhập lên bản
                if(frminput.cheakinput == false)
                {
                    frmproduct.display();
                    frminput.cheakinput = true;
                }
                
                else
                {
                    Close();
                }
                
                //clear text
                clear();
            }
            //update
            else
            {
                //up date
                mydataservices = new dataservices();
                string sql = string.Format("update Products " +
                    "set ProductName = N'{0}', CategoryID =N'{1}', SupplierID =N'{2}', UnitID = N'{3}', Description =N'{4}' " +
                    "where ProductID = {5} ", txtproduct.Text, idcategory, idsupplicer, idunit, txtnote.Text, layid());
                mydataservices.RunQuery(sql);
                messagebox.Information("Đã cập nhật Thành Công!");
                frmproduct.display();



            }
        }
    }
}
