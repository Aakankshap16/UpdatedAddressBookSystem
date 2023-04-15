using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Updated_AddressBookSystem
{
    class AddressBookMainClass
    {
        // Define a list to store the contacts
        List<Contact> contactList = new List<Contact>();

        // AddDetails method to add new contact to the list
        public void AddDetails()
        {
            Contact newContact = new Contact();

            Console.WriteLine("Enter First Name: ");
            newContact.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            newContact.lastName = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            newContact.mobileNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            newContact.address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            newContact.city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            newContact.state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            newContact.zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            newContact.email = Console.ReadLine();

            contactList.Add(newContact);
            Console.WriteLine("Contact added successfully!");
        }

       
       

        // DisplayContact method to display all contacts in the address book
        public void DisplayContact()
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("Address book is empty!");
                return;
            }

            // Sort the contactList alphabetically by Person's name
            contactList.Sort((x, y) => string.Compare(x.firstName, y.firstName));

            // Display the sorted contact list
            Console.WriteLine("Address Book:");
            Console.WriteLine("===================================");
            foreach (var contact in contactList)
            {
                Console.WriteLine(contact.ToString());
                Console.WriteLine("-----------------------------------");
            }
        }

        // Main method to execute the program
        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("!!!!!!Welcome to Updated Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AddressBookMainClass addressBook = new AddressBookMainClass();

            while (flag == true)
            {
                Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            // Add new contact
                            Console.WriteLine("Please add new contact details: ");
                            addressBook.AddDetails();
                            addressBook.DisplayContact();
                            break;
                        }
                    case 0:
                        {
                            // Display all contacts and exit the program
                            addressBook.DisplayContact();
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            flag = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }
        }
    }
}
