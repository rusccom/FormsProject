using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.Operations
{
    static public class GetFormName
    {
        static public string GetNameByOperationCode(Operations.OperationCode operationCode)
        {
            string result = "Опаньки.";

            switch(operationCode)
            {
                case OperationCode.CUSTOMER:
                    result = "Контрагент";
                    break;
                case OperationCode.LIST_CUSTOMER:
                    result = "Список контрагентов";
                    break;
                case OperationCode.LIST_MONEY_IN:
                    result = "Список входящих денег";
                    break;
                case OperationCode.LIST_MONEY_OUT:
                    result = "Список исходящих денег";
                    break;
                case OperationCode.LIST_PRODUCT_IN:
                    result = "Список покупок";
                    break;
                case OperationCode.LIST_PRODUCT_OUT:
                    result = "Список продаж";
                    break;
                case OperationCode.LIST_TMC:
                    result = "Список ТМЦ";
                    break;
                case OperationCode.LIST_UNIT:
                    result = "Единицы измерения";
                    break;
                case OperationCode.MONEY_IN:
                    result = "Приход денег";
                    break;
                case OperationCode.MONEY_OUT:
                    result = "Расход денег";
                    break;
                case OperationCode.PRODUCT_IN:
                    result = "Приход товара";
                    break;
                case OperationCode.PRODUCT_OUT:
                    result = "Расход товара";
                    break;
                case OperationCode.TMC:
                    result = "ТМЦ";
                    break;
                case OperationCode.TmcGroup:
                    result = "Группы ТМЦ";
                    break;
                case OperationCode.TMC_GROUP_LIST:
                    result = "Список групп ТМЦ";
                    break;
                case OperationCode.UNIT:
                    result = "Единица измерения";
                    break;
            }

            return result;
        }
    }
}
