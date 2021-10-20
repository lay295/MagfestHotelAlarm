namespace MagfestAlarmVisual
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.textSoundPath = new System.Windows.Forms.TextBox();
            this.btnSound = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpdateTime = new System.Windows.Forms.NumericUpDown();
            this.textLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.backgroundCheck = new System.ComponentModel.BackgroundWorker();
            this.pictureRave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRave)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(210, 220);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Monitor";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alarm Sound:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum Distance (mi):";
            // 
            // numDistance
            // 
            this.numDistance.DecimalPlaces = 1;
            this.numDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDistance.Location = new System.Drawing.Point(141, 42);
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(48, 20);
            this.numDistance.TabIndex = 3;
            this.numDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDistance.ValueChanged += new System.EventHandler(this.NumDistance_ValueChanged);
            // 
            // textSoundPath
            // 
            this.textSoundPath.Location = new System.Drawing.Point(141, 16);
            this.textSoundPath.Name = "textSoundPath";
            this.textSoundPath.Size = new System.Drawing.Size(100, 20);
            this.textSoundPath.TabIndex = 4;
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(247, 16);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(30, 20);
            this.btnSound.TabIndex = 5;
            this.btnSound.Text = "...";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.BtnSound_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Update Time (s):";
            // 
            // numUpdateTime
            // 
            this.numUpdateTime.Location = new System.Drawing.Point(141, 68);
            this.numUpdateTime.Name = "numUpdateTime";
            this.numUpdateTime.Size = new System.Drawing.Size(48, 20);
            this.numUpdateTime.TabIndex = 7;
            this.numUpdateTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdateTime.ValueChanged += new System.EventHandler(this.NumUpdateTime_ValueChanged);
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(20, 121);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(169, 146);
            this.textLog.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Log:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(210, 193);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(95, 21);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test Settings";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // backgroundCheck
            // 
            this.backgroundCheck.WorkerSupportsCancellation = true;
            this.backgroundCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCheck_DoWork);
            this.backgroundCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundCheck_RunWorkerCompleted);
            // 
            // pictureRave
            // 
            this.pictureRave.Image = global::MagfestAlarmVisual.Properties.Resources.giphy;
            this.pictureRave.Location = new System.Drawing.Point(200, 40);
            this.pictureRave.Name = "pictureRave";
            this.pictureRave.Size = new System.Drawing.Size(115, 150);
            this.pictureRave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRave.TabIndex = 10;
            this.pictureRave.TabStop = false;
            this.pictureRave.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 279);
            this.Controls.Add(this.pictureRave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.numUpdateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.textSoundPath);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Magfest Stalker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.TextBox textSoundPath;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpdateTime;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest;
        private System.ComponentModel.BackgroundWorker backgroundCheck;
        private System.Windows.Forms.PictureBox pictureRave;
    }
}

