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

namespace controller
{
    public partial class vliegpad : Form
    {
        public vliegpad()
        {
            InitializeComponent();
        }

        Tello tello = new Tello();

        private void button1_Click(object sender, EventArgs e)
        {
            //creeer een nieuw vliegpad en sla deze op in een csv bestand
            string[] vliegpad = new string[] { "takeoff", "up 50", "forward 100", "cw 90", "forward 100", "cw 90", "forward 100", "cw 90", "forward 100", "land" };
            System.IO.File.WriteAllLines(@"\GitHub\TelloCSharp\controller\vliegpad.csv", vliegpad);

            //zet het bestand onder de naam vliegpad.csv in de listbox
            listBox1.Items.Add("vliegpad.csv");
        }

        // als er op de item in de listbox wordt geklikt dan wordt deze uitgevoerd
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] vliegpad = System.IO.File.ReadAllLines(@"\GitHub\TelloCSharp\controller\vliegpad.csv");
            foreach (string command in vliegpad)
            {
                tello.Control(command);
            }
        }
    }
}
