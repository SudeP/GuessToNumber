using GuessToNumber.Gateway;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GuessToNumber.Server
{
    public partial class WFMain : MaterialForm
    {
        public WFMain()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            server = new YuppiServer(new IPEndPoint(IPAddress.Any, 7536), Encoding.UTF8);

            server.OnLog += Server_OnLog;

            server.OnRecieveServer += Server_OnRecieveServer;

            FormClosing += WFMain_FormClosing;
        }

        private readonly YuppiServer server;

        private void Server_OnLog(string message, string stackTrace, bool isError)
        {
            Log(message, stackTrace, isError);
        }

        private void Server_OnRecieveServer(SocketData socketData, ISocket handledSocket)
        {
            Log(socketData.JsonString(), "Server_OnRecieveServer", false);
        }

        private void Log(string message, string trace, bool isError)
        {
            Invoke(new Action(() =>
            {
                var old = rtbxLog.Text.Length;

                string text = $@"{DateTime.Now.ToShortTimeString()}|{trace}|{message}{Environment.NewLine}";

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
                server.Stop();
        }

        private void MrbtnStartServer_Click(object sender, EventArgs e)
        {
            mrbtnStartServer.Enabled = false;
            mrbtnStopServer.Enabled = true;
            server.Start();
            mlblStatu.Text = $@"Runnig";
            mlblStatu.ForeColor = Color.Green;
        }

        private void MrbtnStopServer_Click(object sender, EventArgs e)
        {
            mrbtnStartServer.Enabled = true;
            mrbtnStopServer.Enabled = false;
            server.Stop();
            mlblStatu.Text = $@"Stopped";
            mlblStatu.ForeColor = Color.Red;
        }

        private void MfbtnRefreshLobbies_Click(object sender, EventArgs e)
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
}
