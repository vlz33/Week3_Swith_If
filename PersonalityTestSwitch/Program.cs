using System;

namespace PersonalityTestSwitch
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
            //Punane, Sinine, Roheline
            
            Console.WriteLine("Sisesta oma lemmikvärv:");
            string UserColour = Console.ReadLine().ToLower();

            switch(UserColour)
            {
                case "punane":
                    Console.WriteLine("Oled romantik");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber");
                    break;
                    default:
                    Console.WriteLine($"Oled {UserColour} ükssarvik");
                    break;
            }
           
            Console.WriteLine("Kena päeva");
        }

    }
}
