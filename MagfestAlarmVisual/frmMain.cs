using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagfestAlarmVisual
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string soundPath = textSoundPath.Text;
            if (!File.Exists(soundPath))
            {
                textLog.AppendText("ERROR: Sound file not found" + Environment.NewLine);
                return;
            }

            if ((int)numUpdateTime.Value <= 0)
            {
                textLog.AppendText("ERROR: Update time must be greater than 0" + Environment.NewLine);
                return;
            }
            btnTest.Enabled = false;
            btnStart.Enabled = false;
            CheckOptions checkOptions = new CheckOptions(soundPath, (double)numDistance.Value, (double)numUpdateTime.Value);
            SaveSettings();
            backgroundCheck.RunWorkerAsync(checkOptions);
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.SOUND_PATH = textSoundPath.Text;
            Properties.Settings.Default.UPDATE_TIME = (double)numUpdateTime.Value;
            Properties.Settings.Default.MIN_DISTANCE = (double)numDistance.Value;
            Properties.Settings.Default.Save();
        }

        private void BackgroundCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckOptions checkOptions = (CheckOptions)e.Argument;
            bool isPartyTime = false;
            int roomId = 0;
            
            while (!isPartyTime)
            {
                string timeStamp = DateTime.Now.ToString("HH:mm:ss");
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.Headers["Content-Type"] = "application/json;charset=UTF-8";
                        client.Headers["X-EXL-FLOW-CODE"] = "GUEST";
                        JObject results = JObject.Parse(client.UploadString("https://regcloud.experientevent.com/ShowMFS221/api/RoomSearch", "{\"includeSoldOut\":true,\"arrivalDate\":\"2022-01-06T00:00:00.000Z\",\"departureDate\":\"2022-01-09T00:00:00.000Z\"}"));

                        foreach (var result in results["data"])
                        {
                            if (result["distance"].ToObject<double>() <= checkOptions.minDistance && result["distance"].ToObject<double>() >= 0.0 && result["isSoldOut"].ToObject<int>() != 1)
                            {
                                AppendLog("PARTY TIME!");
                                AppendLog("PARTY TIME!");
                                AppendLog("PARTY TIME!");
                                AppendLog("HOTEL FOUND: " + result["hotelName"].ToString());
                                AppendLog("HOTEL FOUND: " + result["hotelName"].ToString());
                                AppendLog("HOTEL FOUND: " + result["hotelName"].ToString());
                                roomId = result["facilityId"].ToObject<int>();
                                isPartyTime = true;
                            }
                        }

                        if (!isPartyTime)
                        {
                            AppendLog(timeStamp + " - No hotel found");
                        }
                    }
                }
                catch (WebException ex)
                {
                    AppendLog(timeStamp + " - WEB ERROR: " + ex.Message);
                }
                catch
                {
                    AppendLog(timeStamp + " - Unknown error :(");
                }
                Thread.Sleep((int)TimeSpan.FromSeconds(checkOptions.updateTime).TotalMilliseconds);
            }

            if (isPartyTime)
                PartyTime(checkOptions, roomId);
        }

        private void AppendLog(string message)
        {
            textLog.BeginInvoke((Action)(() =>
                textLog.AppendText(message + Environment.NewLine)
            ));
        }

        private void PartyTime(CheckOptions checkOptions, int roomId)
        {
            pictureRave.BeginInvoke((Action)(() =>
                pictureRave.Visible = true
            ));

            System.Diagnostics.Process.Start("https://regcloud.experientevent.com/WaitingRoom/RoomMFS221/");
            SoundPlayer alarmSound = new SoundPlayer();
            alarmSound.SoundLocation = checkOptions.soundPath;
            alarmSound.PlayLooping();
        }

        private void BackgroundCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnTest.Enabled = true;
            btnStart.Enabled = true;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            string soundPath = textSoundPath.Text;
            if (!File.Exists(soundPath))
            {
                textLog.AppendText("ERROR: Sound file not found" + Environment.NewLine);
                return;
            }

            if ((int)numUpdateTime.Value <= 0)
            {
                textLog.AppendText("ERROR: Update time must be greater than 0" + Environment.NewLine);
                return;
            }
            CheckOptions checkOptions = new CheckOptions(soundPath, (double)numDistance.Value, (double)numUpdateTime.Value);
            SaveSettings();

            PartyTime(checkOptions, 0);
        }

        private void BtnSound_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "WAV Files (*.wav)|*.wav";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textSoundPath.Text = openFileDialog.FileName;
                    SaveSettings();
                }
            }
        }

        private void NumDistance_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void NumUpdateTime_ValueChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            textSoundPath.Text = Properties.Settings.Default.SOUND_PATH;
            numUpdateTime.Value = Convert.ToDecimal(Properties.Settings.Default.UPDATE_TIME);
            numDistance.Value = Convert.ToDecimal(Properties.Settings.Default.MIN_DISTANCE);
        }
    }
}

public class CheckOptions
{
    public string soundPath;
    public double minDistance;
    public double updateTime;

    public CheckOptions(string SoundPath, double MinDistance, double UpdateTime)
    {
        soundPath = SoundPath;
        minDistance = MinDistance;
        updateTime = UpdateTime;
    }
}