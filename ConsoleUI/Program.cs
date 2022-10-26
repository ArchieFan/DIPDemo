using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Archie";
            owner.LastName = "Fan";
            owner.EmailAddress = "archiefan@gmail.com";
            owner.PhoneNumber = "07621187088";
            //Person owner = new Person
            //{
            //    FirstName = "Archie",
            //    LastName = "Fan",
            //    EmailAddress = "archiefan@gmail.com",
            //    PhoneNumber = "07621187088"
            //};

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;
            //Chore chore = new Chore
            //{
            //    ChoreName = "Take out the trash",
            //    Owner = owner
            //};

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
