
using System.Windows.Forms;

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
            this.mtc = new System.Windows.Forms.TabControl();
            this.mtpLog = new System.Windows.Forms.TabPage();
            this.mchbxScrollToEnd = new System.Windows.Forms.CheckBox();
            this.rtbxLog = new System.Windows.Forms.RichTextBox();
            this.mtpLobbies = new System.Windows.Forms.TabPage();
            this.mfbtnRefreshLobbies = new System.Windows.Forms.Button();
            this.mlblClientCount = new System.Windows.Forms.Label();
            this.mlblLobbyCount = new System.Windows.Forms.Label();
            this.twLobbies = new System.Windows.Forms.TreeView();
            this.mtpStatus = new System.Windows.Forms.TabPage();
            this.msltfPort = new System.Windows.Forms.TextBox();
            this.mlblPort = new System.Windows.Forms.Label();
            this.msltfCustomIp = new System.Windows.Forms.TextBox();
            this.mtbtnCustom = new System.Windows.Forms.RadioButton();
            this.mtbtnLocalHost = new System.Windows.Forms.RadioButton();
            this.mtbtnLocalIp = new System.Windows.Forms.RadioButton();
            this.mtbtnAny = new System.Windows.Forms.RadioButton();
            this.mlblStatu = new System.Windows.Forms.Label();
            this.mrbtnStopServer = new System.Windows.Forms.Button();
            this.mrbtnStartServer = new System.Windows.Forms.Button();
            this.tpClient1 = new System.Windows.Forms.TabPage();
            this.ucTestClient2 = new GuessToNumber.Server.UCTestClient();
            this.tpClient2 = new System.Windows.Forms.TabPage();
            this.ucTestClient1 = new GuessToNumber.Server.UCTestClient();
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
            this.mtc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtc.Location = new System.Drawing.Point(0, 0);
            this.mtc.Name = "mtc";
            this.mtc.SelectedIndex = 0;
            this.mtc.Size = new System.Drawing.Size(1200, 658);
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
            this.mtpLog.Size = new System.Drawing.Size(1192, 626);
            this.mtpLog.TabIndex = 0;
            this.mtpLog.Text = "Log";
            this.mtpLog.UseVisualStyleBackColor = true;
            // 
            // mchbxScrollToEnd
            // 
            this.mchbxScrollToEnd.AutoSize = true;
            this.mchbxScrollToEnd.Checked = true;
            this.mchbxScrollToEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchbxScrollToEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mchbxScrollToEnd.Location = new System.Drawing.Point(8, 13);
            this.mchbxScrollToEnd.Margin = new System.Windows.Forms.Padding(0);
            this.mchbxScrollToEnd.Name = "mchbxScrollToEnd";
            this.mchbxScrollToEnd.Size = new System.Drawing.Size(106, 21);
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
            this.rtbxLog.Size = new System.Drawing.Size(1166, 572);
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
            this.mtpLobbies.Size = new System.Drawing.Size(1192, 626);
            this.mtpLobbies.TabIndex = 1;
            this.mtpLobbies.Text = "Lobbies";
            this.mtpLobbies.UseVisualStyleBackColor = true;
            // 
            // mfbtnRefreshLobbies
            // 
            this.mfbtnRefreshLobbies.AutoSize = true;
            this.mfbtnRefreshLobbies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtnRefreshLobbies.ForeColor = System.Drawing.Color.White;
            this.mfbtnRefreshLobbies.Location = new System.Drawing.Point(602, 100);
            this.mfbtnRefreshLobbies.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbtnRefreshLobbies.Name = "mfbtnRefreshLobbies";
            this.mfbtnRefreshLobbies.Size = new System.Drawing.Size(127, 29);
            this.mfbtnRefreshLobbies.TabIndex = 3;
            this.mfbtnRefreshLobbies.Text = "Refresh Data";
            this.mfbtnRefreshLobbies.UseVisualStyleBackColor = true;
            this.mfbtnRefreshLobbies.Click += new System.EventHandler(this.MfbtnRefreshLobbies_Click);
            // 
            // mlblClientCount
            // 
            this.mlblClientCount.AutoSize = true;
            this.mlblClientCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mlblClientCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblClientCount.Location = new System.Drawing.Point(598, 60);
            this.mlblClientCount.Name = "mlblClientCount";
            this.mlblClientCount.Size = new System.Drawing.Size(0, 18);
            this.mlblClientCount.TabIndex = 2;
            // 
            // mlblLobbyCount
            // 
            this.mlblLobbyCount.AutoSize = true;
            this.mlblLobbyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mlblLobbyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblLobbyCount.Location = new System.Drawing.Point(598, 20);
            this.mlblLobbyCount.Name = "mlblLobbyCount";
            this.mlblLobbyCount.Size = new System.Drawing.Size(0, 18);
            this.mlblLobbyCount.TabIndex = 1;
            // 
            // twLobbies
            // 
            this.twLobbies.Location = new System.Drawing.Point(3, 3);
            this.twLobbies.Name = "twLobbies";
            this.twLobbies.Size = new System.Drawing.Size(557, 615);
            this.twLobbies.TabIndex = 0;
            // 
            // mtpStatus
            // 
            this.mtpStatus.AutoScroll = true;
            this.mtpStatus.BackColor = System.Drawing.Color.White;
            this.mtpStatus.Controls.Add(this.msltfPort);
            this.mtpStatus.Controls.Add(this.mlblPort);
            this.mtpStatus.Controls.Add(this.msltfCustomIp);
            this.mtpStatus.Controls.Add(this.mtbtnCustom);
            this.mtpStatus.Controls.Add(this.mtbtnLocalHost);
            this.mtpStatus.Controls.Add(this.mtbtnLocalIp);
            this.mtpStatus.Controls.Add(this.mtbtnAny);
            this.mtpStatus.Controls.Add(this.mlblStatu);
            this.mtpStatus.Controls.Add(this.mrbtnStopServer);
            this.mtpStatus.Controls.Add(this.mrbtnStartServer);
            this.mtpStatus.Location = new System.Drawing.Point(4, 28);
            this.mtpStatus.Margin = new System.Windows.Forms.Padding(0);
            this.mtpStatus.Name = "mtpStatus";
            this.mtpStatus.Size = new System.Drawing.Size(1192, 626);
            this.mtpStatus.TabIndex = 2;
            this.mtpStatus.Text = "Status";
            // 
            // msltfPort
            // 
            this.msltfPort.Location = new System.Drawing.Point(781, 126);
            this.msltfPort.Name = "msltfPort";
            this.msltfPort.Size = new System.Drawing.Size(102, 26);
            this.msltfPort.TabIndex = 9;
            this.msltfPort.Text = "7536";
            this.msltfPort.TextChanged += new System.EventHandler(this.MsltfPort_TextChanged);
            // 
            // mlblPort
            // 
            this.mlblPort.AutoSize = true;
            this.mlblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mlblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPort.Location = new System.Drawing.Point(726, 126);
            this.mlblPort.Name = "mlblPort";
            this.mlblPort.Size = new System.Drawing.Size(48, 18);
            this.mlblPort.TabIndex = 8;
            this.mlblPort.Text = "Port : ";
            // 
            // msltfCustomIp
            // 
            this.msltfCustomIp.Enabled = false;
            this.msltfCustomIp.Location = new System.Drawing.Point(516, 244);
            this.msltfCustomIp.Name = "msltfCustomIp";
            this.msltfCustomIp.Size = new System.Drawing.Size(102, 26);
            this.msltfCustomIp.TabIndex = 7;
            this.msltfCustomIp.Text = "0.0.0.0";
            this.msltfCustomIp.TextChanged += new System.EventHandler(this.MsltfCustomIp_TextChanged);
            // 
            // mtbtnCustom
            // 
            this.mtbtnCustom.AutoSize = true;
            this.mtbtnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mtbtnCustom.Location = new System.Drawing.Point(424, 237);
            this.mtbtnCustom.Margin = new System.Windows.Forms.Padding(0);
            this.mtbtnCustom.Name = "mtbtnCustom";
            this.mtbtnCustom.Size = new System.Drawing.Size(73, 21);
            this.mtbtnCustom.TabIndex = 6;
            this.mtbtnCustom.Text = "Custom";
            this.mtbtnCustom.UseVisualStyleBackColor = true;
            this.mtbtnCustom.CheckedChanged += new System.EventHandler(this.MtbtnCustom_CheckedChanged);
            // 
            // mtbtnLocalHost
            // 
            this.mtbtnLocalHost.AutoSize = true;
            this.mtbtnLocalHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mtbtnLocalHost.Location = new System.Drawing.Point(424, 195);
            this.mtbtnLocalHost.Margin = new System.Windows.Forms.Padding(0);
            this.mtbtnLocalHost.Name = "mtbtnLocalHost";
            this.mtbtnLocalHost.Size = new System.Drawing.Size(82, 21);
            this.mtbtnLocalHost.TabIndex = 5;
            this.mtbtnLocalHost.Text = "localhost";
            this.mtbtnLocalHost.UseVisualStyleBackColor = true;
            this.mtbtnLocalHost.CheckedChanged += new System.EventHandler(this.MtbtnLocalHost_CheckedChanged);
            // 
            // mtbtnLocalIp
            // 
            this.mtbtnLocalIp.AutoSize = true;
            this.mtbtnLocalIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mtbtnLocalIp.Location = new System.Drawing.Point(424, 154);
            this.mtbtnLocalIp.Margin = new System.Windows.Forms.Padding(0);
            this.mtbtnLocalIp.Name = "mtbtnLocalIp";
            this.mtbtnLocalIp.Size = new System.Drawing.Size(86, 21);
            this.mtbtnLocalIp.TabIndex = 4;
            this.mtbtnLocalIp.Text = "127.0.0.1";
            this.mtbtnLocalIp.UseVisualStyleBackColor = true;
            this.mtbtnLocalIp.CheckedChanged += new System.EventHandler(this.MtbtnLocalIp_CheckedChanged);
            // 
            // mtbtnAny
            // 
            this.mtbtnAny.AutoSize = true;
            this.mtbtnAny.Checked = true;
            this.mtbtnAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mtbtnAny.Location = new System.Drawing.Point(424, 115);
            this.mtbtnAny.Margin = new System.Windows.Forms.Padding(0);
            this.mtbtnAny.Name = "mtbtnAny";
            this.mtbtnAny.Size = new System.Drawing.Size(50, 21);
            this.mtbtnAny.TabIndex = 3;
            this.mtbtnAny.TabStop = true;
            this.mtbtnAny.Text = "Any";
            this.mtbtnAny.UseVisualStyleBackColor = true;
            this.mtbtnAny.CheckedChanged += new System.EventHandler(this.MtbtnAny_CheckedChanged);
            // 
            // mlblStatu
            // 
            this.mlblStatu.AutoSize = true;
            this.mlblStatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mlblStatu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblStatu.Location = new System.Drawing.Point(33, 41);
            this.mlblStatu.Name = "mlblStatu";
            this.mlblStatu.Size = new System.Drawing.Size(0, 18);
            this.mlblStatu.TabIndex = 2;
            // 
            // mrbtnStopServer
            // 
            this.mrbtnStopServer.Enabled = false;
            this.mrbtnStopServer.Location = new System.Drawing.Point(213, 115);
            this.mrbtnStopServer.Name = "mrbtnStopServer";
            this.mrbtnStopServer.Size = new System.Drawing.Size(145, 86);
            this.mrbtnStopServer.TabIndex = 1;
            this.mrbtnStopServer.Text = "Stop Server";
            this.mrbtnStopServer.UseVisualStyleBackColor = true;
            this.mrbtnStopServer.Click += new System.EventHandler(this.MrbtnStopServer_Click);
            // 
            // mrbtnStartServer
            // 
            this.mrbtnStartServer.Location = new System.Drawing.Point(37, 115);
            this.mrbtnStartServer.Name = "mrbtnStartServer";
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
            this.tpClient1.Size = new System.Drawing.Size(1192, 626);
            this.tpClient1.TabIndex = 3;
            this.tpClient1.Text = "Test Client 1";
            // 
            // ucTestClient2
            // 
            this.ucTestClient2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTestClient2.Font = new System.Drawing.Font("Consolas", 12F);
            this.ucTestClient2.Location = new System.Drawing.Point(0, 0);
            this.ucTestClient2.Margin = new System.Windows.Forms.Padding(4);
            this.ucTestClient2.Name = "ucTestClient2";
            this.ucTestClient2.Size = new System.Drawing.Size(1192, 626);
            this.ucTestClient2.TabIndex = 0;
            // 
            // tpClient2
            // 
            this.tpClient2.BackColor = System.Drawing.Color.White;
            this.tpClient2.Controls.Add(this.ucTestClient1);
            this.tpClient2.Location = new System.Drawing.Point(4, 28);
            this.tpClient2.Name = "tpClient2";
            this.tpClient2.Size = new System.Drawing.Size(1192, 626);
            this.tpClient2.TabIndex = 4;
            this.tpClient2.Text = "Test Client 2";
            // 
            // ucTestClient1
            // 
            this.ucTestClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTestClient1.Font = new System.Drawing.Font("Consolas", 12F);
            this.ucTestClient1.Location = new System.Drawing.Point(0, 0);
            this.ucTestClient1.Margin = new System.Windows.Forms.Padding(4);
            this.ucTestClient1.Name = "ucTestClient1";
            this.ucTestClient1.Size = new System.Drawing.Size(1192, 626);
            this.ucTestClient1.TabIndex = 0;
            // 
            // WFMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
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

        private TabControl mtc;
        private System.Windows.Forms.TabPage mtpLog;
        private System.Windows.Forms.TabPage mtpLobbies;
        private System.Windows.Forms.TabPage mtpStatus;
        private Button mrbtnStartServer;
        private Button mrbtnStopServer;
        private Label mlblStatu;
        private System.Windows.Forms.RichTextBox rtbxLog;
        private System.Windows.Forms.TreeView twLobbies;
        private Label mlblClientCount;
        private Label mlblLobbyCount;
        private Button mfbtnRefreshLobbies;
        private CheckBox mchbxScrollToEnd;
        private System.Windows.Forms.TabPage tpClient1;
        private System.Windows.Forms.TabPage tpClient2;
        private UCTestClient ucTestClient1;
        private UCTestClient ucTestClient2;
        private RadioButton mtbtnLocalHost;
        private RadioButton mtbtnLocalIp;
        private RadioButton mtbtnAny;
        private RadioButton mtbtnCustom;
        private TextBox msltfCustomIp;
        private Label mlblPort;
        private TextBox msltfPort;
    }
}