using System;
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

        private void questionTwoButton_Click(object sender, EventArgs e)
        {
            QuestionTwoForm newForm = new QuestionTwoForm();

            newForm.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            QuestionThreeForm newForm = new QuestionThreeForm();

            newForm.ShowDialog();
        }

        private void questionFourButton_Click(object sender, EventArgs e)
        {
            QuestionFourForm newForm = new QuestionFourForm();

            newForm.ShowDialog();
        }
    }
}
