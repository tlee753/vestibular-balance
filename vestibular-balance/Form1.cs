using System;
using System.Drawing;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using WiimoteLib;
using System.Timers;

namespace vestibular_balance
{
    public partial class Form1 : Form
    {
        System.Timers.Timer infoUpdateTimer = new System.Timers.Timer() 
        {
            Interval = 50,
            Enabled = false
        };

        public Form1()
        {
            InitializeComponent();

            infoUpdateTimer.Elapsed += new ElapsedEventHandler(infoUpdateTimerElapsed);

            infoPanel.BackColor = Color.FromArgb(192, Color.Black);
            helpButton.BackColor = Color.FromArgb(224, Color.Crimson);
            connectButton.BackColor = Color.FromArgb(192, Color.Teal);
            disconnectButton.BackColor = Color.FromArgb(192, Color.Crimson);
            initButton.BackColor = Color.FromArgb(192, Color.Teal);
            removeButton.BackColor = Color.FromArgb(192, Color.Crimson);
            reportButton.BackColor = Color.FromArgb(192, Color.Teal);
            softPanel.BackColor = Color.FromArgb(192, Color.Black);
            hardPanel.BackColor = Color.FromArgb(192, Color.Black);
            reportPanel.BackColor = Color.FromArgb(192, Color.Black);
            reportCenter.BackColor = Color.FromArgb(192, Color.Crimson);

            infoLabel.Text = "Welcome to Vestibular Balance. For further assistance, press the help button.";
            softLabel.Text = "No device connected.";
            hardLabel.Text = "Press initialize if the board light isn't solid.\nIf the program is not working, trying pressing the 'Remove' button. Then click the 'Initalize' button and the Red 'SYNC' button on the bottom of the balance board. You can also remove the device from the Windows Bluetooth Menu.";
            reportLabel.Text = "Please connect before reporting values.";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Press 'Initialize' and red 'SYNC' button on bottom of balance board to begin setup process. The LED will begin blinking and the program will report 'Initialized' if the board is properly found and initialized. Then click 'Connect' to connect to board and 'Report' to begin reporting values.";
        }

        private BluetoothClient btClient = new BluetoothClient();
        private string boardName = "";
        private BluetoothAddress boardAddr;
        private WiimoteCollection deviceCollection = new WiimoteCollection();
        private Wiimote wiiDevice = new Wiimote();

        private void initButton_Click(object sender, EventArgs e)
        {
            hardLabel.Text = "Detecting devices...";
            hardLabel.Refresh();

            var btDiscover = btClient.DiscoverDevices(255, false, false, true);

            foreach (var btItem in btDiscover)
            {
                if (btItem.DeviceName.Contains("Nintendo"))
                {
                    boardName = btItem.DeviceName;
                    boardAddr = btItem.DeviceAddress;

                    hardLabel.Text = "Detected\n" + boardName + "\n" + boardAddr.ToString();
                    hardLabel.Refresh();

                    btItem.SetServiceState(BluetoothService.HumanInterfaceDevice, true);
                    System.Threading.Thread.Sleep(4000);

                    hardLabel.Text = "Initialized\n" + boardName + "\n" + boardAddr.ToString();
                    hardLabel.Refresh();

                    break;
                }
            }

            if (hardLabel.Text.Contains("Detecting"))
            {
                hardLabel.Text = "Device not found, please try again.";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var btExistingList = btClient.DiscoverDevices(255, false, true, false);

            foreach (var btItem in btExistingList)
            {
                if (!btItem.DeviceName.Contains("Nintendo"))
                {
                    continue;
                }

                BluetoothSecurity.RemoveDevice(btItem.DeviceAddress);
                btItem.SetServiceState(BluetoothService.HumanInterfaceDevice, false);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                deviceCollection.FindAllWiimotes();
                wiiDevice = deviceCollection[0];
                wiiDevice.Connect();
                wiiDevice.SetLEDs(true, true, true, true);
                wiiDevice.WiimoteChanged += wiiDevice_WiimoteChanged;

                softLabel.Text = "Board Connected.\nReady to report values.";
            }
            catch
            {
                softLabel.Text = "No device found in HID list. Please use the 'Initialize' button below and click the red 'SYNC' button on the bottom of the balance board.";
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            wiiDevice.SetLEDs(false, false, false, false);
            wiiDevice.Disconnect();

            softLabel.Text = "Board disconnected.";
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            infoUpdateTimer.Enabled = !infoUpdateTimer.Enabled;
        }

        void infoUpdateTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(() => report()));
        }

        private void report()
        {
            var topLeft = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopLeft;
            var topRight = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.TopRight;
            var bottomLeft = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomLeft;
            var bottomRight = wiiDevice.WiimoteState.BalanceBoardState.SensorValuesKg.BottomRight;
            var totalWeight = wiiDevice.WiimoteState.BalanceBoardState.WeightKg;

            reportLabel.Text = topLeft.ToString("0.0") + "    " + topRight.ToString("0.0") + "\n"
                + bottomLeft.ToString("0.0") + "    " + bottomRight.ToString("0.0") + "\n"
                + totalWeight.ToString("0.0");

            var x = topRight + bottomRight - topLeft - bottomLeft;
            var y = topLeft + topRight - bottomLeft - bottomRight;

            x = reportPlot.Size.Width / 2 + x - reportCenter.Size.Width / 2;
            y = reportPlot.Size.Height / 2 - y + reportCenter.Size.Height / 2;

            reportCenter.Location = new System.Drawing.Point((int)x, (int)y);
        }

        private void wiiDevice_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            // Called every time there is a sensor update, values available using e.WiimoteState.
            // Use this for tracking and filtering rapid accelerometer and gyroscope sensor data.
            // The balance board values are basic, so can be accessed directly only when needed.
        }
    }
}
