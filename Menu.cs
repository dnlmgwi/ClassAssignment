﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignment
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void questionOneButton_Click(object sender, EventArgs e)
        {
            QuestionOneForm newForm = new QuestionOneForm();

            newForm.ShowDialog();
        }
    }
}
