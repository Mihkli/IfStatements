using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //kui kasutaja siestab "sinine", konsool kuvab "oled töökas"
            //kui kasutaja siestab "roheline", konsool kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled ükssarvik"

            Console.WriteLine("Mis on sinu lemmikvärv?");
            string Usercolor = Console.ReadLine().ToLower();

            if(Usercolor == "punane")
            {
                Console.WriteLine("Oled romantiline");
            }
            else if(Usercolor == "sinine")
            {
                Console.WriteLine("Oled töökas");
            }
            else if(Usercolor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine("Oled tundmatu ükssarvik");
            }
            
            
        }
    }
}
