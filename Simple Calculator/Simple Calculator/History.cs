﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        public void historyData(string data)
        {
            historyScreen.Text += data;
        }
    }
}