﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_S_JadenCasingStrings
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Jaden Casing Strings

        // Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid (2010) and After Earth (2013). 
        // Jaden is also known for some of his philosophy that he delivers via Twitter. 
        // When writing on Twitter, he is known for almost always capitalizing every word. 
        // For simplicity, you'll have to capitalize each word, check out how contractions are expected to be in the example below.

        // Your task is to convert strings to how they would be written by Jaden Smith.
        // The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

        // Example:
        // Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
        // Jaden-Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"



        // ---------------------------------------- My Solution ----------------------------------------
        public string ToJadenCase(string phrase)
        {
            string[] words = phrase.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                var newWord = words[i].ToCharArray();
                newWord[0] = char.ToUpper(newWord[0]);
                words[i] = string.Join("", newWord);
            }
            return string.Join(" ", words);
        }
        // Solved March 18, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public string ToJadenCaseBest(string phrase)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
        }

    } // CW_S_JadenCasingStrings class

} // CSharpPracticeExercises namespace
