using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using GAI.BusinessLogic.DataModel;

namespace GAI.Presentation.Forms
{
    public partial class FmFirms : Form
    {
        private readonly GAIEntities _src;

        public FmFirms()
        {
            _src = new GAIEntities();
            InitializeComponent();
        }

        private void FmFirms_Load(object sender, EventArgs e)
        {
            dgvFirms.DataSource = _src.Firms.Where(frm => !frm.Deleted.HasValue).ToList();
            dgvFirms.DataSource = _src.Firms.Local.ToBindingList();
            dgvFirms.Columns[0].Visible = false;
            dgvFirms.Columns[8].Visible = false;
            dgvFirms.Columns[9].Visible = false;
            dgvFirms.Columns[10].Visible = false;
            
        }

        private void dgvFirms_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _src.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFirms.SelectedCells[0].RowIndex >= 0)
            {
                var selectedId = (int) dgvFirms.Rows[dgvFirms.SelectedCells[0].RowIndex].Cells[0].Value;
                var firm = _src.Firms.FirstOrDefault(i => i.Id == selectedId);
                if (firm != null)
                {
                    firm.Deleted = true;
                }
                var index = dgvFirms.SelectedCells[0].RowIndex;
                dgvFirms.CurrentCell = null;
                dgvFirms.Rows[index].Visible = false;
                _src.SaveChanges();
            }
            else
            {
                MessageBox.Show(@"Please select one row");
            }
        }

        private void FmFirms_FormClosing(object sender, FormClosingEventArgs e)
        {
            _src.SaveChanges();
            _src.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
