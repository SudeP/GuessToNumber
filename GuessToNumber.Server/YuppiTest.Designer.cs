
namespace GuessToNumber.Server
{
    partial class YuppiTest
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbxLog = new System.Windows.Forms.RichTextBox();
            this.cbxAutoScroll = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbxLogClient1 = new System.Windows.Forms.RichTextBox();
            this.btnStopClient1 = new System.Windows.Forms.Button();
            this.btnStartClient1 = new System.Windows.Forms.Button();
            this.cbxAutoScrollClient1 = new System.Windows.Forms.CheckBox();
            this.btnCreateClient1 = new System.Windows.Forms.Button();
            this.btnJoinClient1 = new System.Windows.Forms.Button();
            this.btnWithMeClient1 = new System.Windows.Forms.Button();
            this.btnWithoutMeClient1 = new System.Windows.Forms.Button();
            this.btnServerClient1 = new System.Windows.Forms.Button();
            this.btnClientClient1 = new System.Windows.Forms.Button();
            this.btnClientClient2 = new System.Windows.Forms.Button();
            this.btnServerClient2 = new System.Windows.Forms.Button();
            this.btnWithoutMeClient2 = new System.Windows.Forms.Button();
            this.btnWithMeClient2 = new System.Windows.Forms.Button();
            this.btnJoinClient2 = new System.Windows.Forms.Button();
            this.btnCreateClient2 = new System.Windows.Forms.Button();
            this.btnStopClient2 = new System.Windows.Forms.Button();
            this.btnStartClient2 = new System.Windows.Forms.Button();
            this.cbxAutoScrollClient2 = new System.Windows.Forms.CheckBox();
            this.rtbxLogClient2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.MergeIndex = 0;
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExit.Size = new System.Drawing.Size(101, 20);
            this.btnExit.Text = "Programı Kapat";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 657);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnStart);
            this.tabPage1.Controls.Add(this.cbxAutoScroll);
            this.tabPage1.Controls.Add(this.rtbxLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1256, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sunucu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClientClient1);
            this.tabPage2.Controls.Add(this.btnServerClient1);
            this.tabPage2.Controls.Add(this.btnWithoutMeClient1);
            this.tabPage2.Controls.Add(this.btnWithMeClient1);
            this.tabPage2.Controls.Add(this.btnJoinClient1);
            this.tabPage2.Controls.Add(this.btnCreateClient1);
            this.tabPage2.Controls.Add(this.btnStopClient1);
            this.tabPage2.Controls.Add(this.btnStartClient1);
            this.tabPage2.Controls.Add(this.cbxAutoScrollClient1);
            this.tabPage2.Controls.Add(this.rtbxLogClient1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1256, 625);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test Client 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtbxLog
            // 
            this.rtbxLog.BackColor = System.Drawing.Color.Black;
            this.rtbxLog.ForeColor = System.Drawing.Color.White;
            this.rtbxLog.Location = new System.Drawing.Point(8, 3);
            this.rtbxLog.Name = "rtbxLog";
            this.rtbxLog.Size = new System.Drawing.Size(1132, 614);
            this.rtbxLog.TabIndex = 0;
            this.rtbxLog.Text = "";
            // 
            // cbxAutoScroll
            // 
            this.cbxAutoScroll.AutoSize = true;
            this.cbxAutoScroll.Checked = true;
            this.cbxAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoScroll.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.cbxAutoScroll.Location = new System.Drawing.Point(1146, 6);
            this.cbxAutoScroll.Name = "cbxAutoScroll";
            this.cbxAutoScroll.Size = new System.Drawing.Size(103, 18);
            this.cbxAutoScroll.TabIndex = 1;
            this.cbxAutoScroll.Text = "Auto Scroll";
            this.cbxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1146, 30);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 32);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1145, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 32);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClientClient2);
            this.tabPage3.Controls.Add(this.btnServerClient2);
            this.tabPage3.Controls.Add(this.btnWithoutMeClient2);
            this.tabPage3.Controls.Add(this.btnWithMeClient2);
            this.tabPage3.Controls.Add(this.btnJoinClient2);
            this.tabPage3.Controls.Add(this.btnCreateClient2);
            this.tabPage3.Controls.Add(this.btnStopClient2);
            this.tabPage3.Controls.Add(this.btnStartClient2);
            this.tabPage3.Controls.Add(this.cbxAutoScrollClient2);
            this.tabPage3.Controls.Add(this.rtbxLogClient2);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1256, 625);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test Client 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbxLogClient1
            // 
            this.rtbxLogClient1.BackColor = System.Drawing.Color.Black;
            this.rtbxLogClient1.ForeColor = System.Drawing.Color.White;
            this.rtbxLogClient1.Location = new System.Drawing.Point(5, 5);
            this.rtbxLogClient1.Name = "rtbxLogClient1";
            this.rtbxLogClient1.Size = new System.Drawing.Size(1132, 614);
            this.rtbxLogClient1.TabIndex = 1;
            this.rtbxLogClient1.Text = "";
            // 
            // btnStopClient1
            // 
            this.btnStopClient1.Location = new System.Drawing.Point(1142, 75);
            this.btnStopClient1.Name = "btnStopClient1";
            this.btnStopClient1.Size = new System.Drawing.Size(104, 32);
            this.btnStopClient1.TabIndex = 6;
            this.btnStopClient1.Text = "Durdur";
            this.btnStopClient1.UseVisualStyleBackColor = true;
            this.btnStopClient1.Click += new System.EventHandler(this.btnStopClient1_Click);
            // 
            // btnStartClient1
            // 
            this.btnStartClient1.Location = new System.Drawing.Point(1143, 37);
            this.btnStartClient1.Name = "btnStartClient1";
            this.btnStartClient1.Size = new System.Drawing.Size(104, 32);
            this.btnStartClient1.TabIndex = 5;
            this.btnStartClient1.Text = "Başlat";
            this.btnStartClient1.UseVisualStyleBackColor = true;
            this.btnStartClient1.Click += new System.EventHandler(this.btnStartClient1_Click);
            // 
            // cbxAutoScrollClient1
            // 
            this.cbxAutoScrollClient1.AutoSize = true;
            this.cbxAutoScrollClient1.Checked = true;
            this.cbxAutoScrollClient1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoScrollClient1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.cbxAutoScrollClient1.Location = new System.Drawing.Point(1143, 13);
            this.cbxAutoScrollClient1.Name = "cbxAutoScrollClient1";
            this.cbxAutoScrollClient1.Size = new System.Drawing.Size(103, 18);
            this.cbxAutoScrollClient1.TabIndex = 4;
            this.cbxAutoScrollClient1.Text = "Auto Scroll";
            this.cbxAutoScrollClient1.UseVisualStyleBackColor = true;
            // 
            // btnCreateClient1
            // 
            this.btnCreateClient1.Location = new System.Drawing.Point(1143, 113);
            this.btnCreateClient1.Name = "btnCreateClient1";
            this.btnCreateClient1.Size = new System.Drawing.Size(104, 32);
            this.btnCreateClient1.TabIndex = 7;
            this.btnCreateClient1.Text = "Create";
            this.btnCreateClient1.UseVisualStyleBackColor = true;
            this.btnCreateClient1.Click += new System.EventHandler(this.btnCreateClient1_Click);
            // 
            // btnJoinClient1
            // 
            this.btnJoinClient1.Location = new System.Drawing.Point(1142, 151);
            this.btnJoinClient1.Name = "btnJoinClient1";
            this.btnJoinClient1.Size = new System.Drawing.Size(104, 32);
            this.btnJoinClient1.TabIndex = 8;
            this.btnJoinClient1.Text = "Join";
            this.btnJoinClient1.UseVisualStyleBackColor = true;
            this.btnJoinClient1.Click += new System.EventHandler(this.btnJoinClient1_Click);
            // 
            // btnWithMeClient1
            // 
            this.btnWithMeClient1.Location = new System.Drawing.Point(1142, 189);
            this.btnWithMeClient1.Name = "btnWithMeClient1";
            this.btnWithMeClient1.Size = new System.Drawing.Size(104, 32);
            this.btnWithMeClient1.TabIndex = 9;
            this.btnWithMeClient1.Text = "With me";
            this.btnWithMeClient1.UseVisualStyleBackColor = true;
            this.btnWithMeClient1.Click += new System.EventHandler(this.btnWithMeClient1_Click);
            // 
            // btnWithoutMeClient1
            // 
            this.btnWithoutMeClient1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnWithoutMeClient1.Location = new System.Drawing.Point(1142, 227);
            this.btnWithoutMeClient1.Name = "btnWithoutMeClient1";
            this.btnWithoutMeClient1.Size = new System.Drawing.Size(104, 32);
            this.btnWithoutMeClient1.TabIndex = 10;
            this.btnWithoutMeClient1.Text = "Without me";
            this.btnWithoutMeClient1.UseVisualStyleBackColor = true;
            this.btnWithoutMeClient1.Click += new System.EventHandler(this.btnWithoutMeClient1_Click);
            // 
            // btnServerClient1
            // 
            this.btnServerClient1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnServerClient1.Location = new System.Drawing.Point(1142, 265);
            this.btnServerClient1.Name = "btnServerClient1";
            this.btnServerClient1.Size = new System.Drawing.Size(104, 32);
            this.btnServerClient1.TabIndex = 11;
            this.btnServerClient1.Text = "Server";
            this.btnServerClient1.UseVisualStyleBackColor = true;
            this.btnServerClient1.Click += new System.EventHandler(this.btnServerClient1_Click);
            // 
            // btnClientClient1
            // 
            this.btnClientClient1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnClientClient1.Location = new System.Drawing.Point(1143, 303);
            this.btnClientClient1.Name = "btnClientClient1";
            this.btnClientClient1.Size = new System.Drawing.Size(104, 32);
            this.btnClientClient1.TabIndex = 12;
            this.btnClientClient1.Text = "Client";
            this.btnClientClient1.UseVisualStyleBackColor = true;
            this.btnClientClient1.Click += new System.EventHandler(this.btnClientClient1_Click);
            // 
            // btnClientClient2
            // 
            this.btnClientClient2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnClientClient2.Location = new System.Drawing.Point(1145, 303);
            this.btnClientClient2.Name = "btnClientClient2";
            this.btnClientClient2.Size = new System.Drawing.Size(104, 32);
            this.btnClientClient2.TabIndex = 22;
            this.btnClientClient2.Text = "Client";
            this.btnClientClient2.UseVisualStyleBackColor = true;
            this.btnClientClient2.Click += new System.EventHandler(this.btnClientClient2_Click);
            // 
            // btnServerClient2
            // 
            this.btnServerClient2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnServerClient2.Location = new System.Drawing.Point(1144, 265);
            this.btnServerClient2.Name = "btnServerClient2";
            this.btnServerClient2.Size = new System.Drawing.Size(104, 32);
            this.btnServerClient2.TabIndex = 21;
            this.btnServerClient2.Text = "Server";
            this.btnServerClient2.UseVisualStyleBackColor = true;
            this.btnServerClient2.Click += new System.EventHandler(this.btnServerClient2_Click);
            // 
            // btnWithoutMeClient2
            // 
            this.btnWithoutMeClient2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.btnWithoutMeClient2.Location = new System.Drawing.Point(1144, 227);
            this.btnWithoutMeClient2.Name = "btnWithoutMeClient2";
            this.btnWithoutMeClient2.Size = new System.Drawing.Size(104, 32);
            this.btnWithoutMeClient2.TabIndex = 20;
            this.btnWithoutMeClient2.Text = "Without me";
            this.btnWithoutMeClient2.UseVisualStyleBackColor = true;
            this.btnWithoutMeClient2.Click += new System.EventHandler(this.btnWithoutMeClient2_Click);
            // 
            // btnWithMeClient2
            // 
            this.btnWithMeClient2.Location = new System.Drawing.Point(1144, 189);
            this.btnWithMeClient2.Name = "btnWithMeClient2";
            this.btnWithMeClient2.Size = new System.Drawing.Size(104, 32);
            this.btnWithMeClient2.TabIndex = 19;
            this.btnWithMeClient2.Text = "With me";
            this.btnWithMeClient2.UseVisualStyleBackColor = true;
            this.btnWithMeClient2.Click += new System.EventHandler(this.btnWithMeClient2_Click);
            // 
            // btnJoinClient2
            // 
            this.btnJoinClient2.Location = new System.Drawing.Point(1144, 151);
            this.btnJoinClient2.Name = "btnJoinClient2";
            this.btnJoinClient2.Size = new System.Drawing.Size(104, 32);
            this.btnJoinClient2.TabIndex = 18;
            this.btnJoinClient2.Text = "Join";
            this.btnJoinClient2.UseVisualStyleBackColor = true;
            this.btnJoinClient2.Click += new System.EventHandler(this.btnJoinClient2_Click);
            // 
            // btnCreateClient2
            // 
            this.btnCreateClient2.Location = new System.Drawing.Point(1145, 113);
            this.btnCreateClient2.Name = "btnCreateClient2";
            this.btnCreateClient2.Size = new System.Drawing.Size(104, 32);
            this.btnCreateClient2.TabIndex = 17;
            this.btnCreateClient2.Text = "Create";
            this.btnCreateClient2.UseVisualStyleBackColor = true;
            this.btnCreateClient2.Click += new System.EventHandler(this.btnCreateClient2_Click);
            // 
            // btnStopClient2
            // 
            this.btnStopClient2.Location = new System.Drawing.Point(1144, 75);
            this.btnStopClient2.Name = "btnStopClient2";
            this.btnStopClient2.Size = new System.Drawing.Size(104, 32);
            this.btnStopClient2.TabIndex = 16;
            this.btnStopClient2.Text = "Durdur";
            this.btnStopClient2.UseVisualStyleBackColor = true;
            this.btnStopClient2.Click += new System.EventHandler(this.btnStopClient2_Click);
            // 
            // btnStartClient2
            // 
            this.btnStartClient2.Location = new System.Drawing.Point(1145, 37);
            this.btnStartClient2.Name = "btnStartClient2";
            this.btnStartClient2.Size = new System.Drawing.Size(104, 32);
            this.btnStartClient2.TabIndex = 15;
            this.btnStartClient2.Text = "Başlat";
            this.btnStartClient2.UseVisualStyleBackColor = true;
            this.btnStartClient2.Click += new System.EventHandler(this.btnStartClient2_Click);
            // 
            // cbxAutoScrollClient2
            // 
            this.cbxAutoScrollClient2.AutoSize = true;
            this.cbxAutoScrollClient2.Checked = true;
            this.cbxAutoScrollClient2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoScrollClient2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.cbxAutoScrollClient2.Location = new System.Drawing.Point(1145, 13);
            this.cbxAutoScrollClient2.Name = "cbxAutoScrollClient2";
            this.cbxAutoScrollClient2.Size = new System.Drawing.Size(103, 18);
            this.cbxAutoScrollClient2.TabIndex = 14;
            this.cbxAutoScrollClient2.Text = "Auto Scroll";
            this.cbxAutoScrollClient2.UseVisualStyleBackColor = true;
            // 
            // rtbxLogClient2
            // 
            this.rtbxLogClient2.BackColor = System.Drawing.Color.Black;
            this.rtbxLogClient2.ForeColor = System.Drawing.Color.White;
            this.rtbxLogClient2.Location = new System.Drawing.Point(7, 5);
            this.rtbxLogClient2.Name = "rtbxLogClient2";
            this.rtbxLogClient2.Size = new System.Drawing.Size(1132, 614);
            this.rtbxLogClient2.TabIndex = 13;
            this.rtbxLogClient2.Text = "";
            // 
            // YuppiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GuessToNumber.Server.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YuppiTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.RichTextBox rtbxLog;
        private System.Windows.Forms.CheckBox cbxAutoScroll;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbxLogClient1;
        private System.Windows.Forms.Button btnStopClient1;
        private System.Windows.Forms.CheckBox cbxAutoScrollClient1;
        private System.Windows.Forms.Button btnStartClient1;
        private System.Windows.Forms.Button btnCreateClient1;
        private System.Windows.Forms.Button btnWithoutMeClient1;
        private System.Windows.Forms.Button btnWithMeClient1;
        private System.Windows.Forms.Button btnJoinClient1;
        private System.Windows.Forms.Button btnServerClient1;
        private System.Windows.Forms.Button btnClientClient1;
        private System.Windows.Forms.Button btnClientClient2;
        private System.Windows.Forms.Button btnServerClient2;
        private System.Windows.Forms.Button btnWithoutMeClient2;
        private System.Windows.Forms.Button btnWithMeClient2;
        private System.Windows.Forms.Button btnJoinClient2;
        private System.Windows.Forms.Button btnCreateClient2;
        private System.Windows.Forms.Button btnStopClient2;
        private System.Windows.Forms.Button btnStartClient2;
        private System.Windows.Forms.CheckBox cbxAutoScrollClient2;
        private System.Windows.Forms.RichTextBox rtbxLogClient2;
    }
}