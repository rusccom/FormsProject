using FormsProject.Forms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsProject.Controls;
using System.Globalization;
using FormsProject.TableDataHandler;

namespace FormsProject.Forms.Directory
{
    public partial class FormTmcView : DocumentsView
    {
        public FormTmcView()
        {
            InitializeComponent();

            tvResult.TmcList.AfterCreateTableEvent += TmcList_AfterCreateTableEvent;
        }

        protected override void OnShown(EventArgs e)
        {
            tvResult.FillData(OperationCode);
            InitBaseFunction(tvResult.TmcList);
            base.OnShown(e);
            HideColumns();

            AddRateAndPercentToToolStrip();
        }

        private void TmcList_AfterCreateTableEvent()
        {
            AddRateAndPercentColumns();
        }

        private void AddRateAndPercentColumns()
        {
            RateAndPercentColumns.AddRateAndPercentColumnToTable(tvResult.TmcList);
        }

        private void AddRateAndPercentToToolStrip()
        {
            ///Add checkbox
            CheckBox checkBox = new CheckBox();
            checkBox.Name = "cbEnableRate";
            checkBox.Text = "Включить Курс: ";
            checkBox.Checked = false;
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            checkBox.BackColor = Color.Transparent;
            ToolStripControlHost toolStripControlHost = new ToolStripControlHost(checkBox);
            UserToolStrip.Items.Add(toolStripControlHost);

            ///Add TextBox
            DataTextBox dataTextBox = new DataTextBox();
            dataTextBox.Width = 50;
            dataTextBox.FieldType = Operations.FieldDataType.DECIMAL;
            dataTextBox.Name = "dtbRete";
            dataTextBox.KeyUp += DataTextBox_KeyUp;
            ToolStripControlHost toolStripControlHostRate = new ToolStripControlHost(dataTextBox);
            toolStripControlHostRate.Name = "toolStripControlHostRate";
            toolStripControlHostRate.Visible = false;
            toolStripControlHostRate.AutoSize = false;
            UserToolStrip.Items.Add(toolStripControlHostRate);
        }

        private void DataTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    string strValue = ((DataTextBox)sender).Text;
                    decimal value = 0;
                    if (decimal.TryParse(strValue, out value))
                    {
                        RateAndPercentColumns.CalculateRateAndPercentColumns(tvResult.TmcList, value, OperationCode);
                        //CalculateUserColumns(value);
                    }
                    break;
            }
        }

        //private void CalculateUserColumns(decimal value)
        //{
        //    foreach(DataRow row in tvResult.TmcList.GetDataTable.Rows)
        //    {
        //        decimal price1 = Convert.ToDecimal(row["price1"]);
        //        decimal price3 = Convert.ToDecimal(row["price3"]);

        //        decimal price = price1 >= price3 ? price1 : price3;

        //        decimal convertedPrice = price * value;
        //        row["columnPriceToRate"] = convertedPrice.ToString("0.000", CultureInfo.InvariantCulture); ;
                
        //        decimal convertedPricePercent = convertedPrice / 1.2m;
        //        row["columnPricePercent"] = convertedPricePercent.ToString("0.000", CultureInfo.InvariantCulture);
        //    }
        //}

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isShown = ((CheckBox)sender).Checked;
            RateAndPercentColumns.ShowRateAndPercentColumn(tvResult.TmcList, isShown);
            //tvResult.ShowUserColumns(isShown);

            ((ToolStripControlHost)UserToolStrip.Items["toolStripControlHostRate"]).Visible = isShown;
        }

        public override void OpenFilledForm(TableView table = null)
        {
            base.OpenFilledForm(tvResult.TmcList);
        }

        public override void RefreshTable()
        {
            tvResult.RefreshTable();
            base.RefreshTable();
        }

        //public override void SetFilter(string query = "")
        //{
        //    //if(tvResult.TmcGroup.SelectedNode != null)
        //    //{
        //    //    query += " and GroupId = '" + tvResult.TmcGroup.SelectedNode.Text + "'";
        //    //}
        //    //base.SetFilter(query);
        //}

        private void HideColumns()
        {
           
        }
    }
}
