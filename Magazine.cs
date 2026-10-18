namespace charp_homework4;

public class Magazine
{
    public string Name { get; set; } = string.Empty;
    public uint YearOfEstablishment { get; set; } = 0U;
    public string Description { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    
    public Magazine() {}
    public Magazine(string name, uint yearOfEstablishment, string description, string phoneNumber, string emailAddress)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(nameof(name));
        }
        if (yearOfEstablishment == 0)
        {
            throw new ArgumentException(nameof(yearOfEstablishment));
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
        YearOfEstablishment = yearOfEstablishment;
        Description = description;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
    }
    public void Print()
    {
        Console.WriteLine("--- WEBSITE INFORMATION ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Year Of Establishment: {YearOfEstablishment}");
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
            Console.Write("Year Of Establishment: ");
            string inputYearOfEstablishment = Console.ReadLine();
            if (!uint.TryParse(inputYearOfEstablishment, out uint yearOfEstablishment) || yearOfEstablishment == 0)
            {
                Console.WriteLine("ERROR: Year Of Establishment is invalid");
                YearOfEstablishment = 0U;
            } 
            else
            {
                YearOfEstablishment = yearOfEstablishment;
            }
        } while (YearOfEstablishment == 0);
        
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