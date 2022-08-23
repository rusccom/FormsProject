using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Controls
{
    public class DataTextBox : TextBox, IUserControl
    {
        public bool IsDataCorrect;

        private Operations.FieldDataType fieldType;
        private string fieldName;
        private bool notNull;
        private bool isSqlData;

        public Operations.FieldDataType FieldType
        {
            get { return fieldType; }
            set { fieldType = value; }
        }

        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }

        public bool NotNull
        {
            get { return notNull; }
            set { notNull = value; }
        }

        public bool IsSqlData
        {
            get { return isSqlData; }
            set { isSqlData = value; }
        }

        public DataTextBox()
        {
            this.KeyPress += DataTextBox_KeyPress;
        }

        private void DataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(FieldType)
            {
                case Operations.FieldDataType.DECIMAL:
                    if(e.KeyChar == ',')
                    {
                        e.KeyChar = '.';
                    }
                    break;
            }
        }

        public string GetData()
        {
            string result = string.Empty;
            this.BackColor = SystemColors.Window;

            result = TextBoxHandle();

            return result;
        }

        private string TextBoxHandle()
        {
            string result = string.Empty;
            IsDataCorrect = false;


            switch (FieldType)
            {
                case Operations.FieldDataType.DECIMAL:
                    decimal decimalValue;

                    if (decimal.TryParse(Text, out decimalValue))
                    {
                        result = decimalValue.ToString();
                        IsDataCorrect = true;
                    }
                    break;

                case Operations.FieldDataType.INTEGER:
                    int intValue;

                    if (int.TryParse(Text, out intValue))
                    {
                        result = intValue.ToString();
                        IsDataCorrect = true;
                    }
                    break;

                case Operations.FieldDataType.STRING:
                    result = "'" + Text + "'";
                    IsDataCorrect = true;
                    break;
            }

            if (!IsDataCorrect)
            {
                this.BackColor = Color.IndianRed;
            }

            return result;
        }

    }
}
