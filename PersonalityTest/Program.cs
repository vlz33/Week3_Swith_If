using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma lemmikvärv;
            //kui kasutaja sisestab "punane", siis konsool kuvab "oled romantik";
            //kui kasutaja sisestab "sinine", siis konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", siis konsool kuvab "oled loodusesõber";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "oled {UserColour} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string UserColour = Console.ReadLine();

            if(UserColour == "punane")
            {
                Console.WriteLine("Oled romantik");
            }
            else if(UserColour == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if (UserColour == "roheline")
            {
                Console.WriteLine("Oled loodusesõber");
            }
            else
            {
                Console.WriteLine($"Oled {UserColour} ükssarvik");
            }
            Console.WriteLine("Kena päeva");
        }
    }
}