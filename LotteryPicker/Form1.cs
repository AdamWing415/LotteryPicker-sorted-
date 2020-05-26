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

        private void generateButton_Click(object sender, EventArgs e)
        {
            //resets text
            outputLabel.ResetText();
            Refresh();

            //variable for number of numbers
            int maxNum;
            //sets number of numbers
            maxNum = Convert.ToInt32(NumberPicker.SelectedItem);
            
            //creates list for numbers
            List <int> lotteryList = new List <int>();

            //adds first nadom number
            lotteryList.Add(numGen.Next(1, MAX));

            //adds as many random numbers as there needs to be
            for (int i = 1; i < maxNum; i++)
            {
                int nextNum = numGen.Next(1, MAX);

                //if there are duplicate numbers, it re-randomizes them
                while (lotteryList.Contains(nextNum))
                {
                    nextNum = numGen.Next(1, MAX);
                }
                lotteryList.Add(nextNum);
            }

            //sorts list for output
            lotteryList.Sort();

            //outputs final list
            for (int i = 0; i < maxNum; i++)
            {
                outputLabel.Text += lotteryList[i] + " ";
            }
        }

        
    }
}
