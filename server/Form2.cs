using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace server
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                PingIP = "192.168.0.";
            }
            else if (checkBox2.Checked == true)
            {
                PingIP = "192.168.1.";
            }
            else if (!string.IsNullOrEmpty(textBox1.Text))
            {
                PingIP = textBox1.Text;
            }

            await PingforIP();
        }

        private async Task PingforIP()
        {
            if (string.IsNullOrEmpty(PingIP))
            {
                return;
            }

            var tasks = new List<Task>();

            for (int i = 1; i < 254; i++)
            {
                string ipAddress = $"{PingIP}{i}";

                tasks.Add(PingforIP1(ipAddress, i));
            }
            await Task.WhenAll(tasks);
        }

        private async Task PingforIP1(string ipAddress, int index)
        {
            try
            {
                Ping pingSender = new Ping();
                PingReply reply = await pingSender.SendPingAsync(ipAddress);

                if (reply.Status == IPStatus.Success)
                {
                    richTextBox1.AppendText(ipAddress + "\n");
                }

            }
            catch (PingException ex)
            {
                richTextBox1.AppendText($"Error : {ex.Message}\n");
            }
        }


    }
}
