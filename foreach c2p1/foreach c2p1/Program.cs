using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int[] squareVal = new int[3];
        string[] line = Console.ReadLine().Split(' ');
        squareVal = [Convert.ToInt32(line[0]), Convert.ToInt32(line[1]), Convert.ToInt32(line[2]), Convert.ToInt32(line[3])];
        foreach(var item in squareVal)
        {
            Console.WriteLine(item * item);
        }
    }
}