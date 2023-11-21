using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Dyscord
{
    public delegate void UpdateConversationDelegate(string text);
    public partial class DyscordForm : Form
    {
        string targetUser = "";
        string targetIp = "";
        int targetPort;
        string myIp = "";
        int myPort = 2222;
        Thread thread;
        Socket listener;

        public DyscordForm()
        {
            InitializeComponent();


            this.Show();
            SettingsForm settingsForm = new SettingsForm(this, myPort);
            settingsForm.ShowDialog();
            this.myPort = settingsForm.myPort;

            ThreadStart threadStart = new ThreadStart(Listen);
            thread = new Thread(threadStart);
            thread.Start();

            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress iPAddress in ipHost.AddressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    this.myIp = iPAddress.ToString();
                    break;
                }
            }

            this.loginButton.Click += new EventHandler(LoginButton__Click);
            this.usersButton.Click += new EventHandler(UsersButton__Click);
            this.sendButton.Click += new EventHandler(SendButton__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__Completed);
        }

        public void UpdateConversation(string text)
        {
            this.convRichTextBox.Text += text + '\n';
        }

        public void Listen()
        {
            UpdateConversationDelegate updateConversationDelegate;
            updateConversationDelegate = new UpdateConversationDelegate(UpdateConversation);
            
            IPEndPoint serverEndpoint = new IPEndPoint(IPAddress.Any, this.myPort);
            this.listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.listener.Bind(serverEndpoint);

            listener.Listen(100);

            while(true)
            {
                Socket client = listener.Accept();
                Stream netStream = new NetworkStream(client);
                StreamReader reader = new StreamReader(netStream);
                string result = reader.ReadToEnd();
                Invoke(updateConversationDelegate, result);
                reader.Close();
                netStream.Close();
                client.Close();
            }
        }

        private void LoginButton__Click(object sender, EventArgs e)
        {
            if (userTextBox.TextLength > 0)
            {
                webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?login=" + userTextBox.Text + "&ip=" + this.myIp + ":" + this.myPort);
                webBrowser1.Visible = false;
                userTextBox.Enabled = false;
                loginButton.Enabled = false;
            }
        }

        private void UsersButton__Click(Object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://people.rit.edu/dxsigm/php/login.php?logins");
            webBrowser1.Visible = true;
            convRichTextBox.SendToBack();
        }

        private void SendButton__Click(Object sender, EventArgs e)
        {
            if (targetIp.Length > 0)
            {
                IPAddress iPAddress = IPAddress.Parse(this.targetIp);
                IPEndPoint remoteEndpoint = new IPEndPoint(iPAddress, this.targetPort);

                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(remoteEndpoint);
                Stream netStream = new NetworkStream(server);
                StreamWriter writer = new StreamWriter(netStream);

                string msg = userTextBox.Text + ": " + message.Text;
                writer.WriteLine(msg.ToCharArray(), 0, msg.Length);

                writer.Close();
                netStream.Close();
                server.Close();

                this.convRichTextBox.Text += "> " + this.targetUser + message.Text + '\n';
                message.Clear();
            }
        }

        private void ExitButton__Click(Object sender, EventArgs e)
        {
            listener.Close();
            thread.Abort();
            Application.Exit();
        }

        private void WebBrowser1__Completed(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlElementCollection = webBrowser1.Document.GetElementsByTagName("button");
            foreach (HtmlElement htmlElement in htmlElementCollection)
            {
                htmlElement.Click += new HtmlElementEventHandler(HtmlElement__Click);
            }
        }

        private void HtmlElement__Click(object sender, HtmlElementEventArgs e)
        {
            HtmlElement htmlElement = (HtmlElement)sender;

            string title = htmlElement.GetAttribute("title");
            string[] ipPort = title.Split(':');
            this.targetIp = ipPort[0];
            this.targetPort = Int32.Parse(ipPort[1]);

            this.targetUser = htmlElement.GetAttribute("name");
            this.groupBox1.Text = "Conversing with " + this.targetUser;

            webBrowser1.Visible = false;
            webBrowser1.SendToBack();
        }
    }
}
