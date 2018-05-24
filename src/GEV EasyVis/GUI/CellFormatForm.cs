using GEV.Layouts;
using GEV.Layouts.Extended.Cairo;
using GEV.Layouts.Extended.Cairo.Actions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace GEV.EasyVis.GUI
{
	internal interface IPropertyPage
	{
        CairoSpreadsheet Grid { get; set; }
		void LoadPage();
		WorksheetReusableAction CreateUpdateAction();
		event EventHandler Done;
	}

	public partial class CellFormatForm : GCLForm
	{
		private CairoSpreadsheet grid;

		public CairoSpreadsheet Grid
		{
			get { return grid; }
			set { SetGrid(value); }
		}

		private static int lastTabPageIndex = 0;

		public CellFormatForm() : this(null) { }

		public CellFormatForm(CairoSpreadsheet grid)
		{
			this.grid = grid;
			
			InitializeComponent();

			SetupUILanguage();

			numberPage.Done += new EventHandler(IPropertyPage_Done);
			
			tabControl1.SelectedIndex = lastTabPageIndex;
		}

		void SetupUILanguage()
		{
			//this.Text = LangResource.FormatPage_Caption;

			//this.tabFormat.Text = LangResource.Format;
			//this.tabAlignment.Text = LangResource.Alignment;
			//this.tabBorder.Text = LangResource.Border;
			//this.tabFill.Text = LangResource.Fill;
			//this.tabProtection.Text = LangResource.Protection;

			//this.btnOK.Text = LangResource.Btn_OK;
			//this.btnCancel.Text = LangResource.Btn_Cancel;
		}

		void IPropertyPage_Done(object sender, EventArgs e)
		{
			btnOK.PerformClick();
		}

		protected override void OnCreateControl()
		{
			base.OnCreateControl();

			if (grid != null)
			{
				SetGrid(grid);
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			Point p = new Point();
			unvell.Common.Win32Lib.Win32.GetCursorPos(ref p);

			this.Left = p.X - (Width / 2);
			this.Top = p.Y - (Height / 2);

			if (this.Left < 0) this.Left = 0;
			if (this.Top < 0) this.Top = 0;
		}

		public void SetGrid(CairoSpreadsheet grid)
		{
			var sheet = this.grid.CurrentWorksheet;

			var cell = (grid == null) ? null : (sheet.GetCell(sheet.SelectionRange.StartPos));

			this.ProcessAllPages(p =>
			{
				p.Grid = grid;
				p.LoadPage();
			});
		}

		private void ProcessAllPages(Action<IPropertyPage> handler)
		{
			for (int i = 0; i < tabControl1.TabPages.Count; i++)
			{
				foreach (Control ctrl in tabControl1.TabPages[i].Controls)
				{
					if (ctrl is IPropertyPage)
					{
						handler((IPropertyPage)ctrl);
					}
				}
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (grid != null)
			{
				var actionGroup = new WorksheetReusableActionGroup(grid.CurrentWorksheet.SelectionRange);

				this.ProcessAllPages(p =>
				{
					WorksheetReusableAction action = p.CreateUpdateAction();
					if (action != null) actionGroup.Actions.Add(action);
				});

				grid.DoAction(actionGroup);
			}

			Close();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			lastTabPageIndex = tabControl1.SelectedIndex;
		}
	}
}
