using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS011WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Zpracovat_Click(object sender, EventArgs e)
        {
            vystupLabel.Text = "Výstup: " + textBox.Text;
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Zpracovat_Click(sender, e);
            }

        }
    }
}
