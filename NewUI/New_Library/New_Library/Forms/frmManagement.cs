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
        private Button currentButton;

        frmStaff staff = new frmStaff();
        frmAccount account = new frmAccount();

        public frmManagement()
        {
            InitializeComponent();

            btnAccount.BackColor = ThemeColor.SecondaryColor;
            btnStaff.BackColor = ThemeColor.SecondaryColor;
        }
            
        private void frmManagement_Load(object sender, EventArgs e)
        {
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
                    currentButton.BackColor = ThemeColor.ChangeColorBrightness(pnlManagementMenu.BackColor, +0.2);
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.BackColor = pnlManagementMenu.BackColor;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            GC.Collect();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            this.pnlManagementChildForm.Controls.Clear();

            if (btnSender.GetType() == typeof(Button))
            {
                ActiveButton(btnSender);
            }

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.pnlManagementChildForm.Controls.Add(childForm);
            this.pnlManagementChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(staff, sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(account, sender);
        }
    }
}
