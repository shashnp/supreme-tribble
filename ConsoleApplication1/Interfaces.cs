using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IOutputGenerator
    {
        string GenerateOutput();
    }

    public interface IRange
    {
        int Lower { get; }
        int Upper { get; }
    }
}
