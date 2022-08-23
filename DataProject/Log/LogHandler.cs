using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject.Log
{
    static class LogHandler
    {
        static private Exception _exception;

        static public void SetException(Exception exception)
        {
            _exception = exception;
            Task task = new Task(WriteFile);
            task.Start();
        }

        static private void WriteFile()
        {
            StreamWriter file = new StreamWriter(@"LogSql.txt", true);
            file.WriteLine(DateTime.Now.ToString() + "--------" + _exception.Message + _exception.TargetSite.ToString());
            file.Close();
        }
    }
}
