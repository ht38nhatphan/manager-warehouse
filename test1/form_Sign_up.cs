using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class form_Sign_up : Form
    {
        public form_Sign_up()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            messagebox.Information("Are you sure you escaped ?"); 
            Application.ExitThread();
        }
     
        private void form_Sign_up_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }

       
    }
}
