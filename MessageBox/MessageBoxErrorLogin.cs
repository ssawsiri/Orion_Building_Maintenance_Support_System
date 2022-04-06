using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class MessageBoxErrorLogin : Form
    {
        public MessageBoxErrorLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendingMessage();
            this.Close();
        }

        public int SendingMessage()
        {
            int i = 1;
            return i;
        }

        private void MessageBoxErrorLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
