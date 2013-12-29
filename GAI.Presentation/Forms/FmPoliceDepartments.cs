using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using GAI.BusinessLogic.DataModel;

namespace GAI.Presentation.Forms
{
    public partial class FmPoliceDepartments : Form
    {
        private readonly GAIEntities _src;

        public FmPoliceDepartments()
        {
            _src = new GAIEntities();
            InitializeComponent();
        }

        private void FmPoliceDepartments_Load(object sender, EventArgs e)
        {
            dgvPoliceDepartments.DataSource = _src.PoliceDepartments.Where(pd => !pd.Deleted.HasValue).ToList();
            dgvPoliceDepartments.DataSource = _src.PoliceDepartments.Local.ToBindingList();
            dgvPoliceDepartments.Columns[0].Visible = false;
            dgvPoliceDepartments.Columns[2].Visible = false;
            dgvPoliceDepartments.Columns[3].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPoliceDepartments.SelectedCells[0].RowIndex >= 0)
            {
                var selectedId = (int)dgvPoliceDepartments.Rows[dgvPoliceDepartments.SelectedCells[0].RowIndex].Cells[0].Value;
                var firm = _src.PoliceDepartments.FirstOrDefault(i => i.Id == selectedId);
                if (firm != null)
                {
                    firm.Deleted = true;
                }
                var index = dgvPoliceDepartments.SelectedCells[0].RowIndex;
                dgvPoliceDepartments.CurrentCell = null;
                dgvPoliceDepartments.Rows[index].Visible = false;
                _src.SaveChanges();
            }
            else
            {
                MessageBox.Show(@"Please select one row");
            }
        }

        private void FmPoliceDepartments_FormClosing(object sender, FormClosingEventArgs e)
        {
            _src.SaveChanges();
            _src.Dispose();
        }

        private void dgvPoliceDepartments_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _src.SaveChanges();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
