Feature: WordFrequencyAnalysisFeature
	In order to make sure I'm not repeating myself
	As an author
	I want to know the number of times each word appears in a sentence

@mytag
Scenario: Analyse word frequency in a single sentence
	Given a sentence
	When I process the sentence with the word frequency analyser
	Then I'm returned a distinct list of words in the sentence and the number of times they have occurred
