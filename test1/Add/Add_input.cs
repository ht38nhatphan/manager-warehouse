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
    public partial class Add_input : Form
    {
        private dataservices mydatasevices;
        private DataTable mydatatable;
        addformkhac.product frmproduct = new addformkhac.product();
        usercontrol.us_input frminput = new usercontrol.us_input();
        //khai báo biến có tham số trỏ tới đối tượng addproduct
        public Add_input(addformkhac.product add_product)
        {
            InitializeComponent();
            frmproduct = add_product;
        }
        public Add_input(usercontrol.us_input us_Input)
        {
            InitializeComponent();
            frminput = us_Input;
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
        //lấy id inputdetall

        public int layid_detall()
        {
            mydatasevices = new dataservices();
            string sql = string.Format( "select * from InputDetails a join Input b on a.InputID = b.InputID join Products c on c.ProductID =a.ProductID " +
                    "where a.InputID ={0} and a.InputPrice ={1} and c.ProductName =N'{2}'", frminput.idiput, float.Parse(frminput.inputprice), frminput.nameproduct);
            DataTable dt = mydatasevices.RunQuery(sql);
            return Convert.ToInt32( dt.Rows[0]["InputDetailID"].ToString());
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            //khởi tạo lấy inputid
            date_not_click();


            mydatasevices = new dataservices();
            //cheack dữ liệu không dk trống
            if (cheack_the_case.IsEmpty(txtquantity.Text, "Số lượng ") == true) return;
            if (cheack_the_case.IsEmpty(txtpriceinput.Text, "Giá nhập ") == true) return;
            if (cheack_the_case.IsEmpty(txtpriceoutput.Text, "Giá xuất ") == true) return;
            //Khi nhập vào input cheak nếu trùng sản phẩm nhưng giá nhập khác thì tạo 1 from khác,nhập giá bán vào cập nhập những những sản phẩm mã input và mã product giống nhau
            //tăng số lượng sản phẩm
            if (frmproduct.cheak == false)
            {
                mydatasevices = new dataservices();
                string sql = string.Format("select Count(*) as ct from InputDetails a join Input b on a.InputID = b.InputID join Products c on c.ProductID =a.ProductID " +
                    "where a.InputID ={0} and a.InputPrice ={1} and c.ProductName =N'{2}'", idiput, float.Parse(txtpriceinput.Text.ToString()), txtproduct.Text);
                DataTable dt = mydatasevices.RunQuery(sql);
                if ((int)dt.Rows[0]["ct"] > 0)
                {
                    //update khi số lượng và giá xuất khi nhập vào
                    string sql1 = string.Format("Update InputDetails set Quantity = Quantity + {0} ,OutputPrice = {1} where InputID ={2} and InputPrice ={3} and ProductID ={4}", Convert.ToInt32(txtquantity.Text), float.Parse(txtpriceoutput.Text.ToString()), idiput, float.Parse(txtpriceinput.Text.ToString()), frmproduct.layidpr());
                    mydatasevices.RunQuery(sql1);
                    messagebox.Information("Đã Thêm Thành Công!");

                    //thoát

                    frmproduct.cheak = true;
                }
            }

            //nếu false thì thêm dữ liệu
            if (frmproduct.cheak == false)
            {
                
                string sql = string.Format("insert into InputDetails(InputID,ProductID,Quantity,InputPrice,OutputPrice,Note) Values ({0},{1},{2},{3},{4},N'{5}')", idiput, frmproduct.layidpr(), Convert.ToInt32(txtquantity.Text.ToString()), float.Parse(txtpriceinput.Text.ToString()), float.Parse(txtpriceoutput.Text.ToString()), txtnote.Text);
                mydatasevices.RunQuery(sql);
                messagebox.Information("Đã Thêm Thành Công!");
                Close();
            }
            //nếu false thì update dữ liệu
            if(frminput.cheack == false)
            {
                string sql = string.Format("update InputDetails set Quantity = {0},InputPrice = {1},OutputPrice = {2},Note =N'{3}' where InputDetailID = {4}",txtquantity.Text,txtpriceinput.Text,txtpriceoutput.Text,txtnote.Text,layid_detall());
                mydatasevices.RunQuery(sql);
                messagebox.Information("Đã Cập nhật Thành Công!");
                Close();
                //updat bảng
                frminput.display();
            }
           
            
        }
        
        private void Add_input_Load(object sender, EventArgs e)
        {
            
            txtproduct.Text = frmproduct.productname;
            //nếu đúng add dư liệu click vào các text box
            if(frminput.cheack == false)
            {
                txtproduct.Text = frminput.nameproduct;
                txtquantity.Text = frminput.quantity;
                txtpriceinput.Text = frminput.inputprice;
                txtpriceoutput.Text = frminput.outputprice;
                txtnote.Text = frminput.note;
                //this.txtdate.Value = new System.DateTime(2021, 5, 15, 17, 42, 21, 782);
                //add data lên date
                txtdate.Value = new System.DateTime(Convert.ToDateTime(frminput.date).Year, Convert.ToDateTime(frminput.date).Month, Convert.ToDateTime(frminput.date).Day);

            }
            
        }
        void date_not_click()
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select * from Input where InputDate = '{0}'", txtdate.Text.ToString());
            DataTable dt = mydatasevices.RunQuery(sql);
            // if số đơn hàng tồn tại thì không thêm dữ liệu vào
            if (dt.Rows.Count > 0)
            {
                //lấy số id hiện tại
                idiput = Convert.ToInt32(dt.Rows[0]["InputID"].ToString());
            }
            //them mới dữ liệu
            else
            {
                string sql1 = string.Format("insert into Input(InputDate) values('{0}')", txtdate.Text.ToString());
                mydatasevices.RunQuery(sql1);
                //lấy dữ liệu id mới thêm vào
                DataTable dt1 = mydatasevices.RunQuery(sql);
                idiput = Convert.ToInt32(dt1.Rows[0]["InputID"].ToString());
            }
        }
        //tạo biến lưu inputid
        int idiput;
        private void txtdate_ValueChanged(object sender, EventArgs e)
        {
            mydatasevices = new dataservices();
            string sql = string.Format("select * from Input where InputDate = '{0}'", txtdate.Text.ToString());
            DataTable dt = mydatasevices.RunQuery(sql);
            // if số đơn hàng tồn tại thì không thêm dữ liệu vào
            if (dt.Rows.Count > 0)
            {
                //lấy số id hiện tại
                idiput = Convert.ToInt32(dt.Rows[0]["InputID"].ToString());
            }
            //them mới dữ liệu
            else
            {
                string sql1 = string.Format("insert into Input(InputDate) values('{0}')", txtdate.Text.ToString());
                mydatasevices.RunQuery(sql1);
                //lấy dữ liệu id mới thêm vào
                DataTable dt1 = mydatasevices.RunQuery(sql);
                idiput = Convert.ToInt32(dt1.Rows[0]["InputID"].ToString());
            }
        }
    }
}
