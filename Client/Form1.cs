using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    public partial class Form1 : Form
    {
        IPEndPoint ipserver;
        Socket Server;
        Socket Client;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipserver = new IPEndPoint(IPAddress.Any, 1234);
            Server.Bind(ipserver);
            Server.Listen(5);
            Client = Server.Accept();
            byte[] data = new byte[1024];
            Client.Receive(data);
            listBox1.Items.Add("Server: " + Encoding.ASCII.GetString(data));
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            ipserver = new IPEndPoint(IPAddress.Parse("192.168.1.50"), 1234);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Client.Connect(ipserver);
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(textBox2.Text);
            listBox1.Items.Add("Client: " + textBox2.Text);
            textBox2.Text = "";
            Client.Send(data);
            data = new byte[1024];
            Client.Receive(data);
            string text = Encoding.ASCII.GetString(data);
            listBox1.Items.Add("Server: " + text);
        }
    }
}
