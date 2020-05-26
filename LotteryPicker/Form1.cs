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
            outputLabel.ResetText();
            Refresh();

            int maxNum = 9;

            maxNum = Convert.ToInt32(NumberPicker.SelectedItem);
            

            List <int> lotteryList = new List <int>();


            lotteryList.Add(numGen.Next(1, MAX));

            for (int i = 1; i < maxNum; i++)
            {
                int nextNum = numGen.Next(1, MAX);

                while (lotteryList.Contains(nextNum))
                {
                    nextNum = numGen.Next(1, MAX);
                }
                lotteryList.Add(nextNum);
            }


            lotteryList.Sort();

            for (int i = 0; i < maxNum; i++)
            {
                outputLabel.Text += lotteryList[i] + " ";
            }
        }

        
    }
}
