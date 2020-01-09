﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxDataGrid : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxDataGrid()
		{
			InitializeComponent();

			this.dxDataGrid1.Widget.cellClick += new WidgetEventHandler(dxDataGrid1_WidgetEvent);
		}

		private void dxDataGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}