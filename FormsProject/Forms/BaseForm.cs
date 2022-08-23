using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using FormsProject.Operations;
using FormsProject.Forms.Service;

namespace FormsProject.Forms
{
    public partial class BaseForm : Form
    {
        private Operations.OperationCode operationCode;

        private ToolStripButton stripButtonForm;

        internal UserFilter userFilter;

        public Operations.OperationCode OperationCode
        {
            get { return operationCode; }
            set { operationCode = value; }
        }

        public BaseForm()
        {
            InitializeComponent();
            this.MdiParent = AppInstance.mainForm;
            userFilter = new UserFilter();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //CreateToolStripButton();
        }

        protected override void WndProc(ref System.Windows.Forms.Message msg)
        {
            //if (msg.Msg == 0x112)
            //{
            //    switch(msg.WParam.ToInt32())
            //    {
                    //case (int)0xF020:
                    //    Visible = false;
                    //    SaveFormProperty();
                    //    ShowStripButton();
                    //    break;
                    //case (int)0xF120:
                    //    SetFormProperty();
                    //    break;
                //}

                //if (msg.WParam == (IntPtr)0xF020)
                //{
                //    Visible = false;
                //    SaveFormProperty();
                //    ShowStripButton();
                //}
            //}
            base.WndProc(ref msg);
        }

        protected override void OnCreateControl()
        {
            SetFormProperty();
            base.OnCreateControl();
        }

        private void SaveFormProperty()
        {
            //AppInstance.OperationSettingCollection[OperationCode].formSetting.SaveSetting(this);
        }

        private void SetFormProperty()
        {
            //AppInstance.OperationSettingCollection[OperationCode].formSetting.ReadSetting(this);
        }

        //private void ShowStripButton()
        //{
        //    if (stripButtonForm != null)
        //    {
        //        ToolStripHandler stripHandler = new ToolStripHandler();
        //        stripHandler.ShowButton(ref stripButtonForm);
        //    }
        //}

        //private void CreateToolStripButton()
        //{
        //    ToolStripButton button = new ToolStripButton(this.Text);
        //    button.Tag = OperationCode;
        //    stripButtonForm = button;
        //}


            


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            //SaveFormProperty();
            //AppInstance.FormsCollection.Remove(OperationCode);
            //if (AppInstance.mainForm.UserToolStripMenu.Items.Contains(stripButtonForm))
            //{
            //    AppInstance.mainForm.UserToolStripMenu.Items.Remove(stripButtonForm);
            //}
        }
    }
}
