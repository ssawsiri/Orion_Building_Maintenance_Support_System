using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Orion_Building_Maintenance_Support_System
{
    public partial class frmLoading : Form
    {
        Database_Connect obj = new Database_Connect();
        public frmLoading()
        {
            InitializeComponent();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            try
            {
               DataTable dt = obj.view_data("SELECT * FROM user");
                lblTest.Text = dt.Rows[0][0].ToString();

            }
            catch (Exception er)
            { }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
