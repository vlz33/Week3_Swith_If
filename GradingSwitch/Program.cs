using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mis hinde kasutaja sai
            //kui hinne oli "A", siis konsool kuvab "Suurepärane!";
            //kui hinne oli "B", siis konsool kuvab "Väga hea!";
            //kui hinne oli "C", siis konsool kuvab "Hea!";
            //kui hinne oli "D", siis konsool kuvab "Rahuldav!";
            //kui hinne oli "E", siis konsool kuvab "Kasin!";
            //kui hinne oli "F", siis konsool kuvab "Puudulik!";
            //kui kasutaja sisestab midagi muud, siis konsool kuvab "Vale väärtus";


            Console.WriteLine("Sisesta oma tulemus:");
            char UserResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch(UserResult)

            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine($"Vale väärtus");
                    break;



            }
        }
    }
}
