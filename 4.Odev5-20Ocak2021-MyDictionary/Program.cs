using System;
using System.Collections.Generic;

namespace _4.Odev5_20Ocak2021
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> car = new MyDictionary<string, int>();
            car.Add("Volvo", 2018);
            car.Add("Mercedes", 2021);
            car.Add("Nissan", 2007);
            car.Add("Iveco", 2011);
            Console.WriteLine(car.Count);
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TKey[] tempKeys;
        TValue[] values;
        TValue[] tempValues;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = keys;
            tempValues = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;



            Console.WriteLine("Marka :" + key + " Yıl: " + value);


        }
        public int Count
        {
            get
            {
                return keys.Length;

            }

        }

    }

}
