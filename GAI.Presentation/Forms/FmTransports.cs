using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GAI.BusinessLogic.DataModel;
using GAI.BusinessLogic.Services;

namespace GAI.Presentation.Forms
{
    public partial class FmTransports : Form
    {
        private Dictionary<string, Transport> _dictionaryOfTransports;
        private readonly TransportService _transportService;
        Exception _exception;

        public FmTransports()
        {
            _transportService = new TransportService();
            _dictionaryOfTransports = _transportService.GetTransports();
            InitializeComponent();

            foreach (var transport in _dictionaryOfTransports)
            {
                AddItem(transport.Value);
            }

            cbSearch.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvTransports.Items.Clear();
            foreach (var transport in _dictionaryOfTransports)
            {
                var property = transport.Value.GetType().GetProperty(cbSearch.SelectedItem.ToString());
                if ((property.GetValue(transport.Value) == null) ||
                    (!property.GetValue(transport.Value).ToString().Contains(textSearch.Text)))
                {
                    continue;
                }
                AddItem(transport.Value);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddItem(Transport transport)
        {
            var item = new ListViewItem("")
            {
                SubItems =
                    {
                        transport.License_Plates,
                        transport.Brand_Model,
                        transport.Color,
                        transport.Carcass.ToString(),
                        transport.Type,
                        transport.Max_Weight.ToString(),
                        transport.Notes
                    }
            };
            lvTransports.Items.Add(item);
        }

        private void lvTransports_DoubleClick(object sender, EventArgs e)
        {
            var currentTransport = _dictionaryOfTransports[lvTransports.SelectedItems[0].SubItems[1].Text];
            _dictionaryOfTransports.Remove(currentTransport.License_Plates);
            var form = new FmTransport(currentTransport);
            form.ShowDialog();
            lvTransports.Items.Remove(lvTransports.SelectedItems[0]);
            _dictionaryOfTransports.Add(currentTransport.License_Plates, currentTransport);
            AddItem(currentTransport);
            _transportService.SaveOrUpdateTransport(currentTransport, out _exception);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newTransport = new Transport();
            var form = new FmTransport(newTransport);
            form.ShowDialog();

            _transportService.SaveOrUpdateTransport(newTransport, out _exception);
            if ((_exception != null)
                || (_dictionaryOfTransports.ContainsKey(newTransport.License_Plates)))
            {
                return;
            }
            _dictionaryOfTransports.Add(newTransport.License_Plates, newTransport);
            AddItem(newTransport);
        }
    }
}
