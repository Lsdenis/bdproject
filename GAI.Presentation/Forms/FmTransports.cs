using System;
using System.Collections.Generic;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
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

        private void button1_Click(object sender, EventArgs e)
        {
                object oMissing = Missing.Value;
                var app = new Word.Application();     // приложение ворда

                var doc = app.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                //Word.Paragraph currentPartition = app.ActiveDocument.Paragraphs.Add();
                //currentPartition.Range.Text = valuesOfPartition.Text;
                try
                {                                        
                    var tableLocation = doc.Range(0, 0);

                    tableLocation.InsertBefore("Report of current transports.");
                    tableLocation.Font.Name = "Times New Roman";
                    tableLocation.Font.Size = 14;                    
                    tableLocation.InsertParagraphAfter();
                    tableLocation.SetRange(tableLocation.End, tableLocation.End);
                    tableLocation.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    app.ActiveDocument.Tables.Add(tableLocation, _dictionaryOfTransports.Count + 1, 5);
                    var circleTable = app.ActiveDocument.Tables[1];
                    circleTable.Cell(1, 1).Range.Text = "License_Plates";
                    circleTable.Cell(1, 2).Range.Text = "PoliceDepartment";
                    circleTable.Cell(1, 3).Range.Text = "Brand_Model";
                    circleTable.Cell(1, 4).Range.Text = "Carcass";
                    circleTable.Cell(1, 5).Range.Text = "Max_Weight";
                                        
                    object styleName = "Изысканная таблица";
                    circleTable.set_Style(ref styleName);

//                    for (int i = 0; i < clubSportsmenList.Count; i++)
                    {
//                        circleTable.Cell(1, i + 2).Range.Text = sportsmenList[i];
//                        circleTable.Cell(i + 2, 1).Range.Text = sportsmenList[i];
//                        circleTable.Cell(i + 2, i + 2).Range.Text = "-----------------"; // заполнение
                    }

                    var count = 2;
                    foreach (var transport in _dictionaryOfTransports.Values)
                    {
                        circleTable.Cell(count, 1).Range.Text = transport.License_Plates;
                        circleTable.Cell(count, 2).Range.Text = transport.PoliceDepartment.Name;
                        circleTable.Cell(count, 3).Range.Text = transport.Brand_Model;
                        circleTable.Cell(count, 4).Range.Text = transport.Carcass.ToString();
                        circleTable.Cell(count, 5).Range.Text = transport.Max_Weight.ToString();
                        count++;
                    }

                    app.Visible = true;
                    doc.SaveAs2(@"" + Environment.CurrentDirectory + "\\currentReport.doc");   //для сохранения файла
                }
                catch
                {
                    app.Quit();
                }
        }
    }
}
