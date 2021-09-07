using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasutaja on vanem, kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem, kui 18, siis konsoolis kuvatakse "oled liiga noor" 
            //Kui kasutaja on 18, siis konsoolis kuvatakse "oledki 18"

            Console.WriteLine("Kui vana sa oled?");
            int Age = Int32.Parse(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor");
            }
            else
            {
                Console.WriteLine("Oledki 18.");
            }
            Console.WriteLine("Ilusat päeva!");
           
            Console.Read();
        }
    }
}
