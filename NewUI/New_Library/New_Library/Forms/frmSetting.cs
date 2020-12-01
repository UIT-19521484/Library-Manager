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
    public partial class frmSetting : Form
    {
        Form activeForm;
        Button currentButton;

        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            this.pnlSettingChildForm.BackColor = Color.White;
            this.pnlSettingMenu.BackColor = ThemeColor.SecondaryColor;
            this.btnInfoLibrary.PerformClick();
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
            foreach (Control previousBtn in pnlSettingMenu.Controls)
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
            this.pnlSettingChildForm.Controls.Add(childForm);
            this.pnlSettingChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnInfoLibrary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Setting.frmInfoLibrary(), sender);
        }
    }
}
