using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri 1-10;
            //Kasutaja peab selle numbri ära arvama;
            //Kui kasutaja suutis numbri ära arvata, siis on kasutaja mängu võitnud;
            //Katsete arv on piiramatu;
            //*programm genereerib juhusliku numbri vaid ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Paku, mis number on genereeritud:");

                int userGuess = Convert.ToInt32(Console.ReadLine());

                if(userGuess == cpuNumber)
                {

                Console.WriteLine($"Teie pakkumine, {userGuess}, on õige");
                Console.WriteLine("Kena päeva!");

                loopActive = false;

                }
                        

                else 
                {

                Console.WriteLine($"Teie pakkumine, {userGuess}, on vale. Proovi uuesti!");

                }

            }
        }
    }
}
