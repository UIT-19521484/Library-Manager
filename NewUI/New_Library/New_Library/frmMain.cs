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
        private Form activeForm;

        private string username;
        private string password;
        private string role;

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
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (this.role == "Member")
            {
                this.btnManagement.Visible = false;
            }   
            
            this.lblNoTotalReader.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_readers").ToString();
            this.lblNoBorrowingReader.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_borrowing_readers").ToString();
            this.lblNoOverdueReader.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_overdue_readers").ToString();
            this.lblNoTotalBook.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_books").ToString();
            this.lblNoTotalGenres.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_genres").ToString();
            this.lblNoTotalAvailableCopies.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_available_books").ToString();
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
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }    
            }    
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            //this.pnlChildForm.Controls.Clear();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btnTitle.Text = childForm.Text;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmBook(), sender);
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmGenre(), sender);
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmReader(), sender);
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmReceipt(), sender);
        }
        private void btnManagement_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new Forms.frmManagement(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmSetting(), sender);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frmHelp(), sender);
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            btnTitle.Text = "QUẢN LÝ THƯ VIỆN";
            pnlTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
        }

        private void btnSignout_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnSignout.BackColor = Color.Red; 
        }

        private void btnSignout_MouseLeave(object sender, EventArgs e)
        {
            this.btnSignout.BackColor = Color.FromArgb(51, 51, 76);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtLibraryName.ReadOnly = !txtLibraryName.ReadOnly;
            txtAddressName.ReadOnly = !txtAddressName.ReadOnly;
            txtPhoneName.ReadOnly = !txtPhoneName.ReadOnly;
            txtEmailName.ReadOnly = !txtEmailName.ReadOnly;
        }
    }
}
