using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maple_Scroll_Probability_Calculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //until a number of slots has been chosen for the item, none of these can be changed.
            cmb10.Enabled = false;
            cmb30.Enabled = false;
            cmb60.Enabled = false;
            cmb70.Enabled = false;
            cmb100.Enabled = false;
            //MessageBox.Show(nCr(9,6).ToString());
        }

        private void cmbSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ItemToAdd;

            cmb10.Enabled = true;
            cmb30.Enabled = true;
            cmb60.Enabled = true;
            cmb70.Enabled = true;
            cmb100.Enabled = true;
            cmb10.Items.Clear();           
            cmb30.Items.Clear();            
            cmb60.Items.Clear();            
            cmb70.Items.Clear();            
            cmb100.Items.Clear();


            for (int i = 0; i <= cmbSlots.SelectedIndex; i++)
            {
                
                cmb10.Items.Add(i);
                cmb30.Items.Add(i);
                cmb60.Items.Add(i);
                cmb70.Items.Add(i);
                cmb100.Items.Add(i);
            }
            cmb10.SelectedIndex = 0;
            cmb30.SelectedIndex = 0;
            cmb60.SelectedIndex = 0;
            cmb70.SelectedIndex = 0;
            cmb100.SelectedIndex = 0;
        }

        private void UpdateCombos()
        {
            int TotalFor10;
            int TotalFor30;
            int TotalFor60;
            int TotalFor70;
            int TotalFor100;

            int SlotsLeft;
            
            //work out how many slots are left
            SlotsLeft = cmbSlots.SelectedIndex - cmb10.SelectedIndex - cmb30.SelectedIndex - cmb60.SelectedIndex - cmb70.SelectedIndex - cmb100.SelectedIndex;

            TotalFor10 = cmb10.SelectedIndex + SlotsLeft;
            TotalFor30 = cmb30.SelectedIndex + SlotsLeft;
            TotalFor60 = cmb60.SelectedIndex + SlotsLeft;
            TotalFor70 = cmb70.SelectedIndex + SlotsLeft;
            TotalFor100 = cmb100.SelectedIndex + SlotsLeft;            

            //set items for 10% combo box
            if (TotalFor10 >= cmb10.Items.Count) //we have just decreased another cmb
            {
                for (int i = cmb10.Items.Count; i <= TotalFor10; i++)
                {
                    cmb10.Items.Add(i);
                }
            }
            else if (TotalFor10 < cmb10.Items.Count) //we have just increased another cmb
            {
                for (int i = cmb10.Items.Count - 1; i > TotalFor10; i--)//thanks to 0 indexing and the fact that you can use 0 of a type of scroll, the index is 
                {                                                   //handily the same as the data we want to add in that index. Makes programming this a 
                    cmb10.Items.RemoveAt(i);                        //little easier. 
                }
            }
            //the rest are just the same but with for 30, 60, 70 and 100. 
            //set items for 30% combo box
            if (TotalFor30 >= cmb30.Items.Count) //we have just decreased another cmb
            {
                for (int i = cmb30.Items.Count; i <= TotalFor30; i++)
                {
                    cmb30.Items.Add(i);
                }
            }
            else if (TotalFor30 < cmb30.Items.Count) //we have just increased another cmb
            {
                for (int i = cmb30.Items.Count - 1; i > TotalFor30; i--)
                {                                                  
                    cmb30.Items.RemoveAt(i);                       
                }
            }

            //set items for 60% combo box
            if (TotalFor60 >= cmb60.Items.Count) //we have just decreased another cmb
            {
                for (int i = cmb60.Items.Count; i <= TotalFor60; i++)
                {
                    cmb60.Items.Add(i);
                }
            }
            else if (TotalFor60 < cmb60.Items.Count) //we have just increased another cmb
            {
                for (int i = cmb60.Items.Count - 1; i > TotalFor60; i--)
                {
                    cmb60.Items.RemoveAt(i);
                }
            }

            //set items for 70% combo box
            if (TotalFor70 >= cmb70.Items.Count) //we have just decreased another cmb
            {
                for (int i = cmb70.Items.Count; i <= TotalFor70; i++)
                {
                    cmb70.Items.Add(i);
                }
            }
            else if (TotalFor70 < cmb70.Items.Count) //we have just increased another cmb
            {
                for (int i = cmb70.Items.Count - 1; i > TotalFor70; i--)
                {
                    cmb70.Items.RemoveAt(i);
                }
            }

            //set items for 100% combo box
            if (TotalFor100 >= cmb100.Items.Count) //we have just decreased another cmb
            {
                for (int i = cmb100.Items.Count; i <= TotalFor100; i++)
                {
                    cmb100.Items.Add(i);
                }
            }
            else if (TotalFor100 < cmb100.Items.Count) //we have just increased another cmb
            {
                for (int i = cmb100.Items.Count - 1; i > TotalFor100; i--)
                {
                    cmb100.Items.RemoveAt(i);
                }
            }
        }

        private int nCr(int n, int r)
        {
            //works out how many unique combinations of r objects exist within a group of n size
            int answer = 0;
            answer = Factorial(n) / (Factorial(r) * Factorial(n - r));
            return answer;
        }
        private int Factorial(int number)
        {
            // solves for number!
            int answer = 1;
            for (int i = number; i>0; i--)
            {
                answer = answer * i;
            }
            return answer;
        }

        private void cmb10_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCombos();
        }

        private void cmb30_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCombos();
        }

        private void cmb60_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCombos();
        }

        private void cmb70_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCombos();
        }

        private void cmb100_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCombos();
        }
        
        private Double[] Binomial(int trials, double probability, int bonus)
        {
            //returns an array containing the probability distribution of a binomial function
            //trials is how many times you are doing the thing
            //probability (0-1) is how likely the thing is to do what you want it to
            double Combinations;
            double SuccessFactor;
            double FailureFactor;
            int maxbonus = trials * bonus;
            Double[] answer;
            if (trials > 0)
            {
                answer = new Double[maxbonus + 2];//+2 instead of +1 to shift everything right by 1. the [0] index of these arrays contains boom chance which is always 0 for regular scrolls. Dark scrolls don't use this function.
            }
            else
            {//this if statement needs to exist so that if you don't have any of a certain scroll, the foreach loop still runs. It may be removed if I change how that works. 
                answer = new double[2];
                answer[0] = 0;
                answer[1] = 1;
            }
            answer[0] = 0;//[0] contains boom chance which is always 0% for regular scrolls.
            for (int successes = 0; successes <= trials; successes++)
            {
                //gives the probability of having exactly 1, 2, 3 etc. successes. Puts it into that part of the array 
                //eg: probabilty of having exactly 3 successes will go into answer[3]
                Combinations = nCr(trials, successes);
                SuccessFactor = Math.Pow(probability, successes);
                FailureFactor = Math.Pow((1 - probability), (trials - successes));
                answer[(successes * bonus) + 1] = (Combinations * SuccessFactor * FailureFactor);//this could have all been done on one line, but I think it's clearer being split                                                
            }//successes +1 to shift it to the right again. [0] contains boom chance, which is 0 for all scrolls that are binomial.

            return answer;
        }

        private Double[] Multinomial(int trials, double probability, int bonus)
        {
            //Binomial probability distibution will work fine for regular scrolls because there are only two outcomes for each scroll: pass or fail.
            //For dark scrolls, we need more complicated code to work out the probabilities.
            double BoomChance = (1 - probability) / 2;
            double ZeroChance = (1 - probability) / 2; //I know these are the same probabilities, but I have two variables to make the code a bit more readable
            int maxbonus = bonus * trials;
            Double[] answer;

            if (trials > 0)
            {
                answer = new Double[maxbonus + 2];
            }
            else
            {
                answer = new double[2];
                answer[0] = 0;
                answer[1] = 1;
                return answer;
            }
            answer[0] = 1 - Math.Pow(probability + ZeroChance, trials);//probability that at least one scroll will boom is 1 - the probability that all of them don't.
            answer[1] = Math.Pow(ZeroChance, trials);//probability of getting 0 is the chance that all scrolls fail but don't boom.
            for (int successes = 1; successes <= trials; successes++)// general formula for everything else
            {
                answer[(successes * bonus) + 1] = nCr(trials, successes) * (Math.Pow(probability, successes) * Math.Pow(ZeroChance, trials - successes));
            }
            
            
            return answer;
        }
        private double ThreeSigFigs(double input)
        {
            //Rounds a number to 3 significant figures
            //Don't ask me how it works. I stole it from stackoverflow and I haven't even attempted to understand it. 
            if (input == 0)
            {
                return 0;
            }
            double output = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(input))) + 1);
            output = output * Math.Round(input / output, 3);
            return output;

            

        }

        private int DecimalToInt32 (decimal input)
        {
            if(Int32.TryParse(input.ToString(), out int output))
            {
                return output;
            }
            else
            {
                MessageBox.Show("One of your inputs contains a decimal, or otherwise couldn't be parsed as an int. Please check it your inputs.");
                return 0;
            }
        }

        private Double[] CombineProbabilities(Double[] ScrollArray, Double[] ScrollArray2, int size)
        {
            //I expect there may be some elegant mathematical way to do this, but looking online I couldn't find anything and I couldn't work anything out myself like I could for the multinomial function I made.
            //Frankly, we live in the modern world where brute force and ignorance is the true way to code, so I don't feel bad for it. 
            Double[] finalDistribution = new Double[size + 2];
            for (int index = 0; index < finalDistribution.Length; index++)
            {
                finalDistribution[index] = 0;//write 0 to each value in the final array to initialise it. 
            }
            //first we work out the probability of booming.
            //this is worked out by multiplying the probability of one scroll set booming by the probability of the other not booming for both scroll arrays and adding the results together. Then you add the chance that both scrolls boom
            double totalBoomChance = 
                ScrollArray[0] * (1 - ScrollArray2[0]) //first one booms, second doesn't
                + ScrollArray2[0] * (1 - ScrollArray[0]) //first one doesn't boom, second does
                + ScrollArray[0] * ScrollArray2[0]; //both boom

            finalDistribution[0] = totalBoomChance;
            

            //now comes the complicated bit... relatively speaking. We need to go through every combination of the two scroll sets, multiply the probabilities together and then work out what the total bonus would be. We then add that value into the final array
            for (int index = 1; index <= ScrollArray.Length - 1; index++)
            {
                for (int index2 = 1; index2 <= ScrollArray2.Length -1 ; index2++)
                {
                    if (ScrollArray[index] * ScrollArray2[index2] != 0)//bit of a hack. Don't worry about it. 
                    {
                        finalDistribution[index + index2 - 1] = finalDistribution[index + index2 - 1] + ScrollArray[index] * ScrollArray2[index2];
                    }
                }
            }
            double test = 0;
            foreach (double thing in finalDistribution)
            {
                test = test + thing;
            }
  //          MessageBox.Show(test.ToString());
            return finalDistribution;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int MaxStatGain;
            

            //For whatever reason, you can't force the control I used to only accept ints and it's just easier to convert them all
            //at the start and work with the converted values. If this function fails to parse them as an int, it returns 0
            int stat10value = DecimalToInt32(stat10.Value);
            int stat30value = DecimalToInt32(stat30.Value);
            int stat60value = DecimalToInt32(stat60.Value);
            int stat70value = DecimalToInt32(stat70.Value);
            int stat100value = DecimalToInt32(stat100.Value);


            int IndexTracker10 = 0;//foreach loops are so much easier than dealing with indexes, but I need to know what the index is at any given time. 
            int IndexTracker30 = 0;
            int IndexTracker60 = 0;
            int IndexTracker70 = 0;
            int IndexTracker100 = 0;
            
            Double[] finalDistribution;

            Double[] ArrFor10 = Binomial(cmb10.SelectedIndex,0.1,stat10value);
            Double[] ArrFor30 = Multinomial(cmb30.SelectedIndex, 0.3,stat30value);
            Double[] ArrFor60 = Binomial(cmb60.SelectedIndex, 0.6,stat60value);
            Double[] ArrFor70 = Multinomial(cmb70.SelectedIndex, 0.7,stat70value);
            Double[] ArrFor100 = Binomial(cmb100.SelectedIndex, 1,stat100value);

            MaxStatGain = (cmb10.SelectedIndex * stat10value) 
                + (cmb30.SelectedIndex * stat30value)
                + (cmb60.SelectedIndex * stat60value)
                + (cmb70.SelectedIndex * stat70value)
                + (cmb100.SelectedIndex * stat100value);//I appreciate the brackets are not necessary, but it would be more effort to take them out than write this comment.
            
            //each array has the probability distribution for its respective scroll. We still need to combine these probabilities for the final table.
            //I expect there is a cleaner, formulaic way to do this, similar to the binomial formula I used for the binomial distributions. However,
            //I couldn't work out how to do it and the math went a little over my head. I might try again if people complain about performance issues 
            //while I've got it done this way. 
            
            finalDistribution = new Double[MaxStatGain + 2];//created the array for the final distribution table.
                                                            // first we will combine the arrays for the 30% and 70% scrolls into the finalDistribution array, but only if they are both being used. 
                                                            // we check if they are being used by making sure that both have a non-zero probability of booming

            finalDistribution = CombineProbabilities(ArrFor10, ArrFor30, MaxStatGain);
            finalDistribution = CombineProbabilities(ArrFor60, finalDistribution, MaxStatGain);
            finalDistribution = CombineProbabilities(ArrFor70, finalDistribution, MaxStatGain);
            finalDistribution = CombineProbabilities(ArrFor100, finalDistribution, MaxStatGain);
            
            //round numbers so they are more presentable. 3 significant figures should suffice.

            for (int index = 0; index < finalDistribution.Length; index++)
            {
                finalDistribution[index] = ThreeSigFigs(finalDistribution[index]);
            }
            tblOutputTable.Columns.Clear();
            tblOutputTable.Rows.Clear();
            tblOutputTable.Columns.Add("Outcome","Outcome");
            tblOutputTable.Columns.Add("Value", "Probability");
            
            for (int index = 0; index < finalDistribution.Length; index++)
            {
                if (finalDistribution[index] != 0)
                {
                    if (index == 0)
                    {
                        tblOutputTable.Rows.Add(new object[] { "Boom", (finalDistribution[index] * 100).ToString() + "%" });
                    }
                    else
                    {
                        tblOutputTable.Rows.Add(new object[] { "+" + (index - 1).ToString(), (finalDistribution[index] * 100).ToString() + "%" });
                    }
                }
            }

           
        }

        private void btn532_Click(object sender, EventArgs e)
        {
            stat10.Value = 5;
            stat30.Value = 5;
            stat60.Value = 2;
            stat70.Value = 2;
            stat100.Value = 1;

        }

        private void btn321_Click(object sender, EventArgs e)
        {
            stat10.Value = 3;
            stat30.Value = 3;
            stat60.Value = 2;
            stat70.Value = 2;
            stat100.Value = 1;
        }

        private void btn210_Click(object sender, EventArgs e)
        {
            stat10.Value = 2;
            stat30.Value = 2;
            stat60.Value = 1;
            stat70.Value = 1;
            stat100.Value = 0;
        }
    }
}
