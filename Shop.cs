namespace charp_homework4;

public class Shop
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    
    public Shop() {}
    public Shop(string name, string address, string description, string phoneNumber, string emailAddress)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(nameof(name));
        }
        if (string.IsNullOrWhiteSpace(address))
        {
            throw new ArgumentException(nameof(address));
        }
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException(nameof(description));
        }
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            throw new ArgumentException(nameof(phoneNumber));
        }
        if (string.IsNullOrWhiteSpace(emailAddress))
        {
            throw new ArgumentException(nameof(emailAddress));
        }
        Name = name;
        Address = address;
        Description = description;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
    }
    public void Print()
    {
        Console.WriteLine("--- WEBSITE INFORMATION ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email Address: {EmailAddress}");
        Console.WriteLine("");
    }

    public void InputData()
    {
        Console.WriteLine("--- INPUT DATA ---");
        do
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("ERROR: Name is empty");
            }
        } while (string.IsNullOrWhiteSpace(Name));
        
        do
        {
            Console.Write("Address: ");
            Address = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Address))
            {
                Console.WriteLine("ERROR: Address is empty");
            }
        } while (string.IsNullOrWhiteSpace(Address));
        
        do
        {
            Console.Write("Description: ");
            Description = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Description))
            {
                Console.WriteLine("ERROR: Description is empty");
            }
        } while (string.IsNullOrWhiteSpace(Description));
        
        do
        {
            Console.Write("Phone Number: ");
            PhoneNumber = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                Console.WriteLine("ERROR: Phone Number is empty");
            }
        } while (string.IsNullOrWhiteSpace(PhoneNumber));
        
        do
        {
            Console.Write("Email Address: ");
            EmailAddress = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                Console.WriteLine("ERROR: Email Address is empty");
            }
        } while (string.IsNullOrWhiteSpace(EmailAddress));
        Console.WriteLine("");
    }
}