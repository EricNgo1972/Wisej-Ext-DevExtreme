﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxForm : TestBase
	{
		public dxForm()
		{
			InitializeComponent();

			this.dxForm1.Instance.fieldDataChanged += new WidgetEventHandler(dxForm1_WidgetEvent);
		}

		private void dxForm1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxForm1.Options.labelLocation = this.comboBox1.Text.ToLower();
			this.dxForm1.Options.showOptionalMark = this.checkBox1.Checked;
			this.dxForm1.Options.showRequiredMark = this.checkBox2.Checked;
			this.dxForm1.Options.scrollingEnabled = this.checkBox3.Checked;
			this.dxForm1.Options.showValidationSummary = this.checkBox4.Checked;

			this.dxForm1.Update();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.dxForm1.Instance.resetValues();
		}
	}
}
