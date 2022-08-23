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
    public partial class FormTMC : FormDirectoryBase
    {
        public FormTMC()
        {
            InitializeComponent();
            dcbUnitId.FillComboBox();
            dcbGroup.FillComboBox();
        }
    }
}
