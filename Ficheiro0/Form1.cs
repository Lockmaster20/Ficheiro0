﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Ficheiro0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string docPath = Application.StartupPath + "\\Resources";
        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox.Text = File.ReadAllText(Path.Combine(docPath, "Texto.txt"));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string lines = richTextBox1.Text;
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Texto.txt")))
            {
                outputFile.WriteLine(lines);
            }
        }
    }
}
