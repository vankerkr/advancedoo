using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace StartofTriviaGame

{
    internal class QuestionBank
    {
        private const int NUM_ANSWERS = 4;
        const int NUM_QUESTIONS = 5;
        private string output;

        QuestionUnit[] m_Questions = new QuestionUnit[NUM_QUESTIONS];

        //private List<QuestionUnit> m_Questions = new List<QuestionUnit>();

        public int GetNumberofQuestions
        {
             get { return NUM_QUESTIONS; }
            //get { return m_Questions.Count; } //List
        }

        public int GetNumberofAnswers
        {
            get { return NUM_ANSWERS; }
        }

        public string GETQuestion(int index)
        {
            return m_Questions[index].Question;
        }

        public string GETAnswer(int index) //string answers (4)
        {
            return m_Questions[index].Answer;
        }

        public string GETCorrectAnswer(int index) //get letter hold correct answer
        {
            return m_Questions[index].CorrectAnswer;
        }

        public string GETExplanation(int index) //get letter hold correct answer
        {
            return m_Questions[index].Explanation;
        }

        //Read Question File - commented out is for an array.
        public bool ReadQuestionFile(string path, ref string error)
        {
            int questionCounter = 0;
            string text = null;
            FileInfo theSourceFile = new FileInfo(path);
            //File theSourceFile = new File();
            bool success = true;

            QuestionUnit aQuestion;
            try
            {
                //StreamReader reader = theSourceFile.OpenText();
                StreamReader reader = new StreamReader(path);

                text = reader.ReadLine();
                while (text != null)
                {
                    //create instance.
                    m_Questions[questionCounter] = new QuestionUnit();
                    //aQuestion = new QuestionUnit();

                    //Fill it
                    //aQuestion.Question = text;
                    m_Questions[questionCounter].Question = text;
                    //aQuestion.Answer = reader.ReadLine();
                    m_Questions[questionCounter].Answer = reader.ReadLine();
                    //read Correct Answer
                    //aQuestion.CorrectAnswer = reader.ReadLine();
                    m_Questions[questionCounter].CorrectAnswer = reader.ReadLine();
                    //read Explanation
                    //aQuestion.Explanation = reader.ReadLine();
                    m_Questions[questionCounter].Explanation = reader.ReadLine();

                    //add to Bank
                    //m_Questions.Add(aQuestion);

                    text = reader.ReadLine();  //next question..
                    questionCounter = questionCounter + 1;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception caught and handled");
                error = ex.Message + "QuestionBank.cs ReadQuestionFile()";
                success = false;
            }

            return success;
        }

        public string DisplayContextQuestionBank() //testing
        {
            string output = null;

            for (int i = 0; i < m_Questions.Length; i++)
            {
                output = output + m_Questions[i].Question + "\n";
                output = output + m_Questions[i].Answer + "\n";
                output = output + m_Questions[i].CorrectAnswer + "\n";
                output = output + m_Questions[i].Explanation + "\n";
            }
            return output;
        }

        public string outputQuestion(int index)
        {
            string[] singleAnswers = m_Questions[index].Answer.Split(',');

            output = "\nQuestion: " + m_Questions[index].Question;
            output += "\nA: " + singleAnswers[0];
            output += "\nB: " + singleAnswers[1];
            output += "\nC: " + singleAnswers[2];
            output += "\nD: " + singleAnswers[3];

            return output;
        }
    }
}