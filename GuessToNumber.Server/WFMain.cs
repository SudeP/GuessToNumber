using GuessToNumber.Gateway;
using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GuessToNumber.Server
{
    public partial class WFMain : Form
    {
        #region Others
        public WFMain()
        {
            InitializeComponent();

            FormClosing += WFMain_FormClosing;
        }

        private YuppiServer server;
        private IPAddress ipAddress = IPAddress.Any;
        private int port = 7536;
        #endregion

        #region Server Manage
        private void Server_OnRecieveServer(SocketData socketData, ISocket handledSocket)
        {
            Log(socketData.JsonString(), "Server_OnRecieveServer", false);

        }
        #endregion

        #region Other
        private void Server_OnLog(string message, string stackTrace, bool isError)
        {
            Log(message, stackTrace, isError);
        }
        private void Log(string message, string trace, bool isError)
        {
            Invoke(new Action(() =>
            {
                var old = rtbxLog.Text.Length;

                string text = $@"{DateTime.Now.ToLongTimeString()}|{trace}|{message}{Environment.NewLine}";

                rtbxLog.Text += text;

                rtbxLog.Select(old, old + text.Length);
                rtbxLog.SelectionColor = isError ? Color.Red : Color.White;

                rtbxLog.DeselectAll();

                if (rtbxLog.Text.Length >= 50_000)
                {
                    rtbxLog.Clear();
                    return;
                }

                if (mchbxScrollToEnd.Checked)
                {
                    rtbxLog.SelectionStart = rtbxLog.Text.Length;
                    rtbxLog.ScrollToCaret();
                }
            }));
        }

        private void WFMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (server != null)
            {
                server.Stop();

                server.OnLog -= Server_OnLog;

                server.OnRecieveServer -= Server_OnRecieveServer;

                server.Dispose();
            }
        }

        private void MrbtnStartServer_Click(object sender, EventArgs e)
        {
            mrbtnStartServer.Enabled = false;
            mrbtnStopServer.Enabled = true;


            server = new YuppiServer(new IPEndPoint(ipAddress, port), Encoding.UTF8);

            server.OnLog += Server_OnLog;

            server.OnRecieveServer += Server_OnRecieveServer;

            server.Start();

            mlblStatu.Text = $@"Runnig";
            mlblStatu.ForeColor = Color.Green;
        }

        private void MrbtnStopServer_Click(object sender, EventArgs e)
        {
            mrbtnStartServer.Enabled = true;
            mrbtnStopServer.Enabled = false;

            server.Stop();

            server.OnLog -= Server_OnLog;

            server.OnRecieveServer -= Server_OnRecieveServer;

            server.Dispose();

            mlblStatu.Text = $@"Stopped";
            mlblStatu.ForeColor = Color.Red;
        }

        private void MfbtnRefreshLobbies_Click(object sender, EventArgs e)
        {
            if (server != null && server.lobbies != null)
            {
                twLobbies.Nodes.Clear();

                foreach (var lobby in server.lobbies)
                {
                    twLobbies.Nodes.Add(lobby.Key);

                    var tree = twLobbies.Nodes[twLobbies.Nodes.Count - 1];
                    foreach (var client in lobby.Value.Clients)
                    {
                        tree.Nodes.Add($@"{client.Key} - {client.Value.Socket.RemoteEndPoint}");
                    }
                }

                mlblClientCount.Text = $@"Client Count : {server.sockets.Count}";
                mlblLobbyCount.Text = $@"Lobby Count : {server.lobbies.Count}";

                twLobbies.ExpandAll();
            }
        }

        private void MtbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            msltfCustomIp.Enabled = mtbtnCustom.Checked;
        }

        private void MtbtnAny_CheckedChanged(object sender, EventArgs e)
        {
            if (mtbtnCustom.Checked)
                ipAddress = IPAddress.Any;
        }

        private void MtbtnLocalIp_CheckedChanged(object sender, EventArgs e)
        {
            if (mtbtnCustom.Checked)
                ipAddress = IPAddress.Parse("127.0.0.1");
        }

        private void MtbtnLocalHost_CheckedChanged(object sender, EventArgs e)
        {
            if (mtbtnCustom.Checked)
                ipAddress = IPAddress.Parse("localhost");
        }

        private void MsltfPort_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(msltfPort.Text, out int newPort))
                port = newPort;
        }

        private void MsltfCustomIp_TextChanged(object sender, EventArgs e)
        {
            if (IPAddress.TryParse(msltfCustomIp.Text, out IPAddress newIpAddress))
                ipAddress = newIpAddress;
        }
        #endregion
    }
}