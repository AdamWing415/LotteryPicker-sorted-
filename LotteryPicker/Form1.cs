using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPicker
{
    public partial class Form1 : Form
    {
        //creates the random number generator
        Random numGen = new Random();

        //sets max number to 99 (100 - 1)
        const int MAX = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = numGen.Next(1, MAX);
            
            int num2 = numGen.Next(1, MAX);

            //check num2 for duplicates
            while (num2 == num1)
            {
               num2 = numGen.Next(1, MAX);
            }

            int num3 = numGen.Next(1, MAX);

            //check num3 for duplicates
            while (num3 == num1 || num3 == num2)
            {
               num3 = numGen.Next(1, MAX);
            }

            int num4 = numGen.Next(1, MAX);

            //check num4 for duplicates
            while (num4 == num1 || num4 ==  num2 || num4 == num3)
            {
                num4 = numGen.Next(1, MAX);
            }

            int num5 = numGen.Next(1, MAX);

            //check num5 for duplicates
            while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4)
            {
                num5 = numGen.Next(1, MAX);
            }

            int num6 = numGen.Next(1, MAX);

            //check num6 for duplicates
            while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5)
            {
                num6 = numGen.Next(1, MAX);
            }

            //outputs final numbers
            outputLabel.Text = $"{num1}, {num2}, {num3}, {num4}, {num5}, {num6},";
        }
    }
}
