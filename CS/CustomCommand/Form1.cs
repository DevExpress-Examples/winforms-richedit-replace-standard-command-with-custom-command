using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit;

namespace CustomCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReplaceRichEditCommandFactoryService(richEditControl1);
        }


        void ReplaceRichEditCommandFactoryService(RichEditControl control)
        {
            IRichEditCommandFactoryService service = control.GetService<IRichEditCommandFactoryService>();
            if (service == null)
                return;
            control.RemoveService(typeof(IRichEditCommandFactoryService));
            control.AddService(typeof(IRichEditCommandFactoryService), new CustomRichEditCommandFactoryService(control, service));
        }

    }
}