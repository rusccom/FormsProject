using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms.Directory
{
    public partial class FormСustomer : FormDirectoryBase
    {
        public FormСustomer()
        {
            InitializeComponent();
            dcbPriceType.FillComboBox();
        }
    }
}
