using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace EdenLauncher
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();

            InitializeChromium();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            Cef.Initialize(settings);

            chromeBrowser = new ChromiumWebBrowser("http://tjeynon.us/edenchange.html");

            this.NewsPanel1.Controls.Add(chromeBrowser);

            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.Size = new Size(416, 289);
        }
        private void LaunchEden_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/154.16.67.95:30120");
        }

        private void JoinDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/fzexZJ4");
        }

        private void Sitebutton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/fzexZJ4");
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
