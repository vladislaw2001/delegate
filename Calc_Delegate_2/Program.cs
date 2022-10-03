using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console
{
    delegate double Procedure(double first_number,double last_number);

    class Operation : Operations
    {
        private double Number_a { get; set; }
        private double Number_b { get; set; }
        public Operation(double a, double b)
        {
            Number_a = a;
            Number_b = b;
        }
        public double Add(double a, double b) => a + b;
        public double Substract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => a / b;
        public double Percent(double a, double b) => (a / 100) * b;
        public double Stepin(double a, double stepin) => Math.Pow(a, Convert.ToInt16(stepin));
       

        
        public void user_operations(double Number_a, double Number_b,int choose)
        {
            
            try
            {
                
                switch (choose)
                {
                    case 1:
                        Procedure procedure = Add;
                        Console.WriteLine($"Result -> {procedure(Number_a, Number_b)}");
                        break;
                    case 2:
                        procedure = Substract;
                        Console.WriteLine($"Result -> {procedure(Number_a, Number_b)}");
                        break;
                    case 3:
                        procedure = Multiply;
                        Console.WriteLine($"Result -> {procedure(Number_a, Number_b)}");
                        break;
                    case 4:
                        procedure = Divide;
                        Console.WriteLine($"Result -> {procedure(Number_a, Number_b)}");
                        break;
                    case 5:
                        procedure = Percent;
                        Console.WriteLine($"Result -> {procedure(Number_a, Number_b)}");
                        break;
                    case 6:
                        procedure = Stepin;
                        Console.WriteLine($"Result -> {procedure(Number_a, Number_b)}");
                        break;
                    default:
                        Console.WriteLine("Обрана невiрна дiя! Спробуйте ще раз");
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured! \n Error message -> {ex.Message}");
            }
        }
       
        
        

        


    }
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a->");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter b->");
                double b = Convert.ToDouble(Console.ReadLine());
                Operation user = new Operation(a, b);

                Console.WriteLine("Оберіть дію \n 1 - Додавання \n 2 - Різниця \n 3 - Множення \n 4 - Ділення \n 5 - Відсоток числа \n 6 - Число в степені 'b'");
                int choose = Convert.ToInt32(Console.ReadLine());
                user.user_operations(a, b, choose);
            }
            catch   (Exception ex)
            {
                Console.WriteLine($"Error occured! \n Error message -> {ex.Message}");
            }
            
            Console.ReadKey();
        }

        
    }
}
