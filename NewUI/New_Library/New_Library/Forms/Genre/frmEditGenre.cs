using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms.Genre
{
    public partial class frmEditGenre : Form
    {
        int GenreID;
        public frmEditGenre(LibraryEntity.Genre genre)
        {
            InitializeComponent();

            GenreID = genre.MaTL;
            txtGenreName.Text = genre.TenTL;
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtGenreName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtGenreName_Validated(object sender, EventArgs e)
        {

        }
    }
}
