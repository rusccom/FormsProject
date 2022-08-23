using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Directory
{
    public partial class FormTmcGroup : FormDirectoryBase
    {
        public FormTmcGroup()
        {
            InitializeComponent();
            dcbGroupId.FillComboBox();
            AddDefaultIdToComboBox();
        }

        private void AddDefaultIdToComboBox()
        {
            DataTable table = (DataTable)dcbGroupId.DataSource;
            DataRow row = table.NewRow();
            row["id"] = 0;
            row["name"] = "//";
            row["GroupId"] = 0;
            row["LoginId"] = 1;
            row["CreateDate"] = DateTime.Now;
            table.Rows.InsertAt(row,0);
            dcbGroupId.SelectedIndex = 0;
        }
    }
}
