using System;
using Answer;

namespace Question
{

    class Question<T>
    {

        public string getQuestion()
        {
            Random r = new();
            List<string> questions = new();
            questions.Add("When Is Your Birthday");
            questions.Add("Name");
            int index = r.Next(questions.Count);

            return questions[index];

        }

    }


}

namespace Answer
{

    class Answer<T>
    {

        public List<string> getQuestion()
        {
            List<string> answer = new();

            answer.Add("11/17/1999");

            answer.Add("Ryan G");

            return answer;

        }


    }
}


namespace LGenerics
{
    public class App
    {
        public static void Main(string[] _)
        {
            Question.Question<string> q = new();
            Console.WriteLine(q.getQuestion());

            Answer<string> answers = new();
           

            string? answer = Console.ReadLine();

            if (answer == null) return;

            if (q.getQuestion().Contains("When") && answer.Equals(answers.getQuestion()[0]))
            {
                Console.WriteLine("Correct");
            }

            if (q.getQuestion().StartsWith("Name") && answer.Equals(answers.getQuestion()[1]))
            {
                Console.WriteLine("Correct");
            }


            Console.ReadKey();           
               

        }
    }
};