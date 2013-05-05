namespace LoLConnectionTool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnPing = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRestartModem = new System.Windows.Forms.Button();
            this.webModem = new System.Windows.Forms.WebBrowser();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(12, 12);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 0;
            this.btnPing.Text = "Ping LoL";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 88);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(194, 160);
            this.txtStatus.TabIndex = 1;
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(93, 12);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(113, 23);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "Kill LoL Processes";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRestartModem
            // 
            this.btnRestartModem.Location = new System.Drawing.Point(93, 41);
            this.btnRestartModem.Name = "btnRestartModem";
            this.btnRestartModem.Size = new System.Drawing.Size(113, 23);
            this.btnRestartModem.TabIndex = 4;
            this.btnRestartModem.Text = "Restart Modem";
            this.btnRestartModem.UseVisualStyleBackColor = true;
            this.btnRestartModem.Click += new System.EventHandler(this.btnRestartModem_Click);
            // 
            // webModem
            // 
            this.webModem.Location = new System.Drawing.Point(353, 12);
            this.webModem.MinimumSize = new System.Drawing.Size(20, 20);
            this.webModem.Name = "webModem";
            this.webModem.Size = new System.Drawing.Size(128, 236);
            this.webModem.TabIndex = 5;
            this.webModem.Visible = false;
            this.webModem.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webModem_DocumentCompleted);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 30000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 265);
            this.Controls.Add(this.webModem);
            this.Controls.Add(this.btnRestartModem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoL Connection Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRestartModem;
        private System.Windows.Forms.WebBrowser webModem;
        private System.Windows.Forms.Timer timerCountdown;
    }
}

