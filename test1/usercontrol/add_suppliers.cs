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
    public partial class add_suppliers : UserControl
    {
        public bool cheak = false;
        public int vt;
        public string fnamem, lname, address, phone, mail;
        private dataservices mydatasevices;
        private DataTable mydatatable;
        public add_suppliers()
        {
            InitializeComponent();
        }
        public void display()
        {
            string sql = "select * from Suppliers";
            mydatatable =  mydatasevices.RunQuery(sql);
            bunifuCustomDataGrid1.DataSource = mydatatable;
            
        }
        private void bunifuCustomDataGrid1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            fnamem = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lname = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            address = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            phone = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mail = bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //declare name cheak search
        string category;
        //search
       
        private void btsearch_Click(object sender, EventArgs e)
        {
            if (vt == 1)
            {
                display();
                txtcategory.Text = "";
                txtinput.Text = "";
                vt = 0;
            }
            else
            {
                mydatasevices = new dataservices();
                string sql = string.Format("select *from Suppliers where {0} Like N'{1}%'", category, txtinput.Text);
                mydatatable = mydatasevices.RunQuery(sql);
                if(mydatatable.Rows.Count == 0)
                {
                    messagebox.Warning("Không thấy danh sách bạn cần tìm!");
                }
                //hien len luoi
                bunifuCustomDataGrid1.DataSource = mydatatable;
            }
        }
        //declare in name category
        string[] txt = { "Tên Nhà Cung Cấp", "Tên Người Đại Diện", "Địa Chỉ", "Số điện Thoại", "Email" };
        //addcombobox
        private void addcombox()
        {

            ////add colum in combobox
            for (int i = 0; i < txt.Length; i++)
            {
                txtcategory.Items.Add(txt[i]);
            }

        }
        //cheak all
        private void gunaMediumCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            vt = 1;
            txtcategory.ResetText();
            txtinput.Clear();
        }
        
        private void txtcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            mydatatable = mydatasevices.RunQuery("select * from Suppliers");
            //deacare map
            var map = new Dictionary<string, string>();
            for (int i = 1; i < mydatatable.Columns.Count; i++)
            {
                //add key and values in map
                map.Add(txt[i - 1], mydatatable.Columns[i].ToString());

            }
            //duyêt map
            foreach(var pair in map)
            {
                //nếu tồn tại tên thì trả về tên trong db
                if(txtcategory.Text == pair.Key)
                {
                    category = pair.Value;
                    return;
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            display();
        }

        private void add_suppliers_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            display();
            addcombox();
        }
        //add
        private void btadd_Click(object sender, EventArgs e)
        {
            cheak = false;
            //declare đối tượng add_supplier
            Add.add_supplier add_Supplier = new Add.add_supplier(this);
            add_Supplier.inputdata(cheak, fnamem, lname, address, phone, mail);
            
            add_Supplier.ShowDialog();
        }
        //edit
        private void btedit_Click(object sender, EventArgs e)
        {
            cheak = true;
            //declare đối tượng add_supplier
            Add.add_supplier add_Supplier = new Add.add_supplier(this);
            add_Supplier.inputdata(cheak, fnamem, lname, address, phone, mail);
            
            add_Supplier.ShowDialog();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chắc chắn xóa nhà cung cấp này không?", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            int r = bunifuCustomDataGrid1.CurrentRow.Index;
            mydatatable.Rows[r].Delete();
            mydatasevices.Update(mydatatable);

        }
    }
}
