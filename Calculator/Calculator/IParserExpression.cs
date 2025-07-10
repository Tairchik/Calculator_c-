using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface IParserExpression
    {
        void SetExp(string value);
        string ParseExp();
    }
}
