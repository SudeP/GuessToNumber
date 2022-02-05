using GuessToNumber.Gateway;
using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GuessToNumber.Server
{
    public partial class UCTestClient : UserControl
    {
        public UCTestClient()
        {
            InitializeComponent();
        }

        private YuppiClient client;

        private void Client_OnRecieveClient(SocketData socketData)
        {
            Log(socketData.JsonString(), "Client_OnRecieveClient", false);
        }

        private void Client_OnLog(string message, string stackTrace, bool isError)
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

        private void MfbtnConnect_Click(object sender, EventArgs e)
        {
            mfbtnConnect.Enabled = false;

            mfbtnDisconnect.Enabled = true;
            mfbtnCreateLobby.Enabled = true;
            mfbtnJoinLobby.Enabled = true;

            client = new YuppiClient(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7536), Encoding.UTF8);

            client.OnLog += Client_OnLog;
            client.OnRecieveClient += Client_OnRecieveClient;

            client.Start();

            mlblClientId.Text = $@"Runnig";
            mlblClientId.ForeColor = Color.Green;
        }

        private void MfbtnDisconnect_Click(object sender, EventArgs e)
        {
            mfbtnConnect.Enabled = true;

            mfbtnDisconnect.Enabled = false;
            mfbtnAllClientSendWithMe.Enabled = false;
            mfbtnAllClientSendWithoutMe.Enabled = false;
            mfbtnCreateLobby.Enabled = false;
            mfbtnJoinLobby.Enabled = false;
            mfbtnSendToServer.Enabled = false;
            mfbtnClientToClient.Enabled = false;

            client.Stop();

            client.OnLog -= Client_OnLog;
            client.OnRecieveClient -= Client_OnRecieveClient;

            client.Dispose();

            mlblClientId.Text = $@"Stopped";
            mlblClientId.ForeColor = Color.Red;
        }

        private void MfbtnCreateLobby_Click(object sender, EventArgs e)
        {
            client.CreateLobby(new LobbySettings { AuthorizationKey = msltfAuthKey.Text, Capacity = uint.Parse(msltfCapacity.Text) });

            mfbtnSendToServer.Enabled = true;
            mfbtnClientToClient.Enabled = true;
            mfbtnAllClientSendWithMe.Enabled = true;
            mfbtnAllClientSendWithoutMe.Enabled = true;
        }

        private void MfbtnJoinLobby_Click(object sender, EventArgs e)
        {
            client.JoinLobby(msltfAuthKey.Text);

            mfbtnSendToServer.Enabled = true;
            mfbtnClientToClient.Enabled = true;
            mfbtnAllClientSendWithMe.Enabled = true;
            mfbtnAllClientSendWithoutMe.Enabled = true;
        }

        private void MfbtnAllClientSendWithMe_Click(object sender, EventArgs e)
        {
            client.Send.ToClients(mslftMessage.Text, false);
        }

        private void MfbtnAllClientSendWithoutMe_Click(object sender, EventArgs e)
        {
            client.Send.ToClients(mslftMessage.Text, true);
        }

        private void MfbtnSendToServer_Click(object sender, EventArgs e)
        {
            client.Send.ToServer("Client to Server Request. Client Id = " + client.Id);
        }

        private void MfbtnClientToClient_Click(object sender, EventArgs e)
        {
            client.Send.ToClient(
                $@"Target message for your friend !. Source = {client.Id} | | | Destination = {mslftTargetClientId.Text}",
                uint.Parse(mslftTargetClientId.Text)
            );
        }
    }
}
