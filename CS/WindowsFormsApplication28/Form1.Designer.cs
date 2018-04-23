namespace WindowsFormsApplication28
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
			this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carsDBDataSet = new WindowsFormsApplication28.CarsDBDataSet();
			this.rowID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowTrademark = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowModel = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowHP = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowLiter = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowCyl = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowTransmissSpeedCount = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowTransmissAutomatic = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowMPG_City = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowMPG_Highway = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowCategory = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowDescription = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowHyperlink = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowPrice = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.carsTableAdapter = new WindowsFormsApplication28.CarsDBDataSetTableAdapters.CarsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// vGridControl1
			// 
			this.vGridControl1.DataSource = this.carsBindingSource;
			this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vGridControl1.Location = new System.Drawing.Point(0, 0);
			this.vGridControl1.Name = "vGridControl1";
			this.vGridControl1.RecordWidth = 131;
			this.vGridControl1.RowHeaderWidth = 133;
			this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowID,
            this.rowTrademark,
            this.rowModel,
            this.rowHP,
            this.rowLiter,
            this.rowCyl,
            this.rowTransmissSpeedCount,
            this.rowTransmissAutomatic,
            this.rowMPG_City,
            this.rowMPG_Highway,
            this.rowCategory,
            this.rowDescription,
            this.rowHyperlink,
            this.rowPrice,
            this.editorRow1});
			this.vGridControl1.Size = new System.Drawing.Size(376, 288);
			this.vGridControl1.TabIndex = 0;
			this.vGridControl1.CustomUnboundData += new DevExpress.XtraVerticalGrid.Events.CustomDataEventHandler(this.vGridControl1_CustomUnboundData);
			// 
			// carsBindingSource
			// 
			this.carsBindingSource.DataMember = "Cars";
			this.carsBindingSource.DataSource = this.carsDBDataSet;
			// 
			// carsDBDataSet
			// 
			this.carsDBDataSet.DataSetName = "CarsDBDataSet";
			this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// rowID
			// 
			this.rowID.Name = "rowID";
			this.rowID.Properties.Caption = "ID";
			this.rowID.Properties.FieldName = "ID";
			// 
			// rowTrademark
			// 
			this.rowTrademark.Name = "rowTrademark";
			this.rowTrademark.Properties.Caption = "Trademark";
			this.rowTrademark.Properties.FieldName = "Trademark";
			// 
			// rowModel
			// 
			this.rowModel.Name = "rowModel";
			this.rowModel.Properties.Caption = "Model";
			this.rowModel.Properties.FieldName = "Model";
			// 
			// rowHP
			// 
			this.rowHP.Name = "rowHP";
			this.rowHP.Properties.Caption = "HP";
			this.rowHP.Properties.FieldName = "HP";
			// 
			// rowLiter
			// 
			this.rowLiter.Name = "rowLiter";
			this.rowLiter.Properties.Caption = "Liter";
			this.rowLiter.Properties.FieldName = "Liter";
			// 
			// rowCyl
			// 
			this.rowCyl.Name = "rowCyl";
			this.rowCyl.Properties.Caption = "Cyl";
			this.rowCyl.Properties.FieldName = "Cyl";
			// 
			// rowTransmissSpeedCount
			// 
			this.rowTransmissSpeedCount.Name = "rowTransmissSpeedCount";
			this.rowTransmissSpeedCount.Properties.Caption = "Transmiss Speed Count";
			this.rowTransmissSpeedCount.Properties.FieldName = "TransmissSpeedCount";
			// 
			// rowTransmissAutomatic
			// 
			this.rowTransmissAutomatic.Name = "rowTransmissAutomatic";
			this.rowTransmissAutomatic.Properties.Caption = "Transmiss Automatic";
			this.rowTransmissAutomatic.Properties.FieldName = "TransmissAutomatic";
			// 
			// rowMPG_City
			// 
			this.rowMPG_City.Name = "rowMPG_City";
			this.rowMPG_City.Properties.Caption = "MPG_City";
			this.rowMPG_City.Properties.FieldName = "MPG_City";
			// 
			// rowMPG_Highway
			// 
			this.rowMPG_Highway.Name = "rowMPG_Highway";
			this.rowMPG_Highway.Properties.Caption = "MPG_Highway";
			this.rowMPG_Highway.Properties.FieldName = "MPG_Highway";
			// 
			// rowCategory
			// 
			this.rowCategory.Name = "rowCategory";
			this.rowCategory.Properties.Caption = "Category";
			this.rowCategory.Properties.FieldName = "Category";
			// 
			// rowDescription
			// 
			this.rowDescription.Name = "rowDescription";
			this.rowDescription.Properties.Caption = "Description";
			this.rowDescription.Properties.FieldName = "Description";
			// 
			// rowHyperlink
			// 
			this.rowHyperlink.Name = "rowHyperlink";
			this.rowHyperlink.Properties.Caption = "Hyperlink";
			this.rowHyperlink.Properties.FieldName = "Hyperlink";
			// 
			// rowPrice
			// 
			this.rowPrice.Name = "rowPrice";
			this.rowPrice.Properties.Caption = "Price";
			this.rowPrice.Properties.FieldName = "Price";
			// 
			// editorRow1
			// 
			this.editorRow1.Fixed = DevExpress.XtraVerticalGrid.Rows.FixedStyle.Top;
			this.editorRow1.InternalFixed = DevExpress.XtraVerticalGrid.Rows.FixedStyle.Top;
			this.editorRow1.Name = "editorRow1";
			this.editorRow1.Properties.FieldName = "editorRow10";
			this.editorRow1.Properties.UnboundType = DevExpress.Data.UnboundColumnType.String;
			// 
			// carsTableAdapter
			// 
			this.carsTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 288);
			this.Controls.Add(this.vGridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
		private CarsDBDataSet carsDBDataSet;
		private System.Windows.Forms.BindingSource carsBindingSource;
		private WindowsFormsApplication28.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowID;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTrademark;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowModel;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHP;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowLiter;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCyl;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmissSpeedCount;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTransmissAutomatic;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMPG_City;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowMPG_Highway;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCategory;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDescription;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowHyperlink;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPrice;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
	}
}

