using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmManagement : Form
    {
        private Form activeForm;
        private Button currentButton;
        public frmManagement()
        {
            InitializeComponent();
        }
            
        private void frmManagement_Load(object sender, EventArgs e)
        {
            this.pnlManagementCihildForm.BackColor = Color.White;
            this.pnlManagementMenu.BackColor = ThemeColor.SecondaryColor;
            this.btnStaff.PerformClick();
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, +0.2);
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlManagementMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ThemeColor.SecondaryColor;
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlManagementCihildForm.Controls.Add(childForm);
            this.pnlManagementCihildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStaff(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccount(), sender);
        }
    }
}
