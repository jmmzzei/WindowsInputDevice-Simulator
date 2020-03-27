using System;
using System.IO.Ports;
using System.Windows;

namespace WindowsInputDevice_Simulator
{
    public partial class MainWindow : Window
    {
        SerialPort port = new SerialPort();
        public MainWindow()
        {
            InitializeComponent();
            configurePort(port);
            if (!port.IsOpen)
                port.Open();
        }
        
        public void configurePort(SerialPort p)
        {
            port.BaudRate = 9600;
            port.PortName = "COM20";
            port.DtrEnable = true;
            port.DtrEnable = true;
            port.Parity = Parity.None;
            port.DataBits = 8;
        }

        public void sendKeystroke(object sender, EventArgs e)
        {
            port.WriteLine("+");
        }
    }
}
