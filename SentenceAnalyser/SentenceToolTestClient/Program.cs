using System;
using System.Linq;
using System.Text;
using SentenceTools;

namespace SentenceToolTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Type your sentence and hit enter (or just hit enter to quit)");
            var inputString = Console.ReadLine();
            while (!String.IsNullOrWhiteSpace(inputString))
            {
                var tool = new SentenceAnalyser(inputString);

                var results = tool.GetWordTally();

                var formattedResults = results
                            .Aggregate(new StringBuilder(), (sb, wt) => sb
                            .AppendFormat("{0}: {1}", wt.Word, wt.NumberOfOccurrences)
                            .Append(Environment.NewLine));


                Console.WriteLine("{0}{1}{2}", 
                                  formattedResults , 
                                  Environment.NewLine, 
                                  "Type another sentence and hit enter (or just hit enter to quit)");

                
                inputString = Console.ReadLine();
            }



        }
    }
}
