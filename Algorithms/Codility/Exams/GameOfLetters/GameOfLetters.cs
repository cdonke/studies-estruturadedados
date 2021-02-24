using BenchmarkDotNet.Attributes;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Codility.Exams.GameOfLetters
{
    [MemoryDiagnoser]
    [KeepBenchmarkFiles]
    [MarkdownExporterAttribute.GitHub]
    public class GameOfLetters
    {
        [Benchmark(Description = "First try: String.Join + Replace")]
        [Arguments("cdeo", new[] { 3, 2, 0, 1 })]
        [Arguments("bytdag", new[] { 4, 3, 0, 1, 2, 5 })]
        public string FirstTry(string S, int[] A)
        {
            var word = new char[S.Length];

            // s[0] sends to a[0]: 

            //word[0] = S[0];
            var recipient = 0; ;
            // The loop grants the size of the message, not the order
            for (int i = 0; i < A.Length; i++)
            {
                // Get the current letter from the string
                var letter = S[recipient];
                var nextPlayer = A[recipient];

                // Since when a player does its move, he appends the letter to S, 
                // then, each letter is represented by the turn
                word[i] = letter;

                // The next one to play is the player at A[i]

                recipient = nextPlayer;

                // When the message is sent back to player[0], the word is completed
                if (recipient == 0)
                    break;
            }

            return string.Join("", word).Replace("\0", "");
        }

        [Benchmark(Description = "Second try: StringBuilder")]
        [Arguments("cdeo", new[] { 3, 2, 0, 1 })]
        [Arguments("bytdag", new[] { 4, 3, 0, 1, 2, 5 })]
        public string SecondTry(string S, int[] A)
        {
            var word = new StringBuilder(S.Length);

            // s[0] sends to a[0]: 

            //word[0] = S[0];
            var recipient = 0; ;
            // The loop grants the size of the message, not the order
            for (int i = 0; i < A.Length; i++)
            {
                // Get the current letter from the string
                var letter = S[recipient];
                var nextPlayer = A[recipient];

                // Since when a player does its move, he appends the letter to S, 
                // then, each letter is represented by the turn
                word.Append(letter);

                // The next one to play is the player at A[i]

                recipient = nextPlayer;

                // When the message is sent back to player[0], the word is completed
                if (recipient == 0)
                    break;
            }

            return word.ToString();
        }

        [Benchmark(Description = "Third try: string[] + trim(\\0)")]
        [Arguments("cdeo", new[] { 3, 2, 0, 1 })]
        [Arguments("bytdag", new[] { 4, 3, 0, 1, 2, 5 })]
        public string ThirdTry(string S, int[] A)
        {
            var word = new char[S.Length];

            // s[0] sends to a[0]: 

            //word[0] = S[0];
            var recipient = 0; ;
            // The loop grants the size of the message, not the order
            for (int i = 0; i < A.Length; i++)
            {
                // Get the current letter from the string
                var letter = S[recipient];
                var nextPlayer = A[recipient];

                // Since when a player does its move, he appends the letter to S, 
                // then, each letter is represented by the turn
                word[i] = letter;

                // The next one to play is the player at A[i]

                recipient = nextPlayer;

                // When the message is sent back to player[0], the word is completed
                if (recipient == 0)
                    break;
            }

            return new string(word).Trim('\0');
        }

        [Benchmark(Description = "Fourth try: string.join arraycopy")]
        [Arguments("cdeo", new[] { 3, 2, 0, 1 })]
        [Arguments("bytdag", new[] { 4, 3, 0, 1, 2, 5 })]
        public string FourthTry(string S, int[] A)
        {
            var word = new char[S.Length];

            // s[0] sends to a[0]: 

            //word[0] = S[0];
            var recipient = 0;
            int i;
            // The loop grants the size of the message, not the order
            for (i = 0; i < A.Length; i++)
            {
                // Get the current letter from the string
                var letter = S[recipient];
                var nextPlayer = A[recipient];

                // Since when a player does its move, he appends the letter to S, 
                // then, each letter is represented by the turn
                word[i] = letter;

                // The next one to play is the player at A[i]

                recipient = nextPlayer;

                // When the message is sent back to player[0], the word is completed
                if (recipient == 0)
                    break;
            }

            // Copy the message length to a new array, to remove trailing \0
            char[] output = new char[i + 1];
            Array.Copy(word, output, i + 1);


            return string.Join("", output);
        }
    }
}
