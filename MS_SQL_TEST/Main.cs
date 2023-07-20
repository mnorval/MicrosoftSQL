using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace MS_SQL_TEST
{
    public partial class Main : Form
    {

        SqlConnection myConnection = new SqlConnection("user id=administrator;" +
                                       "password=admin;" +
                                       @"server=192.168.1.25\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=MIKE; " +
                                       "connection timeout=30");

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenSQL();
        }

        void OpenSQL()
        {
            try
            {
                myConnection.Open();
            }
            catch (Exception ae)
            {

                MessageBox.Show(ae.ToString());
            }
        }


        void CloseSQL()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception ae)
            {

                MessageBox.Show(ae.ToString());
            }
        }

    }
}
