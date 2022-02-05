
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
            this.mfbtnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtnDisconnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtnCreateLobby = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtnJoinLobby = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtnAllClientSendWithMe = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtnAllClientSendWithoutMe = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtnSendToServer = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblClientId = new MaterialSkin.Controls.MaterialLabel();
            this.msltfAuthKey = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mchbxScrollToEnd = new MaterialSkin.Controls.MaterialCheckBox();
            this.msltfCapacity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mslftMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mfbtnClientToClient = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.mslftTargetClientId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // rtbxLog
            // 
            this.rtbxLog.BackColor = System.Drawing.Color.Black;
            this.rtbxLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.rtbxLog.ForeColor = System.Drawing.Color.White;
            this.rtbxLog.Location = new System.Drawing.Point(0, 0);
            this.rtbxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbxLog.Name = "rtbxLog";
            this.rtbxLog.Size = new System.Drawing.Size(814, 492);
            this.rtbxLog.TabIndex = 0;
            this.rtbxLog.Text = "";
            // 
            // mfbtnConnect
            // 
            this.mfbtnConnect.AutoSize = true;
            this.mfbtnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnConnect.Depth = 0;
            this.mfbtnConnect.Location = new System.Drawing.Point(824, 9);
            this.mfbtnConnect.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnConnect.Name = "mfbtnConnect";
            this.mfbtnConnect.Primary = false;
            this.mfbtnConnect.Size = new System.Drawing.Size(149, 36);
            this.mfbtnConnect.TabIndex = 1;
            this.mfbtnConnect.Text = "Connect To Server";
            this.mfbtnConnect.UseVisualStyleBackColor = true;
            this.mfbtnConnect.Click += new System.EventHandler(this.MfbtnConnect_Click);
            // 
            // mfbtnDisconnect
            // 
            this.mfbtnDisconnect.AutoSize = true;
            this.mfbtnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnDisconnect.Depth = 0;
            this.mfbtnDisconnect.Enabled = false;
            this.mfbtnDisconnect.Location = new System.Drawing.Point(985, 9);
            this.mfbtnDisconnect.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnDisconnect.Name = "mfbtnDisconnect";
            this.mfbtnDisconnect.Primary = false;
            this.mfbtnDisconnect.Size = new System.Drawing.Size(146, 36);
            this.mfbtnDisconnect.TabIndex = 2;
            this.mfbtnDisconnect.Text = "Disconnect Client";
            this.mfbtnDisconnect.UseVisualStyleBackColor = true;
            this.mfbtnDisconnect.Click += new System.EventHandler(this.MfbtnDisconnect_Click);
            // 
            // mfbtnCreateLobby
            // 
            this.mfbtnCreateLobby.AutoSize = true;
            this.mfbtnCreateLobby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnCreateLobby.Depth = 0;
            this.mfbtnCreateLobby.Enabled = false;
            this.mfbtnCreateLobby.Location = new System.Drawing.Point(824, 63);
            this.mfbtnCreateLobby.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnCreateLobby.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnCreateLobby.Name = "mfbtnCreateLobby";
            this.mfbtnCreateLobby.Primary = false;
            this.mfbtnCreateLobby.Size = new System.Drawing.Size(121, 36);
            this.mfbtnCreateLobby.TabIndex = 3;
            this.mfbtnCreateLobby.Text = "Create A Lobby";
            this.mfbtnCreateLobby.UseVisualStyleBackColor = true;
            this.mfbtnCreateLobby.Click += new System.EventHandler(this.MfbtnCreateLobby_Click);
            // 
            // mfbtnJoinLobby
            // 
            this.mfbtnJoinLobby.AutoSize = true;
            this.mfbtnJoinLobby.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnJoinLobby.Depth = 0;
            this.mfbtnJoinLobby.Enabled = false;
            this.mfbtnJoinLobby.Location = new System.Drawing.Point(985, 63);
            this.mfbtnJoinLobby.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnJoinLobby.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnJoinLobby.Name = "mfbtnJoinLobby";
            this.mfbtnJoinLobby.Primary = false;
            this.mfbtnJoinLobby.Size = new System.Drawing.Size(101, 36);
            this.mfbtnJoinLobby.TabIndex = 4;
            this.mfbtnJoinLobby.Text = "Join A Lobby";
            this.mfbtnJoinLobby.UseVisualStyleBackColor = true;
            this.mfbtnJoinLobby.Click += new System.EventHandler(this.MfbtnJoinLobby_Click);
            // 
            // mfbtnAllClientSendWithMe
            // 
            this.mfbtnAllClientSendWithMe.AutoSize = true;
            this.mfbtnAllClientSendWithMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnAllClientSendWithMe.Depth = 0;
            this.mfbtnAllClientSendWithMe.Enabled = false;
            this.mfbtnAllClientSendWithMe.Location = new System.Drawing.Point(824, 117);
            this.mfbtnAllClientSendWithMe.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnAllClientSendWithMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnAllClientSendWithMe.Name = "mfbtnAllClientSendWithMe";
            this.mfbtnAllClientSendWithMe.Primary = false;
            this.mfbtnAllClientSendWithMe.Size = new System.Drawing.Size(184, 36);
            this.mfbtnAllClientSendWithMe.TabIndex = 5;
            this.mfbtnAllClientSendWithMe.Text = "All Client Send With Me";
            this.mfbtnAllClientSendWithMe.UseVisualStyleBackColor = true;
            this.mfbtnAllClientSendWithMe.Click += new System.EventHandler(this.MfbtnAllClientSendWithMe_Click);
            // 
            // mfbtnAllClientSendWithoutMe
            // 
            this.mfbtnAllClientSendWithoutMe.AutoSize = true;
            this.mfbtnAllClientSendWithoutMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnAllClientSendWithoutMe.Depth = 0;
            this.mfbtnAllClientSendWithoutMe.Enabled = false;
            this.mfbtnAllClientSendWithoutMe.Location = new System.Drawing.Point(824, 162);
            this.mfbtnAllClientSendWithoutMe.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnAllClientSendWithoutMe.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnAllClientSendWithoutMe.Name = "mfbtnAllClientSendWithoutMe";
            this.mfbtnAllClientSendWithoutMe.Primary = false;
            this.mfbtnAllClientSendWithoutMe.Size = new System.Drawing.Size(211, 36);
            this.mfbtnAllClientSendWithoutMe.TabIndex = 6;
            this.mfbtnAllClientSendWithoutMe.Text = "All Client Send Without Me";
            this.mfbtnAllClientSendWithoutMe.UseVisualStyleBackColor = true;
            this.mfbtnAllClientSendWithoutMe.Click += new System.EventHandler(this.MfbtnAllClientSendWithoutMe_Click);
            // 
            // mfbtnSendToServer
            // 
            this.mfbtnSendToServer.AutoSize = true;
            this.mfbtnSendToServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnSendToServer.Depth = 0;
            this.mfbtnSendToServer.Enabled = false;
            this.mfbtnSendToServer.Location = new System.Drawing.Point(824, 216);
            this.mfbtnSendToServer.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnSendToServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnSendToServer.Name = "mfbtnSendToServer";
            this.mfbtnSendToServer.Primary = false;
            this.mfbtnSendToServer.Size = new System.Drawing.Size(121, 36);
            this.mfbtnSendToServer.TabIndex = 7;
            this.mfbtnSendToServer.Text = "Send To Server";
            this.mfbtnSendToServer.UseVisualStyleBackColor = true;
            this.mfbtnSendToServer.Click += new System.EventHandler(this.MfbtnSendToServer_Click);
            // 
            // mlblClientId
            // 
            this.mlblClientId.AutoSize = true;
            this.mlblClientId.Depth = 0;
            this.mlblClientId.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblClientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblClientId.Location = new System.Drawing.Point(1035, 126);
            this.mlblClientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblClientId.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblClientId.Name = "mlblClientId";
            this.mlblClientId.Size = new System.Drawing.Size(0, 19);
            this.mlblClientId.TabIndex = 8;
            // 
            // msltfAuthKey
            // 
            this.msltfAuthKey.Depth = 0;
            this.msltfAuthKey.Enabled = false;
            this.msltfAuthKey.Hint = "";
            this.msltfAuthKey.Location = new System.Drawing.Point(940, 275);
            this.msltfAuthKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msltfAuthKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfAuthKey.Name = "msltfAuthKey";
            this.msltfAuthKey.PasswordChar = '\0';
            this.msltfAuthKey.SelectedText = "";
            this.msltfAuthKey.SelectionLength = 0;
            this.msltfAuthKey.SelectionStart = 0;
            this.msltfAuthKey.Size = new System.Drawing.Size(240, 23);
            this.msltfAuthKey.TabIndex = 9;
            this.msltfAuthKey.Text = "1du82";
            this.msltfAuthKey.UseSystemPasswordChar = false;
            // 
            // mchbxScrollToEnd
            // 
            this.mchbxScrollToEnd.AutoSize = true;
            this.mchbxScrollToEnd.Checked = true;
            this.mchbxScrollToEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchbxScrollToEnd.Depth = 0;
            this.mchbxScrollToEnd.Font = new System.Drawing.Font("Roboto", 10F);
            this.mchbxScrollToEnd.Location = new System.Drawing.Point(818, 448);
            this.mchbxScrollToEnd.Margin = new System.Windows.Forms.Padding(0);
            this.mchbxScrollToEnd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchbxScrollToEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchbxScrollToEnd.Name = "mchbxScrollToEnd";
            this.mchbxScrollToEnd.Ripple = true;
            this.mchbxScrollToEnd.Size = new System.Drawing.Size(111, 30);
            this.mchbxScrollToEnd.TabIndex = 10;
            this.mchbxScrollToEnd.Text = "Scroll To End";
            this.mchbxScrollToEnd.UseVisualStyleBackColor = true;
            // 
            // msltfCapacity
            // 
            this.msltfCapacity.Depth = 0;
            this.msltfCapacity.Enabled = false;
            this.msltfCapacity.Hint = "";
            this.msltfCapacity.Location = new System.Drawing.Point(940, 318);
            this.msltfCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msltfCapacity.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfCapacity.Name = "msltfCapacity";
            this.msltfCapacity.PasswordChar = '\0';
            this.msltfCapacity.SelectedText = "";
            this.msltfCapacity.SelectionLength = 0;
            this.msltfCapacity.SelectionStart = 0;
            this.msltfCapacity.Size = new System.Drawing.Size(240, 23);
            this.msltfCapacity.TabIndex = 11;
            this.msltfCapacity.Text = "2";
            this.msltfCapacity.UseSystemPasswordChar = false;
            // 
            // mslftMessage
            // 
            this.mslftMessage.Depth = 0;
            this.mslftMessage.Hint = "";
            this.mslftMessage.Location = new System.Drawing.Point(940, 360);
            this.mslftMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mslftMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.mslftMessage.Name = "mslftMessage";
            this.mslftMessage.PasswordChar = '\0';
            this.mslftMessage.SelectedText = "";
            this.mslftMessage.SelectionLength = 0;
            this.mslftMessage.SelectionStart = 0;
            this.mslftMessage.Size = new System.Drawing.Size(240, 23);
            this.mslftMessage.TabIndex = 12;
            this.mslftMessage.Text = "Hello friends !";
            this.mslftMessage.UseSystemPasswordChar = false;
            // 
            // mfbtnClientToClient
            // 
            this.mfbtnClientToClient.AutoSize = true;
            this.mfbtnClientToClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnClientToClient.Depth = 0;
            this.mfbtnClientToClient.Enabled = false;
            this.mfbtnClientToClient.Location = new System.Drawing.Point(1026, 216);
            this.mfbtnClientToClient.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.mfbtnClientToClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnClientToClient.Name = "mfbtnClientToClient";
            this.mfbtnClientToClient.Primary = false;
            this.mfbtnClientToClient.Size = new System.Drawing.Size(154, 36);
            this.mfbtnClientToClient.TabIndex = 13;
            this.mfbtnClientToClient.Text = "Send To Client By Id";
            this.mfbtnClientToClient.UseVisualStyleBackColor = true;
            this.mfbtnClientToClient.Click += new System.EventHandler(this.MfbtnClientToClient_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(822, 275);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "auth key :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(822, 318);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "capacity : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(816, 360);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "Message : ";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(820, 405);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(123, 19);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Target Client Id : ";
            // 
            // mslftTargetClientId
            // 
            this.mslftTargetClientId.Depth = 0;
            this.mslftTargetClientId.Hint = "";
            this.mslftTargetClientId.Location = new System.Drawing.Point(951, 405);
            this.mslftTargetClientId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mslftTargetClientId.MouseState = MaterialSkin.MouseState.HOVER;
            this.mslftTargetClientId.Name = "mslftTargetClientId";
            this.mslftTargetClientId.PasswordChar = '\0';
            this.mslftTargetClientId.SelectedText = "";
            this.mslftTargetClientId.SelectionLength = 0;
            this.mslftTargetClientId.SelectionStart = 0;
            this.mslftTargetClientId.Size = new System.Drawing.Size(229, 23);
            this.mslftTargetClientId.TabIndex = 17;
            this.mslftTargetClientId.Text = "1";
            this.mslftTargetClientId.UseSystemPasswordChar = false;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCTestClient";
            this.Size = new System.Drawing.Size(1190, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxLog;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnConnect;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnDisconnect;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnCreateLobby;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnJoinLobby;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnAllClientSendWithMe;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnAllClientSendWithoutMe;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnSendToServer;
        private MaterialSkin.Controls.MaterialLabel mlblClientId;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfAuthKey;
        private MaterialSkin.Controls.MaterialCheckBox mchbxScrollToEnd;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfCapacity;
        private MaterialSkin.Controls.MaterialSingleLineTextField mslftMessage;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnClientToClient;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField mslftTargetClientId;
    }
}
