﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form3 : Form
    {
        public Form3(Gra gra)
        {
            InitializeComponent();
            historia.DataSource = gra.getRuchy();
        }
    }
}
