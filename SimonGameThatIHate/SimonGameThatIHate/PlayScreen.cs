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
        #region List | Arrays | Other

        //List - These can increase
        List<int> computersList = new List<int>();
        List<int> playersList = new List<int>();

        //Arrays - These are fixed
        Button[] theButtons = new Button[4];
        Color[] buttonNorm = new Color[4];
        Color[] buttonHighlight = new Color[4];
        SoundPlayer[] buzzerSound = new SoundPlayer[5];
        SoundPlayer blueSound = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer greenSound = new SoundPlayer(Properties.Resources.green);
        SoundPlayer redSound = new SoundPlayer(Properties.Resources.red);
        SoundPlayer yellowSound = new SoundPlayer(Properties.Resources.yellow);

        //Random numbers
        Random randNum = new Random();

        #endregion
        public PlayScreen()
        {
            InitializeComponent();
            #region Array - Button, Colour Norm, Colour Highlight
            //Buttons
            theButtons[0] = blueButton;
            theButtons[1] = greenButton;
            theButtons[2] = redButton;
            theButtons[3] = yellowButton;

            //Colours NOT clicked
            buttonNorm[0] = Color.CornflowerBlue; //Blue
            buttonNorm[1] = Color.PaleGreen;      //Green
            buttonNorm[2] = Color.LightCoral;     //Red
            buttonNorm[3] = Color.Khaki;          //Yellow

            //Colours WHEN clicked
            buttonHighlight[0] = Color.Blue;
            buttonHighlight[1] = Color.Green;
            buttonHighlight[2] = Color.Red;
            buttonHighlight[3] = Color.Yellow;
            #endregion
        }
        private void playScreen_Load(object sender, EventArgs e)
        {
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(1000);
            computerTurn();
        }
        #region Buttons
        private void yellowButton_Click(object sender, EventArgs e)
        {

        }

        private void greenButton_Click(object sender, EventArgs e)
        {

        }

        private void redButton_Click(object sender, EventArgs e)
        {

        }

        private void blueButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public void computerTurn()
        {
            //create new random pattern
            for (int i = 0; i<Form1.pattern.Count(); i++)
            {
                computersList.Add(randNum.Next(0, 4));
            }

            //highlight each button in the pattern 
            for (int x = 0; x<computersList.Count(); x++)
            {
                switch(computersList[x])
                {
                    case 1:
                        messageLabel.Text = "1";
                        break;

                    case 2:
                        messageLabel.Text = "2";
                        break;

                    case 3:
                        messageLabel.Text = "3";
                        break;

                    case 4:
                        messageLabel.Text = "4";
                        break;

                    default:
                        break;
                }

            }

        }
    }
}