﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxDateBox : TestBase
	{
		public dxDateBox()
		{
			InitializeComponent();

			this.dxDateBox1.Value = "2020-01-01";

			this.dxDateBox1.Instance.valueChanged += new WidgetEventHandler(dxDateBox1_WidgetEvent);
		}

		private void dxDateBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxDateBox1.Options.acceptCustomValue = this.checkBox1.Checked;
			this.dxDateBox1.Options.activeStateEnabled = this.checkBox2.Checked;
			this.dxDateBox1.Options.adaptivityEnabled = this.checkBox3.Checked;
			this.dxDateBox1.Options.showAnalogClock = this.checkBox4.Checked;
			this.dxDateBox1.Options.type = this.comboBox2.SelectedItem;
			this.dxDateBox1.Options.stylingMode = this.comboBox1.SelectedItem;

			this.dxDateBox1.Update();
		}
	}
}
