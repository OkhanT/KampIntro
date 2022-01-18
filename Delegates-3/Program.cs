using System;

namespace Delegates_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegate - Func ile çalışmak 
            Console.WriteLine(Topla(6, 3));

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));

            //Parametresin delegasyonlara delegatelik yapıyor ve sonunda int dönüyor.
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1,100);
            };
            Console.WriteLine(getRandomNumber());

            //Func ikinci kullanım şekli;
            Func<int> getRandomNumber2 = () => new Random().Next(1,100);
            Console.WriteLine(getRandomNumber2());
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
