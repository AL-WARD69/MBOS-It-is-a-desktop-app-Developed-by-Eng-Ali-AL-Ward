using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace MBOS_Full_System
{
    public partial class Formsendsms : Form
    {
        private SerialPort _serialPort;
        public Formsendsms()
        {
            InitializeComponent();
        }

        private void Formsendsms_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            string message = txtMessage.Text;
                        //Replace "COM8"withcorresponding port name
            _serialPort = new SerialPort("COM8", 115200);
            Thread.Sleep(100);
            _serialPort.Open();
            Thread.Sleep(100);
            _serialPort.Write("AT+CMGF=1\r");

            Thread.Sleep(100);

            _serialPort.Write("AT+CMGS=\"" + number + "\"\r\n");

            Thread.Sleep(100);

            _serialPort.Write(message + "\x1A");

            Thread.Sleep(300);

            label1.Text = "Message sent !!";

            _serialPort.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SMSCOMMS SMSEngine = new SMSCOMMS("COM1");
            SMSEngine.Open();
            SMSEngine.SendSMS("919888888888", "THIS IS YOUR MESSAGE");
        }
    }
}
