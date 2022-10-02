using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    delegate int Func(int a, int b);

    class Combine
    {
        public int Combiner(int a, int b)
        {
            return a + b;
        }

    }
    class Diff
    {
        public int Difference(int a, int b)
        {
            return a - b;
        }
    }
    class Mult
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    class Divide
    {
        public int Divid(int a, int b)
        {
            return a / b;
        }
    }
    internal class Program
    {

        static void Main()
        {
            int a, b;
            Func userchoise;
            Console.WriteLine("Chose what u want!\n 1 - Combine \n 2 - Difference \n 3 - Multiply \n 4 - Divide ");
            
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Combine");
                        Console.Write("Write a-> ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Write b-> ");
                        b = Convert.ToInt32(Console.ReadLine());
                        userchoise = new Combine().Combiner;
                        Console.WriteLine($"The result: {userchoise(a, b)}");
                        break;
                    case 2:
                        Console.WriteLine("Difference");
                        Console.Write("Write a-> ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Write b-> ");
                        b = Convert.ToInt32(Console.ReadLine());
                        userchoise = new Diff().Difference;
                        Console.WriteLine($"The result: {userchoise(a, b)}");
                        break;
                    case 3:
                        Console.WriteLine("Multiplys");
                        Console.Write("Write a-> ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Write b-> ");
                        b = Convert.ToInt32(Console.ReadLine());
                        userchoise = new Mult().Multiply;
                        Console.WriteLine($"The result: {userchoise(a, b)}");
                        break;
                    case 4:
                        Console.WriteLine("Divide");
                        Console.Write("Write a-> ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Write b-> ");
                        b = Convert.ToInt32(Console.ReadLine());
                        userchoise = new Divide().Divid;
                        Console.WriteLine($"The result: {userchoise(a, b)}");
                        break;
                    default:
                        Console.WriteLine("Oups, you wrote wrong number!");
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OUCH! Write only numbers !! \n Error message:{ex.ToString()}");
            }
            
            Console.ReadKey();
        }
    }
}
