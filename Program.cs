namespace C_NET
{
    internal class Program
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
            var john = new Person();
            john.FirstName = "John";
            john.Introduce("Tony");
        }
    }
}
