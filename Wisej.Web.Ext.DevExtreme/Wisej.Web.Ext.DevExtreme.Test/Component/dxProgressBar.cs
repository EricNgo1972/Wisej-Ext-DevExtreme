﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxProgressBar : TestBase
	{
		public dxProgressBar()
		{
			InitializeComponent();

			this.dxProgressBar1.Value = 40;
		}

		private void dxProgressBar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxProgressBar1.Options.isValid = this.checkBox1.Checked;
			this.dxProgressBar1.Options.showStatus = this.checkBox2.Checked;
			this.dxProgressBar1.Options.max = this.numericUpDown1.Value;
			this.dxProgressBar1.Options.min = this.numericUpDown2.Value;
			this.dxProgressBar1.Options.value = this.numericUpDown3.Value;

			this.dxProgressBar1.Update();
		}
	}
}
