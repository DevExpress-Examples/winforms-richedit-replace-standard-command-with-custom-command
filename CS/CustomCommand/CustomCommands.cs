using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraRichEdit.Commands;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit;
using DevExpress.Utils;

namespace CustomCommand
{
    #region customsavecommand
    public class CustomSaveDocumentCommand : SaveDocumentCommand
    {
        public CustomSaveDocumentCommand(IRichEditControl control)
            : base(control)
        {
        }

        protected override void ExecuteCore()
        {
            if (Control.Document.Paragraphs.Count > 7)
                base.ExecuteCore();
            else MessageBox.Show(@"You should type at least 7 paragraphs
  to be able to save the document.",
                "Please be creative", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    #endregion customsavecommand


    #region #iricheditcommandfactoryservice
    public class CustomRichEditCommandFactoryService : IRichEditCommandFactoryService
    {
        readonly IRichEditCommandFactoryService service;
        readonly RichEditControl control;

        public CustomRichEditCommandFactoryService(RichEditControl control, 
            IRichEditCommandFactoryService service)
        {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(service, "service");
            this.control = control;
            this.service = service;
        }

        #region IRichEditCommandFactoryService Members
        public RichEditCommand CreateCommand(RichEditCommandId id)
        {
            if (id == RichEditCommandId.FileSave)
                return new CustomSaveDocumentCommand(control);

            return service.CreateCommand(id);
        }
        #endregion
    }
    #endregion #iricheditcommandfactoryservice


}
