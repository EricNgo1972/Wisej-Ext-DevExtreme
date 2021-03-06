﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxList : TestBase
	{
		public dxList()
		{
			InitializeComponent();

			this.dxList1.Instance.itemClick += new WidgetEventHandler(dxList1_WidgetEvent);
			this.dxList1.Instance.pullRefresh += new WidgetEventHandler(dxList1_WidgetEvent);
		}

		private void dxList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxList1.Options.searchMode = this.comboBox1.SelectedItem;
			this.dxList1.Options.selectionMode = this.comboBox2.SelectedItem;
			this.dxList1.Options.itemDeleteMode = this.comboBox3.SelectedItem;
			this.dxList1.Options.searchEnabled = this.checkBox1.Checked;
			this.dxList1.Options.bounceEnabled = this.checkBox2.Checked;
			this.dxList1.Options.pullRefreshEnabled = this.checkBox3.Checked;
			this.dxList1.Options.repaintChangesOnly = this.checkBox4.Checked;
			this.dxList1.Options.showSelectionControls = this.checkBox5.Checked;

			this.dxList1.Update();
		}
	}
}
