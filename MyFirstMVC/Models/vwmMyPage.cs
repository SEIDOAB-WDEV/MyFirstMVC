using System;
using Models;

namespace MyFirstMVC.Models
{
	public class vwmMyPage
	{
        public string Greetings { get; set; } = "Hello everyone";
        public List<csLatinSentence> Latin { get; set; }

        public vwmMyPage()
		{
		}
	}
}

