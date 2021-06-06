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
    public partial class add_unit : Form
    {
        public add_unit()
        {
            InitializeComponent();
        }
        bool cheackbt;
        private dataservices dataservices;
        private DataTable dataTable;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            cheackbt = true;
            txtunit.Clear();
            setcontrol(true);
        }
        public void display()
        {
            dataservices = new dataservices();
            string sql = "select * from Unit";
            dataTable = dataservices.RunQuery(sql);
            bunifuCustomDataGrid2.DataSource = dataTable;
        }
        public void setcontrol(bool edit)
        {
            txtunit.Enabled = edit;
            btadd.Enabled = !edit;
            btedit.Enabled = !edit;
            btdelete.Enabled = !edit;
            btsave.Enabled = edit;
        }
        private void add_unit_Load(object sender, EventArgs e)
        {
            display();
        }
        string _unit;
        private void btedit_Click(object sender, EventArgs e)
        {
            _unit = txtunit.Text;
            setcontrol(true);
            cheackbt = false;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chắc chắn xóa tên đơn vị đã chọn không?", "Thông báo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            int r = bunifuCustomDataGrid2.CurrentRow.Index;
            dataTable.Rows[r].Delete();
            dataservices.Update(dataTable);
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            DataTable data;
            if (cheack_the_case.IsEmpty(txtunit.Text, "Tên đơn vị tính không được để trống!") == true) return;
            //cheack trùng loại
            if (_unit != txtunit.Text)
            {
                dataservices = new dataservices();
                string sql = string.Format("select * from Unit where NameUnit = N'{0}'", txtunit.Text);
                data= dataservices.RunQuery(sql);
                if (data.Rows.Count > 0)
                {
                    messagebox.Warning("Tên đơn vị tính trùng xin mời nhập lại!");
                    return;
                }

            }
            if (cheackbt == true)
            {
                dataservices = new dataservices();
                string sql = "insert into Unit(NameUnit) values(N'" + txtunit.Text + "')";
                dataservices.RunQuery(sql);
                messagebox.Information("Đã thêm thành công!");

            }
            else
            {
                dataservices = new dataservices();
                data = new DataTable();
                int r = bunifuCustomDataGrid2.CurrentRow.Index;
                DataRow datar = data.Rows[r];
                datar["NameUnit"] = txtunit.Text;
                dataservices.Update(data);
            }
            setcontrol(false);
            display();
        }

        private void bunifuCustomDataGrid2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtunit.Text = bunifuCustomDataGrid2.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
