using System;
using System.Windows.Forms;

namespace SerialPortRpi
{
    public partial class frmNumInput : Form
    {
        public int BaudRate { get; set; }
        public bool isValid { get; set; }
        public frmNumInput(int currentBaudRate)
        {
            InitializeComponent();
            BaudRate = currentBaudRate;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lbnNewBaudRate.Text = lbnNewBaudRate.Text.Substring(0, lbnNewBaudRate.Text.Length - 1);
            }
            catch { }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaudRate = Convert.ToInt32(lbnNewBaudRate.Text);
            isValid = true;
            Close();
        }

        private void frmNewBaudRate_Load(object sender, EventArgs e)
        {
            lbnNewBaudRate.Text = "";
        }
    }
}
