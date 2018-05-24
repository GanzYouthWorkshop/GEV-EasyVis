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
    public partial class ColorPickerControl : UserControl
    {
        public event EventHandler<Color> ColorSelected;

        public ColorPickerControl()
        {
            InitializeComponent();

            this.LostFocus += ColorPickerControl_LostFocus;
        }

        private void ColorPickerControl_LostFocus(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OnColorSelected(object sender, EventArgs e)
        {
            Color c = ((ColorButton)sender).Color;
            this.ColorSelected?.Invoke(this, c);
            this.Hide();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(34,34,34);
            this.ColorSelected?.Invoke(this, c);
            this.Hide();
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                Color c = cd.Color;
                this.ColorSelected?.Invoke(this, c);
            }
            this.Hide();
        }
    }
}
