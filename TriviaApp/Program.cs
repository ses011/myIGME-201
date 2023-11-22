using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;

namespace TriviaApp
{

    class Trivia
    {
        public int responseCode;
        public List<TriviaResult> results;
    }

    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Program
    {
        static void Main(String[] args)
        {
            string url = "https://opentdb.com/api.php?amount=1&type=multiple";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            string s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);

            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            Console.WriteLine(trivia.results[0].question);
            for(int i = 0; i < trivia.results[0].incorrect_answers.Count + 1; ++i)
            {
                if (i <= trivia.results[0].incorrect_answers.Count)
                {

                    Console.WriteLine((i + 1 ) + ". " + trivia.results[0].incorrect_answers[i]);
                }
                else
                {
                    Console.WriteLine((i + 1) + ". " + trivia.results[0].correct_answer);
                }
            }
        }
    }
}
