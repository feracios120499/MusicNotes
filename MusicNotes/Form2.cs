using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicNotes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 69; i++)
            {
                var button = new Button();
                button.Tag = i.ToString();
                panel2.Controls.Add(button);
                button.Dock = DockStyle.Left;
                button.Click += Button_Click;
                button.Width = 17;
                button.BackColor = Color.White;
                button.MouseDown += Button_MouseDown;
                button.MouseUp += Button_MouseUp;
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackColor = Color.White;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            button.BackColor = Color.Black;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var task = Task.Factory.StartNew(() => PlayNote(button));
        }
        SoundPlayer player = new SoundPlayer();
        private void PlayNote(Button button)
        {
            string file = Directory.GetFiles("notes/", $"{button.Tag.ToString()}.wav").FirstOrDefault();  
            player.SoundLocation = file;
            player.Play();
        }


        private WaveFileWriter RecordedAudioWriter = null;
        private WasapiLoopbackCapture CaptureInstance = null;
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        private void buttonRecording_Click(object sender, EventArgs e)
        {

            string outputFilePath = @"system_recorded_audio.wav";
            this.CaptureInstance = new WasapiLoopbackCapture();
            this.RecordedAudioWriter = new WaveFileWriter(outputFilePath, CaptureInstance.WaveFormat);
            this.CaptureInstance.DataAvailable += (s, a) =>
            {
                this.RecordedAudioWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };
            this.CaptureInstance.RecordingStopped += (s, a) =>
            {
                this.RecordedAudioWriter.Dispose();
                this.RecordedAudioWriter = null;
                CaptureInstance.Dispose();
            };
            this.buttonRecording.Enabled = false;
            this.buttonPlay.Enabled = false;
            this.buttonSave.Enabled = false;
            this.buttonStop.Enabled = true;

            this.CaptureInstance.StartRecording();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            string file = @"system_recorded_audio.wav";
            player.SoundLocation = file;
            player.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.CaptureInstance.StopRecording();
            this.buttonRecording.Enabled = true;
            this.buttonPlay.Enabled = true;
            this.buttonSave.Enabled = true;
            this.buttonStop.Enabled = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "(*.wav)|*.wav";
            dialog.DefaultExt = "wav";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.Copy("system_recorded_audio.wav", dialog.FileName);
            }

        }
    }
}
