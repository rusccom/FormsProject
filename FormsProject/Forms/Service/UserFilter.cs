using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsProject.Controls;
using FormsProject.Operations;

namespace FormsProject.Forms.Service
{
    public class UserFilter
    {
            public string TextBoxValue { get; set; }
            public DateTime DateTimeFrom { get; set; }
            public DateTime DateTimeTo { get; set; }

        public void SetFilter(TableView tvResult, OperationCode operationCode)
        {
            string query = string.Empty;

            query = GetQuery(operationCode);

            tvResult.Filter(query);
        }

        private  string GetQuery(OperationCode operationCode)
        {
            string result = string.Empty;

            switch(operationCode)
            {
                case OperationCode.LIST_CUSTOMER:
                case OperationCode.LIST_UNIT:
                case OperationCode.TMC_GROUP_LIST:
                case OperationCode.LIST_TMC:
                        
                    result = "CONVERT(id, 'System.String') like '%" + TextBoxValue + "%' or name like '%" + TextBoxValue + "%'";
                    break;

                case OperationCode.PRODUCT_OUT:
                case OperationCode.PRODUCT_IN:
                        result = "CONVERT(TmcId, 'System.String') like '%"+ TextBoxValue + "%' or TmcName like '%" + TextBoxValue + "%'";
                    break;

                case OperationCode.LIST_PRODUCT_IN:
                case OperationCode.LIST_PRODUCT_OUT:
                case OperationCode.LIST_MONEY_IN:
                case OperationCode.LIST_MONEY_OUT:
                    result = "(DocumentDate >= '" + DateTimeFrom + "' and DocumentDate <= '" + DateTimeTo.AddDays(1) + "') and (code like '%" + TextBoxValue + "%' or CustomerId like '%" + TextBoxValue + "%')";
                    break;
            }

            return result;
        }
    }
}
