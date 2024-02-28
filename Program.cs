using System;

namespace Quizbee
{
    class Quizzbee
    {
        static void Main(string[] args)
        {

            Question[] questions = new Question[]
            {
                new Question("Who is the First President of the Philippines", new string[] { "a) Emilio Aguinaldo", "b) Apolinario Mabini", "c) Manuel Roxas" }, "a"),
                new Question("\nWho is the National Philippine Hero", new string[] { "a) Manny Paquiao", "b) Muhammad Ali", "c) Jose Rizal" }, "c"),
                new Question("\nWho is the first Female leader of Philippines Revolution.", new string[] { "a) Jinkee Paquiao", "b) Gabriela Silang", "c) MAMA ko " }, "b"),
                new Question("\nYoungest General of The Philippines", new string[] { "a) Gregorio Del. Pilar", "b) Manuel Tinio", "c) Emilio Aguinaldo" }, "b"),
                new Question("\nWho is the Spanish that Discovered Philippines", new string[] { "a) Lapu-Lapu", "b) King Philip II", "c) Ferdinand Magelan" }, "c")
            };

            Console.WriteLine("Welcome to QuizBee");
            Console.WriteLine("Let's Talk About Philippine History\n");
            Console.WriteLine("Blank Answer Means Wrong!");


            int countCorrectAnswers = 0;
            foreach (var question in questions)
            {
                Console.WriteLine(question.QuesDesc);
                foreach (var option in question.Options)
                {
                    Console.WriteLine(option);
                }
                Console.Write("Answer: ");
                string choice = Console.ReadLine().ToLower();

                if (choice == question.AnswerOption)
                {
                    Console.WriteLine("Correct Answer!!!");
                    countCorrectAnswers++;
                }
                else
                {
                    Console.WriteLine("Wrong Answer!!!");
                }
            }


            Console.WriteLine($"\nYou scored: {countCorrectAnswers} out of {questions.Length}");
        }
    }

    public class Question
    {
        public string QuesDesc { get; }
        public string[] Options { get; }
        public string AnswerOption { get; }

        public Question(string quesDesc, string[] options, string answerOption)
        {
            QuesDesc = quesDesc;
            Options = options;
            AnswerOption = answerOption;
        }
    }
}