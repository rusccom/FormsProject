using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityProject.EntityClasses.Models;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.ComponentModel;
using System.Reflection;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace EntityProject.HandlerData
{
    public static class Data
    {
        public static void GetData(int operation)
        {
            
            Operations.OperationCode operationCode = (Operations.OperationCode) operation;

            using (EntityDBContext data = new EntityDBContext())
            {
                //var qwe = data.AllLogin;
                var qwe  = (from d in data.AllLogin select d);
                //query.sa
            }

            //return result;
            //string columnName = MetaDataHelper.GetDisplayName(typeof(Login), "Name");
           // Type type = typeof(Login);

            //Assembly assy = typeof(Login).Assembly;
            //foreach (Attribute attr in Attribute.GetCustomAttributes(assy))
            //{
                // Check for the AssemblyTitle attribute.
            //    if (attr.GetType() == typeof(DisplayNameAttribute))
            //    {

            //    }
            //}

            // DataTable table = new DataTable();
            //  DataColumn column = new DataColumn(columnName, )
            // table.Columns.Add()
            //  }
            //  string qwe = "sddsd";
            //Attribute atribute = Attribute.GetCustomAttribute(typeof(Login), typeof(DisplayAttribute));
        }

        public static void SetData()
        {
            using (EntityDBContext data = new EntityDBContext())
            {
                Login login = new Login();
                login.Name = "Ruslan";
                login.Password = "pass";

                try
                {
                    data.AllLogin.Add(login);
                    data.SaveChanges();
                }
                catch(Exception exc)
                {

                }

            }
        }

    }
}
