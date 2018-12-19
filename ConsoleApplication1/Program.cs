using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseEvenNumberGenerator x = new ReverseEvenNumberGenerator();
            //x.GenerateOutput();
            var y = new[] { "sport", "parrot", "ports", "matey"};
            x.GetPossibleWords("ortsp", y); //Should return ["sport", "ports"].
        }
    }
}
