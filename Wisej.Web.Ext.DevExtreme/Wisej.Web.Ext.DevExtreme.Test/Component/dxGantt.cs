﻿using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxGantt : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxGantt()
		{
			InitializeComponent();

			this.dxGantt1.Options.tasks.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/tasks.json")));
			this.dxGantt1.Options.dependencies.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/dependencies.json")));
			this.dxGantt1.Options.resources.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/resources.json")));
			this.dxGantt1.Options.resourceAssignments.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/Gantt/resourceAssignments.json")));

			this.dxGantt1.Widget.selectionChanged += new WidgetEventHandler(dxGantt1_WidgetEvent);
		}

		private void dxGantt1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
