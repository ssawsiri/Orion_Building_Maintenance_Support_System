using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Orion_Building_Maintenance_Support_System
{

    class Database_Connect
    {
        MySqlConnection con;
        MySqlCommand cmd;
        DataTable dt = new DataTable ();
        MySqlDataAdapter da;
        MySqlDataReader ds;

        public Database_Connect()
        {
            con = new MySqlConnection(@"DataSource=203.189.72.82;port=3306;username=root;password=;database=orionbss;");
        }

        public int save_update_delete(string query)
        {

            con.Open();
            cmd = new MySqlCommand(query, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

            return i;

        }

        public DataTable view_data(string query)
        {
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            da.Fill(dt);
            //da.Fill(ds);

            return dt;

            
        }

       


    }
}
