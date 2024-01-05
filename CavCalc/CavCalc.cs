using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CavCalc
{
    public partial class CavCalc : Form
    {
        double accumulate;
        string button;
        string operation;


        public CavCalc()
        {
            InitializeComponent();
        }

        private void CavCalc_Load(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            button = "0";
            Adbotao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button = "1";
            Adbotao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button = "2";
            Adbotao();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button = "3";
            Adbotao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button = "4";
            Adbotao();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button = "5";
            Adbotao();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button = "6";
            Adbotao();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button = "7";
            Adbotao();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button = "8";
            Adbotao();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button = "9";
            Adbotao();
        }

        private void Adbotao()
        {
            if (labelResult.Text == "0")
            {
                labelResult.Text = button;
            }
            else
            {
                labelResult.Text += button;
            }
            button = "";
        }

        private void buttonAdc_Click(object sender, EventArgs e)
        {
            operation = "+";
            count();

        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            operation = "-";
            count();
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operation = "*";
            count();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            count();
        }

        private void count()
        {
            switch (operation)
            {
                case "+":
                    accumulate = double.Parse(labelResult.Text);
                    operation = "+";
                    labelResult.Text = "0";
                break;
                case "-":
                    accumulate = double.Parse(labelResult.Text) - accumulate;
                    operation = "-";
                    labelResult.Text = "0";
                    break;
                case "*":
                    accumulate = double.Parse(labelResult.Text);
                    operation = "*";
                    labelResult.Text = "0";
                    break;
                case "/":
                    accumulate = double.Parse(labelResult.Text);
                    operation = "/";
                    labelResult.Text = "0";
                    break;
            }
            button = "";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+": soma(); break;
                case "-": subtacao(); break;
                case "/": divisao(); break;
                case "*": multipicacao(); break;
            }
        }

        private void soma()
        {
            accumulate += double.Parse(labelResult.Text);
            labelResult.Text = accumulate.ToString();
            operation = "";
            accumulate = 0;
        }
        private void subtacao()
        {
            accumulate -= double.Parse(labelResult.Text);
            labelResult.Text = accumulate.ToString();
            operation = "";
            accumulate = 0;
        }
        private void multipicacao()
        {
            accumulate *= double.Parse(labelResult.Text);
            labelResult.Text = accumulate.ToString();
            operation = "";
            accumulate = 0;
        }
        private void divisao()
        {
            accumulate /= double.Parse(labelResult.Text);
            labelResult.Text = accumulate.ToString();
            operation = "";
            accumulate = 0;
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void labelAcc_Click(object sender, EventArgs e)
        {

        }
    }
}
