using System;
using C_NET.AbstractClasses_Members;
using C_NET.Constructors;
using C_NET.Interfaces;
using C_NET.Generics;

namespace C_NET
{

    internal partial class Program
    {

        public interface ITaxCalculator
        {
            int Calculate();
        }
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
            //Text text = new Text();
            //Shape shape = text;
            //text.Width = 100;
            //shape.Width = 200;
            //Console.WriteLine(text.Width);
            //StreamReader reader = new StreamReader(new MemoryStream());
            // ArrayList list = new ArrayList();
            // list.Add(1);
            // list.Add("Mosh");
            // list.Add(new Text());

            //var anotherList = new List<Shape>();
            //Shape shape = new Text();
            //Text text = (Text)shape;
            //Console.WriteLine(1 + 2);
            //Boxing boxing = new Boxing();
            //boxing.list.Add(1);
            //var shapes = new List<Shape>();
            //Shape shape = new Shape();
            /*Circle circle = new Circle();
            circle.Draw();
            Rectangle rectangle = new Rectangle();
            rectangle.Draw();*/

            int[] intArray = { 1, 2, 3,5 };
            double[] doubleArray = { 2.0, 6.0 };
            Iterate.displayElement(doubleArray);
        }
    }
}

