﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGameThatIHate
{
    public partial class Form1 : Form
    {
        #region Publics
        public static List<int> pattern = new List<int>();
        public static int score;
        #endregion

        public Form1()
        {
            InitializeComponent();
            //Create an instance of the Mainscreen
            MainScreen ms = new MainScreen();

            //Adding the user control to the form
            this.Controls.Add(ms);

        }
    }
}
