﻿namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxTileView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTileView));
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxTileView1 = new Wisej.Web.Ext.DevExtreme.dxTileView();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.button1 = new Wisej.Web.Button();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/TileView/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTileView/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 538);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown3, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 457);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxTileView1);
			this.panel.Size = new System.Drawing.Size(787, 538);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/TileView/Basics/jQuery/Light/" +
    "";
			// 
			// dxTileView1
			// 
			this.dxTileView1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxTileView1.CssStyle = ".img { width: 500px; }";
			this.dxTileView1.Location = new System.Drawing.Point(21, 20);
			this.dxTileView1.Name = "dxTileView1";
			this.dxTileView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTileView1.Options"))));
			this.dxTileView1.Size = new System.Drawing.Size(742, 495);
			this.dxTileView1.TabIndex = 0;
			this.dxTileView1.Text = "dxTileView1";
			widgetFunction1.Name = "initFunc";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.dxTileView1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1};
			this.dxTileView1.WidgetTemplates = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetTemplate[0];
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
            "horizontal",
            "vertical"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Direction";
			this.comboBox1.Location = new System.Drawing.Point(28, 312);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(195, 60);
			this.comboBox1.TabIndex = 23;
			this.comboBox1.Text = "horizontal";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.LabelText = "Item Margin";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 102);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown2.TabIndex = 30;
			this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Location = new System.Drawing.Point(28, 35);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 31;
			this.checkBox1.Text = "Show Scrollbar";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.LabelText = "Base Item Height";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 172);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown1.TabIndex = 32;
			this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.LabelText = "Base Item Width";
			this.numericUpDown3.Location = new System.Drawing.Point(28, 242);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(195, 41);
			this.numericUpDown3.TabIndex = 33;
			this.numericUpDown3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 401);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 27);
			this.button1.TabIndex = 34;
			this.button1.Text = "Get Scroll Position";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dxTileView
			// 
			this.Name = "dxTileView";
			this.Size = new System.Drawing.Size(1196, 728);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxTileView dxTileView1;
		private ComboBox comboBox1;
		private NumericUpDown numericUpDown2;
		private Button button1;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox1;
	}
}
