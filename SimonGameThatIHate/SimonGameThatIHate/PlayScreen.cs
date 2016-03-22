using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace SimonGameThatIHate
{
    public partial class PlayScreen : UserControl
    {
        #region Variables
        //List
        List<int> computersList = new List<int>();
        List<int> playersList = new List<int>();

        //Arrays
        SoundPlayer[] buzzerSound;
        Button[] theButtons = new Button[4];
        Color[] buttonNorm = new Color[4];
        Color[] buttonHighlight = new Color[4];

        //Random numbers
        Random randomNumberGen = new Random();

        //Int
        public static int level = 0; //Used to show highscore
        int patternNumber = 2;
        int colour;
        bool playerTurn = false;

        ////Sounds
        //SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        //SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        //SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        //SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);

        #endregion

        public PlayScreen()
        {
            InitializeComponent();

            // For Soundplayer[] buzzerSound;

            //For the buttons itself
            theButtons[0] = blueButton;
            theButtons[1] = greenButton;
            theButtons[2] = redButton;
            theButtons[3] = yellowButton;

            //For Color[] buttonNorm;
            buttonNorm[0] = Color.CornflowerBlue; //Blue
            buttonNorm[1] = Color.PaleGreen;      //Green
            buttonNorm[2] = Color.LightCoral;     //Red
            buttonNorm[3] = Color.Khaki;          //Yellow

            //For Color[] buttonHighlight;
            buttonHighlight[0] = Color.Blue;
            buttonHighlight[1] = Color.Green;
            buttonHighlight[2] = Color.Red;
            buttonHighlight[3] = Color.Yellow;

        }

        private void playScreen_Load(object sender, EventArgs e)    
        {
            //Resetting variables
            computersList.Clear();
            playersList.Clear();
            level = 0;
            Refresh();
            Thread.Sleep(500);

            //Start the computer's turn
            computerTurn();
        }

        public void computerTurn()
        {
            computersList.Clear();
            playersList.Clear();
            Thread.Sleep(500);
            //Reset buttons to normal
            for (int i = 0; i < theButtons.Count(); i++)
            {
                theButtons[i].Refresh();
            }
            //Making it harder 
            patternNumber += 1;

            //Creating the comuter's pattern
            for (int i = 0; i < patternNumber; i++)
            {
                colour = randomNumberGen.Next(0, 4);  //creating that random number
                computersList.Add(colour);           //Adds whatever the colour number is and dumps it into the list
                switch (computersList[i])  //The buttons with the random numbers
                {
                    //Highlights the blue button
                    case 3:
                        theButtons[3].BackColor = buttonHighlight[3]; 
                        blueButton.Refresh();
                        Thread.Sleep(500);
                        break;

                    //Highlights the green button
                    case 2:
                        theButtons[2].BackColor = buttonHighlight[2];
                        greenButton.Refresh();
                        Thread.Sleep(500);
                        break;

                    //Highlights the red button
                    case 1:
                        theButtons[3].BackColor = buttonHighlight[3];
                        redButton.Refresh();
                        Thread.Sleep(500);
                        break;

                    //Highlight the yellow button
                    case 0:
                        theButtons[4].BackColor = buttonHighlight[4];
                        yellowButton.Refresh();
                        Thread.Sleep(500);
                        break;

                    default:
                        break;     
                }
                //Making the buttons go to normal
                for (int x = 0; x <= 3; x++) 
                {
                    theButtons[x].BackColor = buttonNorm[x];
                    theButtons[x].Refresh();
                }
                Thread.Sleep(250);
            }
        }

        void PlayerCheck()
        {
            //Compares computersList to playersList
            for (int x = 0; x < playersList.Count(); x++)
            {
                //Is it a winRar? (Right)
                if (computersList[x] == playersList[x])
                {
                    //Response with the pattern number and a good job
                    messageLabel.Text = Convert.ToString(x + 1) + "/" + Convert.ToString(patternNumber) + "Good Job";
                    messageLabel.Refresh();

                    if (x == patternNumber - 1)
                    {
                        theButtons[playersList[x]].BackColor = buttonNorm[playersList[x]];
                        theButtons[playersList[x]].Refresh();

                        for (int i = 3; i > 0; i--) //count down
                        {
                            messageLabel.Text = "Computer in " + Convert.ToString(i); // Computer in (the count down)
                            messageLabel.Refresh();
                            Thread.Sleep(1000);
                        }
                        playerTurn = false;
                        level++;
                        computerTurn();
                        break;
                    }
                }

                //Not a winRar? (Wrong)
                else
                {
                    for (int i = 0; i < theButtons.Count(); i++)
                    {
                        theButtons[i].Visible = false;
                    }
                    messageLabel.Text += "Get danked";
                    messageLabel.Refresh();
                    Thread.Sleep(1500);

                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                }

                if (playersList.Count > 0)
                {
                    theButtons[playersList[x]].BackColor = buttonNorm[playersList[x]];
                    theButtons[playersList[x]].Refresh();
                }
            }
        }

        void Clicker(int x)
        {
            theButtons[x].BackColor = buttonHighlight[x];
            theButtons[x].Refresh();
            Thread.Sleep(150);
            theButtons[x].BackColor = buttonNorm[x];
            theButtons[x].Refresh();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            Refresh();

            for (int i = 3; i > 0; i--)
            {
                messageLabel.Text = "Computer Turn in " + Convert.ToString(i);
                messageLabel.Refresh();
                Thread.Sleep(1000);
            }
            computerTurn();
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            Clicker(0);
            playersList.Add(0);
            PlayerCheck();
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            Clicker(1);
            playersList.Add(1);
            PlayerCheck();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            Clicker(2);
            playersList.Add(2);
            PlayerCheck();
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            Clicker(3);
            playersList.Add(3);
            PlayerCheck();
        }
    }

}




