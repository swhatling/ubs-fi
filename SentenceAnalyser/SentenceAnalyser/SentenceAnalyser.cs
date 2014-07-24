using System;
using System.Collections.Generic;
using System.Linq;

namespace SentenceTools
{
    public class SentenceAnalyser
    {
        private readonly string _sentence; //make it immutable
        public SentenceAnalyser(string sentence)
        {
            _sentence = sentence.ToLower();
        }

        public IEnumerable<WordTally> GetWordTally()
        {

            var listOfWords = GetListOfWords(_sentence);

            var tally = listOfWords
                        .GroupBy(w => w)
                        .Select(w => new WordTally(w.Key, w.Count()));

            return tally.OrderByDescending(w => w.NumberOfOccurrences);
            //todo: would want to clarify if any other order requirements
        }


        private static IEnumerable<string> GetListOfWords(string phraseToSplit)
        {
            var punctuationTokens = new[] {" ", ",", ";"};
            return phraseToSplit.Split(punctuationTokens, StringSplitOptions.RemoveEmptyEntries);
            
        }

    }
}
