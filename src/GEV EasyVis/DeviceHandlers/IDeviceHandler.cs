using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.EasyVis.DeviceHandlers
{
    public interface IDeviceHandler
    {
        ConnectionState DeviceState { get; }

        string Name { get; set; }
        string IPAddress { get; set; }
        string Username { get; set; }
        string Password { get; set; }

        void Connect();
        void Disconnect();
    }
}
