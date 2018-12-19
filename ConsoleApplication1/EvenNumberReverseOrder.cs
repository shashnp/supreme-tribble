using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Generates a reverse-ordered, comma delimited
    /// list of even numbers from 100 to 0 inclusive
    /// </summary>
    public class ReverseEvenNumberGenerator : IOutputGenerator
    {
        /// <summary>
        /// Use this class to provide a stream of values to Generate Output
        /// </summary>
        /// <returns>integers 0 to 100 inclusive</returns>
        private static IEnumerable<int> GetStream()
        {
            return Enumerable.Range(0, 101);
        }

        /// <summary>
        /// Make changes to this method
        /// See <see cref="UnitTestProject1.UnitTests.TestReverseEvenNumberGenerator()"/> for the Unit Test.
        /// </summary>
        /// <returns>reverse-ordered, comma delimited list of even numbers from 100 to 0 inclusive</returns>
        public string GenerateOutput()
        {
            // use GetStream() for the input range
            var evenNumber = GetStream().Where(x => x%2 == 0).Reverse();
            var commaSeperated = string.Join(",", evenNumber);
            return "Not Implemented.";
        }

        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            //throw new NotImplementedException();
            var substring = jumble.Substring(0, 2);
            string[] temp = {};
            //GetPossibleWords("ortsp", ["sport", "parrot", "ports", "matey"]) Should return ["sport", "ports"].
            var i = 0;
            foreach (var word in dictionary)
            {
                if (word.IndexOf(substring) != -1)
                {
                    temp[i] = word;
                }
                i++;
            }

            return temp;//new[] {"Not Implemented."};
        }
    }
}
