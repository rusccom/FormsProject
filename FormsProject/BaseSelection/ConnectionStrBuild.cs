using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.BaseSelection
{
    static public class ConnectionStrBuild
    {
        static public string GetString(DataBaseInfo info)
        {
            string result = "Server = " + info.Server + "; Database = "+ info.DataBase + "; User id = sa; Password = "+info.Password+ "; Integrated Security = false; persist security info=false; asynchronous processing=true; MultipleActiveResultSets=True";

            return result;
        }
    }
}
