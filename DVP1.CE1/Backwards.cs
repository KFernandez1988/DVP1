using System;
using System.Collections.Generic;
using System.Text;

namespace DVP1.CE1
{
    class Backwards
    {
        public Backwards()
        {

        }


        public void SetBackwards(string sentence) 
        {
            Console.WriteLine("Thank you, you entered the sentence {0} \r\n", sentence);
            string newSentence = "";
            string newWords = "";
            string[] words = sentence.Split(" ");
            char[] letters;
            Array.Reverse(words);
            foreach ( string word in words) {
                letters = word.ToCharArray();
                Array.Reverse(letters);
                String.Join(",",letters);
                newWords += letters ;
            }
            
            Console.WriteLine(newWords);
        }

        public bool Validation(string sentence)
        {
            
            string[] words = sentence.Split(" ");
            Console.WriteLine(words.Length);
            if (words.Length >= 6)
            {
               return true;
            }
              return false;
        }
        
    }
}
