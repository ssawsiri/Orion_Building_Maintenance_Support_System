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
using Forms;

namespace Orion_Building_Maintenance_Support_System
{
    public partial class AdminMainWindow : Form
    {
        private Form activeForm;

       
        public AdminMainWindow()
        {
            InitializeComponent();
            this.Text = string.Empty;
                      

        }

        public void GetUserName(string username)
        {
            lblUsername.Text = username;

        }

        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.userForm(), sender);
        }

        private void btnTechnicalDrawings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TechnicalDrwaingsForm(), sender);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void btnPPM_Click(object sender, EventArgs e)
        {

        }

        private void btnMainPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnSvcAgreement_Click(object sender, EventArgs e)
        {

        }

        private void btnFoodCourtSales_Click(object sender, EventArgs e)
        {

        }

        private void AdminMainWindow_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.userForm(), sender);
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //btnlLogOut
        {
            this.Close();
            loginWindow log = new loginWindow();
            log.Show();

        }

        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            UserPasswordChange password = new UserPasswordChange();
            password.Show();
            Close();
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
