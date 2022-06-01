using System;
using AddressBook;

namespace AddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Address Book Program");
            bool end = true;
            Console.WriteLine("SelectNumber\n1)Sorting alphabetically by Person’s name\n2)Sorting Persons Contacts By City \n3)Sorting Persons Contacts By State \n4)Sorting Persons Contacts By Zip \n5)Writing AddressBook Using File IO \n6)Reading AddressBook Using File IO\n7)End Of Program");
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
                        Console.WriteLine("Sorting Persons Contacts by City");
                        addContact.SortingContactsByCity();
                        break;
                    case 3:
                        Console.WriteLine("Sorting Persons Contacts by State");
                        addContact.SortingContactsByState();
                        break;
                    case 4:
                        Console.WriteLine("Sorting Persons Contacts by Zip");
                        addContact.SortingContactsByZip();
                        break;
                    case 5:
                        addContact.WriteToTextFile();
                        break;
                    case 6:
                        addContact.ReadFileIO();
                        break;
                    case 7:
                        end = false;
                        Console.WriteLine("Program Is Ended");
                        break;

                }
            }
        }
    }
        
}