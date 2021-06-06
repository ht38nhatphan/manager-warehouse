using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    class dataservices
    {
        public dataservices()
        {

        }
        private static SqlConnection mySqlConnection;
        private SqlDataAdapter myDataAdapter;
        public bool OpenDB(string myComputer, string myDB, string uid, string psw)
        {
            string conStr = "server = " + myComputer + "; database = " + myDB + "; uid = '" + uid + "'; pwd = '" + psw + "'";
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
                mySqlConnection = null;
                return false;
            }
            return true;
        }
        //------------------------------------------------------------
        public DataTable RunQuery(string QueryString)
        {
            DataTable myDataTable = new DataTable();
            myDataAdapter = new SqlDataAdapter();
            try
            {
                myDataAdapter = new SqlDataAdapter(QueryString, mySqlConnection);
                SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
                myDataAdapter.Fill(myDataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
                return null;
            }
            return myDataTable;
        }
        //------------------------------------------------------------
        public void Update(DataTable myDataTable)
        {
            try
            {
                myDataAdapter.Update(myDataTable);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
            }
        }
        //------------------------------------------------------------
        public void ExecuteNonQuery(string cmdString)
        {
            SqlCommand mySqlCommand = new SqlCommand(cmdString, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString());
            }
        }



    }
}
