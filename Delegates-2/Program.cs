using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //delegate - Action 
            Console.WriteLine("Hello World!");

            HandleException(() =>
            {
                Find();
            });
        }




        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<String> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not FOund!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

    }

    
}
