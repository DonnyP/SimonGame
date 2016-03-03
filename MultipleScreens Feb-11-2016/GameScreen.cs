using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens_Feb_11_2016
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //clear pattern list (stored in the global form1). FRESH when new
            Form1.patternList.Clear();
            Refresh();
        }

        private void ComputerTurn()
        {
            Random computerGuesses = new Random(0-4);
        }
    }
}
