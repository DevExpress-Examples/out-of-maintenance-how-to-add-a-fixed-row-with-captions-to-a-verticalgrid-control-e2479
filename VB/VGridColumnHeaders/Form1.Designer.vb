Imports Microsoft.VisualBasic
Imports System
Namespace VGridColumnHeaders
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
            Me.components = New System.ComponentModel.Container
            Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl
            Me.rowID = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowTrademark = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowModel = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowHP = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowLiter = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowCyl = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowTransmissSpeedCount = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowTransmissAutomatic = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowMPG_City = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowMPG_Highway = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowCategory = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.rowPrice = New DevExpress.XtraVerticalGrid.Rows.EditorRow
            Me.vGridControl2 = New DevExpress.XtraVerticalGrid.VGridControl
            Me.CarsDBDataSet = New CarsDBDataSet
            Me.CarsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.CarsTableAdapter = New CarsDBDataSetTableAdapters.CarsTableAdapter
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CarsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'vGridControl1
            '
            Me.vGridControl1.DataSource = Me.CarsBindingSource
            Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.vGridControl1.Location = New System.Drawing.Point(0, 31)
            Me.vGridControl1.Name = "vGridControl1"
            Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowID, Me.rowTrademark, Me.rowModel, Me.rowHP, Me.rowLiter, Me.rowCyl, Me.rowTransmissSpeedCount, Me.rowTransmissAutomatic, Me.rowMPG_City, Me.rowMPG_Highway, Me.rowCategory, Me.rowPrice})
            Me.vGridControl1.Size = New System.Drawing.Size(555, 343)
            Me.vGridControl1.TabIndex = 0
            '
            'rowID
            '
            Me.rowID.Name = "rowID"
            Me.rowID.Properties.Caption = "ID"
            Me.rowID.Properties.FieldName = "ID"
            '
            'rowTrademark
            '
            Me.rowTrademark.Name = "rowTrademark"
            Me.rowTrademark.Properties.Caption = "Trademark"
            Me.rowTrademark.Properties.FieldName = "Trademark"
            '
            'rowModel
            '
            Me.rowModel.Name = "rowModel"
            Me.rowModel.Properties.Caption = "Model"
            Me.rowModel.Properties.FieldName = "Model"
            '
            'rowHP
            '
            Me.rowHP.Name = "rowHP"
            Me.rowHP.Properties.Caption = "HP"
            Me.rowHP.Properties.FieldName = "HP"
            '
            'rowLiter
            '
            Me.rowLiter.Name = "rowLiter"
            Me.rowLiter.Properties.Caption = "Liter"
            Me.rowLiter.Properties.FieldName = "Liter"
            '
            'rowCyl
            '
            Me.rowCyl.Name = "rowCyl"
            Me.rowCyl.Properties.Caption = "Cyl"
            Me.rowCyl.Properties.FieldName = "Cyl"
            '
            'rowTransmissSpeedCount
            '
            Me.rowTransmissSpeedCount.Name = "rowTransmissSpeedCount"
            Me.rowTransmissSpeedCount.Properties.Caption = "Transmiss Speed Count"
            Me.rowTransmissSpeedCount.Properties.FieldName = "TransmissSpeedCount"
            '
            'rowTransmissAutomatic
            '
            Me.rowTransmissAutomatic.Name = "rowTransmissAutomatic"
            Me.rowTransmissAutomatic.Properties.Caption = "Transmiss Automatic"
            Me.rowTransmissAutomatic.Properties.FieldName = "TransmissAutomatic"
            '
            'rowMPG_City
            '
            Me.rowMPG_City.Name = "rowMPG_City"
            Me.rowMPG_City.Properties.Caption = "MPG_City"
            Me.rowMPG_City.Properties.FieldName = "MPG_City"
            '
            'rowMPG_Highway
            '
            Me.rowMPG_Highway.Name = "rowMPG_Highway"
            Me.rowMPG_Highway.Properties.Caption = "MPG_Highway"
            Me.rowMPG_Highway.Properties.FieldName = "MPG_Highway"
            '
            'rowCategory
            '
            Me.rowCategory.Name = "rowCategory"
            Me.rowCategory.Properties.Caption = "Category"
            Me.rowCategory.Properties.FieldName = "Category"
            '
            'rowPrice
            '
            Me.rowPrice.Name = "rowPrice"
            Me.rowPrice.Properties.Caption = "Price"
            Me.rowPrice.Properties.FieldName = "Price"
            '
            'vGridControl2
            '
            Me.vGridControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.vGridControl2.Location = New System.Drawing.Point(0, 0)
            Me.vGridControl2.Name = "vGridControl2"
            Me.vGridControl2.OptionsBehavior.Editable = False
            Me.vGridControl2.OptionsView.ShowFocusedFrame = False
            Me.vGridControl2.ScrollVisibility = DevExpress.XtraVerticalGrid.ScrollVisibility.Never
            Me.vGridControl2.Size = New System.Drawing.Size(555, 31)
            Me.vGridControl2.TabIndex = 1
            Me.vGridControl2.TabStop = False
            '
            'CarsDBDataSet
            '
            Me.CarsDBDataSet.DataSetName = "CarsDBDataSet"
            Me.CarsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'CarsBindingSource
            '
            Me.CarsBindingSource.DataMember = "Cars"
            Me.CarsBindingSource.DataSource = Me.CarsDBDataSet
            '
            'CarsTableAdapter
            '
            Me.CarsTableAdapter.ClearBeforeFill = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(555, 374)
            Me.Controls.Add(Me.vGridControl1)
            Me.Controls.Add(Me.vGridControl2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.vGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CarsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CarsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
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
		Private rowPrice As DevExpress.XtraVerticalGrid.Rows.EditorRow
        Private vGridControl2 As DevExpress.XtraVerticalGrid.VGridControl
        Friend WithEvents CarsDBDataSet As CarsDBDataSet
        Friend WithEvents CarsBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents CarsTableAdapter As CarsDBDataSetTableAdapters.CarsTableAdapter
    End Class
End Namespace

