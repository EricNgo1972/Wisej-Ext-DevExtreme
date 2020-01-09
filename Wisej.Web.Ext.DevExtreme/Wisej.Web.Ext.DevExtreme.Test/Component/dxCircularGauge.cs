﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxCircularGauge : TestBase
	{
		public dxCircularGauge()
		{
			InitializeComponent();
		}

		private void dxCircularGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{

		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxCircularGauge1.Value = (int)this.numericUpDown1.Value;
			this.dxCircularGauge1.Options.scale.label.visible = this.checkBox1.Checked;
			this.dxCircularGauge1.Options.scale.tickInterval = this.trackBar1.Value;

			this.dxCircularGauge1.Update();
		}

		private void dxCircularGauge_Load(object sender, EventArgs e)
		{
			this.dxCircularGauge1.Options.containerBackgroundColor = "blue";

			this.dxCircularGauge1.Options.rangeContainer.ranges = buildRanges();
			this.dxCircularGauge1.Update();
		}

		private object buildRanges()
		{

			var ranges = new object[] {
				new { startValue = 50, endValue = 90 },
				new { startValue = 90, endValue = 130 },
				new { startValue = 130, endValue = 150 }
			};

			return ranges;
		}
	}
}