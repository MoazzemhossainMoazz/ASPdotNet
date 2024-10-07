using OOP_Demo;

class Program
{
    static void Main(string[] args)
    {
        Vehicle toyota = new Vehicle();

        toyota.ManufacturarName = "Toyota";
        toyota.Model = "Corolla";

        Vehicle ford = new Vehicle();

        ford.ManufacturarName = "Ford";
        ford.Model = "ford12";
    }
}