using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(4,5));

            //var type = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type);
            //var result = dortIslem.Topla(5,6);
            //Console.WriteLine(result);

            //DortIslem dortIslem1 = (DortIslem)Activator.CreateInstance(type,6,2);
            //var result1 = dortIslem1.Carp2();
            //Console.WriteLine(result1);

            //var type = typeof(DortIslem);
            //var instance = Activator.CreateInstance(type,6,7);
            //var info = instance.GetType().GetMethod("Topla2");
            //var result = info.Invoke(instance, null);
            //Console.WriteLine(result);

            var type = typeof(DortIslem);
            var metodlar = type.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı: {0}",info.Name);
                foreach (var parametre in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}",parametre.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
                }
            }

        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {

        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Çarpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
