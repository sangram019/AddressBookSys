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
    }
}