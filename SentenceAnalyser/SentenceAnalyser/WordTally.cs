using System.Diagnostics;

namespace SentenceTools
{
    [DebuggerDisplay("{Word}: {NumberOfOccurrences}")]
    public class WordTally
    {

        public WordTally(string word, int numberOfOccurrences)
        {
            Word = word;
            NumberOfOccurrences = numberOfOccurrences;
        }

        public string Word { get; private set; }
        public int NumberOfOccurrences { get; private set; }
    }
}
