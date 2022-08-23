using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Controls
{
    public class DataComboBox: ComboBox, IUserControl
    {
        private bool modified;
        private string tableName;
        private string fieldName;
        private bool readOnlyControl;
        private DataTable dataTable;

        public DataTable SourceDataTable
        {
            get { return dataTable; }
        }

        public bool ReadOnlyControl
        {
            get { return readOnlyControl; }
        }

        public DataComboBox()
        {
            this.SelectedValueChanged += DataComboBox_SelectedValueChanged;
        }

        private void DataComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            modified = true;
        }

        public bool Modified
        {
            get { return modified; }
            set { modified = value; }
        }

        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }

        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public void FillComboBox(bool readOnly = false)
        {
            readOnlyControl = readOnly;

            if (TableName != null)
            {
                dataTable = SqlAdapter.SqlQueryAdapter.GetTable(TableName, "order by [name] ASC").Tables[0];
                this.DataSource = dataTable;
                this.ValueMember = "id";
                this.DisplayMember = "name";
                this.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        //protected override void OnCreateControl()
        //{
        //    base.OnCreateControl();
        //    FillComboBox();
        //    this.DropDownStyle = ComboBoxStyle.DropDownList;
        //}
    }
}
