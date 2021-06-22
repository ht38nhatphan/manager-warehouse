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
    public partial class Add_output : Form
    {
        string txtdate = DateTime.Now.ToString();
        private dataservices mydatasevices;
        private DataTable mydatatable;
        //khai báo biến có tham số trỏ tới đối tượng addproduct_output
        addformkhac.product_output frmproduct = new addformkhac.product_output();
        public Add_output(addformkhac.product_output add_product)
        {
            InitializeComponent();
            frmproduct = add_product;
        }
        usercontrol.us_output us_Output = new usercontrol.us_output();
        public Add_output(usercontrol.us_output us_)
        {
            InitializeComponent();
            us_Output = us_;

        }
        private void Add_output_Load(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            if (mydatasevices.OpenDB(@"ADMIN\SQLEXPRESS", "QL_KHO_HANG", "sa", "123456") == false) return;
            txtquantity.Focus();
            if (us_Output.cheack == true)
            {
                txtcustomer.Text = us_Output.namecustomer;
                txtproduct.Text = us_Output.nameproduct;
                txtprice.Text = us_Output.outputprice;
                txtquantity.Text = us_Output.quantity;
                txtnote.Text = us_Output.note;
            }
            else
            {
                txtcustomer.Text = frmproduct.fistname;
                txtproduct.Text = frmproduct.productname;
                txtprice.Text = frmproduct.price;
            }
        }
        public Add_output()
        {
            InitializeComponent();
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
        //lấy id outputdetall

        public int layid_detall()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select * from OutputDetails a where a.OutputID = {0} and a.ProductID = {1} and a.CustomerID ={2} ", idoutput, frmproduct.layidpr(), frmproduct.id);
            DataTable dt = mydatasevices.RunQuery(sql);
            return Convert.ToInt32(dt.Rows[0]["OutputDetailID"].ToString());
        }
        bool cheakinput = true;
        private void btsave_Click(object sender, EventArgs e)
        {
            
            //lấy date hiện tại
            if(txtdate.IndexOf(" ") > 0) { txtdate = txtdate.Substring(0, txtdate.IndexOf(" ")); }
           
            //khởi tạo lấy output
            date_not_click();

            mydatasevices = new dataservices();
            //cheack dữ liệu không dk trống
            if (cheack_the_case.IsEmpty(txtquantity.Text, "Số lượng ") == true) return;
            //kiểm tra số lượng sản phẩm nhập không được nhiều hơn sản phẩm trong kho
            if (Convert.ToInt32(txtquantity.Text.ToString()) > Convert.ToInt32(frmproduct.quantity))
            {
                messagebox.Warning(string.Format("Số lượng của bạn nhập nhiều hơn số lượng trong kho, Số lượng trong kho còn {0}", frmproduct.quantity));
                return;
            }
            //nếu trong danh sách xuất của ngày đó đã có sản phẩm thì tăng sô lượng khi thêm vào
            if (cheakinput == true && us_Output.cheack == false)
            {
                string sql = string.Format("select * from OutputDetails a where a.OutputID = {0} and a.ProductID = {1} and a.CustomerID ={2} ", idoutput, frmproduct.layidpr(), frmproduct.id);
                DataTable tb = mydatasevices.RunQuery(sql);
                if (tb.Rows.Count > 0)
                {
                    //tăng số lượng của đơn xuất
                    string sql1 = string.Format("update OutputDetails set Quantity = Quantity + {0} where OutputDetailID = {1}", Convert.ToInt32(txtquantity.Text),layid_detall());
                    mydatasevices.RunQuery(sql1);
                    //khi tạo đơn xuất thì trừ dữ liệu vào kho hàng
                    string sql2 = string.Format("update Warehouse set Quantity = Quantity - {0} where ProductID = {1}", Convert.ToInt32(txtquantity.Text), frmproduct.layidpr());
                    mydatasevices.RunQuery(sql2);
                    messagebox.Information("Đã Thêm Thành Công!");
                    Close();
                    cheakinput = false;
                }
                
            }
            //sửa
            if(us_Output.cheack == true)
            {
                string sql = string.Format("update OutputDetails set Quantity = {0},Note =N'{1}' where OutputDetailID = {2}", txtquantity.Text, txtnote.Text,layid_detall());

                //lấy giá trị quantity cũ
                string query = string.Format("select Quantity from InputDetails where InputDetailID = {0}", layid_detall());
                mydatatable = new DataTable();
                mydatatable = mydatasevices.RunQuery(query);

                //neu so luong cap nhật bé hơn số lượng cũ thì cập nhật lại vào kho hàng
                if (Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString()) < Convert.ToInt32(txtquantity.Text))
                {
                    //trừ đi dữ liệu mới
                    int tam = Convert.ToInt32(txtquantity.Text) - Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString());
                    string sql4 = string.Format("Update Warehouse set Quantity = Quantity - {0} where  ProductID = {1}", tam, us_Output.layidpr());
                    mydatasevices.RunQuery(sql4);
                }
                // nếu số lượng cập nhật lớn thì cập nhật lại vào kho hàng 
                else if (Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString()) > Convert.ToInt32(txtquantity.Text))
                {
                    //cộng lại dữ liệu
                    int tam = Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString()) - Convert.ToInt32(txtquantity.Text);
                    string sql4 = string.Format("Update Warehouse set Quantity = Quantity + {0}} where  ProductID = {1}", tam, us_Output.layidpr());
                    mydatasevices.RunQuery(sql4);
                }
                mydatasevices.RunQuery(sql);
                mydatasevices.RunQuery(sql);


                messagebox.Information("Đã Cập nhật Thành Công!");
                Close();
            }
            //them
            if (cheakinput==true && us_Output.cheack == false)
            {
                //query add
                string sql = string.Format("insert into OutputDetails(OutputID,ProductID,CustomerID,Quantity,Note) Values ({0},{1},{2},{3},N'{4}')", idoutput, frmproduct.layidpr(), Convert.ToInt32(frmproduct.id), Convert.ToInt32(txtquantity.Text.ToString()),txtnote.Text);
                mydatasevices.RunQuery(sql);
                //khi tạo đơn xuất thì trừ dữ liệu vào kho hàng
                string sql1 = string.Format("update Warehouse set Quantity = Quantity - {0} where ProductID = {1}", Convert.ToInt32(txtquantity.Text), frmproduct.layidpr());
                mydatasevices.RunQuery(sql1);
                messagebox.Information("Đã Thêm Thành Công!");
                Close();
            }
            cheakinput = false;
            frmproduct.display();
        }
        //tạo biến lưu output
        int idoutput;
        void date_not_click()
        {
            //căt chuõi date
            //txtdate = txtdate.Substring(0, txtdate.IndexOf(" "));
            mydatasevices = new dataservices();
            string sql = string.Format("select * from Output where OutputDate = '{0}'", txtdate);
            DataTable dt = mydatasevices.RunQuery(sql);
            // if số đơn hàng tồn tại thì không thêm dữ liệu vào
            if (dt.Rows.Count > 0)
            {
                //lấy số id hiện tại
                idoutput = Convert.ToInt32(dt.Rows[0]["OutputID"].ToString());
            }
            //them mới dữ liệu
            else
            {
                string sql1 = string.Format("insert into Output(OutputDate) values('{0}')", txtdate);
                mydatasevices.RunQuery(sql1);
                //lấy dữ liệu id mới thêm vào
                DataTable dt1 = mydatasevices.RunQuery(sql);
                idoutput = Convert.ToInt32(dt1.Rows[0]["OutputID"].ToString());
            }
        }
    }
}
