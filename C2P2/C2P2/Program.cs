class Program
{
    static void Main(string[] args)
    {
        int[] randomNumber = new int[3];


        Console.WriteLine("Enter all numbers:");
        for(var i=0; i<3; i++)
        {
            randomNumber[i] = Convert.ToInt16(Console.ReadLine());
        }

        Console.WriteLine("\n Roll number is: ");
        for(var i=0; i<randomNumber.Length; i++)
        {
            Console.WriteLine(randomNumber[i]);
        }

        Console.WriteLine("Task finished!!");


    }
}