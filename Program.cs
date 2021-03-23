using System;

namespace randomnumbergeneratorexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int randomNumber = rand.Next(201);

            if (randomNumber >50) {
                System.Console.WriteLine($"{randomNumber} isi greater than 50");   
            } else if (randomNumber ==50) {
                System.Console.WriteLine($"{randomNumber} isi equal than 50");
            } else {
                System.Console.WriteLine($"{randomNumber} isi less than 50");
            }
        }
    }
}
