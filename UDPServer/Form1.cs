using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace UDPServer
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecieve_Click(object sender, EventArgs e)
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAdress.Any, 0);
            UdpClient client = new UdpClient(12345);
            byte[] inström = client.Receive(ref clientEndPoint);
            tbxMessage.Text = Encoding.Unicode.GetString(inström);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
