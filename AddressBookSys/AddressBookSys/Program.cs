﻿using System;
using AddressBook;

namespace AddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Address Book Program");
            bool end = true;
            Console.WriteLine("SelectNumber\n1)Sorting alphabetically by Person’s name\n2)End Of Program");
            Contact contact = new Contact();
            AddressBookMain addContact = new AddressBookMain();
            while (end)
            {
                Console.WriteLine("choose program to exucute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addContact.SortingContactsByName();
                        break;
                    case 2:
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;

                }
            }
        }
    }
}