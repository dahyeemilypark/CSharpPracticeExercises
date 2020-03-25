﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeExercises
{
    class CW_M_JosephusPermutation
    {
        // ---------------------------------------- Problem ----------------------------------------

        // Josephus Permutation

        // This problem takes its name by arguably the most important event in the life of the ancient historian Josephus: 
        // according to his tale, he and his 40 soldiers were trapped in a cave by the Romans during a siege.

        // Refusing to surrender to the enemy, they instead opted for mass suicide, with a twist: 
        // they formed a circle and proceeded to kill one man every three, until one last man was left 
        // (and that it was supposed to kill himself to end the act).

        // Well, Josephus and another man were the last two and, as we now know every detail of the story, 
        // you may have correctly guessed that they didn't exactly follow through the original idea.

        // You are now to create a function that returns a Josephus permutation, taking as parameters the initial array/list of items 
        // to be permuted as if they were in a circle and counted out every k places until none remained.

        // Tips and notes: it helps to start counting from 1 up to n, instead of the usual range 0..n-1; k will always be >=1.

        // For example, with n=7 and k = 3 josephus(7,3) should act this way.
        //  [1, 2, 3, 4, 5, 6, 7] - initial sequence
        //  [1, 2, 4, 5, 6, 7] => 3 is counted out and goes into the result[3]
        //  [1, 2, 4, 5, 7] => 6 is counted out and goes into the result[3, 6]
        //  [1, 4, 5, 7] => 2 is counted out and goes into the result[3, 6, 2]
        //  [1, 4, 5] => 7 is counted out and goes into the result[3, 6, 2, 7]
        //  [1, 4] => 5 is counted out and goes into the result[3, 6, 2, 7, 5]
        //  [4] => 1 is counted out and goes into the result[3, 6, 2, 7, 5, 1]
        //  [] => 4 is counted out and goes into the result[3, 6, 2, 7, 5, 1, 4]
        // So our final result is:
        // josephus([1,2,3,4,5,6,7],3)==[3,6,2,7,5,1,4]



        // ---------------------------------------- My Solution ----------------------------------------
        public List<object> JosephusPermutation(List<object> items, int k)
        {
            var result = new List<object>();
            var next = 0;
            while (items.Count > 0)
            {
                next += k - 1;
                while (next >= items.Count)
                    next -= items.Count;
                result.Add(items[next]);
                items.RemoveAt(next);
            }
            return result;
        }
        // Solved March 25, 2020



        // ---------------------------------------- Best Practices Solution on Codewars ----------------------------------------
        public static List<object> JosephusPermutationBest(List<object> items, int k)
        {
            List<object> res = new List<object>();
            int pos = 0;
            while (items.Count > 0)
            {
                pos = (pos + k - 1) % items.Count;
                res.Add(items[pos]);
                items.RemoveAt(pos);
            }
            return res;
        }

    } // CW_M_JosephusPermutation class

} // CSharpPracticeExercises namespace
