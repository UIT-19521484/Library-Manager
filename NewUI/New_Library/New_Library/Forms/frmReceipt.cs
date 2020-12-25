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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            //LoadTheme();
        }

        //private void LoadTheme()
        //{
        //    foreach (Control btns in this.Controls)
        //    {
        //        if (btns.GetType() == typeof(Button))
        //        {
        //            Button btn = (Button)btns;
        //            btn.BackColor = ThemeColor.PrimaryColor;
        //            btn.ForeColor = Color.White;
        //            btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        //        }
        //    }

        //}
        void LoadData_Receipt()
        {
            dgvReceipt.DataSource = DatabaseData.dtReader;
        }

        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvReceipt.SelectedRows.Count)
            {
                case 0:
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    break;
                default:
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
            }
        }

        private void dgvReceipt_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvReceipt.ClearSelection();
            this.BeginInvoke(new Action(() => { btnDelete.Enabled = false; btnUpdate.Enabled = false; }));
        }


    }
}
