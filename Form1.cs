using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Flowers_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 650, 463, 60, 60));
            InitializeComponent();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WebsiteBtn_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kaoskrew.org");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.kaoskrew.org");
        }

        private void PrintempsBtn_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("Printemps");
            Process PlayGame = new Process();
            PlayGame.StartInfo.FileName = "FLOWERS.EXE";
            PlayGame.Start();
            Application.Exit();
        }

        private void EteBtn_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("Ete");
            Process PlayGame = new Process();
            PlayGame.StartInfo.FileName = "FLOWERS.EXE";
            PlayGame.Start();
            Application.Exit();
        }

        private void AutomneBtn_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("Automne");
            Process PlayGame = new Process();
            PlayGame.StartInfo.FileName = "FLOWERS.EXE";
            PlayGame.Start();
            Application.Exit();
        }

        private void HiverBtn_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("Hiver");
            Process PlayGame = new Process();
            PlayGame.StartInfo.FileName = "FLOWERS.EXE";
            PlayGame.Start();
            Application.Exit();
        }
    }
}
