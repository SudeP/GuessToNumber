
namespace GuessToNumber.Server
{
    partial class WFMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtc = new MaterialSkin.Controls.MaterialTabControl();
            this.mtpLog = new System.Windows.Forms.TabPage();
            this.mchbxScrollToEnd = new MaterialSkin.Controls.MaterialCheckBox();
            this.rtbxLog = new System.Windows.Forms.RichTextBox();
            this.mtpLobbies = new System.Windows.Forms.TabPage();
            this.mfbtnRefreshLobbies = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblClientCount = new MaterialSkin.Controls.MaterialLabel();
            this.mlblLobbyCount = new MaterialSkin.Controls.MaterialLabel();
            this.twLobbies = new System.Windows.Forms.TreeView();
            this.mtpStatus = new System.Windows.Forms.TabPage();
            this.mlblStatu = new MaterialSkin.Controls.MaterialLabel();
            this.mrbtnStopServer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbtnStartServer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tpClient1 = new System.Windows.Forms.TabPage();
            this.tpClient2 = new System.Windows.Forms.TabPage();
            this.mts = new MaterialSkin.Controls.MaterialTabSelector();
            this.ucTestClient1 = new GuessToNumber.Server.UCTestClient();
            this.ucTestClient2 = new GuessToNumber.Server.UCTestClient();
            this.mtc.SuspendLayout();
            this.mtpLog.SuspendLayout();
            this.mtpLobbies.SuspendLayout();
            this.mtpStatus.SuspendLayout();
            this.tpClient1.SuspendLayout();
            this.tpClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtc
            // 
            this.mtc.Controls.Add(this.mtpLog);
            this.mtc.Controls.Add(this.mtpLobbies);
            this.mtc.Controls.Add(this.mtpStatus);
            this.mtc.Controls.Add(this.tpClient1);
            this.mtc.Controls.Add(this.tpClient2);
            this.mtc.Depth = 0;
            this.mtc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mtc.Location = new System.Drawing.Point(0, 114);
            this.mtc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtc.Name = "mtc";
            this.mtc.SelectedIndex = 0;
            this.mtc.Size = new System.Drawing.Size(1200, 544);
            this.mtc.TabIndex = 0;
            // 
            // mtpLog
            // 
            this.mtpLog.AutoScroll = true;
            this.mtpLog.Controls.Add(this.mchbxScrollToEnd);
            this.mtpLog.Controls.Add(this.rtbxLog);
            this.mtpLog.Location = new System.Drawing.Point(4, 28);
            this.mtpLog.Margin = new System.Windows.Forms.Padding(0);
            this.mtpLog.Name = "mtpLog";
            this.mtpLog.Size = new System.Drawing.Size(1192, 512);
            this.mtpLog.TabIndex = 0;
            this.mtpLog.Text = "Log";
            this.mtpLog.UseVisualStyleBackColor = true;
            // 
            // mchbxScrollToEnd
            // 
            this.mchbxScrollToEnd.AutoSize = true;
            this.mchbxScrollToEnd.Checked = true;
            this.mchbxScrollToEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchbxScrollToEnd.Depth = 0;
            this.mchbxScrollToEnd.Font = new System.Drawing.Font("Roboto", 10F);
            this.mchbxScrollToEnd.Location = new System.Drawing.Point(8, 13);
            this.mchbxScrollToEnd.Margin = new System.Windows.Forms.Padding(0);
            this.mchbxScrollToEnd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mchbxScrollToEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mchbxScrollToEnd.Name = "mchbxScrollToEnd";
            this.mchbxScrollToEnd.Ripple = true;
            this.mchbxScrollToEnd.Size = new System.Drawing.Size(107, 30);
            this.mchbxScrollToEnd.TabIndex = 1;
            this.mchbxScrollToEnd.Text = "Scroll to end";
            this.mchbxScrollToEnd.UseVisualStyleBackColor = true;
            // 
            // rtbxLog
            // 
            this.rtbxLog.BackColor = System.Drawing.Color.Black;
            this.rtbxLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.rtbxLog.ForeColor = System.Drawing.Color.White;
            this.rtbxLog.Location = new System.Drawing.Point(8, 46);
            this.rtbxLog.Name = "rtbxLog";
            this.rtbxLog.Size = new System.Drawing.Size(1166, 458);
            this.rtbxLog.TabIndex = 0;
            this.rtbxLog.Text = "";
            // 
            // mtpLobbies
            // 
            this.mtpLobbies.AutoScroll = true;
            this.mtpLobbies.Controls.Add(this.mfbtnRefreshLobbies);
            this.mtpLobbies.Controls.Add(this.mlblClientCount);
            this.mtpLobbies.Controls.Add(this.mlblLobbyCount);
            this.mtpLobbies.Controls.Add(this.twLobbies);
            this.mtpLobbies.Location = new System.Drawing.Point(4, 28);
            this.mtpLobbies.Margin = new System.Windows.Forms.Padding(0);
            this.mtpLobbies.Name = "mtpLobbies";
            this.mtpLobbies.Size = new System.Drawing.Size(1192, 512);
            this.mtpLobbies.TabIndex = 1;
            this.mtpLobbies.Text = "Lobbies";
            this.mtpLobbies.UseVisualStyleBackColor = true;
            // 
            // mfbtnRefreshLobbies
            // 
            this.mfbtnRefreshLobbies.AutoSize = true;
            this.mfbtnRefreshLobbies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnRefreshLobbies.Depth = 0;
            this.mfbtnRefreshLobbies.ForeColor = System.Drawing.Color.White;
            this.mfbtnRefreshLobbies.Location = new System.Drawing.Point(602, 100);
            this.mfbtnRefreshLobbies.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbtnRefreshLobbies.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtnRefreshLobbies.Name = "mfbtnRefreshLobbies";
            this.mfbtnRefreshLobbies.Primary = false;
            this.mfbtnRefreshLobbies.Size = new System.Drawing.Size(109, 36);
            this.mfbtnRefreshLobbies.TabIndex = 3;
            this.mfbtnRefreshLobbies.Text = "Refresh Data";
            this.mfbtnRefreshLobbies.UseVisualStyleBackColor = true;
            this.mfbtnRefreshLobbies.Click += new System.EventHandler(this.MfbtnRefreshLobbies_Click);
            // 
            // mlblClientCount
            // 
            this.mlblClientCount.AutoSize = true;
            this.mlblClientCount.Depth = 0;
            this.mlblClientCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblClientCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblClientCount.Location = new System.Drawing.Point(598, 60);
            this.mlblClientCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblClientCount.Name = "mlblClientCount";
            this.mlblClientCount.Size = new System.Drawing.Size(0, 19);
            this.mlblClientCount.TabIndex = 2;
            // 
            // mlblLobbyCount
            // 
            this.mlblLobbyCount.AutoSize = true;
            this.mlblLobbyCount.Depth = 0;
            this.mlblLobbyCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblLobbyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblLobbyCount.Location = new System.Drawing.Point(598, 20);
            this.mlblLobbyCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblLobbyCount.Name = "mlblLobbyCount";
            this.mlblLobbyCount.Size = new System.Drawing.Size(0, 19);
            this.mlblLobbyCount.TabIndex = 1;
            // 
            // twLobbies
            // 
            this.twLobbies.Location = new System.Drawing.Point(8, 3);
            this.twLobbies.Name = "twLobbies";
            this.twLobbies.Size = new System.Drawing.Size(557, 501);
            this.twLobbies.TabIndex = 0;
            // 
            // mtpStatus
            // 
            this.mtpStatus.AutoScroll = true;
            this.mtpStatus.Controls.Add(this.mlblStatu);
            this.mtpStatus.Controls.Add(this.mrbtnStopServer);
            this.mtpStatus.Controls.Add(this.mrbtnStartServer);
            this.mtpStatus.Location = new System.Drawing.Point(4, 28);
            this.mtpStatus.Margin = new System.Windows.Forms.Padding(0);
            this.mtpStatus.Name = "mtpStatus";
            this.mtpStatus.Size = new System.Drawing.Size(1192, 512);
            this.mtpStatus.TabIndex = 2;
            this.mtpStatus.Text = "Status";
            this.mtpStatus.UseVisualStyleBackColor = true;
            // 
            // mlblStatu
            // 
            this.mlblStatu.AutoSize = true;
            this.mlblStatu.Depth = 0;
            this.mlblStatu.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblStatu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblStatu.Location = new System.Drawing.Point(33, 41);
            this.mlblStatu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblStatu.Name = "mlblStatu";
            this.mlblStatu.Size = new System.Drawing.Size(0, 19);
            this.mlblStatu.TabIndex = 2;
            // 
            // mrbtnStopServer
            // 
            this.mrbtnStopServer.Depth = 0;
            this.mrbtnStopServer.Enabled = false;
            this.mrbtnStopServer.Location = new System.Drawing.Point(213, 115);
            this.mrbtnStopServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnStopServer.Name = "mrbtnStopServer";
            this.mrbtnStopServer.Primary = true;
            this.mrbtnStopServer.Size = new System.Drawing.Size(145, 86);
            this.mrbtnStopServer.TabIndex = 1;
            this.mrbtnStopServer.Text = "Stop Server";
            this.mrbtnStopServer.UseVisualStyleBackColor = true;
            this.mrbtnStopServer.Click += new System.EventHandler(this.MrbtnStopServer_Click);
            // 
            // mrbtnStartServer
            // 
            this.mrbtnStartServer.Depth = 0;
            this.mrbtnStartServer.Location = new System.Drawing.Point(37, 115);
            this.mrbtnStartServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtnStartServer.Name = "mrbtnStartServer";
            this.mrbtnStartServer.Primary = true;
            this.mrbtnStartServer.Size = new System.Drawing.Size(145, 86);
            this.mrbtnStartServer.TabIndex = 0;
            this.mrbtnStartServer.Text = "Start Server";
            this.mrbtnStartServer.UseVisualStyleBackColor = true;
            this.mrbtnStartServer.Click += new System.EventHandler(this.MrbtnStartServer_Click);
            // 
            // tpClient1
            // 
            this.tpClient1.BackColor = System.Drawing.Color.White;
            this.tpClient1.Controls.Add(this.ucTestClient2);
            this.tpClient1.Location = new System.Drawing.Point(4, 28);
            this.tpClient1.Name = "tpClient1";
            this.tpClient1.Size = new System.Drawing.Size(1192, 512);
            this.tpClient1.TabIndex = 3;
            this.tpClient1.Text = "Test Client 1";
            // 
            // tpClient2
            // 
            this.tpClient2.BackColor = System.Drawing.Color.White;
            this.tpClient2.Controls.Add(this.ucTestClient1);
            this.tpClient2.Location = new System.Drawing.Point(4, 28);
            this.tpClient2.Name = "tpClient2";
            this.tpClient2.Size = new System.Drawing.Size(1192, 512);
            this.tpClient2.TabIndex = 4;
            this.tpClient2.Text = "Test Client 2";
            // 
            // mts
            // 
            this.mts.BaseTabControl = this.mtc;
            this.mts.Depth = 0;
            this.mts.Location = new System.Drawing.Point(0, 65);
            this.mts.MouseState = MaterialSkin.MouseState.HOVER;
            this.mts.Name = "mts";
            this.mts.Size = new System.Drawing.Size(1200, 43);
            this.mts.TabIndex = 1;
            // 
            // ucTestClient1
            // 
            this.ucTestClient1.Location = new System.Drawing.Point(9, 4);
            this.ucTestClient1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucTestClient1.Name = "ucTestClient1";
            this.ucTestClient1.Size = new System.Drawing.Size(1150, 500);
            this.ucTestClient1.TabIndex = 0;
            // 
            // ucTestClient2
            // 
            this.ucTestClient2.Location = new System.Drawing.Point(9, 4);
            this.ucTestClient2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucTestClient2.Name = "ucTestClient2";
            this.ucTestClient2.Size = new System.Drawing.Size(1150, 500);
            this.ucTestClient2.TabIndex = 0;
            // 
            // WFMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.mts);
            this.Controls.Add(this.mtc);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WFMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess To Number Server Management";
            this.mtc.ResumeLayout(false);
            this.mtpLog.ResumeLayout(false);
            this.mtpLog.PerformLayout();
            this.mtpLobbies.ResumeLayout(false);
            this.mtpLobbies.PerformLayout();
            this.mtpStatus.ResumeLayout(false);
            this.mtpStatus.PerformLayout();
            this.tpClient1.ResumeLayout(false);
            this.tpClient2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mtc;
        private MaterialSkin.Controls.MaterialTabSelector mts;
        private System.Windows.Forms.TabPage mtpLog;
        private System.Windows.Forms.TabPage mtpLobbies;
        private System.Windows.Forms.TabPage mtpStatus;
        private MaterialSkin.Controls.MaterialRaisedButton mrbtnStartServer;
        private MaterialSkin.Controls.MaterialRaisedButton mrbtnStopServer;
        private MaterialSkin.Controls.MaterialLabel mlblStatu;
        private System.Windows.Forms.RichTextBox rtbxLog;
        private System.Windows.Forms.TreeView twLobbies;
        private MaterialSkin.Controls.MaterialLabel mlblClientCount;
        private MaterialSkin.Controls.MaterialLabel mlblLobbyCount;
        private MaterialSkin.Controls.MaterialFlatButton mfbtnRefreshLobbies;
        private MaterialSkin.Controls.MaterialCheckBox mchbxScrollToEnd;
        private System.Windows.Forms.TabPage tpClient1;
        private System.Windows.Forms.TabPage tpClient2;
        private UCTestClient ucTestClient1;
        private UCTestClient ucTestClient2;
    }
}