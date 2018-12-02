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

        //Make this method return a sentence in backward completly
        public void SetBackwards(string sentence)
        {
    
          string[]  arraySentence = sentence.Split(' ');
          Array.Reverse(arraySentence);
          sentence = string.Join(" ", arraySentence);
            Console.WriteLine(sentence);
        }

        public bool Validation(string sentence)
        {
            return true;
        }
    }
    
  }
