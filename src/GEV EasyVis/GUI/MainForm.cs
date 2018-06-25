using GEV.EasyVis.DeviceHandlers;
using GEV.EasyVis.GUI;
using GEV.EasyVis.GUI.Cairo;
using GEV.Layouts;
using GEV.Layouts.Extended.Cairo;
using GEV.Layouts.Extended.Cairo.Actions;
using GEV.Layouts.Extended.Cairo.CellTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid.PropertyPages;

namespace GEV.EasyVis
{
    public partial class MainForm : GCLForm
    {
        private Worksheet m_CurrentWorkSheet;
        private bool m_UIUpdating = false;
        private bool m_TestMode = false;
        private bool m_MenuShow = true;

        public MainForm()
        {
            InitializeComponent();

            CairoExtensions.Setup();

            this.cspTable.CurrentWorksheetChanged += OnWorkSheetChanged;
            this.m_CurrentWorkSheet = this.cspTable.CurrentWorksheet;
            this.m_CurrentWorkSheet.BeforeSelectionRangeChange += OnSelectionChanging; ;
            this.m_CurrentWorkSheet.SelectionRangeChanged += OnSelectionChanged;

            this.m_CurrentWorkSheet.CellDataChanged += OnCellDataChanged;

            VisionSystem.Project = new Project();
            VisionSystem.Project.Devices.Add(new InsightSensor("192.168.90.215", "admin", ""));
            VisionSystem.Project.Devices[0].Name = "test";
            VisionSystem.Project.Devices[0].Connect();
            (VisionSystem.Project.Devices[0] as InsightSensor).ResultsChanged += MainForm_ResultsChanged;
        }

        private void MainForm_ResultsChanged(object sender, EventArgs e)
        {
            this.cspTable.CurrentWorksheet.IterateCells((row, col, cell) =>
            {
                if (cell.Formula != null && cell.Formula.Contains("INSIGHT("))
                {
                    string f = cell.Formula;
                    cell.Formula = "";
                    cell.Formula = f;
                }
                return true;
            });
        }

        #region Spreadsheetselection related events
        private void OnSelectionChanging(object sender, Layouts.Extended.Cairo.Events.BeforeSelectionChangeEventArgs e)
        {
            Worksheet w = this.m_CurrentWorkSheet;
            w.Cells[w.SelectionRange.StartPos].TraceFormulaPrecedents = false;
            w.Cells[w.SelectionRange.StartPos].TraceFormulaDependents = false;
        }

        private void OnCellDataChanged(object sender, Layouts.Extended.Cairo.Events.CellEventArgs e)
        {
            Worksheet w = this.m_CurrentWorkSheet;
            if (w.SelectionRange.IsSingleCell && e.Cell == w.Cells[w.SelectionRange.StartPos])
            {
                e.Cell.TraceFormulaPrecedents = this.chkShowTrace.Checked;
                e.Cell.TraceFormulaDependents = this.chkShowTrace.Checked;
            }
        }

        private void OnSelectionChanged(object sender, Layouts.Extended.Cairo.Events.RangeEventArgs e)
        {
            this.m_UIUpdating = true;
            WorksheetRangeStyle style = this.m_CurrentWorkSheet.GetRangeStyles(this.m_CurrentWorkSheet.SelectionRange);

            this.chkBold.Checked = style.Bold;
            this.chkItalic.Checked = style.Italic;
            this.chkUnderline.Checked = style.Underline;

            this.chkAlignLeft.Checked = style.HAlign == ReoGridHorAlign.Left;
            this.chkAlignCenter.Checked = style.HAlign == ReoGridHorAlign.Center;
            this.chkAlignRight.Checked = style.HAlign == ReoGridHorAlign.Right;
            this.chkAlignJustified.Checked = style.HAlign == ReoGridHorAlign.DistributedIndent;
            this.chkAlignTop.Checked = style.VAlign == ReoGridVerAlign.Top;
            this.chkAlignMiddle.Checked = style.VAlign == ReoGridVerAlign.Middle;
            this.chkAlignBottom.Checked = style.VAlign == ReoGridVerAlign.Bottom;

            this.chkMerge.Checked = !this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.m_CurrentWorkSheet.IsMergedCell(this.m_CurrentWorkSheet.SelectionRange.StartPos);

            this.cbxFont.SelectedItem = this.cbxFont.Items.Cast<FontFamily>().FirstOrDefault(f => f.Name == style.FontName);
            this.cbxFontSize.SelectedItem = style.FontSize.ToString();

            this.rdbDataCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(CellBody));
            this.rdbButtonCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(ButtonCell));
            this.rdbCheckboxCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(CheckBoxCell));
            this.rdbDatePickerCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(DatePickerCell));
            this.rdbDropdownCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(DropdownCell));
            this.rdbImageButtonCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(ImageButtonCell));
            this.rdbImageCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(ImageCell));
            this.rdbLinkCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(HyperlinkCell));
            this.rdbProgressbarCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(ProgressCell));
            this.rdbRadioButtonCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(RadioButtonCell));
            this.rdbNegativeProgressBarCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(NegativeProgressCell));
            this.rdbSliderCell.Checked = this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.IsCellType(typeof(SliderCell));

            var cell = this.m_CurrentWorkSheet.Cells[this.m_CurrentWorkSheet.SelectionRange.StartPos];
            if(cell.Formula == null)
            {
                if(cell.Data != null)
                {
                    this.txtFormula.Text = cell.Data.ToString();
                }
                else
                {
                    this.txtFormula.Text = "";
                }
            }
            else
            {
                this.txtFormula.Text = "=" + cell.Formula;
            }

            this.m_CurrentWorkSheet.RemoveAllHighlightRanges();
            if (this.m_CurrentWorkSheet.SelectionRange.IsSingleCell && this.chkShowTrace.Checked)
            {
                this.m_CurrentWorkSheet.TraceCellPrecedents(this.m_CurrentWorkSheet.SelectionRange.StartPos);
                this.m_CurrentWorkSheet.TraceCellDependents(this.m_CurrentWorkSheet.SelectionRange.StartPos);

                List<ReferenceRange> references = this.m_CurrentWorkSheet.GetCellFormulaReferenceRanges(this.m_CurrentWorkSheet.SelectionRange.StartPos);
                if(references != null)
                {
                    foreach (ReferenceRange reference in references)
                    {
                        this.m_CurrentWorkSheet.AddHighlightRange(reference);
                    }
                }
            }

            this.m_UIUpdating = false;
        }

        private void OnWorkSheetChanged(object sender, EventArgs e)
        {
            this.m_CurrentWorkSheet.SelectionRangeChanged -= OnSelectionChanged;
            this.m_CurrentWorkSheet = this.cspTable.CurrentWorksheet;
            this.m_CurrentWorkSheet.SelectionRangeChanged += OnSelectionChanged;
        }
        #endregion

        #region Utility methods
        private void SetRangeStyle(WorksheetRangeStyle style)
        {
            if(!this.m_UIUpdating)
            {
                this.cspTable.DoAction(new SetRangeStyleAction(this.m_CurrentWorkSheet.SelectionRange, style));
            }
        }

        private void SetCellType(Type type)
        {
            if(!this.m_UIUpdating)
            {
                foreach (var cell in this.m_CurrentWorkSheet.Ranges[this.m_CurrentWorkSheet.SelectionRange].Cells)
                {
                    cell.Body = Activator.CreateInstance(type) as ICellBody;
                }
            }
        }

        private bool IsCellType(Type t)
        {
            var cell = this.cspTable.CurrentWorksheet.Cells[this.cspTable.CurrentWorksheet.SelectionRange.StartPos];
            if(cell.Body != null)
            {
                return cell.Body.GetType().IsSubclassOf(t);
            }
            else if(t.Equals(typeof(CellBody)))
            {
                return true;
            }

            return false;
        }
        #endregion

        #region Styling events
        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.FontStyleBold, Bold = this.chkBold.Checked });
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.FontStyleItalic, Italic = this.chkItalic.Checked });
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.FontStyleUnderline, Underline = this.chkUnderline.Checked });
        }

        private void cbxFont_SelectedValueChanged(object sender, EventArgs e)
        {
            string value = (this.cbxFont.SelectedItem as FontFamily).Name;
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.FontName, FontName = value });
        }

        private void cbxFontSize_SelectedValueChanged(object sender, EventArgs e)
        {
            float value = float.Parse(this.cbxFontSize.SelectedValue.ToString());
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.FontSize, FontSize = value });
        }

        private void cpbForeColor_ColorSelected(object sender, EventArgs e)
        {
            Color value = this.cpbForeColor.Color;
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.TextColor, TextColor = value });
        }

        private void cpbBackColor_ColorSelected(object sender, EventArgs e)
        {
            Color value = this.cpbBackColor.Color;
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.BackColor, BackColor = value });
        }

        private void chkAlignLeft_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.HorizontalAlign, HAlign = ReoGridHorAlign.Left });

        }

        private void chkAlignCenter_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.HorizontalAlign, HAlign = ReoGridHorAlign.Center });
        }

        private void chkAlignRight_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.HorizontalAlign, HAlign = ReoGridHorAlign.Right });
        }

        private void chkAlignJustified_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.HorizontalAlign, HAlign = ReoGridHorAlign.DistributedIndent });
        }

        private void chkAlignTop_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.VerticalAlign, VAlign = ReoGridVerAlign.Top });
        }

        private void chkAlignMiddle_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.VerticalAlign, VAlign = ReoGridVerAlign.Middle });
        }

        private void chkAlignBottom_CheckedChanged(object sender, EventArgs e)
        {
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.VerticalAlign, VAlign = ReoGridVerAlign.Bottom });
        }

        private void chkMerge_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.m_UIUpdating)
            {
                if (this.chkMerge.Checked)
                {
                    this.cspTable.DoAction(new MergeRangeAction(this.m_CurrentWorkSheet.SelectionRange));

                }
                else
                {
                    this.cspTable.DoAction(new UnmergeRangeAction(this.m_CurrentWorkSheet.SelectionRange));
                }
            }
        }

        private void btnRotateText_Click(object sender, EventArgs e)
        {
            float angle = this.m_CurrentWorkSheet.Cells[this.m_CurrentWorkSheet.SelectionRange.StartPos].Style.RotationAngle;
            this.SetRangeStyle(new WorksheetRangeStyle() { Flag = PlainStyleFlag.RotationAngle, RotationAngle = angle + 90 });
        }
        #endregion

        private void txtFormula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.cspTable.CurrentWorksheet.Cells[this.cspTable.CurrentWorksheet.SelectionRange.StartPos].Data = this.txtFormula.Text;
            }
        }

        private void lnkFontSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FontSettings fs = new FontSettings();
            if (fs.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void lnkAlignmentSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CellFormatForm fs = new CellFormatForm(this.cspTable);
            if (fs.ShowDialog() == DialogResult.OK)
            {

            }

        }

        #region Developer modes
        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            if(this.m_TestMode)
            {
                this.EndTestMode();
                this.btnShowMenu.Text = "▲";
            }
            else if(this.m_MenuShow)
            {
                this.tabsMenu.Height = 40;
                this.btnShowMenu.Text = "▼";
                this.m_MenuShow = false;
            }
            else
            {
                this.tabsMenu.Height = 175;
                this.btnShowMenu.Text = "▲";
                this.m_MenuShow = true;

            }
        }

        private void btnTestView_Click(object sender, EventArgs e)
        {
            this.tabsMenu.Hide();
            this.gclPanel1.Hide();
            this.cspTable.SetSettings(WorkbookSettings.View_ShowSheetTabControl, false);
            this.cspTable.CurrentWorksheet.SetSettings(WorksheetSettings.View_ShowColumnHeader, false);
            this.cspTable.CurrentWorksheet.SetSettings(WorksheetSettings.View_ShowRowHeader, false);
            this.cspTable.CurrentWorksheet.SetSettings(WorksheetSettings.View_ShowGridLine, false);
            this.cspTable.CurrentWorksheet.SelectionMode = WorksheetSelectionMode.None;
            this.btnShowMenu.Text = "◀";

            this.btnShowMenu.BringToFront();

            this.m_TestMode = true;
        }

        private void EndTestMode()
        {
            this.tabsMenu.Show();
            this.gclPanel1.Show();
            this.cspTable.SetSettings(WorkbookSettings.View_ShowSheetTabControl, true);
            this.cspTable.CurrentWorksheet.SetSettings(WorksheetSettings.View_ShowColumnHeader, true);
            this.cspTable.CurrentWorksheet.SetSettings(WorksheetSettings.View_ShowRowHeader, true);
            this.cspTable.CurrentWorksheet.SetSettings(WorksheetSettings.View_ShowGridLine, true);
            this.cspTable.CurrentWorksheet.SelectionMode = WorksheetSelectionMode.Range;
            this.btnShowMenu.BringToFront();

            this.m_TestMode = false;
        }

        #endregion

        #region Form Cells
        private void rdbDataCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(CellBody));
        }

        private void rdbButtonCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(ButtonCell));
        }

        private void rdbLinkCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(HyperlinkCell));
        }

        private void rdbCheckboxCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(CheckBoxCell));
        }

        private void rdbDropdownCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(DropdownListCell));
        }

        private void rdbRadioButtonCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(RadioButtonCell));
        }

        private void rdbDatePickerCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(DatePickerCell));
        }

        private void rdbProgressbarCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(ProgressCell));
        }

        private void rdbImageCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(ImageCell));
        }

        private void rdbImageButtonCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(ImageButtonCell));
        }

        private void rdbMegativeProgressBarCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(NegativeProgressCell));
        }

        private void rdbSliderCell_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCellType(typeof(SliderCell));
        }
        #endregion

        private void cpbSpecialColor1_ColorSelected(object sender, EventArgs e)
        {
            if (!this.m_UIUpdating)
            {
                if (this.m_CurrentWorkSheet.Cells[this.m_CurrentWorkSheet.SelectionRange.StartPos].Body is IControlCell)
                {
                    (this.m_CurrentWorkSheet.Cells[this.m_CurrentWorkSheet.SelectionRange.StartPos].Body as IControlCell).Color1 = this.cpbSpecialColor1.Color;
                }
            }
        }

        private void cpbSpecialColor2_ColorSelected(object sender, EventArgs e)
        {
            if(!this.m_UIUpdating)
            {
                if(this.m_CurrentWorkSheet.Cells[this.m_CurrentWorkSheet.SelectionRange.StartPos].Body is IControlCell)
                {
                    (this.m_CurrentWorkSheet.Cells[this.m_CurrentWorkSheet.SelectionRange.StartPos].Body as IControlCell).Color2 = this.cpbSpecialColor2.Color;
                }
            }
        }

        private void cpbSpecialColor1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            new InSightEditor(VisionSystem.Project.Devices[0] as InsightSensor).Show();
        }

        private void gclButton1_Click(object sender, EventArgs e)
        {
            (VisionSystem.Project.Devices[0] as InsightSensor).Trigger(); ;

        }
    }
}
