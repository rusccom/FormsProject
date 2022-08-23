using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsProject.Operations;
using FormsProject.Forms.Directory;
using FormsProject.Forms.Documents;
using System.Drawing;
using FormsProject.Forms.Reports;
using FormsProject.Forms.IStore;

namespace FormsProject.Forms
{
    static public class FormManager
    {
        static public void OpenForm(Form form)
        {
            form.Show();
        }

        static private BaseForm ShowForm(BaseForm form, OperationCode operationCode, int recordId = 0)
        {
            BaseForm _form = InitForm(operationCode, recordId);
            _form.Show();
            return _form;
        }

        static private BaseForm OpenListForm(BaseForm form, OperationCode operationCode)
        {
            BaseForm _form = null;

            if (AppInstance.FormsCollection.ContainsKey(operationCode))
            {
                _form = AppInstance.FormsCollection[operationCode];
                if (_form.WindowState == FormWindowState.Minimized)
                {
                    _form.WindowState = FormWindowState.Normal;
                }
                AppInstance.FormsCollection[operationCode].Focus();
            }
            else
            {
                _form = ShowForm(form, operationCode);
                AppInstance.FormsCollection.Add(operationCode, _form);
            }

            return _form;
        }

        static private BaseForm OpenDirrectoryForm(BaseForm form, OperationCode operationCode, int recordId = 0)
        {
            BaseForm _form = null;

            bool isReportForm = operationCode.ToString().ToLower().Contains("report");
            if (!isReportForm)
            {

                if (recordId > 0)
                {
                    bool isBusi = DataProject.TempTable.TempTableHandler.GetValueFromTempTable(recordId, (int)operationCode, AppInstance.sqlConnection);
                    if (isBusi)
                    {
                        MessageBox.Show("Форма занята другим пользователем", "Форма уже открыта", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        _form = ShowForm(form, operationCode, recordId);
                        DataProject.TempTable.TempTableHandler.SetValueToTempTable(AppInstance.UserId, recordId, (int)operationCode, AppInstance.sqlConnection);
                    }
                }
                else
                {
                    _form = ShowForm(form, operationCode, recordId);
                }
            }
            else
            {
                _form = ShowForm(form, operationCode, recordId);
            }

            return _form;
        }

        static private bool IsAccessRights(OperationCode operationCode)
        {
            bool isAccess = true;

            switch(operationCode)
            {
                case OperationCode.ReportTmcIncome:
                    if (AppInstance.UserId != 6)
                        isAccess = false;
                    break;
            }

            return isAccess;
        }

        static public BaseForm OpenForm(OperationCode operationCode, int recordId = 0)
        {
            BaseForm form = null;

            if (IsAccessRights(operationCode))
            {

                bool isListForm = operationCode.ToString().Contains("LIST");
                if (isListForm)
                {
                    form = OpenListForm(form, operationCode);
                }
                else
                {
                    form = OpenDirrectoryForm(form, operationCode, recordId);
                }

                if (form != null)
                {
                    form.Text = GetFormName.GetNameByOperationCode(operationCode);
                }
            }

            return form;
        }

        static private BaseForm InitForm(OperationCode operationCode, int recordId = 0)
        {
            BaseForm form = null;

            switch (operationCode)
            {
                case OperationCode.TMC_GROUP_LIST:
                    form = new FormDocumentsListView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.TmcGroup:
                    form = new FormTmcGroup();
                    form.OperationCode = operationCode;
                    ((FormTmcGroup)form).LoadForm(recordId);
                    break;
                case OperationCode.MONEY_IN:
                    form = new FormMoneyDocuments();
                    form.OperationCode = operationCode;
                    form.BackColor = Color.FromArgb(247, 233, 235);
                    ((FormMoneyDocuments)form).LoadForm(recordId);
                    break;
                case OperationCode.MONEY_OUT:
                    form = new FormMoneyDocuments();
                    form.OperationCode = operationCode;
                    ((FormMoneyDocuments)form).LoadForm(recordId);
                    form.BackColor = Color.FromArgb(235, 247, 233);
                    break;
                case OperationCode.PRODUCT_IN:
                    form = new FormProducts();
                    form.OperationCode = operationCode;
                    ((FormProducts)form).LoadForm(recordId);
                    form.BackColor = Color.FromArgb(247, 233, 235);
                    break;
                case OperationCode.PRODUCT_OUT:
                    form = new FormProducts();
                    form.OperationCode = operationCode;
                    ((FormProducts)form).LoadForm(recordId);
                    form.BackColor = Color.FromArgb(235, 247, 233);
                    break;
                case OperationCode.TMC:
                    form = new FormTMC();
                    form.OperationCode = operationCode;
                    ((FormTMC)form).LoadForm(recordId);
                    break;
                case OperationCode.CUSTOMER:
                    form = new FormСustomer();
                    form.OperationCode = operationCode;
                    ((FormСustomer)form).LoadForm(recordId);
                    break;
                case OperationCode.LIST_MONEY_IN:
                    form = new FormDocumentsListView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.LIST_MONEY_OUT:
                    form = new FormDocumentsListView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.LIST_PRODUCT_IN:
                    form = new FormDocumentsListView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.LIST_PRODUCT_OUT:
                    form = new FormDocumentsListView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.LIST_TMC:
                    form = new FormTmcView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.LIST_CUSTOMER:
                    form = new FormDocumentsListView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.LIST_UNIT:
                    form = new FormDocumentsListView();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.UNIT:
                    form = new FormUnit();
                    form.OperationCode = operationCode;
                    ((FormUnit)form).LoadForm(recordId);
                    break;
                case OperationCode.ReportCustomerInfo:
                    form = new FormCustomerInfo();
                    form.OperationCode = operationCode;
                    ((FormCustomerInfo)form).InitReport(recordId);
                    break;
                case OperationCode.ReportTmcinfo:
                    form = new FormTMCInfo();
                    form.OperationCode = operationCode;
                    ((FormTMCInfo)form).InitReport(recordId);
                    break;
                case OperationCode.ReportCustomerNonCashInfo:
                    form = new FormNonCashDebt();
                    form.OperationCode = operationCode;
                    ((FormNonCashDebt)form).InitReport(recordId);
                    break;
                case OperationCode.ReportTmcIncome:
                    form = new FormTmcIncome();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.ReportQuantity:
                    form = new FormReportQuantity();
                    form.OperationCode = operationCode;
                    break;
                case OperationCode.ListOrdersIS:
                    form = new FormListOrders();
                    form.OperationCode = operationCode;
                    break;
            }

            return form;
        }
    }
}
