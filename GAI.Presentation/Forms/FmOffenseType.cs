using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GAI.BusinessLogic.DataModel;

namespace GAI.Presentation.Forms
{
    public partial class FmOffenseType : Form
    {
        private GAIEntities _src;

        public FmOffenseType()
        {
            _src = new GAIEntities();
            InitializeComponent();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOffenseType.SelectedCells[0].RowIndex >= 0)
            {
                var selectedId = (int)dgvOffenseType.Rows[dgvOffenseType.SelectedCells[0].RowIndex].Cells[0].Value;
                var firm = _src.Offense_Type.FirstOrDefault(i => i.Id == selectedId);
                if (firm != null)
                {
                    firm.Deleted = true;
                }
                var index = dgvOffenseType.SelectedCells[0].RowIndex;
                dgvOffenseType.CurrentCell = null;
                dgvOffenseType.Rows[index].Visible = false;
                _src.SaveChanges();
            }
            else
            {
                MessageBox.Show(@"Please select one row");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvOffenseType_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _src.SaveChanges();
        }

        private void FmOffenseType_Load(object sender, EventArgs e)
        {
            dgvOffenseType.DataSource = _src.Offense_Type.Where(pd => !pd.Deleted.HasValue).ToList();
            dgvOffenseType.DataSource = _src.Offense_Type.Local.ToBindingList();
            dgvOffenseType.Columns[0].Visible = false;
            dgvOffenseType.Columns[2].Visible = false;
            dgvOffenseType.Columns[3].Visible = false;
        }

        private void FmOffenseType_FormClosing(object sender, FormClosingEventArgs e)
        {
            _src.SaveChanges();
            _src.Dispose();
        }
    }
}
