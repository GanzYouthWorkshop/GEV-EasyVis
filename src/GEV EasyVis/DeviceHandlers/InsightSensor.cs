using System;
using Cognex.InSight;
using Cognex.InSight.Cell;
using System.Drawing;
using Cognex.InSight.Controls.Display;

namespace GEV.EasyVis.DeviceHandlers
{
    /// <summary>
    /// Egy Cognex InSight kamerát kezelő osztály.
    /// </summary>
    public class InsightSensor : IDeviceHandler
    {
        public enum CellType
        {
            Numeric,
            String,
            Other
        }

        public CvsInSightDisplay InSightDisplay { get; private set; }
        public CvsInSight InSightConnection { get; private set; }

        /// <summary>
        /// A szenzor képkészítése, vagy egyéb, cellaértékváltozás esetén küldött eseménye
        /// </summary>
        public event EventHandler ResultsChanged;

        /// <summary>
        /// A szenzorkezelő jelenlegi állapota.
        /// </summary>
        public ConnectionState DeviceState { get; private set; }

        /// <summary>
        /// A szenzor neve
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A kamera IP-címe.
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// A kamera felhasználóneve. Alapértelmezett értéke <code>admin</code>.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// A felhasználónévhez tartozó jelszó.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// A kamera legutóbb készült képe.
        /// </summary>
        public Bitmap Image
        {
            get
            {
                return this.InSightConnection.Results.Image.ToBitmap();
            }
        }

        /// <summary>
        /// Létrehoz egy új Cognex InSight szenzorhoz tartozó kezelőt.
        /// </summary>
        /// <param name="p_IP">A kamera IP-címe.</param>
        /// <param name="p_Username">A kamera felhasználóneve. Alapértelmezett értéke <code>admin</code>.</param>
        /// <param name="p_Password">A felhasználónévhez tartozó jelszó.</param>
        public InsightSensor(string p_IP, string p_Username, string p_Password)
        {
            this.InSightDisplay = new CvsInSightDisplay();
            this.DeviceState = ConnectionState.Disconnected;
            this.IPAddress = p_IP;
            this.Username = p_Username;
            this.Password = p_Password;

        }

        private void InSightDisplay_ConnectCompleted(object sender, CvsConnectCompletedEventArgs e)
        {
            this.InSightConnection = this.InSightDisplay.InSight;
            this.InSightConnection.ResultsChanged += M_InSightConnection_ResultsChanged;

            this.DeviceState = ConnectionState.Connected;
        }

        /// <summary>
        /// Csatlakozik a kamerához a megadott IP-címmel, felhasználóval és jelszóval.
        /// </summary>
        public void Connect()
        {
            try
            {
                this.InSightDisplay.Connect(this.IPAddress, this.Username, this.Password, true);
                this.InSightDisplay.ConnectCompleted += InSightDisplay_ConnectCompleted;

                this.DeviceState = ConnectionState.Connecting;
            }
            catch (CvsInSightLockedException ex)
            {
                this.DeviceState = ConnectionState.LockedBySoftware;
            }
            catch (CvsSensorAlreadyConnectedException ex)
            {
                this.DeviceState = ConnectionState.Edited;
            }
            catch (CvsInvalidLogonException ex)
            {
                this.DeviceState = ConnectionState.AuthError;
            }
            catch (Exception ex)
            {
                this.DeviceState = ConnectionState.ConnectError;
            }
        }

        /// <summary>
        /// Lekapcsolódik a kameráról.
        /// </summary>
        public void Disconnect()
        {
            if(this.InSightConnection != null)
            {
                this.InSightConnection.Disconnect();
                this.DeviceState = ConnectionState.Disconnected;
            }
        }

        /// <summary>
        /// Küld a kamerának egy triggerjelet.
        /// </summary>
        public void Trigger()
        {
            this.InSightConnection.ManualAcquire();
        }

        private void M_InSightConnection_ResultsChanged(object sender, EventArgs e)
        {
            this.ResultsChanged?.Invoke(this, e);
            this.InSightConnection.AcceptUpdate();
        }

        /// <summary>
        /// Visszaadja a cella értéktípusát.
        /// </summary>
        /// <param name="p_Cell">A cella neve, pl. A0, B8, BA25 stb.</param>
        /// <returns>A cella értéktípusa.</returns>
        public CellType GetCellType(string p_Cell)
        {
            CvsCell cell = this.InSightConnection.Results.Cells[p_Cell];
            if(cell != null)
            {
                switch (cell.DataType)
                {
                    case CvsCellDataType.Integer:
                    case CvsCellDataType.FloatingPoint:
                        return CellType.Numeric;

                    case CvsCellDataType.String:
                        return CellType.String;

                    default:
                        return CellType.Other;
                }
            }
            return CellType.Other;
        }


        /// <summary>
        /// Elkéri a cella integer értékét. Meghívás előtt mindig nézzük meg a cella típusát a <code>GetCellType</code> metódusal!
        /// </summary>
        /// <param name="p_Cell">A cella neve, pl. A0, B8, BA25 stb.</param>
        /// <returns>A cella integer értéke</returns>
        public int GetIntCell(string p_Cell)
        {
            CvsCell cell = this.InSightConnection.Results.Cells[p_Cell];
            if (cell != null)
            {
                if (cell.DataType == CvsCellDataType.FloatingPoint)
                {
                    return (int)(cell as CvsCellFloat).Value;
                }
                else if (cell.DataType == CvsCellDataType.Integer)
                {
                    return (cell as CvsCellInt).Value;
                }
                else
                {
                    throw new InvalidCastException("The selected type cannot be returned as type \"int\"");
                }
            }
            throw new InvalidCastException("The selected type cannot be returned as type \"int\"");
        }

        /// <summary>
        /// Elkéri a cella float értékét. Meghívás előtt mindig nézzük meg a cella típusát a <code>GetCellType</code> metódusal!
        /// </summary>
        /// <param name="p_Cell">A cella neve, pl. A0, B8, BA25 stb.</param>
        /// <returns>A cella integer értéke</returns>
        public float GetFloatCell(string p_Cell)
        {
            CvsCell cell = this.InSightConnection.Results.Cells[p_Cell];
            if (cell != null)
            {

                if (cell.DataType == CvsCellDataType.FloatingPoint)
                {
                    return (cell as CvsCellFloat).Value;
                }
                else if (cell.DataType == CvsCellDataType.Integer)
                {
                    return (cell as CvsCellInt).Value;
                }
                else
                {
                    throw new InvalidCastException("The selected type cannot be returned as type \"float\"");
                }
            }
            throw new InvalidCastException("The selected type cannot be returned as type \"float\"");
        }

        /// <summary>
        /// Elkéri a cella sztring értékét.
        /// </summary>
        /// <param name="p_Cell">A cella neve, pl. A0, B8, BA25 stb.</param>
        /// <returns>A cella sztring értéke.</returns>
        public string GetStringCell(string p_Cell)
        {
            CvsCell cell = this.InSightConnection.Results.Cells[p_Cell];
            if (cell != null)
            {
                return cell.ToString();
            }
            return null;
        }

        /// <summary>
        /// Elkéri a cella bool értékét. Számok esetében 0 <code>false</code> és minden más <code>true</code>,
        /// sztring esetén az üres sztring <code>false</code> minden és más <code>true</code>, egyéb cella mindig <code>false</code>.
        /// </summary>
        /// <param name="p_Cell">A cella neve, pl. A0, B8, BA25 stb.</param>
        /// <returns>A cella bool értéke.</returns>
        public bool GetBoolCell(string p_Cell)
        {
            CvsCell cell = this.InSightConnection.Results.Cells[p_Cell];
            if (cell != null)
            {
                switch (cell.DataType)
                {
                    case CvsCellDataType.Integer:
                        return (cell as CvsCellInt).Value != 0;

                    case CvsCellDataType.FloatingPoint:
                        return (cell as CvsCellFloat).Value != 0;

                    case CvsCellDataType.String:
                        return cell.ToString().Length < 1;

                    default:
                        return false;
                }
            }
            return false;
        }
    }
}
