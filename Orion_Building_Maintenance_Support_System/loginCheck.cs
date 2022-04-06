using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using MessageBox;

namespace Orion_Building_Maintenance_Support_System
{
    class loginCheck
    {
        Database_Connect obj = new Database_Connect();
        AdminMainWindow adminWindow = new AdminMainWindow();
        MessageBoxErrorLogin errorLogin = new MessageBoxErrorLogin();
        loginWindow loginWindow = new loginWindow();
        UserPasswordChange changePassword = new UserPasswordChange();



        public void LoginCheck(string username, string password)
        {
            
            try
            {
                DataTable dtAdmin = obj.view_data("SELECT COUNT(*) FROM user WHERE UserName='" + @username + "' AND UserPassword='" + @password + "' AND UserType='Admin'");
                DataTable dtTechnicalOfficer = obj.view_data("SELECT COUNT(*) FROM user WHERE UserName='" + @username + "' AND UserPassword='" + @password + "' AND UserType='TO'");
                DataTable dtMEP = obj.view_data("SELECT COUNT(*) FROM user WHERE UserName='" + @username + "' AND UserPassword='" + @password + "' AND UserType='MEP'");
                DataTable dtFM = obj.view_data("SELECT COUNT(*) FROM user WHERE UserName='" + @username + "' AND UserPassword='" + @password + "' AND UserType='FM'");
                DataTable dtGM = obj.view_data("SELECT COUNT(*) FROM user WHERE UserName='" + @username + "' AND UserPassword='" + @password + "' AND UserType='GM'");


                if (dtAdmin.Rows[0][0].ToString() == "1")
                {

                    adminWindow.Show();
                    SendUserName(username);

                }
                else if (dtTechnicalOfficer.Rows[0][0].ToString() == "1")
                {

                    //supervisor_window supwin = new supervisor_window();
                    //supwin.Show();
                }
                else if (dtMEP.Rows[0][0].ToString() == "1")
                {

                    //dispenser_window diswin = new dispenser_window();
                    // diswin.Show();
                }
                else
                {
                    
                    
                    errorLogin.Show();
                    int i = errorLogin.SendingMessage();

                    if (i == 1)
                        loginWindow.Show();

                }
            }
            catch(Exception ex)
            {
                errorLogin.Show();
                int i = errorLogin.SendingMessage();

                if (i == 1)
                    loginWindow.Show();
            }
            

        }

        public void SendUserName(string username)
        {
            adminWindow.GetUserName(username);
            changePassword.GetUserName(username);
        }
    }
}
