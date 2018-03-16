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

namespace TH1Bai1
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

        private void btn_file_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Server = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
            ipserver = new IPEndPoint(IPAddress.Any, 1234);
            Server.Bind(ipserver);
            Server.Listen(5);
            Client = Server.Accept();
            textBox2.Text = (Client.RemoteEndPoint).ToString();
            byte[] data = new byte[1024];
            Client.Receive(data);
            listBox1.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }

        private void btn_f5_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            listBox1.Items.Add("Server: " + text);
            textBox2.Text = "";
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(text);
            Client.Send(data);
            data = new byte[1024];
            Client.Receive(data);
            listBox1.Items.Add("Client: " + Encoding.ASCII.GetString(data));
        }
    }
}
