using System;
using System.Text;

namespace TGS.Challenge
{
    /*
          Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
          one another return true, else return false

          "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
          phrase to produce a new word or phrase, using all the original letters exactly once; for example
          orchestra can be rearranged into carthorse.

          areAnagrams("horse", "shore") should return true
          areAnagrams("horse", "short") should return false

          NOTE: Punctuation, including spaces should be ignored, e.g.

          horse!! shore = true
          horse  !! shore = true
            horse? heroes = true

          There are accompanying unit tests for this exercise, ensure all tests pass & make
          sure the unit tests are correct too.
       */
    public class Anagram
    {
        public bool AreAnagrams(string word1, string word2)
        {
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
                throw new ArgumentException();

            word1 = Cleanword(word1);
            word2 = Cleanword(word2);
            //determine length of inputstring
            int lenword1 = word1.Length;
            int lenword2 = word2.Length;

            if (lenword1 != lenword2)
                return false;
            //create an array of characters to compare
            char[] arrWord1 = word1.ToCharArray();
            char[] arrWord2 = word2.ToCharArray();
            //sort array so two consecutive char will be flagged
            Array.Sort(arrWord1);
            Array.Sort(arrWord2);

            string newword1 = new string(arrWord1);
            string newword2 = new string(arrWord2);
            if (newword1.Length == newword2.Length)
            {
                if (newword1 == newword2)
                {
                    return true;
                }
            }

            return false;
        }
        private string Cleanword(string inputstr)
        {
            //set string to lowercase
            inputstr = inputstr.ToLower();
            //set to char array to check for letters
            char[] arrinputstr = inputstr.ToCharArray();
            int len = inputstr.Length;
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                //check if character is a letter
                if (char.IsLetter(arrinputstr[i]))
                {
                    s.Append(arrinputstr[i]);
                }
            }
            return s.ToString();
        }
    }
}
