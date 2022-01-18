using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1, LastName = "Demiroğ", Age=22};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequitedProperty]
        public string FristName { get; set; }
        [RequitedProperty]
        public string LastName { get; set; }
        [RequitedProperty]
        public int Age { get; set; }

    }

    class CustomerDal
    {
        [Obsolete("Don't use Add, instaed use AddNew")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id,customer.FristName,customer.LastName,customer.Age);
        }

        public void AddNew()
        {

        }
    }

    class RequitedPropertyAttribute:Attribute
    {

    }

    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
