using System;
using Answer;
using QNA;

namespace QNA
{

    class Question<T>
    {

        public string getQuestion()
        {
            Random r = new();
            List<string> questions = new();
            questions.Add("When Is Your Birthday");
            questions.Add("Favorite Color");
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
            answer.Add("Green | Blue");

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
            Question<string> q = new();
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
            
            if (q.getQuestion().StartsWith("Favorite") && answer.Equals(answers.getQuestion()[2])) {

                Console.WriteLine("Correct");

            }


            Console.ReadLine();         


        }
    }
};