﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGameForReal
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
            Form f = this.FindForm();
            f.Controls.Remove(this);
        }
    }
}
