using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSet2S1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "man I can understand how it might be";
 
            MatchCollection matches = Regex.Matches(sentence, @"((\b[^\s]+\b)((?<=\.\w).)?)");
             
            Dictionary<string, int> WordCount = new Dictionary<string, int>();
             
            foreach(Match m in matches){
                if(!WordCount.Keys.Contains(m.ToString())){
                    WordCount.Add(m.ToString(), m.ToString().Length); 
                } 
            }
            
            foreach(var kvp in WordCount){
                Console.WriteLine("Key: " + kvp.Key + "            " + "Value: " + kvp.Value);   
            }
        }
    }
}