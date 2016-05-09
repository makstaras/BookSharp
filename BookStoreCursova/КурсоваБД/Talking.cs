﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;

using System.Web;
using System.Net.Mail;



namespace КурсоваБД
{
    public partial class Talking : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;


        public Talking()
        {
            InitializeComponent();

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textLocalIP.Text = getLocal();
            textFriendIP.Text = getLocal();

            password.PasswordChar = '*';
        }

        private string getLocal() 
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void messageCallBack(IAsyncResult async) 
        {
            try {
                int size = socket.EndReceiveFrom(async, ref epRemote);
                if (size > 0) {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])async.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    listBox1.Items.Add("Відповідь: " + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            
        }

       


       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIP.Text), Convert.ToInt32(textLocalPort.Text));
                socket.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textFriendIP.Text), Convert.ToInt32(textFriendPort.Text));
                socket.Connect(epRemote);

                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

                button4.Text = "З'єднано";
                button4.Enabled = false;
                button5.Enabled = true;
                textBox1.Focus();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            { 
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textBox1.Text);

                socket.Send(msg);
                listBox1.Items.Add("Ви: " + textBox1.Text);
                textBox1.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void attachBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            if (dl.ShowDialog() == DialogResult.OK)
            {
                string picPath = dl.FileName.ToString();
                attach.Text = picPath;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
          //  mail.Attachments.Add(new Attachment(attach.Text));
            SmtpClient client = new SmtpClient(smtp.Text);
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Email sent", "Success", MessageBoxButtons.OK);
        }
    }
}
