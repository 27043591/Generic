using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int IntInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your number");
            string strInput = Console.ReadLine();
            GenericClass<int, string> compare = new GenericClass<int, string>();
            if (compare.Check(IntInput, strInput))
                Console.WriteLine("they are same");
            else
                Console.WriteLine("they are not same");
            Console.ReadLine();
        }
        
    }
    class GenericClass<I, T>
    {
        public bool Check(I x, T y)
        {
            if (x.ToString().Equals(y.ToString()))
                return true;
            else
                return false;
        
        }

       
    }
  
}