using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFR
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void btN0_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "0";
        }

        private void btN1_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "1";
        }

        private void btN2_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "2";
        }

        private void btN3_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "3";
        }

        private void btN4_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "4";
        }

        private void btN5_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "5";
        }

        private void btN6_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "6";
        }

        private void btN7_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "7";
        }

        private void btN8_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "8";
        }

        private void btN9_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + "9";
        }

        private void btNPunto_Click(object sender, EventArgs e)
        {
            tbxScreem.Text = tbxScreem.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btNSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
        }
    }
}
