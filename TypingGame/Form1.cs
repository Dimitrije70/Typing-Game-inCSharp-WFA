using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingGame
{
    public partial class Form1 : Form
    {
        string[] words = { "internet", "programming", "dimi", "coding", "sky", "banana" };

        Random rnd = new Random();

        int correct = 0;
        int incorrect = 0;

        public Form1()
        {
            InitializeComponent();

            lblWord.Text = words[rnd.Next(0, words.Length)];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == lblWord.Text)
                {
                    correct++;
                    lblWord.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                else
                {
                    incorrect++;
                    lblWord.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                lblRight.Text = "Correct: " + correct;
                lblWrong.Text = "Incorrect: " + incorrect;
            }
        }
    }
}
