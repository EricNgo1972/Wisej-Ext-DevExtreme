﻿namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxToolbar
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxToolbar));
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction19 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction20 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction21 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxToolbar1 = new Wisej.Web.Ext.DevExtreme.dxToolbar();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Toolbar/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxToolbar/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 229);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 148);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxToolbar1);
			this.panel.Size = new System.Drawing.Size(455, 395);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Toolbar/Overview/jQuery/Light" +
    "/";
			// 
			// dxToolbar1
			// 
			this.dxToolbar1.Dock = Wisej.Web.DockStyle.Top;
			this.dxToolbar1.Name = "dxToolbar1";
			this.dxToolbar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxToolbar1.Options"))));
			this.dxToolbar1.Size = new System.Drawing.Size(453, 38);
			this.dxToolbar1.TabIndex = 0;
			this.dxToolbar1.Text = "dxToolbar1";
			widgetFunction19.Name = "click";
			widgetFunction19.Source = "DevExpress.ui.notify(\"clicked!\");";
			widgetFunction20.Name = "itemTemplate";
			widgetFunction20.Source = "return $(\"<div class=\'toolbar-label\'><b>Tom\'s Club</b> Products</div>\");";
			widgetFunction21.Name = "valueChange";
			widgetFunction21.Source = "var args = arguments[0];\r\n\r\nDevExpress.ui.notify(\"item \" + args.value + \" was cli" +
    "cked!\");";
			this.dxToolbar1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction19,
        widgetFunction20,
        widgetFunction21};
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 27;
			this.checkBox1.Text = "Hover State Enabled";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Location = new System.Drawing.Point(28, 80);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 28;
			this.checkBox2.Text = "RTL Enabled";
			// 
			// dxToolbar
			// 
			this.Name = "dxToolbar";
			this.Size = new System.Drawing.Size(864, 585);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxToolbar dxToolbar1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
