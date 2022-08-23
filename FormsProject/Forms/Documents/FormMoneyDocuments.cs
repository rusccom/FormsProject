using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Documents
{
    public partial class FormMoneyDocuments : FormDirectoryBase
    {
        public FormMoneyDocuments()
        {
            InitializeComponent();
            dcbCustomer.FillComboBox();
        }
    }
}
