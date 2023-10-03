Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit

Namespace CustomCommand

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ReplaceRichEditCommandFactoryService(richEditControl1)
        End Sub

        Private Sub ReplaceRichEditCommandFactoryService(ByVal control As RichEditControl)
            Dim service As IRichEditCommandFactoryService = control.GetService(Of IRichEditCommandFactoryService)()
            If service Is Nothing Then Return
            control.RemoveService(GetType(IRichEditCommandFactoryService))
            control.AddService(GetType(IRichEditCommandFactoryService), New CustomRichEditCommandFactoryService(control, service))
        End Sub
    End Class
End Namespace
