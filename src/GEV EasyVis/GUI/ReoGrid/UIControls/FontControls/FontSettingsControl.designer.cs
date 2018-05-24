/*****************************************************************************
 * 
 * ReoGrid - .NET Spreadsheet Control
 * 
 * http://reogrid.net/
 *
 * Font Settings Control Panel - Windows Standard Font Dialog-like control
 * 
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * Author: Jing <lujing at unvell.com>
 *
 * Copyright (c) 2012-2016 Jing <lujing at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

using System.Windows.Forms;
using GEV.EasyVis.GUI.UIControls;

namespace GEV.EasyVis.GUI.UIControls
{
	partial class FontSettingsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.labFont = new System.Windows.Forms.Label();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.labStyle = new System.Windows.Forms.Label();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.labSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.styleList = new System.Windows.Forms.ListBox();
            this.sizeList = new System.Windows.Forms.ListBox();
            this.labColor = new System.Windows.Forms.Label();
            this.sampleGroup = new System.Windows.Forms.GroupBox();
            this.labSample = new System.Windows.Forms.Label();
            this.chkStrikeout = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.fontColor = new GEV.EasyVis.GUI.UIControls.ColorComboBox();
            this.fontList = new GEV.EasyVis.GUI.UIControls.FontListBox();
            this.sampleGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // labFont
            // 
            this.labFont.AutoSize = true;
            this.labFont.Location = new System.Drawing.Point(13, 13);
            this.labFont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFont.Name = "labFont";
            this.labFont.Size = new System.Drawing.Size(36, 17);
            this.labFont.TabIndex = 0;
            this.labFont.Text = "Font";
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(17, 33);
            this.txtFont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(332, 22);
            this.txtFont.TabIndex = 2;
            // 
            // labStyle
            // 
            this.labStyle.AutoSize = true;
            this.labStyle.Location = new System.Drawing.Point(357, 13);
            this.labStyle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStyle.Name = "labStyle";
            this.labStyle.Size = new System.Drawing.Size(39, 17);
            this.labStyle.TabIndex = 0;
            this.labStyle.Text = "Style";
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(361, 33);
            this.txtStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(152, 22);
            this.txtStyle.TabIndex = 2;
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(523, 13);
            this.labSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(35, 17);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(527, 33);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 22);
            this.txtSize.TabIndex = 2;
            // 
            // styleList
            // 
            this.styleList.FormattingEnabled = true;
            this.styleList.ItemHeight = 16;
            this.styleList.Location = new System.Drawing.Point(361, 59);
            this.styleList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.styleList.Name = "styleList";
            this.styleList.Size = new System.Drawing.Size(152, 148);
            this.styleList.TabIndex = 3;
            // 
            // sizeList
            // 
            this.sizeList.FormattingEnabled = true;
            this.sizeList.ItemHeight = 16;
            this.sizeList.Location = new System.Drawing.Point(527, 59);
            this.sizeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizeList.Name = "sizeList";
            this.sizeList.Size = new System.Drawing.Size(100, 148);
            this.sizeList.TabIndex = 4;
            // 
            // labColor
            // 
            this.labColor.Location = new System.Drawing.Point(361, 228);
            this.labColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labColor.Name = "labColor";
            this.labColor.Size = new System.Drawing.Size(76, 28);
            this.labColor.TabIndex = 6;
            this.labColor.Text = "Color:";
            this.labColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sampleGroup
            // 
            this.sampleGroup.Controls.Add(this.labSample);
            this.sampleGroup.Location = new System.Drawing.Point(152, 279);
            this.sampleGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sampleGroup.Name = "sampleGroup";
            this.sampleGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sampleGroup.Size = new System.Drawing.Size(476, 108);
            this.sampleGroup.TabIndex = 7;
            this.sampleGroup.TabStop = false;
            this.sampleGroup.Text = "Sample";
            // 
            // labSample
            // 
            this.labSample.Location = new System.Drawing.Point(8, 23);
            this.labSample.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSample.Name = "labSample";
            this.labSample.Size = new System.Drawing.Size(460, 79);
            this.labSample.TabIndex = 0;
            this.labSample.Text = "ReoGrid サンプル";
            // 
            // chkStrikeout
            // 
            this.chkStrikeout.AutoSize = true;
            this.chkStrikeout.Location = new System.Drawing.Point(21, 279);
            this.chkStrikeout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkStrikeout.Name = "chkStrikeout";
            this.chkStrikeout.Size = new System.Drawing.Size(115, 21);
            this.chkStrikeout.TabIndex = 8;
            this.chkStrikeout.Text = "Strikethrough";
            this.chkStrikeout.UseVisualStyleBackColor = true;
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(21, 307);
            this.chkUnderline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(91, 21);
            this.chkUnderline.TabIndex = 9;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // fontColor
            // 
            this.fontColor.BackColor = System.Drawing.Color.White;
            this.fontColor.CloseOnClick = true;
            this.fontColor.dropdown = false;
            this.fontColor.Location = new System.Drawing.Point(445, 228);
            this.fontColor.Margin = new System.Windows.Forms.Padding(4);
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(183, 28);
            this.fontColor.SolidColor = System.Drawing.Color.Empty;
            this.fontColor.TabIndex = 5;
            this.fontColor.Text = "colorComboBox1";
            // 
            // fontList
            // 
            this.fontList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fontList.FormattingEnabled = true;
            this.fontList.ItemHeight = 26;
            this.fontList.Location = new System.Drawing.Point(17, 59);
            this.fontList.Margin = new System.Windows.Forms.Padding(4);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(332, 160);
            this.fontList.TabIndex = 1;
            // 
            // FontSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkUnderline);
            this.Controls.Add(this.chkStrikeout);
            this.Controls.Add(this.sampleGroup);
            this.Controls.Add(this.labColor);
            this.Controls.Add(this.fontColor);
            this.Controls.Add(this.sizeList);
            this.Controls.Add(this.styleList);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.labSize);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.labStyle);
            this.Controls.Add(this.fontList);
            this.Controls.Add(this.labFont);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FontSettingsControl";
            this.Size = new System.Drawing.Size(638, 398);
            this.sampleGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labFont;
		private FontListBox fontList;
		private System.Windows.Forms.TextBox txtFont;
		private System.Windows.Forms.Label labStyle;
		private System.Windows.Forms.TextBox txtStyle;
		private System.Windows.Forms.Label labSize;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.ListBox styleList;
		private System.Windows.Forms.ListBox sizeList;
		private GEV.EasyVis.GUI.UIControls.ColorComboBox fontColor;
		private System.Windows.Forms.Label labColor;
		private System.Windows.Forms.GroupBox sampleGroup;
		private System.Windows.Forms.CheckBox chkStrikeout;
		private System.Windows.Forms.CheckBox chkUnderline;
		private Label labSample;
	}
}
