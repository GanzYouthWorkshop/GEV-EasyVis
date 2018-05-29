using Cognex.InSight;
using GEV.EasyVis.DeviceHandlers;
using GEV.Layouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEV.EasyVis.GUI
{
    public partial class InSightEditor : GCLForm
    {
        public InSightEditor()
        {
            InitializeComponent();
        }

        public InSightEditor(InsightSensor device)
        {
            InitializeComponent();

            this.pnlDisplayContainer.Controls.Add(device.InSightDisplay);

            device.InSightDisplay.Dock = DockStyle.Fill;
            device.InSightDisplay.ShowGrid = true;
        }

        private void InSightEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.pnlDisplayContainer.Controls.Clear();
        }
    }
}
