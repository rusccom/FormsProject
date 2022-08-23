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
    public partial class FormCount : Form
    {
        private decimal count;

        public decimal Count
        {
            get { return count; }
        }

        public FormCount()
        {
            InitializeComponent();

            this.KeyUp += FormCount_KeyUp;
            tbCount.KeyUp += TbCount_KeyUp;
        }

        private void SetCount()
        {
            if (decimal.TryParse(tbCount.Text, out count))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TbCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCount();
            }
        }

        private void FormCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCount();
            }
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            SetCount();
        }
    }
}
