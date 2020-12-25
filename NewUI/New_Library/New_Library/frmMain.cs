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

namespace New_Library
{
    public partial class frmMain : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        private string username;
        private string password;
        private string role;

        Forms.frmDashboard dashboard = new Forms.frmDashboard();
        Forms.frmBook book = new Forms.frmBook();
        Forms.frmGenre genre = new Forms.frmGenre();
        Forms.frmReader reader = new Forms.frmReader();
        Forms.frmReceipt receipt = new Forms.frmReceipt();
        Forms.frmManagement management = new Forms.frmManagement();
        Forms.frmSetting setting = new Forms.frmSetting();
        Forms.frmHelp help = new Forms.frmHelp();

        //Constructor
        public frmMain(string username, string password, string role)
        {
            InitializeComponent();         
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            this.username = username;
            this.password = password;
            this.role = role;

            this.ResizeBegin += (s, e) => { this.SuspendLayout(); };
            this.ResizeEnd += (s, e) => { this.ResumeLayout(true); };
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (this.role == "Member")
            {
                this.btnManagement.Visible = false;
            }

            lblLogo_Click(lblLogo, new EventArgs());

            DatabaseListener.SetupSqlTableDependency();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitleBar.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }    
            }    
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(51, 51, 76);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            GC.Collect();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            this.pnlChildForm.Controls.Clear();

            if (btnSender.GetType() == typeof(Button))
            {
                ActiveButton(btnSender);
            }

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnTitle.Text = childForm.Text;
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            OpenChildForm(dashboard, sender);
            Reset();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(book, sender);
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            OpenChildForm(genre, sender);
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            OpenChildForm(reader, sender);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(receipt, sender);
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(management, sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(setting, sender);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(help, sender);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            GC.Collect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Reset()
        {
            DisableButton();
            btnTitle.Text = "QUẢN LÝ THƯ VIỆN";
            pnlTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseListener.Dispose();
        }
    }
}
