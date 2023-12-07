using System;
using Models;

namespace Services
{
	public interface ICoolLists
	{
		public List<csLatinSentence> LatinSentences { get; set; }
        public List<csQuote> Quotes { get; set; }
    }

	public class csCoolList : ICoolLists
	{
        public List<csLatinSentence> LatinSentences { get; set; }
        public List<csQuote> Quotes { get; set; }

		public csCoolList()
		{
			var _seeder = new csSeedGenerator();

			LatinSentences = _seeder.LatinSentences(50).Select(s => new csLatinSentence() { Sentence = s }).ToList();
			Quotes = _seeder.AllQuotes.Select(q => new csQuote() { Quote = q.Quote, Author = q.Author }).ToList();

		}

	}
}

