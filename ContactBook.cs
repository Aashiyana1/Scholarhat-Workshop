// Contact Book: Build a contact book using C# using classes to manage contacts.
class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Phone: {PhoneNumber}, Email: {Email}";
    }
}

class ContactBook
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(string name, string phoneNumber, string email)
    {
        contacts.Add(new Contact(name, phoneNumber, email));
    }

    public void UpdateContact(string name, string newName, string newPhoneNumber, string newEmail)
    {
        Contact contactToUpdate = contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (contactToUpdate != null)
        {
            contactToUpdate.Name = newName;
            contactToUpdate.PhoneNumber = newPhoneNumber;
            contactToUpdate.Email = newEmail;
        }
        else
        {
            Console.WriteLine($"Contact with name '{name}' not found.");
        }
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Contacts in the Contact Book:");
        foreach (var contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
}

class Program1
{
    static void Main(string[] args)
    {
        ContactBook contactBook = new ContactBook();

        contactBook.AddContact("Aashiyana Pathan", "123-456-7890", "aashiyana@gmail.com");
        contactBook.AddContact("Suraj Divekar", "987-654-3210", "surajd@gmail.com");

        contactBook.DisplayContacts();

        Console.WriteLine("\nUpdating contact...");
        contactBook.UpdateContact("Aashiyana Pathan", "Aashiyana Shaikh", "555-555-5555", "aashiyana.a@gmail.com");

        contactBook.DisplayContacts();
    }
}
