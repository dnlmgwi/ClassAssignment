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
    public partial class QuestionOneForm : Form
    {
        public QuestionOneForm()
        {
            InitializeComponent();
        }

        private void QuestionOneForm_Load(object sender, EventArgs e)
        {
            textBoxQuestionOne.Text = "L4DC" + Environment.NewLine + "Daniel Mgawi";
        }
    }
}
