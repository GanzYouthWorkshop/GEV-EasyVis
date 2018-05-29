using GEV.EasyVis.DeviceHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.EasyVis
{
    [Serializable]
    public class Project
    {
        public List<IDeviceHandler> Devices { get; } = new List<IDeviceHandler>();
        public string Name { get; set; }
    }
}
