using System.Numerics;

class Program
{
    static void Main()
    {
        int integer = int.Parse(Console.ReadLine());
        Matrix(integer);
    }
    static void Matrix(int integer)
    {
        for (int rows = 1; rows <= integer; rows++)
        {
            for (int j = 1; j <= integer; j++)
            {
                Console.Write(integer + " ");
            }
            Console.WriteLine();
        }
        
        
    }
}