using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.EasyVis.DeviceHandlers
{
    public class DatamanSensor : IDeviceHandler
    {
        public ConnectionState DeviceState { get; private set; }

        public string IPAddress { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }
    }
}
