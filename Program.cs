using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 5, 8, 9, };
            Console.WriteLine("The lucky number is " + luckyNumbers[0]);

            String[] friends = new string[5];
            friends[0] = "Thando";
            friends[1] = "Minenhle";
            friends[2] = "Monde";
            Console.WriteLine("The name at index 0 is " + friends[0]);
            
            Console.ReadLine();
        }
    }
}
