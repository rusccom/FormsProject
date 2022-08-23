using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Operations
{
    public static class Effect
    {
        public static void WaitForm(Form form, bool isWait)
        {
            foreach (Control control in form.Controls)
            {
                control.Enabled = !isWait;
            }
            if (isWait)
            {
                form.Cursor = Cursors.WaitCursor;
            }
            else
            {
                form.Cursor = Cursors.Default;
            }
        }
    }
}
