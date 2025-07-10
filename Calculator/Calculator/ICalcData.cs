using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalcData
    {
        // int - num of operation, char - symbol of operation 
        Dictionary<int, char> Operations { get; set; }
        // int - num of operation, double - numbers 
        Dictionary<int, double> Values { get; set; }
    }
}
