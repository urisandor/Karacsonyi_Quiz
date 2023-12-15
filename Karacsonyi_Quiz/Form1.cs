using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karacsonyi_Quiz
{
    public partial class Form1 : Form
    {
        //quiz game variables 


        int correctAnswer;
        int QuestionNumber = 1;
        int score;
        int percentage;
        int totalQuestion = 4;
        
        
        public Form1()
        {
            InitializeComponent();

            askQuestion(QuestionNumber);
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int ButtonTag = Convert.ToInt32(senderObject.Tag);

            if (ButtonTag == correctAnswer)
            {
                score++;
            }

            if (QuestionNumber == totalQuestion)
            {
                //work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestion);



                MessageBox.Show(
                    "A Quiz végéhez értünk!" + Environment.NewLine +
                    "A helyes válaszaitok:" + score + Environment.NewLine +
                    "Ez " + percentage + "% értetek el" + Environment.NewLine +

                    score

                    );
                Application.Exit();



            }

            QuestionNumber++;
            askQuestion(QuestionNumber);


        }

        private void askQuestion(int qnum) 
        {
            switch(qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "Melyik este jon a Jezuska?";

                    button1.Text = "December 25.";
                    button2.Text = "December 24.";
                    button3.Text = "December 26.";
                    button4.Text = "December 27.";

                    correctAnswer = 2;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "2.Mennyi adventi gyertyát kell meggyújtani az ünnep alatt?";

                    button1.Text = "3";
                    button2.Text = "4";
                    button3.Text = "7";
                    button4.Text = "9";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "3.Ki lopta el egyszer a Karacsonyt?";

                    button1.Text = "Az ordog";
                    button2.Text = "A Krampusz";
                    button3.Text = "Egy gonosz mano";
                    button4.Text = "A Grincs";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "4. Hany renszarvas huzza a telapo szanjat Rudolfal egyutt";

                    button1.Text = "5";
                    button2.Text = "6";
                    button3.Text = "9";
                    button4.Text = "10";

                    correctAnswer = 3;

                    break;
            }




        }
    }
}
