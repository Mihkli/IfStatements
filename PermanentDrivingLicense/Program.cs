using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutaja, kas ta on piisavalt vana, juhiluba saada

            Console.WriteLine("Mis aastal sa oled sündinud?");
            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("Oled Piisavalt vana, et juhilube saada");
            }
            else
            {
                Console.WriteLine("Liiga noorm, et juhilube saada");
            }


            /*if(Age > 18)
            {
                Console.WriteLine("Olete piisavalt vana, et saada juhilube");
            }
            else if(Age < 18)
            {
                Console.WriteLine("Olete liiga noor");
            }
            else
            {
                Console.WriteLine("Oled 18, nüüd saad juhilube teha");
            }
            */
            
        }
    }
}
