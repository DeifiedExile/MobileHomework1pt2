using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Transactions;

namespace MobileHomework1pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();

            bool quit = false;

            while(!quit)
            {
                Console.WriteLine("Please enter a 1) Student, 2) Teacher, 3) End");
                
                int personType = Convert.ToInt16(Console.ReadLine());
                if (personType != 1 && personType != 2)
                {
                    quit = true;
                }
                

                if (!quit)
                {
                    Person tempPerson;
                    if (personType == 1)
                    {
                         tempPerson = new Student(); 
                    }
                    else
                    {
                         tempPerson = new Teacher();
                    }
                    

                    Console.WriteLine("Name: ");

                    tempPerson.Name = Console.ReadLine();

                    Console.WriteLine("Age: ");
                    tempPerson.Age = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("ID: ");
                    tempPerson.Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Program[");
                    foreach (string subject in Enum.GetNames(typeof(Subject)))
                    {
                        Console.Write((int)Enum.Parse(typeof(Subject), subject) + ")" + subject + " ");
                        
                    }

                    Console.WriteLine("]");

                    tempPerson.Program = (Subject) Convert.ToInt16(Console.ReadLine());

                    if (personType == 1)
                    {
                        Console.WriteLine("Credits Earned: ");
                    }
                    else
                    {
                        Console.WriteLine("Years of Service: ");
                    }
                    tempPerson.setPerformance(Convert.ToInt16(Console.ReadLine()));
                    PersonList.Add(tempPerson);
                }

            }

            if (PersonList.Count > 0)
            {
                foreach (var person in PersonList)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            else
            {
                Console.WriteLine("No persons on file");
            }

        }
    }
}
