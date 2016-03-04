using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultipleScreens_Feb_11_2016
{
    public partial class GameScreen : UserControl
    {
        //Lists
        List<int> playerPattern = new List<int>();
        List<int> computerPattern = new List<int>();

        //Random Number generator
        Random numbGen = new Random(0 - 4);

        //Regular int for each level.
        int patternLevel = 0; // for the comuter to start off with level
       
        //Arrays
        Button[] buttons = new Button[4]; 
        
        public GameScreen()
        {
            InitializeComponent();
            //Components of the button
            buttons[0] = redButton;
            buttons[1] = blueButton;
            buttons[2] = greenButton;
            buttons[3] = pinkButton;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //clear pattern list (stored in the global form1). FRESH when new
            Form1.patternList.Clear();
            Refresh();
            Thread.Sleep(1000);
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            patternLevel++;
            for(int i = 0; i < patternLevel; i++)
            {
                Form1.patternList.Add(numbGen.Next(0,4));  //picking a number between 0-1-2-3

                switch (Form1.patternList[i])
                {
                    case 0:
                        buttons[0].BackColor = Color.White; //red
                        Refresh();
                        Thread.Sleep(100);
                        buttons[0].BackColor = Color.Red;
                        break;

                    case 1:
                        buttons[1].BackColor = Color.White; //blue
                        Refresh();
                        Thread.Sleep(100);
                        buttons[1].BackColor = Color.Blue;
                        break;

                    case 2:
                        buttons[2].BackColor = Color.White;  //green
                        Refresh();
                        Thread.Sleep(100);
                        buttons[2].BackColor = Color.Green;
                        break;

                    case 3:
                        buttons[3].BackColor = Color.White; //pink
                        Refresh();
                        Thread.Sleep(100);
                        buttons[3].BackColor = Color.Pink; 
                        break;

                    default:
                        break;
                //make an array for the backcolor 
                }
            }

            PlayerTurn();
        }
        private void PlayerTurn()
        {
            for (int x = 0; x < playerPattern.Count(); x++) ;
            {
                //If the player gets it right
                if (computerPattern[x] == playerPattern[x]) ;


        }
    }
}
