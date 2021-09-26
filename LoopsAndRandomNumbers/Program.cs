using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt pin koodi;
            //program võrdleb sisestatud pin koodi arvuga 1234;
            //Kui sisestatud pin kood pn 1234, siis konsool kuvab "Tere tulemast!";
            //Kui sisestatud pin kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //Kasutajal on kolm katset; i < 3


            int i = 0; // i - iteration

            while (i < 3)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale pin. {3 - i} katset on jäänud.");
                }

                //switch (userPIN)
                //{
                    //case (1234):
                        //Console.WriteLine("Tere tulemast!");
                        //break;

                    //default:
                        //Console.WriteLine("Vale PIN. Proovi uuesti.");
                        //break;
                //}
                
            }

            Console.WriteLine("Kena Päeva!");
        }
    }
}
