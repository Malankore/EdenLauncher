﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdenLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayEden_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("fivem://connect/154.16.67.95:30120");
        }
    }
}
