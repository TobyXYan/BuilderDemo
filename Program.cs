using System;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDirector director = new BookOrderDirector();
            IPurchaseOrderBuilder orderBuilder = new FluentBookOrderBuilder();
            director.CreateOrder(orderBuilder);

            director = new PhoneOrderDirector();
            orderBuilder = new FluentPhoneOrderBuilder();
            director.CreateOrder(orderBuilder);
            Console.WriteLine("Hello World!");
        }
    }
}
