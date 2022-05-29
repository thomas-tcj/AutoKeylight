namespace App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbKeylightIp = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbWebcamStatus = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AutoKeyLight";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            // 
            // tbKeylightIp
            // 
            this.tbKeylightIp.Location = new System.Drawing.Point(12, 37);
            this.tbKeylightIp.Name = "tbKeylightIp";
            this.tbKeylightIp.Size = new System.Drawing.Size(708, 31);
            this.tbKeylightIp.TabIndex = 0;
            this.tbKeylightIp.TextChanged += new System.EventHandler(this.tbKeylightIp_TextChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(95, 25);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Keylight IP";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(12, 71);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(137, 25);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Webcam status:";
            // 
            // lbWebcamStatus
            // 
            this.lbWebcamStatus.AutoSize = true;
            this.lbWebcamStatus.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbWebcamStatus.Location = new System.Drawing.Point(146, 71);
            this.lbWebcamStatus.Name = "lbWebcamStatus";
            this.lbWebcamStatus.Size = new System.Drawing.Size(87, 25);
            this.lbWebcamStatus.TabIndex = 3;
            this.lbWebcamStatus.Text = "Unknown";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(239, 71);
            this.lbError.MinimumSize = new System.Drawing.Size(475, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(475, 25);
            this.lbError.TabIndex = 4;
            this.lbError.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 105);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbWebcamStatus);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbKeylightIp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AutoKeyLight";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private TextBox tbKeylightIp;
        private Label lb1;
        private Label lb2;
        private Label lbWebcamStatus;
        private Label lbError;
    }
}