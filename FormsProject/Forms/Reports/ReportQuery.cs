using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Reports
{
    public static class ReportQuery
    {
        public static string GetQuery(object value, Operations.OperationCode operationCode)
        {
            string result = string.Empty;

            List<DateTime> datetime = null;

            switch (operationCode)
            {
                case Operations.OperationCode.ReportCustomerInfo:
                    result = File.ReadAllText(Application.StartupPath + "/SqlQuery/Reports/Customerinfo.txt", Encoding.Default);
                    result = result.Replace("#CusId#", value.ToString());
                    break;
                case Operations.OperationCode.ReportTmcinfo:
                    result = File.ReadAllText(Application.StartupPath + "/SqlQuery/Reports/TMCinfo.txt", Encoding.Default);
                    result = result.Replace("#TmcId#", value.ToString());
                    break;
                case Operations.OperationCode.ReportCustomerNonCashInfo:
                    result = File.ReadAllText(Application.StartupPath + "/SqlQuery/Reports/NonCashInfo.txt", Encoding.Default);
                    result = result.Replace("#CusId#", value.ToString());
                    break;
                case Operations.OperationCode.ReportTmcIncome:
                    datetime = (List<DateTime>)value;
                    result = File.ReadAllText(Application.StartupPath + "/SqlQuery/Reports/ReportIncome.txt", Encoding.Default);
                    result = result.Replace("#DateFrom#", datetime[0].ToString());
                    result = result.Replace("#DateTo#", datetime[1].ToString());
                    break;

                case Operations.OperationCode.ReportQuantity:
                    datetime = (List<DateTime>)value;
                    result = File.ReadAllText(Application.StartupPath + "/SqlQuery/Reports/ReportQuantity.txt", Encoding.Default);
                    result = result.Replace("#DateFrom#", datetime[0].ToString());
                    result = result.Replace("#DateTo#", datetime[1].ToString());
                    break;
            }

            return result;
        }
    }
}
