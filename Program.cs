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
            List<string> questions = [];
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
            List<string> answer = [];

            answer.Add("11/17/1999");

            answer.Add("Ryan G");
            answer.Add("Green | Blue");

            return answer;

        }


        public  delegate void CorrectAnswer(string message);

        public static CorrectAnswer d = (string message) => Console.WriteLine(message);


        
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
            Answer<string> an = new Answer<string>();   
        

            string? answer = Console.ReadLine();

            if (answer == null) return;

            if (answer.Equals(answers.getQuestion()[0]))
            {
                correctMessage("Correct");
            }

            if (answer.Equals(answers.getQuestion()[1]))
            {
                correctMessage("Correct");
            } 
            
            if (answer.Equals(answers.getQuestion()[2])) {

               correctMessage("Correct");

            }
            Console.ReadLine();         


        }
    
        public static void correctMessage(string s)
        {

            Answer.Answer<string>.d.Invoke(s);
        }

    }
};