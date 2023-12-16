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
        int totalQuestion = 10;
        
        
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



                //MessageBox.Show(
                //    "A Quiz végéhez értünk!" + Environment.NewLine +
                //    "A helyes válaszaitok:" + score + Environment.NewLine +
                //    "Ez " + percentage + "% értetek el" + Environment.NewLine +

                //    score

                //    ,"Eredmény");

                



                //Application.Exit();
                panel1.Visible = true;
                label2.Text = score.ToString()+ " Helyes választ adtatok." 
                   +"\n" + percentage + "% ra sikerült megoldani a feladatot." 
                   + "\n" + totalQuestion + "/" + score + " Lett a pontszámotok.";

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

                    lblQuestions.Text = "1.Melyik este jön a Jézuska?";

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

                    lblQuestions.Text = "3.Ki lopta el egyszer a Karácsonyt?";

                    button1.Text = "Az ördög";
                    button2.Text = "A Krampusz";
                    button3.Text = "Egy gonosz manó";
                    button4.Text = "A Grincs";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "4. Hány rénszarvas húzza a télapó szánját Rudolfal együtt";

                    button1.Text = "5";
                    button2.Text = "6";
                    button3.Text = "9";
                    button4.Text = "10";

                    correctAnswer = 3;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "5.Melyik városhoz kötődik a karácsony ünnepe ";

                    button1.Text = "Názáret";
                    button2.Text = "Palesztína";
                    button3.Text = "Jeruzsálem";
                    button4.Text = "Betlehem";

                    correctAnswer = 4;

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "6.A felsoroltak közül melyik ajándékot NEM vitték a napkeleti bölcsek az újszülött Jézusnak?";

                    button1.Text = "arany";
                    button2.Text = "tömjén";
                    button3.Text = "mirha";
                    button4.Text = "ezüst";

                    correctAnswer = 4;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "7.Melyik név nem tartozik Mikulás szarvasaihoz?";

                    button1.Text = "Táltos";
                    button2.Text = "Aggancs";
                    button3.Text = "Táncos";
                    button4.Text = "Üstökös";

                    correctAnswer = 2;

                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "8.Melyik vállalat tette népszerűvé a Mikulást Amerikában?";

                    button1.Text = "CoCa-Cola";
                    button2.Text = "Pepsi";
                    button3.Text = "Dr Pepper";
                    button4.Text = "Prime";

                    correctAnswer = 1;

                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "9.Hány szellem van a Karácsonyi énekben?";

                    button1.Text = "12";
                    button2.Text = "8";
                    button3.Text = "4";
                    button4.Text = "14";

                    correctAnswer = 3;

                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._3HWIAZ;

                    lblQuestions.Text = "10.Karácsony másodnapja melyik szentnek a napja?";

                    button1.Text = "Szent Istán";
                    button2.Text = "Szent Dominik";
                    button3.Text = "Szent Mária";
                    button4.Text = "Szent László";

                    correctAnswer = 1;

                    break;
            }




        }
    }
}
