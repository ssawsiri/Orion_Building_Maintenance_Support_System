using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_Building_Maintenance_Support_System
{
    public partial class UserPasswordChange : Form
    {
        loginWindow login = new loginWindow();
        public UserPasswordChange()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.MessageBoxQuestion ask = new MessageBox.MessageBoxQuestion();             
            ask.Show();
            Hide();
           int i = ask.RetunValue();
           
            if (i == 1)
            {
                
                login.Show();
                Close();
            }

            else if(i == 2)
            {
                this.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            login.Show();
            Close();
            
        }

        private void UserPasswordChange_Load(object sender, EventArgs e)
        {

        }

        public void GetUserName(string username)
        {
            lblUsername.Text = username;

        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
