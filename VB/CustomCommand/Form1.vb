Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit

Namespace CustomCommand
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			ReplaceRichEditCommandFactoryService(richEditControl1)
		End Sub


		Private Sub ReplaceRichEditCommandFactoryService(ByVal control As RichEditControl)
			Dim service As IRichEditCommandFactoryService = control.GetService(Of IRichEditCommandFactoryService)()
			If service Is Nothing Then
				Return
			End If
			control.RemoveService(GetType(IRichEditCommandFactoryService))
			control.AddService(GetType(IRichEditCommandFactoryService), New CustomRichEditCommandFactoryService(control, service))
		End Sub

	End Class
End Namespace