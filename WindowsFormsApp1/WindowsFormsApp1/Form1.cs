﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox_Results.Text == "0" || isOperationPerformed) 
                textBox_Results.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Results.Text.Contains("."))
                textBox_Results.Text = textBox_Results.Text + button.Text;
            }
            else
            textBox_Results.Text = textBox_Results.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
                {
                button17.PerformClick();
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Results.Text);
                labelOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                }
            else
                {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Results.Text);
                labelOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
                }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Results.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox_Results.Text = "0";
            resultValue = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Results.Text = (resultValue + Double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "-":
                    textBox_Results.Text = (resultValue - Double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "*":
                    textBox_Results.Text = (resultValue * Double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "/":
                    textBox_Results.Text = (resultValue / Double.Parse(textBox_Results.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Results.Text);
            labelOperation.Text = "";
        }
    }
}
