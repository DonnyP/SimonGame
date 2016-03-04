using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens_Feb_11_2016
{
    public partial class Form1 : Form
    {
       public static string name = "Hello Donny!";  // on the playScreen.cs
       public static List<int> patternList = new List<int>();
       public static List<int> playerList = new List<int>();
        
    
        public Form1()
        {
            InitializeComponent();
            MainScreen ms = new MainScreen();
            ms.Location = new Point((Screen.PrimaryScreen.Bounds.Width - ms.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - ms.Height) / 2);
            this.Controls.Add(ms);
        }
    }
}
