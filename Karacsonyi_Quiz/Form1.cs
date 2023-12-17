using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Karacsonyi_Quiz
{
  public partial class Form1 : Form
  {
    // Quiz game variables 
    private readonly QuestionObject[] _questions;
    private readonly int _totalQuestion;

    private int _actualQuestionIndex = 0;
    private int _score;

    private int _correctAnswer;

    public Form1()
    {
      string filePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "questions.json");

      string jsonString = File.ReadAllText(filePath);
      _questions = JsonConvert.DeserializeObject<QuestionObject[]>(jsonString);
      _totalQuestion = _questions.Length;

      InitializeComponent();
      NextQuestion();
    }

    private void checkAnswerEvent(object sender, EventArgs e)
    {
      var senderObject = (Button)sender;
      var buttonAnwserTag = Convert.ToInt32(senderObject.Tag);
      if (buttonAnwserTag == _correctAnswer)
      {
        _score++;
      }

      if (_actualQuestionIndex == _totalQuestion)
      {
        End();
        return;
      }

      NextQuestion();
    }


    private void NextQuestion()
    {
      _actualQuestionIndex++;
      var question = _questions[_actualQuestionIndex - 1];

      lblQuestions.Text = $"{_actualQuestionIndex}. {question.Question}";
      button1.Text = question.Answers[0];
      button2.Text = question.Answers[1];
      button3.Text = question.Answers[2];
      button4.Text = question.Answers[3];
      _correctAnswer = question.CorrectAnswer;
    }

    private void End()
    {
      var percentage = (int)Math.Round((double)(_score * 100) / _totalQuestion);
      panel1.Visible = true;

      label2.Text = $"{_score} Helyes választ adtatok.\n" +
        $"{percentage} %-ra sikerült megoldani a feladatot.\n" +
        $"{_totalQuestion} / {_score} Lett a pontszámotok.";
    }
  }
}
