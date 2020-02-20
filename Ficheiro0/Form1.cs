using System;
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

        RTFFile texto = new RTFFile();
        private void Button1_Click(object sender, EventArgs e)
        {
            TextBox.Text = texto.Texto;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            texto.Texto = richTextBox1.Text;
            texto.Salvar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            texto.Texto = richTextBox1.Text = "";
        }
    }
}
