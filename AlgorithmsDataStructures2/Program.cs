using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int depth = 7;
            int result = 1 << (depth - 1);
            result |= result - 1;
        }
    }
}
