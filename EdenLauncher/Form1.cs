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
        //set the name of the browser component
        public ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();
            //Initialize cefsharp browser
            InitializeChromium();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();

            Cef.Initialize(settings);
            //Create the browser and specify the address to load
            chromeBrowser = new ChromiumWebBrowser("http://tjeynon.us/edenchange.html");
            //Specify the location of the browser
            this.NewsPanel1.Controls.Add(chromeBrowser);
            //Specify the browser dock style
            chromeBrowser.Dock = DockStyle.Fill;
            //Specify browser size
            chromeBrowser.Size = new Size(416, 289);
        }
        private void LaunchEden_Click(object sender, EventArgs e)
        {
            //Launch FiveM and connect to the server
            System.Diagnostics.Process.Start("fivem://connect/154.16.67.95:30120");
        }

        private void JoinDiscord_Click(object sender, EventArgs e)
        {
            //Open users browser to the discord invite
            System.Diagnostics.Process.Start("https://discord.gg/fzexZJ4");
        }

        private void Sitebutton_Click(object sender, EventArgs e)
        {
            //Open the users browser to the website
            System.Diagnostics.Process.Start("https://discord.gg/fzexZJ4");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Be sure to shut the browser down before the app fully closes
            Cef.Shutdown();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
