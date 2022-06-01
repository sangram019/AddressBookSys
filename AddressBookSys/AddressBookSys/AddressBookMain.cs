using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> addressBook = new List<Contact>();
        public Dictionary<string, List<Contact>> dict = new Dictionary<string, List<Contact>>();
        public static Dictionary<string, List<Contact>> dictcity = new Dictionary<string, List<Contact>>();
        public static Dictionary<string, List<Contact>> dictstate = new Dictionary<string, List<Contact>>();
        Contact contact = new Contact();
        public void SortingContactsByName()
        {
            foreach (var data in addressBook.OrderBy(s => s.FirstName).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of the Person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Email ID : " + data.Email);
                    Console.WriteLine("Mobile Number : " + data.PhoneNumber);
                    Console.WriteLine("Address : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State : " + data.State);
                    Console.WriteLine("ZipCode : " + data.ZipCode);
                    Console.WriteLine("\n");
                }

            }
        }
        public void SortingContactsByCity()
        {

            foreach (var data in addressBook.OrderBy(s => s.City).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("ZipCode :" + data.ZipCode);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }

        public void SortingContactsByState()
        {

            foreach (var data in addressBook.OrderBy(s => s.State).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("ZipCode :" + data.ZipCode);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }

        public void SortingContactsByZip()
        {

            foreach (var data in addressBook.OrderBy(s => s.ZipCode).ToList())
            {
                if (addressBook.Contains(data))
                {
                    Console.WriteLine("Name of person : " + data.FirstName + " " + data.LastName);
                    Console.WriteLine("Address of person is : " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State :" + data.State);
                    Console.WriteLine("ZipCode :" + data.ZipCode);
                    Console.WriteLine("Phone Number of person: " + data.PhoneNumber);
                    Console.WriteLine("Email of person : " + data.Email);
                    Console.WriteLine();
                }

            }
        }
        string path = @"C:\Repository\AddressBookSys\AddressBookSys\AddressBookSys\InputOutputFile.txt";
        public void WriteToTextFile()
        {
            using (TextWriter Tw = File.AppendText(path))
            {
                foreach (Contact item in addressBook)
                {
                    Tw.WriteLine("First Name:" + item.FirstName.ToString());
                    Tw.WriteLine("Last Name:" + item.LastName.ToString());
                    Tw.WriteLine("Address:" + item.Address.ToString());
                    Tw.WriteLine("City:" + item.City.ToString());
                    Tw.WriteLine("State:" + item.State.ToString());
                    Tw.WriteLine("ZipCode1:" + item.ZipCode.ToString());
                    Tw.WriteLine("PhoneNumber:" + item.PhoneNumber.ToString());
                    Tw.WriteLine("EmailId:" + item.Email.ToString());

                }
            }
        }
        public void ReadFileIO()
        {
            string lines;

            lines = File.ReadAllText(path);
            Console.WriteLine("Reading All the Text\n" + lines);
        }
    }
}

    