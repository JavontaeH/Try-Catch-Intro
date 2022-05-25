using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        Dictionary<string, Contact> ContactList = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            try
            {
                ContactList.Add(contact.Email, contact);
            }
            catch
            {
                Console.WriteLine($"Contact with email: {contact.Email} already exists.");
            }
        }

        public Contact GetByEmail(string email)
        {
            try
            {
                return ContactList[email];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"{email} was not found in the contact list.");
                return null;
            }
        }

    }
}