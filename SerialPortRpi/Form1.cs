using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortRpi
{
    public partial class Form1 : Form
    {
        string selectedCOMPort = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        Timer WatchUpdateTimer;
        private void Form1_Load(object sender, EventArgs e)
        {
            WatchUpdateTimer = new Timer();
            WatchUpdateTimer.Interval = 500; //500ms
            WatchUpdateTimer.Tick += WatchUpdateTimer_Tick;
            WatchUpdateTimer.Enabled = true;

            UpDateSerialPorts();
        }

        private void UpDateSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            lbSerialPorts.Items.Clear();
            lbSerialPorts.Items.AddRange(ports);
        }

        private void WatchUpdateTimer_Tick(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                lbnTime.Text = DateTime.Now.ToShortTimeString();
            });
            
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            frmNumInput newBaudMaker = new frmNumInput(serialPort.BaudRate);
            newBaudMaker.ShowDialog();
            if (newBaudMaker.isValid)
            {
                serialPort.BaudRate = newBaudMaker.BaudRate;
                label4.Text = serialPort.BaudRate.ToString();
            }
        }

        private void lbSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbSerialPorts.SelectedIndex;
            if(index != -1)
            {
                //Valid Selcetion
                gpConnection.Visible = true;
                selectedCOMPort = lbSerialPorts.Items[index].ToString();
                btnConnect.Text = $"Connect to {selectedCOMPort}";
                
            }
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            frmNewMessage newMsgMaker = new frmNewMessage();
            newMsgMaker.ShowDialog();
            if (newMsgMaker.vaild)
            {
                if (serialPort.IsOpen)
                    serialPort.Write(newMsgMaker.text);
                else
                    tbConsole.AppendText("SerialPort not connected!"+Environment.NewLine);
            }
        }
    }
}
