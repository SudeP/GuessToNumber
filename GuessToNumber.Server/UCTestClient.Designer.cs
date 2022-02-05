
using System.Windows.Forms;

namespace GuessToNumber.Server
{
    partial class UCTestClient
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbxLog = new System.Windows.Forms.RichTextBox();
            this.mfbtnConnect = new System.Windows.Forms.Button();
            this.mfbtnDisconnect = new System.Windows.Forms.Button();
            this.mfbtnCreateLobby = new System.Windows.Forms.Button();
            this.mfbtnJoinLobby = new System.Windows.Forms.Button();
            this.mfbtnAllClientSendWithMe = new System.Windows.Forms.Button();
            this.mfbtnAllClientSendWithoutMe = new System.Windows.Forms.Button();
            this.mfbtnSendToServer = new System.Windows.Forms.Button();
            this.mlblClientId = new System.Windows.Forms.Label();
            this.msltfAuthKey = new System.Windows.Forms.TextBox();
            this.mchbxScrollToEnd = new System.Windows.Forms.CheckBox();
            this.msltfCapacity = new System.Windows.Forms.TextBox();
            this.mslftMessage = new System.Windows.Forms.TextBox();
            this.mfbtnClientToClient = new System.Windows.Forms.Button();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.mslftTargetClientId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbxLog
            // 
            this.rtbxLog.BackColor = System.Drawing.Color.Black;
            this.rtbxLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.rtbxLog.ForeColor = System.Drawing.Color.White;
            this.rtbxLog.Location = new System.Drawing.Point(0, 0);
            this.rtbxLog.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxLog.Name = "rtbxLog";
            this.rtbxLog.Size = new System.Drawing.Size(814, 492);
            this.rtbxLog.TabIndex = 0;
            this.rtbxLog.Text = "";
            // 
            // mfbtnConnect
            // 
            this.mfbtnConnect.AutoSize = true;
            this.mfbtnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnConnect.Location = new System.Drawing.Point(824, 9);
            this.mfbtnConnect.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnConnect.Name = "mfbtnConnect";
            this.mfbtnConnect.Size = new System.Drawing.Size(172, 29);
            this.mfbtnConnect.TabIndex = 1;
            this.mfbtnConnect.Text = "Connect To Server";
            this.mfbtnConnect.UseVisualStyleBackColor = true;
            this.mfbtnConnect.Click += new System.EventHandler(this.MfbtnConnect_Click);
            // 
            // mfbtnDisconnect
            // 
            this.mfbtnDisconnect.AutoSize = true;
            this.mfbtnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnDisconnect.Enabled = false;
            this.mfbtnDisconnect.Location = new System.Drawing.Point(1008, 9);
            this.mfbtnDisconnect.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnDisconnect.Name = "mfbtnDisconnect";
            this.mfbtnDisconnect.Size = new System.Drawing.Size(172, 29);
            this.mfbtnDisconnect.TabIndex = 2;
            this.mfbtnDisconnect.Text = "Disconnect Client";
            this.mfbtnDisconnect.UseVisualStyleBackColor = true;
            this.mfbtnDisconnect.Click += new System.EventHandler(this.MfbtnDisconnect_Click);
            // 
            // mfbtnCreateLobby
            // 
            this.mfbtnCreateLobby.AutoSize = true;
            this.mfbtnCreateLobby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnCreateLobby.Enabled = false;
            this.mfbtnCreateLobby.Location = new System.Drawing.Point(824, 63);
            this.mfbtnCreateLobby.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnCreateLobby.Name = "mfbtnCreateLobby";
            this.mfbtnCreateLobby.Size = new System.Drawing.Size(145, 29);
            this.mfbtnCreateLobby.TabIndex = 3;
            this.mfbtnCreateLobby.Text = "Create A Lobby";
            this.mfbtnCreateLobby.UseVisualStyleBackColor = true;
            this.mfbtnCreateLobby.Click += new System.EventHandler(this.MfbtnCreateLobby_Click);
            // 
            // mfbtnJoinLobby
            // 
            this.mfbtnJoinLobby.AutoSize = true;
            this.mfbtnJoinLobby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnJoinLobby.Enabled = false;
            this.mfbtnJoinLobby.Location = new System.Drawing.Point(985, 63);
            this.mfbtnJoinLobby.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnJoinLobby.Name = "mfbtnJoinLobby";
            this.mfbtnJoinLobby.Size = new System.Drawing.Size(127, 29);
            this.mfbtnJoinLobby.TabIndex = 4;
            this.mfbtnJoinLobby.Text = "Join A Lobby";
            this.mfbtnJoinLobby.UseVisualStyleBackColor = true;
            this.mfbtnJoinLobby.Click += new System.EventHandler(this.MfbtnJoinLobby_Click);
            // 
            // mfbtnAllClientSendWithMe
            // 
            this.mfbtnAllClientSendWithMe.AutoSize = true;
            this.mfbtnAllClientSendWithMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnAllClientSendWithMe.Enabled = false;
            this.mfbtnAllClientSendWithMe.Location = new System.Drawing.Point(823, 115);
            this.mfbtnAllClientSendWithMe.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnAllClientSendWithMe.Name = "mfbtnAllClientSendWithMe";
            this.mfbtnAllClientSendWithMe.Size = new System.Drawing.Size(226, 29);
            this.mfbtnAllClientSendWithMe.TabIndex = 5;
            this.mfbtnAllClientSendWithMe.Text = "All Client Send With Me";
            this.mfbtnAllClientSendWithMe.UseVisualStyleBackColor = true;
            this.mfbtnAllClientSendWithMe.Click += new System.EventHandler(this.MfbtnAllClientSendWithMe_Click);
            // 
            // mfbtnAllClientSendWithoutMe
            // 
            this.mfbtnAllClientSendWithoutMe.AutoSize = true;
            this.mfbtnAllClientSendWithoutMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnAllClientSendWithoutMe.Enabled = false;
            this.mfbtnAllClientSendWithoutMe.Location = new System.Drawing.Point(824, 162);
            this.mfbtnAllClientSendWithoutMe.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnAllClientSendWithoutMe.Name = "mfbtnAllClientSendWithoutMe";
            this.mfbtnAllClientSendWithoutMe.Size = new System.Drawing.Size(253, 29);
            this.mfbtnAllClientSendWithoutMe.TabIndex = 6;
            this.mfbtnAllClientSendWithoutMe.Text = "All Client Send Without Me";
            this.mfbtnAllClientSendWithoutMe.UseVisualStyleBackColor = true;
            this.mfbtnAllClientSendWithoutMe.Click += new System.EventHandler(this.MfbtnAllClientSendWithoutMe_Click);
            // 
            // mfbtnSendToServer
            // 
            this.mfbtnSendToServer.AutoSize = true;
            this.mfbtnSendToServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnSendToServer.Enabled = false;
            this.mfbtnSendToServer.Location = new System.Drawing.Point(824, 216);
            this.mfbtnSendToServer.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnSendToServer.Name = "mfbtnSendToServer";
            this.mfbtnSendToServer.Size = new System.Drawing.Size(145, 29);
            this.mfbtnSendToServer.TabIndex = 7;
            this.mfbtnSendToServer.Text = "Send To Server";
            this.mfbtnSendToServer.UseVisualStyleBackColor = true;
            this.mfbtnSendToServer.Click += new System.EventHandler(this.MfbtnSendToServer_Click);
            // 
            // mlblClientId
            // 
            this.mlblClientId.AutoSize = true;
            this.mlblClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mlblClientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblClientId.Location = new System.Drawing.Point(1077, 122);
            this.mlblClientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblClientId.Name = "mlblClientId";
            this.mlblClientId.Size = new System.Drawing.Size(0, 18);
            this.mlblClientId.TabIndex = 8;
            // 
            // msltfAuthKey
            // 
            this.msltfAuthKey.Enabled = false;
            this.msltfAuthKey.Location = new System.Drawing.Point(940, 275);
            this.msltfAuthKey.Margin = new System.Windows.Forms.Padding(4);
            this.msltfAuthKey.Name = "msltfAuthKey";
            this.msltfAuthKey.Size = new System.Drawing.Size(240, 26);
            this.msltfAuthKey.TabIndex = 9;
            this.msltfAuthKey.Text = "1du82";
            // 
            // mchbxScrollToEnd
            // 
            this.mchbxScrollToEnd.AutoSize = true;
            this.mchbxScrollToEnd.Checked = true;
            this.mchbxScrollToEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchbxScrollToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mchbxScrollToEnd.Location = new System.Drawing.Point(818, 448);
            this.mchbxScrollToEnd.Margin = new System.Windows.Forms.Padding(0);
            this.mchbxScrollToEnd.Name = "mchbxScrollToEnd";
            this.mchbxScrollToEnd.Size = new System.Drawing.Size(112, 21);
            this.mchbxScrollToEnd.TabIndex = 10;
            this.mchbxScrollToEnd.Text = "Scroll To End";
            this.mchbxScrollToEnd.UseVisualStyleBackColor = true;
            // 
            // msltfCapacity
            // 
            this.msltfCapacity.Enabled = false;
            this.msltfCapacity.Location = new System.Drawing.Point(940, 318);
            this.msltfCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.msltfCapacity.Name = "msltfCapacity";
            this.msltfCapacity.Size = new System.Drawing.Size(240, 26);
            this.msltfCapacity.TabIndex = 11;
            this.msltfCapacity.Text = "2";
            // 
            // mslftMessage
            // 
            this.mslftMessage.Location = new System.Drawing.Point(940, 360);
            this.mslftMessage.Margin = new System.Windows.Forms.Padding(4);
            this.mslftMessage.Name = "mslftMessage";
            this.mslftMessage.Size = new System.Drawing.Size(240, 26);
            this.mslftMessage.TabIndex = 12;
            this.mslftMessage.Text = "Hello friends !";
            // 
            // mfbtnClientToClient
            // 
            this.mfbtnClientToClient.AutoSize = true;
            this.mfbtnClientToClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnClientToClient.Enabled = false;
            this.mfbtnClientToClient.Location = new System.Drawing.Point(981, 216);
            this.mfbtnClientToClient.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnClientToClient.Name = "mfbtnClientToClient";
            this.mfbtnClientToClient.Size = new System.Drawing.Size(199, 29);
            this.mfbtnClientToClient.TabIndex = 13;
            this.mfbtnClientToClient.Text = "Send To Client By Id";
            this.mfbtnClientToClient.UseVisualStyleBackColor = true;
            this.mfbtnClientToClient.Click += new System.EventHandler(this.MfbtnClientToClient_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(822, 275);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 18);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "auth key :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(822, 318);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 18);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "capacity : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(816, 360);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 18);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Message : ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(820, 405);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(118, 18);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Target Client Id : ";
            // 
            // mslftTargetClientId
            // 
            this.mslftTargetClientId.Location = new System.Drawing.Point(951, 405);
            this.mslftTargetClientId.Margin = new System.Windows.Forms.Padding(4);
            this.mslftTargetClientId.Name = "mslftTargetClientId";
            this.mslftTargetClientId.Size = new System.Drawing.Size(229, 26);
            this.mslftTargetClientId.TabIndex = 17;
            this.mslftTargetClientId.Text = "1";
            // 
            // UCTestClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.mslftTargetClientId);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.mfbtnClientToClient);
            this.Controls.Add(this.mslftMessage);
            this.Controls.Add(this.msltfCapacity);
            this.Controls.Add(this.mchbxScrollToEnd);
            this.Controls.Add(this.msltfAuthKey);
            this.Controls.Add(this.mlblClientId);
            this.Controls.Add(this.mfbtnSendToServer);
            this.Controls.Add(this.mfbtnAllClientSendWithoutMe);
            this.Controls.Add(this.mfbtnAllClientSendWithMe);
            this.Controls.Add(this.mfbtnJoinLobby);
            this.Controls.Add(this.mfbtnCreateLobby);
            this.Controls.Add(this.mfbtnDisconnect);
            this.Controls.Add(this.mfbtnConnect);
            this.Controls.Add(this.rtbxLog);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCTestClient";
            this.Size = new System.Drawing.Size(1190, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxLog;
        private Button mfbtnConnect;
        private Button mfbtnDisconnect;
        private Button mfbtnCreateLobby;
        private Button mfbtnJoinLobby;
        private Button mfbtnAllClientSendWithMe;
        private Button mfbtnAllClientSendWithoutMe;
        private Button mfbtnSendToServer;
        private Label mlblClientId;
        private TextBox msltfAuthKey;
        private CheckBox mchbxScrollToEnd;
        private TextBox msltfCapacity;
        private TextBox mslftMessage;
        private Button mfbtnClientToClient;
        private Label materialLabel1;
        private Label materialLabel2;
        private Label materialLabel3;
        private Label materialLabel4;
        private TextBox mslftTargetClientId;
    }
}
