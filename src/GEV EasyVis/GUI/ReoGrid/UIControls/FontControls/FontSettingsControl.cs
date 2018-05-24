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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using unvell.Common;
using GEV.EasyVis.GUI.UIControls;

namespace GEV.EasyVis.GUI.UIControls
{
	public partial class FontSettingsControl : UserControl
	{
		private bool updateUI = false;
		private bool noRaiseEvent = false;
	
		public FontSettingsControl()
		{
			InitializeComponent();

			ShowColorPicker = true;

			sizeList.Items.AddRange(FontUIToolkit.FontSizeList.Select(f => (object)f).ToArray());
		}

		private void SetFontNameByString(string fontName)
		{
		}

		private void SetFontStyleByStyle(FontStyle style)
		{
			//txtStyle.Text = FontUIToolkit.GetFontStyleName(style, "Regular", "Italic", "Bold");
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (fontList.SelectedIndex == -1)
			{
				SelectedFont = new FontInfo(SystemFonts.DefaultFont);
			}
		}
	

		private FontInfo selectedFont;

		public FontInfo SelectedFont
		{
			get
			{
				return selectedFont;
			}
			set
			{
				if (selectedFont != value)
				{
					selectedFont = value;

					noRaiseEvent = true;

					txtFont.Text = selectedFont.Name;
					SetFontNameByString(selectedFont.Name);
					SetFontStyleByStyle(selectedFont.Style);
					txtSize.Text = selectedFont.Size.ToString();
					for (int i = 0; i < sizeList.Items.Count; i++)
					{
						if (((float)sizeList.Items[i]) == selectedFont.Size)
						{
							sizeList.SelectedIndex = i;
							break;
						}
					}

					noRaiseEvent = false;
				}
			}
		}

		private void UpdateFontStyle()
		{
			chkStrikeout.Checked = (selectedFont.Style & FontStyle.Strikeout) == FontStyle.Strikeout;
			chkUnderline.Checked = (selectedFont.Style & FontStyle.Underline) == FontStyle.Underline;

			styleList.Items.Clear();

			if (string.IsNullOrEmpty(selectedFont.Name))
			{
				styleList.Enabled = false;
			}
			else
			{
				styleList.Enabled = true;

				using (FontFamily ff = new FontFamily(selectedFont.Name))
				{
					if (ff.IsStyleAvailable(FontStyle.Regular))
						styleList.Items.Add("Regular");

					if (ff.IsStyleAvailable(FontStyle.Italic))
						styleList.Items.Add("Italic");

					if (ff.IsStyleAvailable(FontStyle.Bold))
						styleList.Items.Add("Bold");

					if (ff.IsStyleAvailable(FontStyle.Bold | FontStyle.Italic))
						styleList.Items.Add("Bold Italic");

					chkStrikeout.Enabled = ff.IsStyleAvailable(FontStyle.Strikeout);
					if (!chkStrikeout.Enabled) chkStrikeout.Checked = false;

					chkUnderline.Enabled = ff.IsStyleAvailable(FontStyle.Underline);
					if (!chkUnderline.Enabled) chkUnderline.Checked = false;

					int foundOldStyle = -1;
					for (int i = 0; i < styleList.Items.Count; i++)
					{
						string text = Convert.ToString(styleList.Items[i]);
						FontStyle fs = FontUIToolkit.GetFontStyleByName(text,
							"italic", "bold");
						if (fs == SelectedFont.Style)
						{
							styleList.SelectedIndex = foundOldStyle = i;
							break;
						}
					}

					if (foundOldStyle == -1 && styleList.Items.Count > 0)
					{
						styleList.SelectedIndex = 0;
						selectedFont.Style = FontUIToolkit.GetFontStyleByName(Convert.ToString(styleList.Items[0]),
							"italic", "bold");

						if (chkUnderline.Checked) selectedFont.Style |= FontStyle.Underline;
						if (chkStrikeout.Checked) selectedFont.Style |= FontStyle.Strikeout;
					}
				}
			}

			txtStyle.Text = FontUIToolkit.GetFontStyleName(selectedFont.Style,
							"Regular", "Italic", "Bold");

			labSample.Invalidate();
		}

		public void RaiseFontNameChanged()
		{
			if (!noRaiseEvent)
			{
				if (SelectedFontNameChanged != null) SelectedFontNameChanged(this, null);
				RaiseSelectedFontChanged();
			}
		}
		public void RaiseFontSizeChanged()
		{
			if (!noRaiseEvent)
			{
				if (SelectedFontSizeChanged != null) SelectedFontSizeChanged(this, null);
				RaiseSelectedFontChanged();
			}
		}
		public void RaiseFontStyleChanged()
		{
			if (!noRaiseEvent)
			{
				if (SelectedFontStyleChanged != null) SelectedFontStyleChanged(this, null);
				RaiseSelectedFontChanged();
			}
		}
		public void RaiseSelectedFontChanged()
		{
			if (!noRaiseEvent)
			{
				if (SelectedFontChanged != null) SelectedFontChanged(this, null);
			}
		}

		public event EventHandler SelectedFontChanged;
		public event EventHandler SelectedFontNameChanged;
		public event EventHandler SelectedFontSizeChanged;
		public event EventHandler SelectedFontStyleChanged;
		public event EventHandler SelectedFontColorChanged;

		public bool ShowColorPicker
		{
			get
			{
				return fontColor.Visible;
			}
			set
			{
				labColor.Visible = fontColor.Visible = value;
			}
		}

		public Color FontColor
		{
			set
			{
				fontColor.SolidColor = value;
			}
			get
			{
				return fontColor.SolidColor;
			}
		}
	}
}
