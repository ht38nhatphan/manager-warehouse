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
        string txtdate = DateTime.Now.ToString();
        
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
        //luuw
        private void btsave_Click(object sender, EventArgs e)
        {
            //lấy date hiện tại
            if(txtdate.IndexOf(" ") > 0)
            {
                txtdate = txtdate.Substring(0, txtdate.IndexOf(" "));
            }
            
            //khởi tạo lấy inputid
            date_not_click();


            mydatasevices = new dataservices();
            //cheack dữ liệu không dk trống
            if (cheack_the_case.IsEmpty(txtquantity.Text, "Số lượng ") == true) return;
            if (cheack_the_case.IsEmpty(txtpriceinput.Text, "Giá nhập ") == true) return;
            if (cheack_the_case.IsEmpty(txtpriceoutput.Text, "Giá xuất ") == true) return;
            //cheak dữ liệu của giá xuất không được nhỏ hơn giá nhập
            if(float.Parse(txtpriceinput.Text.ToString())> float.Parse(txtpriceoutput.Text.ToString()))
            {
                messagebox.Information("Giá xuất không được nhỏ hơn giá nhập!");
                return;
            }
            //Khi nhập vào input cheak nếu trùng sản phẩm nhưng giá nhập khác thì tạo 1 from khác,nhập giá bán vào cập nhập những những sản phẩm mã input và mã product giống nhau trong ngày đó
            //tăng số lượng sản phẩm
                if (frmproduct.cheak == false)
            {

                mydatasevices = new dataservices();
                //query kiểm tra sản phẩm trong trong ngày hiện tại có giá nhập trùng vs giá nhập trong csdl thì tăng sản phẩm nếu giá xuất khác thì chỉnh theo giá xuất hiện tại
                string sql = string.Format("select Count(*) as ct from InputDetails a join Input b on a.InputID = b.InputID join Products c on c.ProductID =a.ProductID " +
                    "where a.InputID ={0} and a.InputPrice ={1} and c.ProductName =N'{2}'", idiput, float.Parse(txtpriceinput.Text.ToString()), txtproduct.Text);
                
                DataTable dt = mydatasevices.RunQuery(sql);
                if ((int)dt.Rows[0]["ct"] > 0)
                {
                    //update khi số lượng và giá xuất khi nhập vào của ngày hiện tại
                    string sql1 = string.Format("Update InputDetails set Quantity = Quantity + {0} ,OutputPrice = {1} where InputID ={2} and InputPrice ={3} and ProductID ={4}", Convert.ToInt32(txtquantity.Text), float.Parse(txtpriceoutput.Text.ToString()), idiput, float.Parse(txtpriceinput.Text.ToString()), frmproduct.layidpr());
                    mydatasevices.RunQuery(sql1);

                    //query kiểm tra nêu trong chi tiết nếu trùng sản phẩm trong bảng mà không có trong ngày hôm nay thì cập nhập giá xuất hiện tại
                    string sql2 = string.Format("select Count(*) as ct from InputDetails a join Products c on c.ProductID =a.ProductID " +
                        "where c.ProductName = N'{0}'", txtproduct.Text);
                    DataTable tb1 = mydatasevices.RunQuery(sql2);
                    if ((int)tb1.Rows[0]["ct"] > 0)
                    {
                        //update giá xuất
                        string sql3 = string.Format("Update InputDetails set OutputPrice = {0} where  ProductID = {1}", float.Parse(txtpriceoutput.Text.ToString()), frmproduct.layidpr());
                        mydatasevices.RunQuery(sql3);
                    }

                    //update số lượng vào giá vào bảng kho hàng
                    string sql4 = string.Format("Update Warehouse set Quantity = Quantity + {0}, OutputPrice = {1},InputPrice = {2} where  ProductID = {3}", Convert.ToInt32(txtquantity.Text), float.Parse(txtpriceoutput.Text.ToString()), float.Parse(txtpriceinput.Text.ToString()), frmproduct.layidpr());
                    mydatasevices.RunQuery(sql4);

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
                //query kiểm tra nêu trong chi tiết nếu trùng sản phẩm trong bảng mà không có trong ngày hôm nay thì cập nhập giá xuất hiện tại
                string sql1 = string.Format("select Count(*) as ct from InputDetails a join Products c on c.ProductID =a.ProductID " +
                    "where c.ProductName =N'{0}'", txtproduct.Text);
                DataTable tb1 = mydatasevices.RunQuery(sql1);
                if ((int)tb1.Rows[0]["ct"] > 0)
                {
                    //update giá xuất
                    string sql2 = string.Format("Update InputDetails set OutputPrice = {0} where  ProductID = {1}", float.Parse(txtpriceoutput.Text.ToString()),frmproduct.layidpr());
                    mydatasevices.RunQuery(sql2);
                }
                //query kiểm tra nếu trong kho hàng chưa có sản phẩm thì thêm mới sản phẩm vào
                string sql3 = string.Format("select * from Warehouse a where a.ProductID={0}", frmproduct.layidpr());
                DataTable tb2 = mydatasevices.RunQuery(sql3);
                if (tb2.Rows.Count == 0)
                {
                    string sql4 = string.Format("insert into Warehouse(ProductID,OutputPrice,Quantity,InputPrice) values({0},{1},{2},{3})", frmproduct.layidpr(), float.Parse(txtpriceoutput.Text.ToString()), Convert.ToInt32(txtquantity.Text.ToString()),float.Parse(txtpriceinput.Text.ToString()));
                    mydatasevices.RunQuery(sql4);
                }
                else
                {
                    string sql4 = string.Format("Update Warehouse set Quantity = Quantity + {0}, OutputPrice = {1},InputPrice ={2} where  ProductID = {3}", Convert.ToInt32(txtquantity.Text), float.Parse(txtpriceoutput.Text.ToString()), float.Parse(txtpriceinput.Text.ToString()), frmproduct.layidpr());
                    mydatasevices.RunQuery(sql4);
                }
                messagebox.Information("Đã Thêm Thành Công!");
                Close();
            }
            //nếu false thì update dữ liệu 
            if(frminput.cheack == false)
            {
                string sql = string.Format("update InputDetails set Quantity = {0},InputPrice = {1},OutputPrice = {2},Note =N'{3}' where InputDetailID = {4}",txtquantity.Text,txtpriceinput.Text,txtpriceoutput.Text,txtnote.Text,layid_detall());
                //lấy giá trị quantity cũ
                string query = string.Format("select Quantity from InputDetails where InputDetailID = {0}", layid_detall());
                mydatatable = new DataTable();
                mydatatable = mydatasevices.RunQuery(query);
                //neu so luong cap nhật lơn hơn số lượng cũ thì cập nhật lại vào kho hàng
                if(Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString())< Convert.ToInt32(txtquantity.Text))
                {
                    int tam = Convert.ToInt32(txtquantity.Text) - Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString()) ;
                    string sql4 = string.Format("Update Warehouse set Quantity = Quantity + {0}, OutputPrice = {1},InputPrice = {2} where  ProductID = {3}", tam, float.Parse(txtpriceoutput.Text.ToString()), float.Parse(txtpriceinput.Text.ToString()), frminput.layidpr());
                    mydatasevices.RunQuery(sql4);
                }
                // nếu số lượng cập nhật bé hơn thì cập nhật lại vào kho hàng 
                else if(Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString()) > Convert.ToInt32(txtquantity.Text))
                {
                    int tam =   Convert.ToInt32(mydatatable.Rows[0]["Quantity"].ToString()) - Convert.ToInt32(txtquantity.Text) ;
                    string sql4 = string.Format("Update Warehouse set Quantity = Quantity - {0}, OutputPrice = {1},InputPrice = {2} where  ProductID = {3}", tam, float.Parse(txtpriceoutput.Text.ToString()), float.Parse(txtpriceinput.Text.ToString()), frminput.layidpr());
                    mydatasevices.RunQuery(sql4);
                }
                mydatasevices.RunQuery(sql);
                
                messagebox.Information("Đã Cập nhật Thành Công!");
                Close();
                //updat bảng
                frminput.display_date();
            }
           
            
        }
        //load
        private void Add_input_Load(object sender, EventArgs e)
        {
            txtquantity.Focus();
            

            //nếu thêm
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
                //txtdate.Value = new System.DateTime(Convert.ToDateTime(frminput.date).Year, Convert.ToDateTime(frminput.date).Month, Convert.ToDateTime(frminput.date).Day);

            }
            //neu co gia nhap gia xuat truoc trong csdl them vao ca text khi them
            else
            {
                mydatasevices = new dataservices();
                string sql = string.Format("select top 1 InputDetailID, InputPrice,OutputPrice,Note from InputDetails where ProductID = {0} order by InputDetailID desc ", frmproduct.layidpr());
                mydatatable = new DataTable();
                mydatatable = mydatasevices.RunQuery(sql);
                if (mydatatable.Rows.Count > 0)
                {
                    txtpriceinput.Text = mydatatable.Rows[0]["InputPrice"].ToString();
                    txtpriceoutput.Text = mydatatable.Rows[0]["OutputPrice"].ToString();
                    txtnote.Text = mydatatable.Rows[0]["Note"].ToString();
                }

            }

        }
        //tạo biến lưu inputid
        int idiput;
        void date_not_click()
        {
            //căt chuõi date
            //txtdate = txtdate.Substring(0, txtdate.IndexOf(" "));
            mydatasevices = new dataservices();
            string sql = string.Format("select * from Input where InputDate = '{0}'", txtdate);
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
                string sql1 = string.Format("insert into Input(InputDate) values('{0}')", txtdate);
                mydatasevices.RunQuery(sql1);
                //lấy dữ liệu id mới thêm vào
                DataTable dt1 = mydatasevices.RunQuery(sql);
                idiput = Convert.ToInt32(dt1.Rows[0]["InputID"].ToString());
            }
        }
       
       
    }
}
