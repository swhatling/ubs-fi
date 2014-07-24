using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SentenceTools;
using TechTalk.SpecFlow;

namespace SentenceAnalysisTests
{
    [Binding]
    public class WordFrequencyAnalysisFeatureSteps
    {
        private const string TestSentence = "To unit-test or not to unit-test, that is the question";
        private SentenceAnalyser _analyser;
        private List<WordTally> _tally;

        [Given(@"a sentence")]
        public void GivenASentence()
        {
            _analyser = new SentenceAnalyser(TestSentence);
        }
        
        [When(@"I process the sentence with the word frequency analyser")]
        public void WhenIProcessTheSentenceWithTheWordFrequencyAnalyser()
        {
            _tally = _analyser.GetWordTally().ToList();
        }
        
        [Then(@"I'm returned a distinct list of words in the sentence and the number of times they have occurred")]
        public void ThenIMReturnedADistinctListOfWordsInTheSentenceAndTheNumberOfTimesTheyHaveOccurred()
        {
            //ScenarioContext.Current.Pending();

            Assert.AreEqual(8, _tally.Count(), "should be 8 distinct words");
            Assert.AreEqual(2, _tally.Single(w => w.Word == "unit-test").NumberOfOccurrences, "wrong count for token 'unit-test'");
            Assert.AreEqual(2, _tally.Single(w => w.Word == "to").NumberOfOccurrences, "wrong count for token 'to'");
            Assert.AreEqual(1, _tally.Single(w => w.Word == "question").NumberOfOccurrences, "wrong count for token 'question'");

        }
    }
}
