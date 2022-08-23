using FormsProject.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Reports
{
    public class CustomerAddSetting
    {
        TableView _table;

        public void Init(TableView table)
        {
            _table = table;

            _table.CellMouseClick += Table_CellMouseClick;
            CreateContextMenu();
        }

        private void Table_CellMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        _table.ClearSelection();
                        _table.Rows[e.RowIndex].Selected = true;
                        _table.ContextMenu.Show(_table, _table.PointToClient(Cursor.Position));
                        break;
                }
            }
        }

        private void CreateContextMenu()
        {
            ContextMenu contexMenu = new ContextMenu();
            MenuItem menuItemMoneyMove = new MenuItem("Движение по клиенту");
            menuItemMoneyMove.Click += MenuItemMoneyMove_Click;

            MenuItem menuItemNonCashInfo = new MenuItem("Безнальные долги");
            menuItemNonCashInfo.Click += MenuItemNonCashInfo_Click;

            contexMenu.MenuItems.Add(menuItemMoneyMove);
            contexMenu.MenuItems.Add(menuItemNonCashInfo);

            _table.ContextMenu = contexMenu;
        }

        private void MenuItemMoneyMove_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt16(_table.SelectedRows[0].Cells["id"].Value);
            BaseForm form = FormManager.OpenForm(Operations.OperationCode.ReportCustomerInfo, value);
            if (form != null)
                form.Text = "Движение по клиенту - "+ _table.SelectedRows[0].Cells["name"].Value.ToString();
        }

        private void MenuItemNonCashInfo_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt16(_table.SelectedRows[0].Cells["id"].Value);
            BaseForm form = FormManager.OpenForm(Operations.OperationCode.ReportCustomerNonCashInfo, value);
            if (form != null)
                form.Text = "Безнальные долги - "+ _table.SelectedRows[0].Cells["name"].Value.ToString();
        }
    }
}
