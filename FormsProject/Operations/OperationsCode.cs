using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.Operations
{
    public enum OperationCode
    {
        LIST_PRODUCT_IN = 1,
        LIST_PRODUCT_ITEM_IN = 19,
        LIST_PRODUCT_OUT = 2,
        LIST_PRODUCT_ITEM_OUT = 22,
        LIST_MONEY_IN = 3,
        LIST_MONEY_OUT = 4,
        LIST_TMC = 5,
        LIST_CUSTOMER = 7,
        PRODUCT_IN = 8,
        PRODUCT_ITEM_IN = 20,
        PRODUCT_OUT = 9,
        PRODUCT_ITEM_OUT = 21,
        MONEY_IN = 10,
        MONEY_OUT = 11,
        TMC = 12,
        CUSTOMER = 13,
        LIST_UNIT = 14,
        UNIT = 15,
        SYSTEM_LOGIN = 16,
        TMC_GROUP_LIST = 17,
        TmcGroup = 18,
        ReportTmcinfo = 23,
        ReportCustomerInfo = 24,
        ReportCustomerNonCashInfo = 25,
        ReportTmcIncome = 26,
        ReportQuantity = 27,
        ListOrdersIS = 28,
        NONE = 0
    }

    public enum FieldDataType
    {

        STRING = 1,
        DECIMAL = 2,
        INTEGER = 3
    }

    public enum DocumentType
    {
        DocumentIn = 1,
        DocumentOut = 2,
        MoneyIn = 3,
        MoneyOut = 4
    }


    public static class Operation
    {
        public static string GetTableNameByOperationCode(OperationCode code)
        {
            string result = string.Empty;

            switch (code)
            {
                //Document in Product
                case OperationCode.LIST_PRODUCT_IN:
                    result = "[DocumentInView]";
                    break;
                case OperationCode.PRODUCT_IN:
                    result = "[DocumentIn]";
                    break;
                case OperationCode.PRODUCT_ITEM_IN:
                    result = "[DocumentInItem]";
                    break;
                case OperationCode.LIST_PRODUCT_ITEM_IN:
                    result = "[DocumentItemInView]";
                    break;

                //Document out Product
                case OperationCode.LIST_PRODUCT_OUT:
                    result = "[DocumentOutView]";
                    break;
                case OperationCode.PRODUCT_OUT:
                    result = "[DocumentOut]";
                    break;
                case OperationCode.PRODUCT_ITEM_OUT:
                    result = "[DocumentOutItem]";
                    break;
                case OperationCode.LIST_PRODUCT_ITEM_OUT:
                    result = "[DocumentItemOutView]";
                    break;

                //Money out Product
                case OperationCode.LIST_MONEY_OUT:
                    result = "[DocumentMoneyOutView]";
                    break;
                case OperationCode.MONEY_OUT:
                    result = "[DocumentMoneyOut]";
                    break;

                //Money in Product
                case OperationCode.LIST_MONEY_IN:
                    result = "[DocumentMoneyInView]";
                    break;
                case OperationCode.MONEY_IN:
                    result = "[DocumentMoneyIn]";
                    break;
                
                    //
                case OperationCode.LIST_UNIT:
                    result = "[UnitView]";
                    break;
                case OperationCode.UNIT:
                    result = "[Unit]";
                    break;
                case OperationCode.LIST_CUSTOMER:
                    result = "[CustomerView]";
                    break;
                case OperationCode.CUSTOMER:
                    result = "[Customer]";
                    break;

                case OperationCode.LIST_TMC:
                    result = "[TmcView]";
                    break;
                case OperationCode.TMC:
                    result = "[tmc]";
                    break;
                case OperationCode.SYSTEM_LOGIN:
                    result = "[system].[login]";
                    break;
                case OperationCode.TMC_GROUP_LIST:
                    result = "[TmcGroupView]";
                    break;
                case OperationCode.TmcGroup:
                    result = "[TmcGroup]";
                    break;
            }

            return result;
        }

        public static OperationCode GetOperationFormCodeByList(OperationCode code)
        {
            OperationCode result = OperationCode.NONE;

            switch (code)
            {
                case OperationCode.LIST_PRODUCT_IN:
                    result = OperationCode.PRODUCT_IN;
                    break;
                case OperationCode.LIST_PRODUCT_ITEM_IN:
                    result = OperationCode.PRODUCT_ITEM_IN;
                    break;
                case OperationCode.LIST_PRODUCT_OUT:
                    result = OperationCode.PRODUCT_OUT;
                    break;
                case OperationCode.LIST_PRODUCT_ITEM_OUT:
                    result = OperationCode.PRODUCT_ITEM_OUT;
                    break;
                case OperationCode.TMC_GROUP_LIST:
                    result = OperationCode.TmcGroup;
                    break;
                case OperationCode.LIST_CUSTOMER:
                    result = OperationCode.CUSTOMER;
                    break;
                case OperationCode.LIST_MONEY_IN:
                    result = OperationCode.MONEY_IN;
                    break;
                case OperationCode.LIST_MONEY_OUT:
                    result = OperationCode.MONEY_OUT;
                    break;
                case OperationCode.LIST_TMC:
                    result = OperationCode.TMC;
                    break;
                case OperationCode.LIST_UNIT:
                    result = OperationCode.UNIT;
                    break;
            }

            return result;
        }

        public static OperationCode GetDocumentItemOperation(OperationCode code)
        {
            OperationCode result = OperationCode.NONE;

            switch (code)
            {
                case OperationCode.PRODUCT_IN:
                    result = OperationCode.PRODUCT_ITEM_IN;
                    break;
                case OperationCode.PRODUCT_OUT:
                    result = OperationCode.PRODUCT_ITEM_OUT;
                    break;
            }

            return result;
        }

        public static OperationCode GetDocumentItemListOperation(OperationCode code)
        {
            OperationCode result = OperationCode.NONE;

            switch (code)
            {
                case OperationCode.PRODUCT_IN:
                    result = OperationCode.LIST_PRODUCT_ITEM_IN;
                    break;
                case OperationCode.PRODUCT_OUT:
                    result = OperationCode.LIST_PRODUCT_ITEM_OUT;
                    break;
            }

            return result;
        }

        public static string GetDocumentCodeByOperationCode(Operations.OperationCode operationCode)
        {
            //120218
            DateTime timeNow = DateTime.Now;
            string day = timeNow.Day.ToString();
            string mount = timeNow.Month.ToString();
            string year = timeNow.Year.ToString().Remove(0,2);
            string hour = timeNow.Hour.ToString();
            string minute = timeNow.Minute.ToString();
            string second = timeNow.Second.ToString();
            char millisecond = timeNow.Millisecond.ToString()[0];

            string result = year + mount + day + hour + minute + second + millisecond;
            switch(operationCode)
            {
                case OperationCode.PRODUCT_IN:
                    result = "ПН-" + result;
                    break;
                case OperationCode.PRODUCT_OUT:
                    result = "РН-" + result;
                    break;
                case OperationCode.MONEY_IN:
                    result = "ПК-" + result;
                    break;
                case OperationCode.MONEY_OUT:
                    result = "РК-" + result;
                    break;
            }

            return result;
        }

        public static OperationCode GetOperationCodeByDocCode(int docCode)
        {
            OperationCode operationCode = OperationCode.NONE;

            switch (docCode)
            {
                case 1:
                    operationCode = OperationCode.PRODUCT_IN;
                    break;
                case 2:
                    operationCode = OperationCode.PRODUCT_OUT;
                    break;
                case 3:
                    operationCode = OperationCode.MONEY_IN;
                    break;
                case 4:
                    operationCode = OperationCode.MONEY_OUT;
                    break;
            }

            return operationCode;
        }
    }
}
