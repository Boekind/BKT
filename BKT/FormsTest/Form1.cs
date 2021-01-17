using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTest
{
    public partial class Form1 : Form
    {
        Held Held1 = new Held("Bob", 24, $@"{Environment.CurrentDirectory}\\Bilder\\Bob.PNG", 200, 100);
        Held Held2 = new Held("NichtBob", 50, $@"{Environment.CurrentDirectory}\\Bilder\\NichtBob.PNG", 300, 100);

        string test = Path.Combine(Environment.CurrentDirectory, "\\Bilder\\Bob.PNG");


        public Form1()
        {
            InitializeComponent();
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelName.Text == "Bob")
            {
                SetHeld(Held2);
            }
            else
            {
                SetHeld(Held1);
            }
        }

        private void SetHeld(Held held)
        {
            pictureHeld.Image = Image.FromFile(held.BildUrl);
            labelName.Text = held.Name;
            labelLevel.Text = $"Level: {held.Level}";
            progressBar1.Maximum = held.MaxHP;
            progressBar1.Value = held.CurrentHP;
            labelHP.Text = $"{held.CurrentHP} / {held.MaxHP}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var r = new Random();
            progressBar1.Value += r.Next(1, 10);
        }
    }
}
