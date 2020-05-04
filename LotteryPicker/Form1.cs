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
        //creates the random number generator.
        Random numGen = new Random();

        //sets max number to 99 (100 - 1)
        const int MAX = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //array for all 6 numbers
            int[] lotteryArray = new int[6];
            lotteryArray[0] = numGen.Next(1, MAX);
            lotteryArray[1] = numGen.Next(1, MAX);
            lotteryArray[2] = numGen.Next(1, MAX);
            lotteryArray[3] = numGen.Next(1, MAX);
            lotteryArray[4] = numGen.Next(1, MAX);
            lotteryArray[5] = numGen.Next(1, MAX);
            
            //sorts numbers in increasing order to make comparing easier
            
            Array.Sort(lotteryArray);
            
            //compares all array values
            while (lotteryArray[0] == lotteryArray[1] || lotteryArray[1] == lotteryArray[2] || lotteryArray[2] == lotteryArray[3] || lotteryArray[3] == lotteryArray[4] || lotteryArray[4] == lotteryArray[5])
            {
                //if any value is equal to another value, re-randomize
                lotteryArray[0] = numGen.Next(1, MAX);
                lotteryArray[1] = numGen.Next(1, MAX);
                lotteryArray[2] = numGen.Next(1, MAX);
                lotteryArray[3] = numGen.Next(1, MAX);
                lotteryArray[4] = numGen.Next(1, MAX);
                lotteryArray[5] = numGen.Next(1, MAX);
            }

            //displays final numbers
            outputLabel.Text = $"{lotteryArray[0]}, {lotteryArray[1]}, {lotteryArray[2]}, {lotteryArray[3]}, {lotteryArray[4]}, {lotteryArray[5]}";
        }
    }
}
