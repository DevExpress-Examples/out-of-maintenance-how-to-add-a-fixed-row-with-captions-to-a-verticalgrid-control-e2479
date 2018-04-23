using System;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Events;

namespace WindowsFormsApplication28
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
		}

		private void vGridControl1_CustomUnboundData(object sender, CustomDataEventArgs e)
		{
			if ( e.Row != editorRow1 )
				return;

			if ( e.IsGetData )
				e.Value = "Caption " + e.ListSourceRowIndex;
		}
	}
}
