using System;

namespace Delta_praca_domowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double a, b, c, x1, x2, delta;
            
            Console.WriteLine("Podaj wartośc a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartośc b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wartośc c");
            c = Convert.ToDouble(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (a == 0)
            {
                Console.WriteLine("A nie może być zerem bo nie bedzie to równanie kwadratowe!");
            }
            
      
            if(delta < 0)
            {
                Console.WriteLine("brak pierwiastków rzeczywistych");
                
            } 
            if(delta == 0)
            {
                delta = b * b - 4 * a * c;
                Console.WriteLine("Istnieje jeden pierwiastek rzeczywisty");
                x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("X1 wynosi" + ' '+ x1);
            }   
            if(delta > 0)
            {
                Console.WriteLine("IStnieją dwa pierwiastki rzeczywiste");

                delta = b * b - 4 * a * c;
                x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                x2 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("X1 wynosi" + ' '+ x1);
                Console.WriteLine("x2 wynosi" + ' ' + x2);
            }

            Console.Read();
        }
    }
}
