using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] Personclass = new Person[5];
            Console.WriteLine("--------------Students------------");
            Personclass[0] = new Student("Suba", 90);
            Student_Message(Personclass[0].IsOutStanding());

            Console.WriteLine("--------------Students------------");

            Personclass[0] = new Student("Sree", 70);
            Student_Message(Personclass[0].IsOutStanding());

            Console.WriteLine("--------------Students------------");

            Personclass[0] = new Student("Raji", 100);
            Student_Message(Personclass[0].IsOutStanding());

            Console.WriteLine("--------------Students------------");

            Personclass[0] = new Student("Jegan", 95);
            Student_Message(Personclass[0].IsOutStanding());

            Console.WriteLine("--------------Students------------");


            Personclass[0] = new Student("Rama", 50);
            Student_Message(Personclass[0].IsOutStanding());

            Console.WriteLine("--------------Professor------------");


            Personclass[0] = new Professor("SubaSree", 8);
            Student_Message(Personclass[0].IsOutStanding());

            Console.WriteLine("--------------Professor------------");

            Personclass[0] = new Professor("Jegan", 7);
            Student_Message(Personclass[0].IsOutStanding());

            Console.WriteLine("--------------Professor------------");

            Personclass[0] = new Professor("Raji", 2);
            Student_Message(Personclass[0].IsOutStanding());

            Console.ReadLine();
        }

        static void Student_Message(bool result)
        {
            if(result)
            {
                Console.WriteLine("The student is outstanding by scoring above 85!!");
            }               
            else
            {
                Console.WriteLine("The student is not outstanding by scoring below 85!!");
            }
        }

        static void Professor_Message(bool result)
        {
            if (result)
            {
                Console.WriteLine("The professor is outstanding by publishing more than 4 books!!");
            }
            else
            {
                Console.WriteLine("The professor is not outstanding by publishing less than 4 books!!");
            }
        }
    }
}
