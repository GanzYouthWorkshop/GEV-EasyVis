/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * http://reogrid.net/
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * ReoGrid and ReoGridEditor is released under MIT license.
 *
 * Copyright (c) 2012-2016 Jing <lujing at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

using GEV.Layouts;
using unvell.ReoGrid.PropertyPages;

namespace GEV.EasyVis.GUI
{
	partial class CellFormatForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tabControl1 = new GEV.Layouts.GCLTabControl();
            this.tabFormat = new System.Windows.Forms.TabPage();
            this.numberPage = new unvell.ReoGrid.PropertyPages.FormatPage();
            this.tabAlignment = new System.Windows.Forms.TabPage();
            this.alignmentPage1 = new GEV.EasyVis.GUI.PropertyPages.AlignmentPage();
            this.tabBorder = new System.Windows.Forms.TabPage();
            this.borderPage = new unvell.ReoGrid.PropertyPages.BorderPropertyPage();
            this.tabFill = new System.Windows.Forms.TabPage();
            this.fillPage1 = new unvell.ReoGrid.PropertyPages.FillPage();
            this.btnCancel = new GEV.Layouts.GCLButton();
            this.btnOK = new GEV.Layouts.GCLButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gclWindowHeader1 = new GEV.Layouts.GCLWindowHeader();
            this.tabControl1.SuspendLayout();
            this.tabFormat.SuspendLayout();
            this.tabAlignment.SuspendLayout();
            this.tabBorder.SuspendLayout();
            this.tabFill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(87)))));
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabFormat);
            this.tabControl1.Controls.Add(this.tabAlignment);
            this.tabControl1.Controls.Add(this.tabBorder);
            this.tabControl1.Controls.Add(this.tabFill);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.MenuColor = System.Drawing.Color.White;
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabControl1.Size = new System.Drawing.Size(775, 436);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabHandlerVisible = true;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tabControl1.UseFormTheming = true;
            this.tabControl1.UseThemeColors = true;
            // 
            // tabFormat
            // 
            this.tabFormat.Controls.Add(this.numberPage);
            this.tabFormat.Location = new System.Drawing.Point(120, -3);
            this.tabFormat.Name = "tabFormat";
            this.tabFormat.Size = new System.Drawing.Size(658, 442);
            this.tabFormat.TabIndex = 1;
            this.tabFormat.Text = "Format";
            this.tabFormat.UseVisualStyleBackColor = true;
            // 
            // numberPage
            // 
            this.numberPage.BackColor = System.Drawing.Color.Gainsboro;
            this.numberPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberPage.Grid = null;
            this.numberPage.Location = new System.Drawing.Point(0, 0);
            this.numberPage.Margin = new System.Windows.Forms.Padding(4);
            this.numberPage.Name = "numberPage";
            this.numberPage.Size = new System.Drawing.Size(658, 442);
            this.numberPage.TabIndex = 0;
            // 
            // tabAlignment
            // 
            this.tabAlignment.Controls.Add(this.alignmentPage1);
            this.tabAlignment.Location = new System.Drawing.Point(120, -3);
            this.tabAlignment.Name = "tabAlignment";
            this.tabAlignment.Size = new System.Drawing.Size(658, 442);
            this.tabAlignment.TabIndex = 3;
            this.tabAlignment.Text = "Alignment";
            this.tabAlignment.UseVisualStyleBackColor = true;
            // 
            // alignmentPage1
            // 
            this.alignmentPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.alignmentPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alignmentPage1.Grid = null;
            this.alignmentPage1.Location = new System.Drawing.Point(0, 0);
            this.alignmentPage1.Margin = new System.Windows.Forms.Padding(4);
            this.alignmentPage1.Name = "alignmentPage1";
            this.alignmentPage1.Size = new System.Drawing.Size(658, 442);
            this.alignmentPage1.TabIndex = 0;
            // 
            // tabBorder
            // 
            this.tabBorder.Controls.Add(this.borderPage);
            this.tabBorder.Location = new System.Drawing.Point(120, -3);
            this.tabBorder.Name = "tabBorder";
            this.tabBorder.Size = new System.Drawing.Size(658, 442);
            this.tabBorder.TabIndex = 0;
            this.tabBorder.Text = "Border";
            this.tabBorder.UseVisualStyleBackColor = true;
            // 
            // borderPage
            // 
            this.borderPage.BackColor = System.Drawing.Color.Gainsboro;
            this.borderPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPage.Grid = null;
            this.borderPage.Location = new System.Drawing.Point(0, 0);
            this.borderPage.Margin = new System.Windows.Forms.Padding(4);
            this.borderPage.Name = "borderPage";
            this.borderPage.Size = new System.Drawing.Size(658, 442);
            this.borderPage.TabIndex = 0;
            // 
            // tabFill
            // 
            this.tabFill.Controls.Add(this.fillPage1);
            this.tabFill.Location = new System.Drawing.Point(120, -3);
            this.tabFill.Name = "tabFill";
            this.tabFill.Padding = new System.Windows.Forms.Padding(3);
            this.tabFill.Size = new System.Drawing.Size(658, 442);
            this.tabFill.TabIndex = 2;
            this.tabFill.Text = "Fill";
            this.tabFill.UseVisualStyleBackColor = true;
            // 
            // fillPage1
            // 
            this.fillPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.fillPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPage1.Grid = null;
            this.fillPage1.Location = new System.Drawing.Point(3, 3);
            this.fillPage1.Margin = new System.Windows.Forms.Padding(4);
            this.fillPage1.Name = "fillPage1";
            this.fillPage1.Size = new System.Drawing.Size(652, 436);
            this.fillPage1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Checked = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnCancel.Location = new System.Drawing.Point(693, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseThemeColors = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.Checked = false;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnOK.Location = new System.Drawing.Point(605, 7);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseThemeColors = true;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 7, 2, 0);
            this.panel1.Size = new System.Drawing.Size(775, 30);
            this.panel1.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(685, 7);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 23);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // gclWindowHeader1
            // 
            this.gclWindowHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.gclWindowHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gclWindowHeader1.Location = new System.Drawing.Point(0, 0);
            this.gclWindowHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.gclWindowHeader1.Name = "gclWindowHeader1";
            this.gclWindowHeader1.ShowCloseButton = true;
            this.gclWindowHeader1.ShowWindowButtons = false;
            this.gclWindowHeader1.Size = new System.Drawing.Size(775, 40);
            this.gclWindowHeader1.TabIndex = 3;
            this.gclWindowHeader1.Title = "Cella formázása";
            // 
            // CellFormatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(775, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gclWindowHeader1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellFormatForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowInTaskbar = false;
            this.Text = "Cella formázása";
            this.tabControl1.ResumeLayout(false);
            this.tabFormat.ResumeLayout(false);
            this.tabAlignment.ResumeLayout(false);
            this.tabBorder.ResumeLayout(false);
            this.tabFill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TabPage tabBorder;
		private BorderPropertyPage borderPage;
		private System.Windows.Forms.TabPage tabFormat;
		private FormatPage numberPage;
		private System.Windows.Forms.TabPage tabFill;
		private FillPage fillPage1;
		private System.Windows.Forms.TabPage tabAlignment;
		private GEV.EasyVis.GUI.PropertyPages.AlignmentPage alignmentPage1;
        private GEV.Layouts.GCLWindowHeader gclWindowHeader1;
        private GEV.Layouts.GCLTabControl tabControl1;
        private GEV.Layouts.GCLButton btnCancel;
        private GEV.Layouts.GCLButton btnOK;
    }
}