using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsProject.BaseSelection
{
    [Serializable()]
    public class ListInfo : BindingList<DataBaseInfo>
    {
        public bool Update = false;
    }
}
