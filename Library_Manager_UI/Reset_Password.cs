using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class Reset_Password : Form
    {
        public Reset_Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Menu obj1 = new Login_Menu();
            obj1.ShowDialog();
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Menu obj1 = new Login_Menu();
            obj1.ShowDialog();
            this.Close();
        }
    }
}
