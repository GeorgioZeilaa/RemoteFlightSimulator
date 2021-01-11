using System;
using System.Text;
using System.Web.Script.Serialization;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
//17014182
namespace RemoteFlightController
{
    public struct ControlsUpdate//to send this data to the server
    {
        public double Throttle;//plane's speed
        public double ElevatorPitch;//where the plane is pointing at; upwards or downwards
    }
    public struct TelemetryUpdate//to retrieve data from the server
    {
        public double Altitude;//Altitude in ft.
        public double Speed;//Plane's speed in Knts.
        public double Pitch;//Plane's pitch in degrees relative to horizon. Positive is planes pointing upwards, negative plane points downwards;
        public double VerticalSpeed;//Plane's vertical speed in Feet per minute.
        public double Throttle;//Current throttle setting as a percentage (i.e. 0% no throttle, 100% full throttle).
        public double ElevatorPitch;//Current Elevator Pitch in degrees. Positive creates upwards lift, negative downwards.
        public int WarningCode;//Warning code: 0 - No Warnings; 1 -  Too Low (less than 1000ft); 2 - Stall.
    }

    public delegate void ReceivedDataDelegate(TelemetryUpdate telemetryUpdate);
    public delegate void AutoPilotDelegate(TelemetryUpdate telemetryUpdate);
    public delegate void SendingDataDelegate(ControlsUpdate controlsUpdate);
    public delegate void WarningDelegate(string message);

    public partial class RemoteFlightController : Form
    {
        TcpClient tcpClient = new TcpClient();
        Remote remote = new Remote();
        Thread retrievingThread;

        private void RemoteFlightController_Load(object sender, EventArgs e)
        {
            txtIPAddress.Text = "";//default connection IP
            txtPort.Text = "9999";//default port
            txtCurrentConnectionStatus.Text = "Not Connected!";//default connection status
            txtAutoPilotStatus.Text = "OFF";//default auto-pilot status

            trkbThrottle.Minimum = 0;
            trkbThrottle.Maximum = 100;
            trkbThrottle.TickFrequency = 1;
            trkbElevatorLevel.Minimum = -50;
            trkbElevatorLevel.Maximum = 50;

            //no need to make changes to these objects
            txtCurrentConnection.ReadOnly = Enabled;
            txtCurrentConnectionStatus.ReadOnly = Enabled;
            txtWarning.ReadOnly = Enabled;
            txtAutoPilotStatus.ReadOnly = Enabled;
            txtAirSpeed.ReadOnly = Enabled;
            txtAltitude.ReadOnly = Enabled;
            txtElevatorPitch.ReadOnly = Enabled;
            txtPitchAngle.ReadOnly = Enabled;
            txtThrottle.ReadOnly = Enabled;
            txtVerticleSpeed.ReadOnly = Enabled;
            dgvreceiverDataTable.ReadOnly = Enabled;

            //cannot use these object before connecting
            trkbElevatorLevel.Enabled = false;
            trkbThrottle.Enabled = false;
            btnAutoPilot.Enabled = false;
            btnAutoPilotStop.Enabled = false;
        }
        public RemoteFlightController()
        {
            InitializeComponent();
            PassingOnDelegate();//this is the start of getcontolsupdate and setcontrolsupdate
        }
        private void PassingOnDelegate()
        {
            //creates instances of a delegates and registers them using +=
            remote.receivingEvent += new ReceivedDataDelegate(showPlaneStats);
            remote.SendingEvent += new SendingDataDelegate(updateControls);
            remote.warningEvent += new WarningDelegate(getMessageWarning);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIPAddress.Text.Length == 0 || txtPort.Text.Length == 0)
            {
                MessageBox.Show("Please input an IP and Port please!");
            }
            else
            {
                int Searchinteger = 0;
                if (!int.TryParse(txtPort.Text, out Searchinteger))//checks if there is an integer in variable integer
                {
                    MessageBox.Show("Please input only an integer in port!");
                }
                else
                {
                    int Port = int.Parse(txtPort.Text);
                    IPAddress IP = IPAddress.Parse(txtIPAddress.Text);//converting the string of txtIPAddress to IPAddress datatype
                    txtPort.Text = Convert.ToString(Port);//converting it to string because the textbox only accepts string datatype

                    try
                    {
                        //this part of the code will run if the connection is successfull
                        tcpClient.Connect(IP, Port);//this is used to pass on the IP and Port to use that to establish a connection
                        txtCurrentConnectionStatus.Text = "Connected!";
                        txtCurrentConnection.Text = IP.ToString() + ":" + Port.ToString();
                        
                        retrievingThread = new Thread(new ThreadStart(remote.ReceiveData));//this thread will always be used to retrieve data
                        retrievingThread.Start();

                        NetworkStream networkStream = tcpClient.GetStream();//the stream is then received
                        remote.networkStream = networkStream;//we set the networkStream in remote class to the networkStream with the connection that we have established

                        MessageBox.Show("Connected to: " + IP.ToString() + ":" + Port.ToString());//showing the IP and Port when connected properly

                        //disabling appropriate objects in design
                        btnConnect.Enabled = false;
                        btnAutoPilot.Enabled = true;
                        trkbThrottle.Enabled = true;
                        trkbElevatorLevel.Enabled = true;
                    }
                    catch (Exception ex)//we catch any message that is thrown when something goes wrong
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public class Remote
        {
            public event SendingDataDelegate SendingEvent;//sends the controlUpdate, includes: throttle and elevator level
            public event ReceivedDataDelegate receivingEvent;//we use this event to trigger an update to the struct variables
            public event WarningDelegate warningEvent;//this event is used to send the warning message depending on the code
            public event AutoPilotDelegate AutoPilotEvent;//used to activate a function and send the telemetryUpdate data

            public NetworkStream networkStream;

            public void SendData(ControlsUpdate controlUpdate)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();//this is the way we start serializer
                //serializer is getting the controlUpdate struct that has been passed onto the SendData function in the class sender to update controlUpdate variables

                byte[] Data = Encoding.ASCII.GetBytes(serializer.Serialize(controlUpdate));//this is an array of rawData that we receive from the deserialization
                networkStream.Write(Data, 0, Data.Length);//this is just like writing to a file however we write to a another program via socket programming using network stream

                SendingEvent?.Invoke(controlUpdate);//we use the event to add the data into controlUpdate
            }
            public void ReceiveData()
            {
                TelemetryUpdate telemetryUpdate = new TelemetryUpdate();//this makes sure that the data is cleared from the structs

                bool Retrieve = true;

                while (Retrieve)//endless loop so we always try to retrieve data
                {
                    byte[] data = new byte[256];
                    int numberOfBytes = networkStream.Read(data, 0, 256);//the data variable is an array to store the data that is being received

                    JavaScriptSerializer serializer = new JavaScriptSerializer();//this is the way we start serializer
                    telemetryUpdate = serializer.Deserialize<TelemetryUpdate>(Encoding.ASCII.GetString(data, 0, numberOfBytes));//telemetryUpdate will be populated by decoding the numberOfByte

                    if (telemetryUpdate.WarningCode == 1)
                    {
                        warningEvent?.Invoke("Too low terrain (lower than 1000 ft)!");//passing on the proper message to the warning label
                    }
                    else if (telemetryUpdate.WarningCode == 2)
                    {
                        warningEvent?.Invoke("Stalling!");//passing on the proper message to the warning label
                    }
                    else if (telemetryUpdate.WarningCode == 0)
                    {
                        warningEvent?.Invoke("No warnings");//passing on the proper message to the warning label
                    }

                    receivingEvent?.Invoke(telemetryUpdate);//so we see what we are receiving
                    AutoPilotEvent?.Invoke(telemetryUpdate);//this is placed in here so we can always update the throttle and elevator pitch angle when activated by the button
                }
            }
        }
        private void trkbThrottle_ValueChanged(object sender, EventArgs e)
        {
            lblThrottlePercentage.Text = trkbThrottle.Value.ToString() + "%";
            planeStatsChanged();//this is where the controls are sent
        }
        private void trkbElevatorLevel_ValueChanged(object sender, EventArgs e)
        {
            double elevator = (trkbElevatorLevel.Value * 0.1) / trkbElevatorLevel.TickFrequency;//this is where we multiply the elevator level value by 0.1 so it is for example: 2.3 which is a double
            lblEelevatorPercentage.Text = elevator.ToString() + "%";
            planeStatsChanged();//this is where the controls are sent
        }
        public void planeStatsChanged()
        {
            NetworkStream networkStream = tcpClient.GetStream();//everytime we scroll in the trackbars we have to get the stream

            ControlsUpdate controlsUpdate = new ControlsUpdate();//we get the controlsupdate ready to be used to update
            controlsUpdate.Throttle = trkbThrottle.Value;
            controlsUpdate.ElevatorPitch = trkbElevatorLevel.Value * 0.1;//passing on the correct double value

            remote.networkStream = networkStream;//this is where we send the stream info
            remote.SendData(controlsUpdate);//we then pass on the variables in the struct to SendData object

            Thread.Sleep(50);//it will send a lot of data at once so we pause the thread for a bit
        }
        private void updateControls(ControlsUpdate controlUpdate)
        {
            if (this.InvokeRequired)//checks if it is on the same thread
            {
                this.Invoke(new SendingDataDelegate(updateControls), new object[] { controlUpdate });//this is from the remote class
            }
            else
            {
                controlUpdate.Throttle = trkbThrottle.Value;
                controlUpdate.ElevatorPitch = trkbElevatorLevel.Value * 0.1;
            }
        }
        private void showPlaneStats(TelemetryUpdate telemetryUpdate)
        {
            if (this.InvokeRequired)//to check if it is on the same thread still
            {
                this.Invoke(new ReceivedDataDelegate(showPlaneStats), new object[] { telemetryUpdate });
            }
            else
            {
                //keeping the textboxes up to date with the stats of the plane
                txtAltitude.Text = Math.Round(telemetryUpdate.Altitude).ToString() + " ft";
                txtAirSpeed.Text = Math.Round(telemetryUpdate.Speed).ToString() + " knots";
                txtVerticleSpeed.Text = Math.Round(telemetryUpdate.VerticalSpeed).ToString() + " fpm";
                txtThrottle.Text = Math.Round(telemetryUpdate.Throttle).ToString() + " %";
                txtPitchAngle.Text = Math.Round(telemetryUpdate.Pitch).ToString() + "°";
                txtElevatorPitch.Text = Math.Round(telemetryUpdate.ElevatorPitch).ToString() + "°";

                //showing it in the table
                DataGridViewRow row = (DataGridViewRow)dgvreceiverDataTable.Rows[0].Clone();
                row.Cells[0].Value = telemetryUpdate.Speed.ToString();
                row.Cells[1].Value = telemetryUpdate.VerticalSpeed.ToString();
                row.Cells[2].Value = telemetryUpdate.Pitch.ToString();
                row.Cells[3].Value = telemetryUpdate.Altitude.ToString();
                row.Cells[4].Value = telemetryUpdate.Throttle.ToString();
                row.Cells[5].Value = telemetryUpdate.ElevatorPitch.ToString();
                row.Cells[6].Value = telemetryUpdate.WarningCode.ToString();

                dgvreceiverDataTable.Rows.Insert(0, row);//inserting to what we have set above
            }
        }
        private void getMessageWarning(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new WarningDelegate(getMessageWarning), new object[] { message });
            }
            else
            {
                txtWarning.Text = message;//changing the label text to what ever the warning message is depending on the warning code
            }
        }
        private void btnAutoPilot_Click(object sender, EventArgs e)
        {
            //creates instance of a delegate and register it using +=
            remote.AutoPilotEvent += new AutoPilotDelegate(AutoPilotfunction);
            txtAutoPilotStatus.Text = "ON";

            btnAutoPilotStop.Enabled = true;
            btnAutoPilot.Enabled = false;
        }
        private void btnAutoPilotStop_Click(object sender, EventArgs e)
        {
            //this deregisters  the delegate from the event
            remote.AutoPilotEvent -= new AutoPilotDelegate(AutoPilotfunction);
            txtAutoPilotStatus.Text = "OFF";

            btnAutoPilotStop.Enabled = false;
            btnAutoPilot.Enabled = true;
        }
        private void AutoPilotfunction(TelemetryUpdate telemetryUpdate)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new AutoPilotDelegate(AutoPilotfunction), new object[] { telemetryUpdate });
            }
            else
            {
                //--------------------------------
                //the throttle changes
                if (telemetryUpdate.Speed <= 250)
                {
                    if (trkbThrottle.Value != 100)
                    {
                        trkbThrottle.Value = 100;
                    }
                }
                else if (telemetryUpdate.Speed >= 300) 
                {
                    if (trkbThrottle.Value != 30) 
                    {
                        trkbThrottle.Value = 30;
                    }
                }
                else
                {
                    if (trkbThrottle.Value != 60) 
                    {
                        trkbThrottle.Value = 60;
                    }
                }
                //--------------------------------

                //--------------------------------
                //the elevator pitch angle changes
                if (telemetryUpdate.Altitude < 1000)
                {
                    if (trkbElevatorLevel.Value != 50)
                    {
                        trkbElevatorLevel.Value = 50;
                    }
                }
                else if (telemetryUpdate.Altitude < 10000) 
                {
                    if (trkbElevatorLevel.Value != 20)
                    {
                        trkbElevatorLevel.Value = 20;
                    }
                }
                else if (telemetryUpdate.Altitude >= 10000 && telemetryUpdate.Altitude <= 12000) 
                {
                    if (trkbElevatorLevel.Value != 15)
                    {
                        trkbElevatorLevel.Value = 15;
                    }
                }
                if (telemetryUpdate.Altitude >= 13000 && telemetryUpdate.Altitude <= 15000)
                {
                    if (trkbElevatorLevel.Value != 10)
                    {
                        trkbElevatorLevel.Value = 10;
                    }
                }
                //--------------------------------
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            remote.receivingEvent -= new ReceivedDataDelegate(showPlaneStats);
            remote.SendingEvent -= new SendingDataDelegate(updateControls);
            remote.warningEvent -= new WarningDelegate(getMessageWarning);
            if (txtAutoPilotStatus.Text == "ON") 
            {
                remote.AutoPilotEvent -= new AutoPilotDelegate(AutoPilotfunction);
            }
            Environment.Exit(Environment.ExitCode);
            System.Windows.Forms.Application.Exit();
        }
    }
}