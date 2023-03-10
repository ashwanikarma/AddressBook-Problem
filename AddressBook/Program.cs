namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Book System");

            //add a new contact
            //CreateContact.PersonDetails();

            ////add a new contact
            //AddContact.GetCustomer();
            //AddContact.ListingPeople();

            //// Modify existing contact
            //EditContact.GetCustomer();
            //EditContact.Modify();
            //EditContact.ListingPeople();

            ////delete a person          
            //DeleteContact.GetCustomer();
            //DeleteContact.Modify();
            //DeleteContact.ListingPeople();
            //DeleteContact.RemovePeople();

            //add multiple person to Address Book
            Console.WriteLine("Welcome To Address Book System!");
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "2":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.Modify();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "3":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.ListingPeople();
                    break;
                case "4":
                    AddressBook.AddBook.GetCustomer();
                    AddressBook.AddBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }

            //add multiple Address Book to the System.
            Console.WriteLine("Enter number of AddressBook to create");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            //Create dictionary to store addressbook
            IDictionary<string, AddressBookSystem[]> numberNames = new Dictionary<string, AddressBookSystem[]>();

            //Runs till number of addressbook needs to be added
            while (i < num)
            {
                //Get input
                Console.WriteLine("Enter name of addressBook");
                string addrBookName = Console.ReadLine();

                //Create object for Class
                AddressBookSystem addressBookSystem = new AddressBookSystem();
                Console.WriteLine("Enter number of Contacts to Add");
                int contacts = Convert.ToInt32(Console.ReadLine());

                //Input contacts values from user
                while (contacts > 0)
                {
                    Console.WriteLine("Enter Firstname ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Enter Lastname ");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter City");
                    string city = Console.ReadLine();

                    Console.WriteLine("Enter State");
                    string state = Console.ReadLine();

                    Console.WriteLine("Enter pincode");
                    int pincode = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter PhoneNumber ");
                    long phone = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();

                    //Call Method
                    addressBookSystem.CreateContact(firstname, lastname, address, city, state, pincode, phone, email);
                    contacts--;
                }

                //Check if any modification needed
                Console.WriteLine("Do you want to Modify?(Y/N)");
                char ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'Y')
                {
                    addressBookSystem.Modify();
                }

                //Implements IDictionary<TKey, TValue> interface.
                numberNames.Add(addrBookName, addressBookSystem.ContactArray);
                foreach (KeyValuePair<string, AddressBookSystem[]> kvp in numberNames)
                {
                    //Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value[0].firstName);              
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                }
                i++;
            }
        }
        //Display Details
        public void Display(AddressBookSystem[] ContactArray, int N)
        {
            Console.WriteLine("---------Address Book Contains---------");
            int i;
            for (i = 0; i < N; i++)
            {
                Console.WriteLine("First name: {0}\n Last name: {1}\n Address: {2}\n City: {3}\n Zip: {4}\n State: {5}\n Phone Number: {6}\n Email: {7} \n", ContactArray[i].firstName, ContactArray[i].lastName, ContactArray[i].Address, ContactArray[i].city, ContactArray[i].zip, ContactArray[i].state, ContactArray[i].phoneNumber, ContactArray[i].email);

            }
        }

    
    }
}