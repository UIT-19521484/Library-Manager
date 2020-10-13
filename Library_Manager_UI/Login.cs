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
    public partial class Login_Menu : Form
    {
        public Login_Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chuyển form bằng khối lệnh bên dưới.
                this.Hide();
                Main obj1 = new Main();
                obj1.ShowDialog();
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Reset_Password obj1 = new Reset_Password();
            obj1.ShowDialog();
            this.Close();
        }

        private void Login_Menu_Load(object sender, EventArgs e)
        {

        }

        private void Login_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult box = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (box == DialogResult.Yes)
                Application.Exit();
            else if (box == DialogResult.No)
                e.Cancel = true;
        }

        private void Username_Text_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
