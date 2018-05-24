using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cairo_Editor.Controls
{
    public partial class ColorPickerButton : UserControl
    {
        [Browsable(true)]
        public event EventHandler ColorSelected;

        public string Symbol
        {
            get { return this.m_Text; }
            set { this.gclButton1.Text = m_Text = value; }
        }
        private string m_Text;

        [Browsable(false)]
        public Color Color { get; set; } = Color.FromArgb(34, 34, 34);

        internal ColorPickerControl ColorPicker { get; set; } = new ColorPickerControl();

        public ColorPickerButton()
        {
            InitializeComponent();

            this.ColorPicker.ColorSelected += ColorPicker_ColorSelected;
        }

        private void ColorPicker_ColorSelected(object sender, Color e)
        {
            this.Color = e;
            this.gclButton1.ForeColor = e;

            this.ColorSelected?.Invoke(this, new EventArgs());
        }

        private void gclButton2_Click(object sender, EventArgs e)
        {
            if(this.ParentForm != null)
            {
                Point realLocation = this.FindLocation(this);               
                this.ColorPicker.Location = new Point(realLocation.X, realLocation.Y + this.Height);
                this.ParentForm.Controls.Add(this.ColorPicker);
                this.ColorPicker.BringToFront();
                this.ColorPicker.Focus();
                this.ColorPicker.Show();
            }
        }

        private Point FindLocation(Control ctrl)
        {
            if (ctrl.Parent is Form)
                return ctrl.Location;
            else
            {
                Point p = FindLocation(ctrl.Parent);
                p.X += ctrl.Location.X;
                p.Y += ctrl.Location.Y;
                return p;
            }
        }

        private void gclButton1_Click(object sender, EventArgs e)
        {
            this.ColorSelected?.Invoke(this, e);
        }
    }
}
