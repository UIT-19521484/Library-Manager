using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        bool isMenuHiddenn;
        frmBook book = new frmBook();
        public frmMain()
        {
            InitializeComponent();

            isMenuHiddenn = false;
            typeof(Guna.UI2.WinForms.Guna2Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty
            | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null,
            pnlMenu, new object[] { true });
            btnInfo_Click(this, new EventArgs());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrSideMenuAnimation.Start();
        }

        private void tmrSideMenuAnimation_Tick(object sender, EventArgs e)
        {
            if (isMenuHiddenn)
            {
                pnlMenu.Width += 10;
                if (pnlMenu.Width >= pnlMenu.MaximumSize.Width)
                {
                    tmrSideMenuAnimation.Stop();
                    isMenuHiddenn = false;
                    pnlMenu.Refresh();
                }
                this.btnMenu.Image = Properties.Resources.icons8_back_64px;
            }
            else
            {
                pnlMenu.Width -= 10;
                if (pnlMenu.Width <= pnlMenu.MinimumSize.Width)
                {
                    tmrSideMenuAnimation.Stop();
                    isMenuHiddenn = true;
                    pnlMenu.Refresh();
                }
                this.btnMenu.Image = Properties.Resources.icons8_menu_64px;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (pnlChildForm.HasChildren)
            {
                pnlChildForm.Controls.Clear();
            }
            frmDashboard dashboard = new frmDashboard();
            dashboard.TopLevel = false;
            dashboard.AutoSize = false;
            pnlChildForm.Controls.Add(dashboard);
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();   
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (pnlChildForm.HasChildren)
            {
                pnlChildForm.Controls.Clear();
            }
            book.TopLevel = false;
            book.AutoSize = false;
            pnlChildForm.Controls.Add(book);
            book.Dock = DockStyle.Fill;
            book.Show();
        }
    }
}
