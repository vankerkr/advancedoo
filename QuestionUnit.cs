//*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*
//# Student's Name:              #
//* Course Name:         ITDEV-115-200                  *
//# Instructor's Name:   Judy Ligocki                   #
//* Assignment:          Assignment #5 File IO          *
//# Date:                4/7/2011                       #
//*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*#*

namespace StartofTriviaGame
{
    internal class QuestionUnit
    {
        private string m_Question;
        private string m_Answers;  //array.
        private string m_CorrectAnswer;
        private string m_Explanation;
        

        public string Question
        {
            get
            {
                return m_Question;
            }

            set
            {
                m_Question = value;
            }
        }

        public string Answer
        {
            get
            {
                return m_Answers;
            }

            set
            {
                m_Answers = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return m_CorrectAnswer;
            }

            set
            {
                m_CorrectAnswer = value;
            }
        }

        public string Explanation
        {
            get
            {
                return m_Explanation;
            }

            set
            {
                m_Explanation = value;
            }
        }

        
    }
}