using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GEV.Layouts;

namespace Cairo_Editor.Controls
{
    public partial class ColorButton : UserControl
    {
        public Color Color
        {
            get { return this.gclPanel1.BackColor; }
            set { this.gclPanel1.BackColor = value; }
        }

        public new event EventHandler Click;

        public ColorButton()
        {
            InitializeComponent();
        }

        private Color m_TempColor;

        private void gclPanel1_MouseEnter(object sender, EventArgs e)
        {
            m_TempColor = this.BackColor;
            this.BackColor = GCLColors.SoftBorder;
        }

        private void gclPanel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = m_TempColor;
        }

        private void gclPanel1_Click(object sender, EventArgs e)
        {
            this.Click?.Invoke(this, e);
        }
    }
}
