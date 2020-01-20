﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxHtmlEditor : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxHtmlEditor()
		{
			InitializeComponent();
		}

		private void dxHtmlEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
