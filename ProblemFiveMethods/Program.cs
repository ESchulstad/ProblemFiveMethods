using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemFiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Double(inputNum));
        }

        static int Double(int num)
        {
            int answer = num * 2;
            return answer;
        }
    }
}
