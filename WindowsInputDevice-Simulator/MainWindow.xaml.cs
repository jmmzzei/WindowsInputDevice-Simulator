using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows;
using System.Windows.Controls;
namespace WindowsInputDevice_Simulator
{
    public partial class MainWindow : Window
    {
        Dictionary<string, string> keystroke = new Dictionary<string, string>
        {
            {"Double", "d" },
            {"Long", "l" },
            {"Click", "c" },
            {"+", "p" },
            {"-", "m" }
        };
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
            port.Write(keystroke[((Button)sender).Content.ToString()]);
        }
    }
}
