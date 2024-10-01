using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tellocs;
using LogLib;
using SettingsLib;
using System.IO;

namespace controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tello tello = new Tello();



        private void Form1_Load(object sender, EventArgs e)
        {
            ConsoleLog log = Log.Instance as ConsoleLog;
            log.LogSeverityLevel = LogSeverity.Info;
            // load settings
            string settingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TelloConfig.txt");
            Log.Action($"Load settings from {settingsFile}");
            Settings settings = new Settings(settingsFile);
            settings.LoadSettings();
            tello.Speed = settings.GetOrAddSetting<int>("DefaultDroneSpeed", 50);
            tello.FFmpegPath = settings.GetOrAddSetting<string>("FFmpegPath", "ffmpeg.exe");
            tello.DebugMode = settings.GetOrAddSetting<bool>("DebugMode", false);

            Log.Action("Connecting to Tello");
            tello.Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tello.Takeoff();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tello.Land();
        }
    }
}

