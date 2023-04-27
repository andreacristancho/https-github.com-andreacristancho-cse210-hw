using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic nunmber? ");
        string magic_number = Console.ReadLine();
        int magic_num = int.Parse(Console.ReadLine());


        int guess_num = -1;

        while (guess_num != magic_num)

        {
            Console.Write("What is your guess? ");
            guess_num = int.Parse(Console.ReadLine());

            if (magic_num > guess_num)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_num < guess_num)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guess it");
            }
        }
    }
}