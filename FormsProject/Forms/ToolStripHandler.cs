using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Forms
{
    public class ToolStripHandler
    {
        public void ShowButton(ref ToolStripButton button)
        {
            if (button != null && !AppInstance.mainForm.UserToolStripMenu.Items.Contains(button))
            {
                button.Click += Button_Click;
                AppInstance.mainForm.UserToolStripMenu.Items.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ToolStripButton button = (ToolStripButton)sender;
            button.Click -= Button_Click;
            FormManager.OpenForm((Operations.OperationCode)button.Tag);
            AppInstance.mainForm.UserToolStripMenu.Items.Remove(button);
        }
    }
}
