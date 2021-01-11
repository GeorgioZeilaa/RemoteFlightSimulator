namespace RemoteFlightController
{
    partial class RemoteFlightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteFlightController));
            this.grpConnectionDetails = new System.Windows.Forms.GroupBox();
            this.txtCurrentConnectionStatus = new System.Windows.Forms.TextBox();
            this.lblCurrentConnectionStatus = new System.Windows.Forms.Label();
            this.txtCurrentConnection = new System.Windows.Forms.TextBox();
            this.lblCurrentConnection = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.dgvreceiverDataTable = new System.Windows.Forms.DataGridView();
            this.clmnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnVerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPitchAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAltitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnThrottle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWarningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPlane = new System.Windows.Forms.GroupBox();
            this.lblElevatorPitch = new System.Windows.Forms.Label();
            this.txtElevatorPitch = new System.Windows.Forms.TextBox();
            this.lblPitchAngle = new System.Windows.Forms.Label();
            this.txtPitchAngle = new System.Windows.Forms.TextBox();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.txtThrottle = new System.Windows.Forms.TextBox();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.lblVerticleSpeed = new System.Windows.Forms.Label();
            this.txtVerticleSpeed = new System.Windows.Forms.TextBox();
            this.lblAirSpeed = new System.Windows.Forms.Label();
            this.txtAirSpeed = new System.Windows.Forms.TextBox();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.grpAutoPilot = new System.Windows.Forms.GroupBox();
            this.btnAutoPilot = new System.Windows.Forms.Button();
            this.lblAutoPilotStatus = new System.Windows.Forms.Label();
            this.txtAutoPilotStatus = new System.Windows.Forms.TextBox();
            this.btnAutoPilotStop = new System.Windows.Forms.Button();
            this.grpCurrentElevator = new System.Windows.Forms.GroupBox();
            this.lblEelevatorPercentage = new System.Windows.Forms.Label();
            this.grpCurrentThrottle = new System.Windows.Forms.GroupBox();
            this.lblThrottlePercentage = new System.Windows.Forms.Label();
            this.lblElevatorlevel = new System.Windows.Forms.Label();
            this.lblThrottleControls = new System.Windows.Forms.Label();
            this.trkbElevatorLevel = new System.Windows.Forms.TrackBar();
            this.trkbThrottle = new System.Windows.Forms.TrackBar();
            this.grpWarning = new System.Windows.Forms.GroupBox();
            this.txtWarning = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpConnectionDetails.SuspendLayout();
            this.grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceiverDataTable)).BeginInit();
            this.grpPlane.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.grpAutoPilot.SuspendLayout();
            this.grpCurrentElevator.SuspendLayout();
            this.grpCurrentThrottle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbElevatorLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbThrottle)).BeginInit();
            this.grpWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnectionDetails
            // 
            this.grpConnectionDetails.Controls.Add(this.txtCurrentConnectionStatus);
            this.grpConnectionDetails.Controls.Add(this.lblCurrentConnectionStatus);
            this.grpConnectionDetails.Controls.Add(this.txtCurrentConnection);
            this.grpConnectionDetails.Controls.Add(this.lblCurrentConnection);
            this.grpConnectionDetails.Controls.Add(this.lblPort);
            this.grpConnectionDetails.Controls.Add(this.txtPort);
            this.grpConnectionDetails.Controls.Add(this.lblIPAddress);
            this.grpConnectionDetails.Controls.Add(this.txtIPAddress);
            this.grpConnectionDetails.Controls.Add(this.btnConnect);
            this.grpConnectionDetails.Location = new System.Drawing.Point(12, 12);
            this.grpConnectionDetails.Name = "grpConnectionDetails";
            this.grpConnectionDetails.Size = new System.Drawing.Size(551, 82);
            this.grpConnectionDetails.TabIndex = 0;
            this.grpConnectionDetails.TabStop = false;
            this.grpConnectionDetails.Text = "Connection";
            // 
            // txtCurrentConnectionStatus
            // 
            this.txtCurrentConnectionStatus.Location = new System.Drawing.Point(434, 16);
            this.txtCurrentConnectionStatus.Name = "txtCurrentConnectionStatus";
            this.txtCurrentConnectionStatus.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentConnectionStatus.TabIndex = 8;
            // 
            // lblCurrentConnectionStatus
            // 
            this.lblCurrentConnectionStatus.AutoSize = true;
            this.lblCurrentConnectionStatus.Location = new System.Drawing.Point(297, 19);
            this.lblCurrentConnectionStatus.Name = "lblCurrentConnectionStatus";
            this.lblCurrentConnectionStatus.Size = new System.Drawing.Size(134, 13);
            this.lblCurrentConnectionStatus.TabIndex = 7;
            this.lblCurrentConnectionStatus.Text = "Current Connection Status:";
            // 
            // txtCurrentConnection
            // 
            this.txtCurrentConnection.Location = new System.Drawing.Point(434, 42);
            this.txtCurrentConnection.Name = "txtCurrentConnection";
            this.txtCurrentConnection.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentConnection.TabIndex = 6;
            // 
            // lblCurrentConnection
            // 
            this.lblCurrentConnection.AutoSize = true;
            this.lblCurrentConnection.Location = new System.Drawing.Point(330, 45);
            this.lblCurrentConnection.Name = "lblCurrentConnection";
            this.lblCurrentConnection.Size = new System.Drawing.Size(101, 13);
            this.lblCurrentConnection.TabIndex = 5;
            this.lblCurrentConnection.Text = "Current Connection:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(51, 45);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(83, 42);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(22, 19);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(61, 13);
            this.lblIPAddress.TabIndex = 2;
            this.lblIPAddress.Text = "IP Address:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(83, 16);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtIPAddress.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(189, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grpTable
            // 
            this.grpTable.Controls.Add(this.dgvreceiverDataTable);
            this.grpTable.Location = new System.Drawing.Point(12, 99);
            this.grpTable.Name = "grpTable";
            this.grpTable.Size = new System.Drawing.Size(551, 380);
            this.grpTable.TabIndex = 1;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Receiver Data Table";
            // 
            // dgvreceiverDataTable
            // 
            this.dgvreceiverDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvreceiverDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnSpeed,
            this.clmnVerticalSpeed,
            this.clmnPitchAngle,
            this.clmnAltitude,
            this.clmnThrottle,
            this.clmnElevatorPitch,
            this.clmnWarningCode});
            this.dgvreceiverDataTable.Location = new System.Drawing.Point(25, 37);
            this.dgvreceiverDataTable.Name = "dgvreceiverDataTable";
            this.dgvreceiverDataTable.Size = new System.Drawing.Size(509, 327);
            this.dgvreceiverDataTable.TabIndex = 0;
            // 
            // clmnSpeed
            // 
            this.clmnSpeed.HeaderText = "Speed";
            this.clmnSpeed.Name = "clmnSpeed";
            this.clmnSpeed.Width = 50;
            // 
            // clmnVerticalSpeed
            // 
            this.clmnVerticalSpeed.HeaderText = "Vertical Speed";
            this.clmnVerticalSpeed.Name = "clmnVerticalSpeed";
            this.clmnVerticalSpeed.Width = 75;
            // 
            // clmnPitchAngle
            // 
            this.clmnPitchAngle.HeaderText = "Pitch Angle";
            this.clmnPitchAngle.Name = "clmnPitchAngle";
            this.clmnPitchAngle.Width = 75;
            // 
            // clmnAltitude
            // 
            this.clmnAltitude.HeaderText = "Altitude";
            this.clmnAltitude.Name = "clmnAltitude";
            this.clmnAltitude.Width = 55;
            // 
            // clmnThrottle
            // 
            this.clmnThrottle.HeaderText = "Throttle";
            this.clmnThrottle.Name = "clmnThrottle";
            this.clmnThrottle.Width = 60;
            // 
            // clmnElevatorPitch
            // 
            this.clmnElevatorPitch.HeaderText = "Elevator Pitch";
            this.clmnElevatorPitch.Name = "clmnElevatorPitch";
            this.clmnElevatorPitch.Width = 75;
            // 
            // clmnWarningCode
            // 
            this.clmnWarningCode.HeaderText = "Warning Code";
            this.clmnWarningCode.Name = "clmnWarningCode";
            this.clmnWarningCode.Width = 75;
            // 
            // grpPlane
            // 
            this.grpPlane.Controls.Add(this.lblElevatorPitch);
            this.grpPlane.Controls.Add(this.txtElevatorPitch);
            this.grpPlane.Controls.Add(this.lblPitchAngle);
            this.grpPlane.Controls.Add(this.txtPitchAngle);
            this.grpPlane.Controls.Add(this.lblThrottle);
            this.grpPlane.Controls.Add(this.txtThrottle);
            this.grpPlane.Controls.Add(this.lblAltitude);
            this.grpPlane.Controls.Add(this.txtAltitude);
            this.grpPlane.Controls.Add(this.lblVerticleSpeed);
            this.grpPlane.Controls.Add(this.txtVerticleSpeed);
            this.grpPlane.Controls.Add(this.lblAirSpeed);
            this.grpPlane.Controls.Add(this.txtAirSpeed);
            this.grpPlane.Location = new System.Drawing.Point(579, 12);
            this.grpPlane.Name = "grpPlane";
            this.grpPlane.Size = new System.Drawing.Size(420, 103);
            this.grpPlane.TabIndex = 2;
            this.grpPlane.TabStop = false;
            this.grpPlane.Text = "Plane Stats";
            // 
            // lblElevatorPitch
            // 
            this.lblElevatorPitch.AutoSize = true;
            this.lblElevatorPitch.Location = new System.Drawing.Point(215, 73);
            this.lblElevatorPitch.Name = "lblElevatorPitch";
            this.lblElevatorPitch.Size = new System.Drawing.Size(73, 13);
            this.lblElevatorPitch.TabIndex = 15;
            this.lblElevatorPitch.Text = "Elevator Pitch";
            // 
            // txtElevatorPitch
            // 
            this.txtElevatorPitch.Location = new System.Drawing.Point(290, 70);
            this.txtElevatorPitch.Name = "txtElevatorPitch";
            this.txtElevatorPitch.Size = new System.Drawing.Size(100, 20);
            this.txtElevatorPitch.TabIndex = 16;
            // 
            // lblPitchAngle
            // 
            this.lblPitchAngle.AutoSize = true;
            this.lblPitchAngle.Location = new System.Drawing.Point(215, 47);
            this.lblPitchAngle.Name = "lblPitchAngle";
            this.lblPitchAngle.Size = new System.Drawing.Size(61, 13);
            this.lblPitchAngle.TabIndex = 13;
            this.lblPitchAngle.Text = "Pitch Angle";
            // 
            // txtPitchAngle
            // 
            this.txtPitchAngle.Location = new System.Drawing.Point(290, 44);
            this.txtPitchAngle.Name = "txtPitchAngle";
            this.txtPitchAngle.Size = new System.Drawing.Size(100, 20);
            this.txtPitchAngle.TabIndex = 14;
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Location = new System.Drawing.Point(215, 21);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(43, 13);
            this.lblThrottle.TabIndex = 11;
            this.lblThrottle.Text = "Throttle";
            // 
            // txtThrottle
            // 
            this.txtThrottle.Location = new System.Drawing.Point(290, 18);
            this.txtThrottle.Name = "txtThrottle";
            this.txtThrottle.Size = new System.Drawing.Size(100, 20);
            this.txtThrottle.TabIndex = 12;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(11, 73);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(42, 13);
            this.lblAltitude.TabIndex = 9;
            this.lblAltitude.Text = "Altitude";
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(89, 70);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(100, 20);
            this.txtAltitude.TabIndex = 10;
            // 
            // lblVerticleSpeed
            // 
            this.lblVerticleSpeed.AutoSize = true;
            this.lblVerticleSpeed.Location = new System.Drawing.Point(11, 47);
            this.lblVerticleSpeed.Name = "lblVerticleSpeed";
            this.lblVerticleSpeed.Size = new System.Drawing.Size(76, 13);
            this.lblVerticleSpeed.TabIndex = 7;
            this.lblVerticleSpeed.Text = "Verticle Speed";
            // 
            // txtVerticleSpeed
            // 
            this.txtVerticleSpeed.Location = new System.Drawing.Point(89, 44);
            this.txtVerticleSpeed.Name = "txtVerticleSpeed";
            this.txtVerticleSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtVerticleSpeed.TabIndex = 8;
            // 
            // lblAirSpeed
            // 
            this.lblAirSpeed.AutoSize = true;
            this.lblAirSpeed.Location = new System.Drawing.Point(11, 21);
            this.lblAirSpeed.Name = "lblAirSpeed";
            this.lblAirSpeed.Size = new System.Drawing.Size(50, 13);
            this.lblAirSpeed.TabIndex = 6;
            this.lblAirSpeed.Text = "AirSpeed";
            // 
            // txtAirSpeed
            // 
            this.txtAirSpeed.Location = new System.Drawing.Point(89, 18);
            this.txtAirSpeed.Name = "txtAirSpeed";
            this.txtAirSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtAirSpeed.TabIndex = 6;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.grpAutoPilot);
            this.grpControls.Controls.Add(this.grpCurrentElevator);
            this.grpControls.Controls.Add(this.grpCurrentThrottle);
            this.grpControls.Controls.Add(this.lblElevatorlevel);
            this.grpControls.Controls.Add(this.lblThrottleControls);
            this.grpControls.Controls.Add(this.trkbElevatorLevel);
            this.grpControls.Controls.Add(this.trkbThrottle);
            this.grpControls.Location = new System.Drawing.Point(573, 208);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(420, 271);
            this.grpControls.TabIndex = 3;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // grpAutoPilot
            // 
            this.grpAutoPilot.Controls.Add(this.btnAutoPilot);
            this.grpAutoPilot.Controls.Add(this.lblAutoPilotStatus);
            this.grpAutoPilot.Controls.Add(this.txtAutoPilotStatus);
            this.grpAutoPilot.Controls.Add(this.btnAutoPilotStop);
            this.grpAutoPilot.Location = new System.Drawing.Point(295, 78);
            this.grpAutoPilot.Name = "grpAutoPilot";
            this.grpAutoPilot.Size = new System.Drawing.Size(119, 125);
            this.grpAutoPilot.TabIndex = 11;
            this.grpAutoPilot.TabStop = false;
            this.grpAutoPilot.Text = "Auto-Pilot";
            // 
            // btnAutoPilot
            // 
            this.btnAutoPilot.Location = new System.Drawing.Point(14, 57);
            this.btnAutoPilot.Name = "btnAutoPilot";
            this.btnAutoPilot.Size = new System.Drawing.Size(92, 25);
            this.btnAutoPilot.TabIndex = 5;
            this.btnAutoPilot.Text = "Start";
            this.btnAutoPilot.UseVisualStyleBackColor = true;
            this.btnAutoPilot.Click += new System.EventHandler(this.btnAutoPilot_Click);
            // 
            // lblAutoPilotStatus
            // 
            this.lblAutoPilotStatus.AutoSize = true;
            this.lblAutoPilotStatus.Location = new System.Drawing.Point(19, 22);
            this.lblAutoPilotStatus.Name = "lblAutoPilotStatus";
            this.lblAutoPilotStatus.Size = new System.Drawing.Size(40, 13);
            this.lblAutoPilotStatus.TabIndex = 10;
            this.lblAutoPilotStatus.Text = "Status:";
            // 
            // txtAutoPilotStatus
            // 
            this.txtAutoPilotStatus.Location = new System.Drawing.Point(67, 19);
            this.txtAutoPilotStatus.Name = "txtAutoPilotStatus";
            this.txtAutoPilotStatus.Size = new System.Drawing.Size(39, 20);
            this.txtAutoPilotStatus.TabIndex = 10;
            // 
            // btnAutoPilotStop
            // 
            this.btnAutoPilotStop.Location = new System.Drawing.Point(14, 89);
            this.btnAutoPilotStop.Name = "btnAutoPilotStop";
            this.btnAutoPilotStop.Size = new System.Drawing.Size(92, 25);
            this.btnAutoPilotStop.TabIndex = 7;
            this.btnAutoPilotStop.Text = "Stop";
            this.btnAutoPilotStop.UseVisualStyleBackColor = true;
            this.btnAutoPilotStop.Click += new System.EventHandler(this.btnAutoPilotStop_Click);
            // 
            // grpCurrentElevator
            // 
            this.grpCurrentElevator.Controls.Add(this.lblEelevatorPercentage);
            this.grpCurrentElevator.Location = new System.Drawing.Point(140, 114);
            this.grpCurrentElevator.Name = "grpCurrentElevator";
            this.grpCurrentElevator.Size = new System.Drawing.Size(67, 51);
            this.grpCurrentElevator.TabIndex = 9;
            this.grpCurrentElevator.TabStop = false;
            this.grpCurrentElevator.Text = "Current";
            // 
            // lblEelevatorPercentage
            // 
            this.lblEelevatorPercentage.AutoSize = true;
            this.lblEelevatorPercentage.Location = new System.Drawing.Point(15, 21);
            this.lblEelevatorPercentage.Name = "lblEelevatorPercentage";
            this.lblEelevatorPercentage.Size = new System.Drawing.Size(36, 13);
            this.lblEelevatorPercentage.TabIndex = 11;
            this.lblEelevatorPercentage.Text = "0.00%";
            // 
            // grpCurrentThrottle
            // 
            this.grpCurrentThrottle.Controls.Add(this.lblThrottlePercentage);
            this.grpCurrentThrottle.Location = new System.Drawing.Point(6, 114);
            this.grpCurrentThrottle.Name = "grpCurrentThrottle";
            this.grpCurrentThrottle.Size = new System.Drawing.Size(67, 51);
            this.grpCurrentThrottle.TabIndex = 8;
            this.grpCurrentThrottle.TabStop = false;
            this.grpCurrentThrottle.Text = "Current";
            // 
            // lblThrottlePercentage
            // 
            this.lblThrottlePercentage.AutoSize = true;
            this.lblThrottlePercentage.Location = new System.Drawing.Point(13, 21);
            this.lblThrottlePercentage.Name = "lblThrottlePercentage";
            this.lblThrottlePercentage.Size = new System.Drawing.Size(36, 13);
            this.lblThrottlePercentage.TabIndex = 10;
            this.lblThrottlePercentage.Text = "0.00%";
            // 
            // lblElevatorlevel
            // 
            this.lblElevatorlevel.AutoSize = true;
            this.lblElevatorlevel.Location = new System.Drawing.Point(198, 26);
            this.lblElevatorlevel.Name = "lblElevatorlevel";
            this.lblElevatorlevel.Size = new System.Drawing.Size(75, 13);
            this.lblElevatorlevel.TabIndex = 7;
            this.lblElevatorlevel.Text = "Elevator Level";
            // 
            // lblThrottleControls
            // 
            this.lblThrottleControls.AutoSize = true;
            this.lblThrottleControls.Location = new System.Drawing.Point(70, 26);
            this.lblThrottleControls.Name = "lblThrottleControls";
            this.lblThrottleControls.Size = new System.Drawing.Size(43, 13);
            this.lblThrottleControls.TabIndex = 6;
            this.lblThrottleControls.Text = "Throttle";
            // 
            // trkbElevatorLevel
            // 
            this.trkbElevatorLevel.Location = new System.Drawing.Point(213, 51);
            this.trkbElevatorLevel.Maximum = 50;
            this.trkbElevatorLevel.Minimum = -50;
            this.trkbElevatorLevel.Name = "trkbElevatorLevel";
            this.trkbElevatorLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkbElevatorLevel.Size = new System.Drawing.Size(45, 204);
            this.trkbElevatorLevel.TabIndex = 1;
            this.trkbElevatorLevel.ValueChanged += new System.EventHandler(this.trkbElevatorLevel_ValueChanged);
            // 
            // trkbThrottle
            // 
            this.trkbThrottle.Location = new System.Drawing.Point(79, 51);
            this.trkbThrottle.Maximum = 100;
            this.trkbThrottle.Name = "trkbThrottle";
            this.trkbThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkbThrottle.Size = new System.Drawing.Size(45, 204);
            this.trkbThrottle.TabIndex = 0;
            this.trkbThrottle.ValueChanged += new System.EventHandler(this.trkbThrottle_ValueChanged);
            // 
            // grpWarning
            // 
            this.grpWarning.Controls.Add(this.txtWarning);
            this.grpWarning.Controls.Add(this.lblWarning);
            this.grpWarning.Location = new System.Drawing.Point(579, 121);
            this.grpWarning.Name = "grpWarning";
            this.grpWarning.Size = new System.Drawing.Size(321, 81);
            this.grpWarning.TabIndex = 4;
            this.grpWarning.TabStop = false;
            // 
            // txtWarning
            // 
            this.txtWarning.Location = new System.Drawing.Point(84, 26);
            this.txtWarning.Name = "txtWarning";
            this.txtWarning.Size = new System.Drawing.Size(219, 20);
            this.txtWarning.TabIndex = 9;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(26, 29);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(50, 13);
            this.lblWarning.TabIndex = 6;
            this.lblWarning.Text = "Warning:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(903, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 75);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RemoteFlightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 485);
            this.Controls.Add(this.grpPlane);
            this.Controls.Add(this.grpWarning);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpTable);
            this.Controls.Add(this.grpConnectionDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoteFlightController";
            this.Text = "RemoteFlightController";
            this.Load += new System.EventHandler(this.RemoteFlightController_Load);
            this.grpConnectionDetails.ResumeLayout(false);
            this.grpConnectionDetails.PerformLayout();
            this.grpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvreceiverDataTable)).EndInit();
            this.grpPlane.ResumeLayout(false);
            this.grpPlane.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.grpAutoPilot.ResumeLayout(false);
            this.grpAutoPilot.PerformLayout();
            this.grpCurrentElevator.ResumeLayout(false);
            this.grpCurrentElevator.PerformLayout();
            this.grpCurrentThrottle.ResumeLayout(false);
            this.grpCurrentThrottle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbElevatorLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbThrottle)).EndInit();
            this.grpWarning.ResumeLayout(false);
            this.grpWarning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnectionDetails;
        private System.Windows.Forms.Label lblCurrentConnection;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.GroupBox grpPlane;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.GroupBox grpCurrentElevator;
        private System.Windows.Forms.Label lblEelevatorPercentage;
        private System.Windows.Forms.GroupBox grpCurrentThrottle;
        private System.Windows.Forms.Label lblThrottlePercentage;
        private System.Windows.Forms.Label lblElevatorlevel;
        private System.Windows.Forms.Label lblThrottleControls;
        private System.Windows.Forms.TrackBar trkbElevatorLevel;
        private System.Windows.Forms.TrackBar trkbThrottle;
        private System.Windows.Forms.GroupBox grpWarning;
        private System.Windows.Forms.Label lblElevatorPitch;
        private System.Windows.Forms.TextBox txtElevatorPitch;
        private System.Windows.Forms.Label lblPitchAngle;
        private System.Windows.Forms.TextBox txtPitchAngle;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.TextBox txtThrottle;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.Label lblVerticleSpeed;
        private System.Windows.Forms.TextBox txtVerticleSpeed;
        private System.Windows.Forms.Label lblAirSpeed;
        private System.Windows.Forms.TextBox txtAirSpeed;
        private System.Windows.Forms.DataGridView dgvreceiverDataTable;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnAutoPilot;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCurrentConnection;
        private System.Windows.Forms.TextBox txtCurrentConnectionStatus;
        private System.Windows.Forms.Label lblCurrentConnectionStatus;
        private System.Windows.Forms.TextBox txtWarning;
        private System.Windows.Forms.Button btnAutoPilotStop;
        private System.Windows.Forms.TextBox txtAutoPilotStatus;
        private System.Windows.Forms.Label lblAutoPilotStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnVerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPitchAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAltitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnThrottle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnWarningCode;
        private System.Windows.Forms.GroupBox grpAutoPilot;
    }
}

