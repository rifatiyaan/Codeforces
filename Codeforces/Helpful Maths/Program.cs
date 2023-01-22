using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpful_Maths
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] first = input.Split('+');
            Array.Sort(first);

             
            string second = String.Join("+", first);
            foreach (var item in second)
            {
                Console.Write(item);
            }

        }


    }
}
