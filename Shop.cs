namespace charp_homework4;

public class Shop
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public uint Area { get; private set; } = 0U;
    
    public Shop() {}
    public Shop(string name, string address, string description, 
        string phoneNumber, string emailAddress, uint area)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(nameof(name));
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException(nameof(address));
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException(nameof(description));
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException(nameof(phoneNumber));
        if (string.IsNullOrWhiteSpace(emailAddress))
            throw new ArgumentException(nameof(emailAddress));
        
        Name = name;
        Address = address;
        Description = description;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        Area = area;
    }
    public void Print()
    {
        Console.WriteLine("--- SHOP INFORMATION ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email Address: {EmailAddress}");
        Console.WriteLine($"Area: {Area}\n");
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
        
        do
        {
            Console.Write("Area: ");
            string inputArea = Console.ReadLine();
            if (!uint.TryParse(inputArea, out uint area))
            {
                Console.WriteLine("ERROR: Area is invalid");
                Area = 0U;
                continue;
            }
            Area = area;
            break;
        } while (true);
        Console.WriteLine("");
    }
    
    // homework 19.10.2026
    public static Shop operator +(Shop sh, uint value)
    {
        if (sh == null)
            throw new ArgumentNullException(nameof(sh));
        sh.Area += value;
        return sh;
    }
    public static Shop operator +(uint value, Shop sh)
    {
        if (sh == null)
            throw new ArgumentNullException(nameof(sh));
        return sh + value;
    }

    public static Shop operator +(Shop left, Shop right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return new Shop(
            left.Name,
            left.Address,
            left.Description,
            left.PhoneNumber,
            left.EmailAddress,
            left.Area + right.Area);
    }

    public static Shop operator -(Shop sh, uint value)
    {
        if (sh == null)
            throw new ArgumentNullException(nameof(sh));
        if (sh.Area > value)
        {
            sh.Area -= value;
        }
        else
        {
            sh.Area = 0;
        }
        return sh;
    }
    public static Shop operator -(uint value, Shop sh)
    {
        if (sh == null)
            throw new ArgumentNullException(nameof(sh));
        if (value > sh.Area)
        {
            sh.Area = value - sh.Area;
        }
        else
        {
            sh.Area = 0;
        }
        return sh;
    }

    public static Shop operator -(Shop left, Shop right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));

        uint newArea = 0;
        if (left.Area > right.Area)
            newArea = left.Area - right.Area;
        return new Shop(
            left.Name,
            left.Address,
            left.Description,
            left.PhoneNumber,
            left.EmailAddress,
            newArea
        );
    }

    public static bool operator ==(Shop left, Shop right)
    {
        if (ReferenceEquals(left, right))
            return true;
        if (left is null || right is null)
            return false;
        return left.Area == right.Area;
    }

    public static bool operator !=(Shop left, Shop right)
    {
        return !(left == right);
    }

    public static bool operator <(Shop left, Shop right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.Area < right.Area;
    }
    public static bool operator >(Shop left, Shop right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.Area > right.Area;
    }
    public static bool operator <=(Shop left, Shop right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.Area <= right.Area;
    }
    public static bool operator >=(Shop left, Shop right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.Area >= right.Area;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Shop);
    }

    public bool Equals(Shop other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return Area == other.Area;
    }
}