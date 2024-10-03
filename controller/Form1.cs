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
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Input;
using System.Windows.Controls;

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

        private void BtnTurnLeft_Click(object sender, EventArgs e)
        {
            tello.CounterClockwise(90);
        }

        private void BtnTurnRight_Click(object sender, EventArgs e)
        {
            tello.Clockwise(90);
        }

        private void BtnVooruit_Click(object sender, EventArgs e)
        {
            tello.Forward(50);
        }

        private void BtnAchteruit_Click(object sender, EventArgs e)
        {
            tello.Back(50);
        }

        private void BtnFlip_Click(object sender, EventArgs e)
        {
            tello.Flip("l");
        }

        private void BtnFlipRight_Click(object sender, EventArgs e)
        {
            tello.Flip("r");
        }

        private void BtnFrontFlip_Click(object sender, EventArgs e)
        {
            tello.Flip("f");
        }

        private void BtnBackFlip_Click(object sender, EventArgs e)
        {
            tello.Flip("b");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tello.Right(100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tello.Left(100);
        }

        private void BtnStream_Click(object sender, EventArgs e)
        {
            //start video stream
            tello.StartOrStopVideoStreaming();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //update battery status op Label1
            label1.Text = "baterij " + tello.Battery.ToString();
        }

        private void BtnOmhoog_Click(object sender, EventArgs e)
        {
            tello.Up(50);
        }

        private void BtnOmlaag_Click(object sender, EventArgs e)
        {
            tello.Down(50);
        }

        private int lr = 0, fb = 0, ud = 0, d = 0;
        private bool useRC = true; // Voor de demonstratie, als useRC ergens anders vandaan komt moet dit aangepast worden.

        private void BtnVliegPadSelecteren_Click(object sender, EventArgs e)
        {

            //creeer een nieuw vliegpad en sla deze op in een csv bestand
            string[] vliegpad = new string[] { "takeoff", "up 50", "forward 100","flip f" ,"flip b","flip l","flip r", "land" };

            foreach (string command in vliegpad)
            {
                tello.Control(command);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] vliegpad = System.IO.File.ReadAllLines(@"\GitHub\TelloCSharp\controller\vliegpad.csv");
            //foreach (string command in vliegpad)
            //{
            //    tello.Control(command);
            //}
        }

        //private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.W)
        //    {
        //        fb = 100;
        //    }
        //    else if (e.KeyCode == Keys.S)
        //    {
        //        fb = -100;
        //    }

        //    if (e.KeyCode == Keys.Left)
        //    {
        //        lr = -100;
        //    }
        //    else if (e.KeyCode == Keys.Right)
        //    {
        //        lr = 100;
        //    }

        //    if (e.KeyCode == Keys.Space)
        //    {
        //        ud = 100;
        //    }
        //    else if (e.KeyCode == Keys.ShiftKey)
        //    {
        //        ud = -100;
        //    }

        //    if (e.KeyCode == Keys.D)
        //    {
        //        d = 100;
        //    }
        //    else if (e.KeyCode == Keys.A)
        //    {
        //        d = -100;
        //    }

        //    // Stuur de commando's als useRC true is
        //    if (useRC)
        //    {
        //        tello.SendRCControl(lr, fb, ud, d); // Zorg ervoor dat tello correct geïnitialiseerd is in jouw project
        //    }
        //}
    }
}

