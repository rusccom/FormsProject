using FormsProject.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms
{
    static public class TableSetting
    {
       static public void SetDocumentProductItemProperty(TableView table)
        {
            table.EditingControlShowing += DataGridView_EditingControlShowing;
            table.ReadOnly = false;
            table.Columns["id"].Visible = false;

            //TMCID Display propery in Product Item Document
            table.Columns["TmcId"].Visible = true;
            table.Columns["TmcId"].ReadOnly = true;
            table.Columns["TmcId"].DisplayIndex = 1;

            table.Columns["DocumentId"].Visible = false;
            table.Columns["LoginId"].Visible = false;
            table.Columns["CreateDate"].Visible = false;

            
            table.Columns["price"].ValueType = typeof(Decimal);

            table.Columns["quantity"].ValueType = typeof(Decimal);

            table.Columns["TmcName"].ReadOnly = true;
            table.Columns["UnitId"].ReadOnly = true;
            table.Columns["suma"].ReadOnly = true;

            table.AllowUserToDeleteRows = false;
        }

        //static public void AddPropertToDataGridView(DataGridView dataGridView)
        //{
        //    dataGridView.EditingControlShowing += DataGridView_EditingControlShowing;
        //}

        private static void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += Control_KeyPress;
        }

        private static void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = e.KeyChar == ',' ? '.' : e.KeyChar;
        }

        static public void SetColumnType(TableView table)
        {
            //foreach()
        }

        static public void SetColumnName(TableView table)
        {
            foreach(DataGridViewColumn column in table.Columns)
            {
                switch(column.Name)
                {
                    case "name":
                        column.HeaderText = "Название";
                        column.Width = 400;
                        break;
                    case "address":
                        column.HeaderText = "Адресс";
                        column.Width = 150;
                        break;
                    case "info":
                        column.HeaderText = "Доп. информация";
                        column.Width = 200;
                        break;
                    case "LoginId":
                        column.HeaderText = "Автор";
                        column.Width = 80;
                        break;
                    case "CreateDate":
                        column.HeaderText = "Дата создания";
                        column.Width = 150;
                        break;
                    case "Done":
                        column.HeaderText = "Проведено";
                        column.Width = 40;
                        break;
                    case "CustomerId":
                        column.HeaderText = "Контрагент";
                        column.Width = 200;
                        break;
                    case "suma":
                        column.HeaderText = "Сумма";
                        column.Width = 70;
                        break;
                    case "DocumentDate":
                        column.HeaderText = "Дата документа";
                        column.Width = 150;
                        break;
                    case "note":
                        column.HeaderText = "Информация";
                        column.Width = 200;
                        break;
                    case "TmcId":
                        column.HeaderText = "Артикул";
                        column.Width = 60;
                        break;
                    case "price":
                        column.HeaderText = "Цена";
                        column.Width = 70;
                        break;
                    case "quantity":
                        column.HeaderText = "Количество";
                        column.Width = 70;
                        break;
                    case "Cashless":
                        column.HeaderText = "Деньги";
                        column.Width = 40;
                        break;
                    case "UnitId":
                        column.HeaderText = "Ед.Изм.";
                        column.Width = 50;
                        break;
                    case "GroupId":
                        column.HeaderText = "Группа";
                        column.Width = 150;
                        break;
                    case "price1":
                        column.HeaderText = "Цена1";
                        column.Width = 70;
                        break;
                    case "price2":
                        column.HeaderText = "Цена2";
                        column.Width = 70;
                        break;
                    case "price3":
                        column.HeaderText = "Цена3";
                        column.Width = 70;
                        break;
                    case "MinQuantity":
                        column.HeaderText = "Мин. запас";
                        column.Width = 50;
                        break;
                    case "Description":
                        column.HeaderText = "Расшифровка";
                        column.Width = 200;
                        break;
                    case "TmcName":
                        column.HeaderText = "Название";
                        column.Width = 400;
                        break;
                    case "Debts":
                        column.HeaderText = "Долг";
                        column.Width = 100;
                        break;
                    case "NonCashInDebt":
                        column.HeaderText = "Безнал ОН";
                        column.Width = 100;
                        break;
                    case "NonCashOutDebt":
                        column.HeaderText = "Безнал МЫ";
                        column.Width = 100;
                        break;
                    case "code":
                        column.HeaderText = "Номер документа";
                        column.Width = 150;
                        break;
                    case "DocName":
                        column.HeaderText = "Название документа";
                        column.Width = 150;
                        break;
                    case "PriceTypeId":
                        column.HeaderText = "Цена клиента";
                        column.Width = 85;
                        break;
                    case "NonCash":
                        column.HeaderText = "Безнал";
                        column.Width = 50;
                        break;
                    case "InPrice":
                        column.HeaderText = "С/C единицы";
                        column.Width = 50;
                        break;
                    case "InSum":
                        column.HeaderText = "Сум. закупки";
                        column.Width = 50;
                        break;
                    case "Income":
                        column.HeaderText = "Валовая";
                        column.Width = 50;
                        break;
                    case "AddPricePercent":
                        column.HeaderText = "Маржа";
                        column.Width = 50;
                        break;
                    case "SumOutQuantity":
                        column.HeaderText = "Продано";
                        column.Width = 80;
                        break;
                }
            }
        }
    }
}
