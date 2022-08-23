using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject.Operations
{
    public struct FormSetting
    {
        public FormWindowState windowState;
        public int Height, Width, X, Y;
        public bool Activate;


        public void SaveSetting(Form form)
        {
            if (form.WindowState != FormWindowState.Maximized && form.WindowState != FormWindowState.Minimized)
            {
                Width = form.Size.Width;
                Height = form.Size.Height;
                X = form.Location.X;
                Y = form.Location.Y;
            }
            windowState = form.WindowState;
            Activate = true;
        }

        public void ReadSetting(Form form)
        {
            if (Activate)
            {
                switch (windowState)
                {
                    //case FormWindowState.Maximized:
                    //    //form.WindowState = windowState;
                    //    break;

                    case FormWindowState.Normal:
                        form.Size = new System.Drawing.Size(Width, Height);
                        form.Location = new System.Drawing.Point(X, Y);
                        break;

                    default:
                        form.WindowState = windowState;
                        form.Size = new System.Drawing.Size(Width, Height);
                        form.Location = new System.Drawing.Point(X, Y);

                        break;
                }
            }
        }
    }
}
