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
            form.ShowDialog();
        }

        private void btnOwners_Click(object sender, EventArgs e)
        {
            var form = new FmOwners();
            form.ShowDialog();
        }

        private void btnOffense_Click(object sender, EventArgs e)
        {
            var form = new FmOffenseType();
            form.ShowDialog();
        }

        private void btnPoliceDepartments_Click(object sender, EventArgs e)
        {
            var form = new FmPoliceDepartments();
            form.ShowDialog();
        }

        private void btnFirms_Click(object sender, EventArgs e)
        {
            var form = new FmFirms();
            form.ShowDialog();
        }
    }
}
