using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var reverseWord = word.Reverse();
            return word.SequenceEqual(word.Reverse());

         
        }
    }
}       
