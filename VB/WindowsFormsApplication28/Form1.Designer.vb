Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication28
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet = New CarsDBDataSet()
            Me.rowID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTrademark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowModel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowHP = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowLiter = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCyl = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTransmissSpeedCount = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowTransmissAutomatic = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowMPG_City = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowMPG_Highway = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowDescription = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowHyperlink = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.rowPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
            Me.carsTableAdapter = New CarsDBDataSetTableAdapters.CarsTableAdapter()
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.DataSource = Me.carsBindingSource
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.vGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RecordWidth = 131
			Me.vGridControl1.RowHeaderWidth = 133
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.rowID, Me.rowTrademark, Me.rowModel, Me.rowHP, Me.rowLiter, Me.rowCyl, Me.rowTransmissSpeedCount, Me.rowTransmissAutomatic, Me.rowMPG_City, Me.rowMPG_Highway, Me.rowCategory, Me.rowDescription, Me.rowHyperlink, Me.rowPrice, Me.editorRow1})
			Me.vGridControl1.Size = New System.Drawing.Size(376, 288)
			Me.vGridControl1.TabIndex = 0
'			Me.vGridControl1.CustomUnboundData += New DevExpress.XtraVerticalGrid.Events.CustomDataEventHandler(Me.vGridControl1_CustomUnboundData);
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' rowID
			' 
			Me.rowID.Name = "rowID"
			Me.rowID.Properties.Caption = "ID"
			Me.rowID.Properties.FieldName = "ID"
			' 
			' rowTrademark
			' 
			Me.rowTrademark.Name = "rowTrademark"
			Me.rowTrademark.Properties.Caption = "Trademark"
			Me.rowTrademark.Properties.FieldName = "Trademark"
			' 
			' rowModel
			' 
			Me.rowModel.Name = "rowModel"
			Me.rowModel.Properties.Caption = "Model"
			Me.rowModel.Properties.FieldName = "Model"
			' 
			' rowHP
			' 
			Me.rowHP.Name = "rowHP"
			Me.rowHP.Properties.Caption = "HP"
			Me.rowHP.Properties.FieldName = "HP"
			' 
			' rowLiter
			' 
			Me.rowLiter.Name = "rowLiter"
			Me.rowLiter.Properties.Caption = "Liter"
			Me.rowLiter.Properties.FieldName = "Liter"
			' 
			' rowCyl
			' 
			Me.rowCyl.Name = "rowCyl"
			Me.rowCyl.Properties.Caption = "Cyl"
			Me.rowCyl.Properties.FieldName = "Cyl"
			' 
			' rowTransmissSpeedCount
			' 
			Me.rowTransmissSpeedCount.Name = "rowTransmissSpeedCount"
			Me.rowTransmissSpeedCount.Properties.Caption = "Transmiss Speed Count"
			Me.rowTransmissSpeedCount.Properties.FieldName = "TransmissSpeedCount"
			' 
			' rowTransmissAutomatic
			' 
			Me.rowTransmissAutomatic.Name = "rowTransmissAutomatic"
			Me.rowTransmissAutomatic.Properties.Caption = "Transmiss Automatic"
			Me.rowTransmissAutomatic.Properties.FieldName = "TransmissAutomatic"
			' 
			' rowMPG_City
			' 
			Me.rowMPG_City.Name = "rowMPG_City"
			Me.rowMPG_City.Properties.Caption = "MPG_City"
			Me.rowMPG_City.Properties.FieldName = "MPG_City"
			' 
			' rowMPG_Highway
			' 
			Me.rowMPG_Highway.Name = "rowMPG_Highway"
			Me.rowMPG_Highway.Properties.Caption = "MPG_Highway"
			Me.rowMPG_Highway.Properties.FieldName = "MPG_Highway"
			' 
			' rowCategory
			' 
			Me.rowCategory.Name = "rowCategory"
			Me.rowCategory.Properties.Caption = "Category"
			Me.rowCategory.Properties.FieldName = "Category"
			' 
			' rowDescription
			' 
			Me.rowDescription.Name = "rowDescription"
			Me.rowDescription.Properties.Caption = "Description"
			Me.rowDescription.Properties.FieldName = "Description"
			' 
			' rowHyperlink
			' 
			Me.rowHyperlink.Name = "rowHyperlink"
			Me.rowHyperlink.Properties.Caption = "Hyperlink"
			Me.rowHyperlink.Properties.FieldName = "Hyperlink"
			' 
			' rowPrice
			' 
			Me.rowPrice.Name = "rowPrice"
			Me.rowPrice.Properties.Caption = "Price"
			Me.rowPrice.Properties.FieldName = "Price"
			' 
			' editorRow1
			' 
			Me.editorRow1.Fixed = DevExpress.XtraVerticalGrid.Rows.FixedStyle.Top
			Me.editorRow1.InternalFixed = DevExpress.XtraVerticalGrid.Rows.FixedStyle.Top
			Me.editorRow1.Name = "editorRow1"
			Me.editorRow1.Properties.FieldName = "editorRow10"
			Me.editorRow1.Properties.UnboundType = DevExpress.Data.UnboundColumnType.String
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(376, 288)
			Me.Controls.Add(Me.vGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private carsDBDataSet As CarsDBDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
        Private carsTableAdapter As CarsDBDataSetTableAdapters.CarsTableAdapter
        Private rowID As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTrademark As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowModel As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowHP As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowLiter As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCyl As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmissSpeedCount As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowTransmissAutomatic As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowMPG_City As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowMPG_Highway As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowCategory As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowDescription As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowHyperlink As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private rowPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
	End Class
End Namespace

