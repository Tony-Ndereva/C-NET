using System;
using C_NET.Upcasting_Downcasting;

namespace C_NET
{

    internal partial class Program
    {
        static void Main(string[] args)
        {

            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Smith";
            //john.Introduce();

            //Calculator calculator = new Calculator();

            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result); 

            //ArrayPractise.PrintArray();
            //var method = ShippingMethods.Express;
            //Console.WriteLine((int)method);
            //var methodId = 3;
            //Console.WriteLine((ShippingMethods)methodId);
            //Console.WriteLine(method);
            //var methodName = "Express";
            //Enum.Parse(typeof(ShippingMethods), methodName);
            // ListPractise.PrintList();
            //var john = new Person();
            //john.FirstName = "John";
            //john.Introduce("Tony");

            //var James = new Customer(1, "James");

            //var order = new Order();
            //James.Orders.Add(order);
            //Console.WriteLine(James.Id);
            //Console.WriteLine(James.Name);
            //var sheila = new Person(new DateTime(1982, 1, 1));

            //Console.WriteLine(sheila.Age);
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();
            /*  var dbMigrator = new DbMigrator(new Logger());
              var logger = new Logger();
              var installer = new Installer(logger);
              dbMigrator.Migrate();
              installer.Install();

  */
            //var car = new Car("XYZ-1234");
            Text text = new Text();
            Shape shape = text;
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);

        }
    }
}

