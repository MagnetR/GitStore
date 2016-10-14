using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string myInput;
            int myInt;

            Console.Write("Please enter a number: ");
            myInput = Console.ReadLine();
            myInt = Int32.Parse(myInput);
            Console.WriteLine(myInt);
        }
    }
}
