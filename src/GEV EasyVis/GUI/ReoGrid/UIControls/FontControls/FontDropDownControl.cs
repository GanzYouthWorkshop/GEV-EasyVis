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
 * ReoGrid and ReoGridEditor is released under MIT license\.
 *
 * Copyright (c) 2012-2016 Jing <lujing at unvell.com>
 * Copyright (c) 2012-2016 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

using GEV.Layouts;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using unvell.Common;

namespace GEV.EasyVis.GUI.UIControls
{
	public partial class FontDropDownControl : GCLComboBox
	{
		public FontDropDownControl()
		{
			DropDownStyle = ComboBoxStyle.DropDownList;
			DrawMode = DrawMode.OwnerDrawFixed;
			DropDownHeight = 500;
			ItemHeight = 20;
			DrawItem += new DrawItemEventHandler(ComboBox_DrawItem);

			foreach (FontFamily family in FontFamily.Families)
			{
				base.Items.Add(family);
			}

            this.DisplayMember = "Name";
		}

		void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics g = e.Graphics;

			e.DrawBackground();

			if (e.Index >= 0 && e.Index < base.Items.Count)
			{
				FontUIToolkit.DrawFontItem(g, (FontFamily)base.Items[e.Index], e.Bounds,
					(e.State & DrawItemState.Selected) == DrawItemState.Selected);
			}
		}
	}
}
