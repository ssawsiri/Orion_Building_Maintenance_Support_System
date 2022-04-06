using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBox;
using System.Net;

namespace Orion_Building_Maintenance_Support_System
{
    public partial class frmLoading : Form
    {
        
        loginWindow loginWindow = new loginWindow();

        public frmLoading()
        {
            InitializeComponent();
                       

        }

       

        private void frmLoading_Load(object sender, EventArgs e)
        {
            bool capture = IsConnectedToInternet();

            if (capture == false)
            {
                frmNoInternet obj = new frmNoInternet();

                obj.Show();
                
            }
            else
            {
                lblInternet.Text = "Your Computer is Connected to Internet";
                
                Loading();

            }

        }

        public static bool IsConnectedToInternet()
        {
            
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loading()
        {
            timer1.Start();
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            

            timer1.Stop();
            loginWindow.Show();
            Hide();
            


        }
    }
}
