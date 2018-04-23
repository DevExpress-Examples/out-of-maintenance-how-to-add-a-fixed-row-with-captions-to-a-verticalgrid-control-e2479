Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid

Namespace VGridColumnHeaders
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.CarsTableAdapter.Fill(Me.CarsDBDataSet.Cars)

            AddHandler vGridControl1.RowHeaderWidthChanged, AddressOf OnRowHeaderWidthChanged
			AddHandler vGridControl2.RowHeaderWidthChanged, AddressOf OnRowHeaderWidthChanged
			AddHandler vGridControl1.RecordWidthChanged, AddressOf OnRecordWidthChanged
			AddHandler vGridControl2.RecordWidthChanged, AddressOf OnRecordWidthChanged

			Dim vridClientBounds As Rectangle = vGridControl1.ViewInfo.GetClientRect(vGridControl1.Bounds)
			Dim borderHeight As Integer = vridClientBounds.Y - vGridControl1.Bounds.Y

			Dim captions(vGridControl1.RecordCount - 1) As String
			For i As Integer = 0 To vGridControl1.RecordCount - 1
				captions(i) = "Caption " & i.ToString()
			Next i

			vGridControl2.DataSource = captions
			vGridControl2.Height = vGridControl2.ViewInfo.GetVisibleRowHeight(vGridControl2.Rows(0)) + borderHeight * 3
			vGridControl2.Rows(0).Properties.Caption = ""
			vGridControl2.Appearance.FocusedRow.Assign(vGridControl1.ViewInfo.PaintAppearance.RowHeaderPanel)
			vGridControl2.Appearance.HideSelectionRow.Assign(vGridControl1.ViewInfo.PaintAppearance.RowHeaderPanel)
			vGridControl2.Appearance.ReadOnlyRecordValue.Assign(vGridControl1.ViewInfo.PaintAppearance.RowHeaderPanel)

			FindHScroll(vGridControl1)
			FindHScroll(vGridControl2)
		End Sub

		Private Sub FindHScroll(ByVal vGrid As VGridControl)
			For Each control As Control In vGrid.Controls
				If TypeOf control Is VGridHorzScrollBar Then
					AddHandler (CType(control, VGridHorzScrollBar)).ValueChanged, AddressOf OnHScrollValueChanged
					Return
				End If
			Next control
		End Sub

		Private Sub OnHScrollValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim hScroll As VGridHorzScrollBar = CType(sender, VGridHorzScrollBar)
			If hScroll.Parent Is vGridControl1 Then
				vGridControl2.LeftVisibleRecord = vGridControl1.LeftVisibleRecord
			Else
				vGridControl2.LeftVisibleRecord = vGridControl1.LeftVisibleRecord
			End If
		End Sub

		Private Sub OnRowHeaderWidthChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim sendControl As VGridControl = CType(sender, VGridControl)
			If sendControl Is vGridControl1 Then
				vGridControl2.RowHeaderWidth = vGridControl1.RowHeaderWidth
			Else
				vGridControl1.RowHeaderWidth = vGridControl2.RowHeaderWidth
			End If
		End Sub

		Private Sub OnRecordWidthChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim sendControl As VGridControl = CType(sender, VGridControl)
			If sendControl Is vGridControl1 Then
				vGridControl2.RecordWidth = vGridControl1.RecordWidth
			Else
				vGridControl1.RecordWidth = vGridControl2.RecordWidth
			End If
		End Sub
	End Class
End Namespace
