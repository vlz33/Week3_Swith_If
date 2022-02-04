using System;

namespace GradingIF
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

            if (UserResult == 'A')

            {
                Console.WriteLine("Suurepärane!");
            }
            else if (UserResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (UserResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (UserResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if (UserResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (UserResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine($"Vale väärtus");
            }

        }




    }
}

