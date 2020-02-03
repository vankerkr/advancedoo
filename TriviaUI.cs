using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StartofTriviaGame
{
    internal class TriviaUI
    {
        private QuestionBank Questions = new QuestionBank();
        int correct = 0;
        int incorrect = 0;
        bool cont;

        private void DisplayWelcome()
        {
            System.Console.WriteLine("Welcome, answer most of the questions correct and you can keep playing.");
        }

        public void Play() //MainMethod.
        {
            string error = "";
            bool success = false;
            string currentGuess;
            cont = true;
            DisplayWelcome();
            success = Questions.ReadQuestionFile("Questions.txt", ref error);
            if (success == false)
                Console.WriteLine(error);
            else
            {
                while (cont) {
                    correct = 0;
                    incorrect = 0;
                    //Loop through Bank....
                    //display one question at a time.
                    for (int i = 0; i < Questions.GetNumberofQuestions; i++)
                    {
                    
                        //Display possible Answers.- Parse answers.
                        Console.WriteLine(Questions.outputQuestion(i));

                        //PromptforGuess
                        currentGuess = PromptforGuess();
                        currentGuess = currentGuess.ToUpper();

                        //Compare the guess
                        //accumulate correct and incorrect
                        //displayfeedback.
                        if (currentGuess.Equals(Questions.GETCorrectAnswer(i)))
                        {
                            Console.WriteLine("Correct Answer!");
                            correct++;

                            Console.WriteLine("Correct Answers: " + correct);
                            Console.WriteLine("Incorrect Answers: " + incorrect);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer!");
                            incorrect++;
                            Console.WriteLine("The correct answer was: " + Questions.GETCorrectAnswer(i));
                            Console.WriteLine(Questions.GETExplanation(i));

                            Console.WriteLine("Correct Answers: " + correct);
                            Console.WriteLine("Incorrect Answers: " + incorrect);

                        }


                    }
                    continueGame();

                }
                //Console.WriteLine(Questions.DisplayContextQuestionBank()); //testing
            }
            System.Console.ReadLine();
        }

        private string PromptforGuess()
        {
            string guess;

            System.Console.WriteLine("Select A - D");
            guess = System.Console.ReadLine();
            if (guess != null)
                guess = guess.Substring(0).ToUpper();

            return guess;
        }

        public void continueGame()
        {
            if (incorrect > correct)
            {
                Console.WriteLine("\nSorry you lost! Better Luck next time");
                Console.Read();

                cont = false;
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("\nYou won, Play Again? ");
                if (System.Console.ReadLine().ToUpper().Equals("Y")){

                    cont = true;
                }   else
                {
                    cont = false;
                    System.Environment.Exit(1);
                }
            }
        }
    }
}