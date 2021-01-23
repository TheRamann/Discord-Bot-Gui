using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Process processss;
        bool BotOn = false;
        ProcessStartInfo p = new ProcessStartInfo();



        public Form1()
        {
            InitializeComponent();
            p.FileName = "cmd.exe";
            p.WindowStyle = ProcessWindowStyle.Hidden;
            p.Arguments = "/k node index.js";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BotOn == false) 
            {
                processss = Process.Start(p);
                BotOn = true;
                MessageBox.Show("Bot Is Now Online");
            }
            else
            {
                MessageBox.Show("Bot Is Already online");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BotOn == true) 
            {
                processss.Kill();
                BotOn = false;
                MessageBox.Show("Bot Is Now Offline");
            }
            else
            {
                MessageBox.Show("Bot was not online");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "./bot/token.json");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
