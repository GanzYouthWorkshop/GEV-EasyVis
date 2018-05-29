using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.EasyVis.DeviceHandlers
{
    public enum ConnectionState
    {
        Disconnected,

        AuthError,
        AlreadyInUse,
        LockedBySoftware,
        ConnectError,

        Connecting,
        Connected,
        Edited
    }
}
