using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //Kasutaja peab selle numbri ära arvama;
            //Kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud;
            //Katsete arv on kolm, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mangu võidab arvuti;
            //*programm genereerib juhusliku numbri vaid ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Paku, mis number on genereeritud:");

                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == cpuNumber)
                {

                    Console.WriteLine($"Teie pakkumine, {userGuess}, on õige");
                    Console.WriteLine("Kena päeva!");
                    break;

                }


                else
                {
                    i++;
                    Console.WriteLine($"Teie pakkumine, {userGuess}, on vale. Teil on {3 - i} katset jäänud.");

                }


            }
        }
    }
}
