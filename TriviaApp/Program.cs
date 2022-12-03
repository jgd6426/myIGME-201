using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Web;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string diffuculty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }

    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }

    /*
        20221203082048
        https://opentdb.com/api.php?amount=1

        {
          "response_code": 0,
          "results": [
            {
              "category": "Science: Computers",
              "type": "multiple",
              "difficulty": "medium",
              "question": "What was the first commerically available computer processor?",
              "correct_answer": "Intel 4004",
              "incorrect_answers": [
                "Intel 486SX",
                "TMS 1000",
                "AMD AM386"
              ]
            }
          ]
        }
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].question);


            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }
        }
    }
}
