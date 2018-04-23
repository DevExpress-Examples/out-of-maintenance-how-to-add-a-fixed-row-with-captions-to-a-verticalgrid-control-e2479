using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;

namespace VGridColumnHeaders
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);

			vGridControl1.RowHeaderWidthChanged += new EventHandler(OnRowHeaderWidthChanged);
			vGridControl2.RowHeaderWidthChanged += new EventHandler(OnRowHeaderWidthChanged);
			vGridControl1.RecordWidthChanged += new EventHandler(OnRecordWidthChanged);
			vGridControl2.RecordWidthChanged += new EventHandler(OnRecordWidthChanged);

			Rectangle vridClientBounds = vGridControl1.ViewInfo.GetClientRect(vGridControl1.Bounds);
			int borderHeight = vridClientBounds.Y - vGridControl1.Bounds.Y;

			string[] captions = new string[vGridControl1.RecordCount];
			for ( int i = 0; i < vGridControl1.RecordCount; i++ )
				captions[i] = "Caption " + i.ToString();

			vGridControl2.DataSource = captions;
			vGridControl2.Height = vGridControl2.ViewInfo.GetVisibleRowHeight(vGridControl2.Rows[0]) + borderHeight * 3;
			vGridControl2.Rows[0].Properties.Caption = "";
			vGridControl2.Appearance.FocusedRow.Assign(vGridControl1.ViewInfo.PaintAppearance.RowHeaderPanel);
			vGridControl2.Appearance.HideSelectionRow.Assign(vGridControl1.ViewInfo.PaintAppearance.RowHeaderPanel);
			vGridControl2.Appearance.ReadOnlyRecordValue.Assign(vGridControl1.ViewInfo.PaintAppearance.RowHeaderPanel);

			FindHScroll(vGridControl1);
			FindHScroll(vGridControl2);
		}

		private void FindHScroll(VGridControl vGrid)
		{
			foreach ( Control control in vGrid.Controls )
				if ( control is VGridHorzScrollBar )
				{
					((VGridHorzScrollBar)control).ValueChanged += new EventHandler(OnHScrollValueChanged);
					return;
				}
		}

		private void OnHScrollValueChanged(object sender, EventArgs e)
		{
			VGridHorzScrollBar hScroll = (VGridHorzScrollBar)sender;
			if ( hScroll.Parent == vGridControl1 )
				vGridControl2.LeftVisibleRecord = vGridControl1.LeftVisibleRecord;
			else
				vGridControl2.LeftVisibleRecord = vGridControl1.LeftVisibleRecord;
		}

		private void OnRowHeaderWidthChanged(object sender, EventArgs e)
		{
			VGridControl sendControl = (VGridControl)sender;
			if ( sendControl == vGridControl1 )
				vGridControl2.RowHeaderWidth = vGridControl1.RowHeaderWidth;
			else
				vGridControl1.RowHeaderWidth = vGridControl2.RowHeaderWidth;
		}

		private void OnRecordWidthChanged(object sender, EventArgs e)
		{
			VGridControl sendControl = (VGridControl)sender;
			if ( sendControl == vGridControl1 )
				vGridControl2.RecordWidth = vGridControl1.RecordWidth;
			else
				vGridControl1.RecordWidth = vGridControl2.RecordWidth;
		}
	}
}
