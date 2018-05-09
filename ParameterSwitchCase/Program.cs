using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterSwitchCase
{
    class Program
    {

        public void Oper(int a, int b,string c)
        {
            switch(c)
            {
                case "+": int sum=a+b;
                    Console.WriteLine("Sum is " + sum);
                            break;

                case "-": int sub = a - b;
                   Console.WriteLine("Sub is " + sub);
                            break;
                case "*": int mul = a * b;
                   Console.WriteLine("Mul is " + mul);
                            break;
                case "/": int div = a / b;
                   Console.WriteLine("Div is " + div);
                            break;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 nos");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator");
            string o = Console.ReadLine();
            Program p = new Program();
            p.Oper(a,b,o);
            Console.ReadKey();
        }
    }
}
