namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Book System");

            //add a new contact
            CreateContact.PersonDetails();

            //add a new contact
            AddContact.GetCustomer();
            AddContact.ListingPeople();

            // Modify existing contact
            EditContact.GetCustomer();
            EditContact.Modify();
            EditContact.ListingPeople();
        }
    }
}