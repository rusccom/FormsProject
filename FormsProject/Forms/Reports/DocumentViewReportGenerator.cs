using FormsProject.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.Forms.Reports
{
    public class DocumentViewReportGenerator
    {
        public void AddOtherTableSettibg(TableView table, Operations.OperationCode operationCode)
        {
            InitEvent(table, operationCode);
        }

        private void InitEvent(TableView table, Operations.OperationCode operationCode)
        {
            switch(operationCode)
            {
                case Operations.OperationCode.LIST_CUSTOMER:
                    CustomerAddSetting customerAddSetting = new CustomerAddSetting();
                    customerAddSetting.Init(table);
                    break;
            }
        }
    }
}
