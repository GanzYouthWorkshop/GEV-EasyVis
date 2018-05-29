using Cognex.DataMan.SDK;
using Cognex.DataMan.SDK.Utils;
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

        public DataManSystem Sensor { get; private set; }
        public ResultCollector Collector { get; private set; }

        public void Connect()
        {
            EthSystemConnector connection = new EthSystemConnector(System.Net.IPAddress.Parse(this.IPAddress))
            {
                UserName = "admin",
                Password = "",
            };

            this.Sensor = new DataManSystem(connection);
            this.Sensor.DefaultTimeout = 5000;
            this.Sensor.SetKeepAliveOptions(true, 3000, 1000);

            ResultTypes requestedResults = ResultTypes.ReadXml | ResultTypes.Image | ResultTypes.ImageGraphics;

            this.Collector = new ResultCollector(this.Sensor, requestedResults);
            this.Collector.ComplexResultArrived += M_DatamanResultCollector_ComplexResultArrived;

            this.Sensor.Connect();

            try
            {
                this.Sensor.SetResultTypes(requestedResults);
            }
            catch
            {
            }
        }

        private void M_DatamanResultCollector_ComplexResultArrived(object sender, ResultInfo e)
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }
    }
}
