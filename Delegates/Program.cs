using System;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int sayi1, int sayi2);
    class Program
    {      
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;

            myDelegate -= customerManager.SendMessage;
            myDelegate();


            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Hello");

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            var result = myDelegate3(3,8);
            Console.WriteLine(result);

            myDelegate3 += matematik.Carp;
            var result2 = myDelegate3(2,6);
            Console.WriteLine(result2);

        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
}
