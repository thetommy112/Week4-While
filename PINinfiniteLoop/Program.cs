using System;

namespace PINinfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //Programm küsib kasutajalt pin koodi;
            //program võrdleb sisestatud pin koodi arvuga 1234;
            //Kui sisestatud pin kood pn 1234, siis konsool kuvab "Tere tulemast!";
            //Kui sisestatud pin kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //Kasutajal on piiramatult palju katseid;


            bool loopActive = true;
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN:"); // cw+double TAB
                int userPIN = Convert.ToInt32(Console.ReadLine());

                switch (userPIN) 
                {
                    case (1234):
                    Console.WriteLine("Tere tulemast!");
                        loopActive = false;
                        break;

                    default:
                        Console.WriteLine("Vale pin. Proovi uuesti!");

                        i++;

                        Console.WriteLine($"Oled vale PIN koodi {i} korda sisestanud.");
                        break;
                }
                
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
