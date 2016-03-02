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
            //Load event method
            //clear pattern list (stored in the global form1). FRESH when new
            //Refresh to show screen
            //Pause the program a bit
            //Then Starts the custom method "Computer Turn"
        }

        //custom metheod ComputerTurn
    }
}
