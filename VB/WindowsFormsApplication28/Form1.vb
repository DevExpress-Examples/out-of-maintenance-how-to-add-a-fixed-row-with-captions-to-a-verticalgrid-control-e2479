Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid.Events

Namespace WindowsFormsApplication28
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)
		End Sub

		Private Sub vGridControl1_CustomUnboundData(ByVal sender As Object, ByVal e As CustomDataEventArgs) Handles vGridControl1.CustomUnboundData
			If e.Row IsNot editorRow1 Then
				Return
			End If

			If e.IsGetData Then
				e.Value = "Caption " & e.ListSourceRowIndex
			End If
		End Sub
	End Class
End Namespace
