using System;
using System.Windows.Forms;

namespace GAI.Presentation.Forms
{
    public partial class FmMainMenu : Form
    {
        public FmMainMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTransports_Click(object sender, EventArgs e)
        {
            var form = new FmTransports();
            form.Show();
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            var form = new FmOwners();
            form.Show();
        }

        private void btnOffense_Click(object sender, EventArgs e)
        {
            var form = new FmOffense();
            form.Show();
        }

        private void btnPoliceDepartments_Click(object sender, EventArgs e)
        {
            var form = new FmPoliceDepartments();
            form.Show();
        }

        private void btnFirms_Click(object sender, EventArgs e)
        {
            var form = new FmFirms();
            form.Show();
        }
    }
}
