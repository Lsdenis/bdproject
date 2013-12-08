using System;
using System.Windows.Forms;
using GAI.BusinessLogic.DataModel;
using GAI.BusinessLogic.Services;

namespace GAI.Presentation.Forms
{
    public partial class FmTransport : Form
    {
        private Transport _transport;
        private readonly TransportService _transportService;
        private readonly PoliceDepartmentsService _policeDepartmentsService;

        public FmTransport(Transport transport)
        {
            _policeDepartmentsService = new PoliceDepartmentsService();
            _transportService = new TransportService();
            _transport = transport;
            InitializeComponent();
            cbPoliceDepartment.Items.AddRange(_policeDepartmentsService.GetPoliceDepartments().ToArray());
            if (transport.License_Plates == null)
            {
                return;
            }
            textBrandModel.Text = transport.Brand_Model;
            textCarcass.Text = transport.Carcass.ToString();
            textLicensePlates.Text = transport.License_Plates;
            textMaxWeight.Text = transport.Max_Weight.ToString();
            textType.Text = transport.Type;
            textColor.Text = transport.Color;

            cbPoliceDepartment.SelectedIndex = cbPoliceDepartment.FindStringExact(transport.PoliceDepartment.Name);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textLicensePlates.Text))
            {
                MessageBox.Show(@"License plates should not be null");
                return;
            }

            int value;
            _transport.License_Plates = textLicensePlates.Text;
            _transport.Brand_Model = textBrandModel.Text;
            int.TryParse(textCarcass.Text, out value);
            _transport.Carcass = value;
            _transport.Color = textColor.Text;
            _transport.Creation_Date = DateTime.Today.Date;
            var pd = (PoliceDepartment) cbPoliceDepartment.SelectedItem;
            _transport.Id_Police_Department = pd.Id;
            _transport.Notes = rtextNotes.Text;
            _transport.Type = textType.Text;
            int.TryParse(textMaxWeight.Text, out value);
            _transport.Max_Weight = value;

            Close();
        }
    }
}
