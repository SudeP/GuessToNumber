using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Yuppi.Environment;
using Yuppi.Manager.SocketLobbyManagement;
using Yuppi.Networking.Abstract;
using Yuppi.Networking.Inheritance;

namespace GuessToNumber.Server
{
    public partial class YuppiTest : Form
    {
        public YuppiTest()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            StopServer();

            Process.GetCurrentProcess().Kill();
        }

        private IPAddress address = IPAddress.Any;
        private int port = 7536;

        private void Management_OnLog(object sender, string message, string stackTrace, LogType type)
        {
            Color color = Color.White;

            if (type == LogType.Info)
                color = Color.FromArgb(151, 151, 151);
            else if (type == LogType.Log)
                color = Color.FromArgb(255, 255, 255);
            else if (type == LogType.Warning)
                color = Color.FromArgb(255, 121, 5);
            else if (type == LogType.Error)
                color = Color.FromArgb(212, 0, 0);

            Log(rtbxLog, cbxAutoScroll.Checked, string.Format("{0}{1}{2}{3}", message, "\r\n", "\t", stackTrace), color);
        }

        private void Log(RichTextBox rtbx, bool isAutoScroll, string message, Color color)
        {
            var prevTextLength = rtbx.Text.Length;

            string newLine = string.Format("{0} {1}{2}{3}",
                DateTime.Now.ToLongTimeString(),
                message,
                Environment.NewLine,
                Environment.NewLine
            );

            rtbx.AppendText(newLine);

            rtbx.Select(prevTextLength, prevTextLength + newLine.Length);

            rtbx.SelectionColor = color;

            rtbx.DeselectAll();

            if (rtbx.Text.Length >= 50_000)
            {
                rtbx.Clear();
                return;
            }

            if (isAutoScroll)
            {
                rtbx.SelectionStart = rtbxLog.Text.Length;
                rtbx.ScrollToCaret();
            }
        }

        #region Server Side
        private SocketLobbyManagement management;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartServer();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            StopServer();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void StartServer()
        {
            management = new SocketLobbyManagement(address, port);

            management.OnLog += Management_OnLog;

            management.server.Start();
        }

        private void StopServer()
        {
            if (management != null)
            {
                try
                {
                    management.Dispose();
                    management = null;
                }
                catch (Exception ex)
                {
                    Log(rtbxLog, cbxAutoScroll.Checked, ex.ToString(), Color.Red);
                }
            }
        }
        #endregion

        #region Client1 Side
        private SocketClient client1;

        private void btnStartClient1_Click(object sender, EventArgs e)
        {
        }

        private void btnStopClient1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateClient1_Click(object sender, EventArgs e)
        {

        }

        private void btnJoinClient1_Click(object sender, EventArgs e)
        {

        }

        private void btnWithMeClient1_Click(object sender, EventArgs e)
        {

        }

        private void btnWithoutMeClient1_Click(object sender, EventArgs e)
        {

        }

        private void btnServerClient1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientClient1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Client2 Side
        private void btnStartClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnStopClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnJoinClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnWithMeClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnWithoutMeClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnServerClient2_Click(object sender, EventArgs e)
        {

        }

        private void btnClientClient2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void StartClient(SocketClient client)
        {
            client = new SocketClient(IPAddress.Parse("127.0.0.1"), port);

            client.OnLog += Client_OnLog;

            client.ListenRemoteEndPoint();

            //client.OnReceive += Client_OnReceive;

        }

        //private void Client_OnReceive(Yuppi.Struct.P2PMessage request)
        //{
        //    if (request.destination == 101)
        //    {
        //        Log(rtbxLogClient1, cbxAutoScrollClient1.Checked, )
        //    }
        //    else
        //    {

        //    }
        //}

        private void Client_OnLog(object sender, string message, string stackTrace, LogType type)
        {
            Color color = Color.White;

            if (type == LogType.Info)
                color = Color.FromArgb(151, 151, 151);
            else if (type == LogType.Log)
                color = Color.FromArgb(255, 255, 255);
            else if (type == LogType.Warning)
                color = Color.FromArgb(255, 121, 5);
            else if (type == LogType.Error)
                color = Color.FromArgb(212, 0, 0);

            if (((SocketNode)sender).Identity == 101)
            {
                Log(
                    rtbxLogClient1,
                    cbxAutoScrollClient1.Checked,
                    string.Format("{0}{1}{2}{3}", message, "\r\n", "\t", stackTrace),
                    color);
            }
            else
            {
                Log(
                    rtbxLogClient1,
                    cbxAutoScrollClient1.Checked,
                    string.Format("{0}{1}{2}{3}", message, "\r\n", "\t", stackTrace),
                    color);
            }
        }
    }
}
