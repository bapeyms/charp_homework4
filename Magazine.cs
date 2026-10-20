namespace charp_homework4;

public class Magazine
{
    public string Name { get; set; } = string.Empty;
    public uint YearOfEstablishment { get; set; } = 0U;
    public string Description { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public uint NumberOfEmployees { get; set; } = 0U;
    
    public Magazine() {}
    public Magazine(string name, uint yearOfEstablishment, 
        string description, string phoneNumber, string emailAddress,
        uint numberOfEmployees)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException(nameof(name));
        if (yearOfEstablishment == 0)
            throw new ArgumentException(nameof(yearOfEstablishment));
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException(nameof(description));
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException(nameof(phoneNumber));
        if (string.IsNullOrWhiteSpace(emailAddress))
            throw new ArgumentException(nameof(emailAddress));
        
        Name = name;
        YearOfEstablishment = yearOfEstablishment;
        Description = description;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        NumberOfEmployees = numberOfEmployees;
    }
    public void Print()
    {
        Console.WriteLine("--- MAGAZINE INFORMATION ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Year Of Establishment: {YearOfEstablishment}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email Address: {EmailAddress}");
        Console.WriteLine($"Number of Employees: {NumberOfEmployees}\n");
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

        do
        {
            Console.Write("Number of Employees: ");
            string inputNumberOfEmployees = Console.ReadLine();
            if (!uint.TryParse(inputNumberOfEmployees, out uint numberOfEmployees))
            {
                Console.WriteLine("ERROR: Number of Employees is invalid");
                NumberOfEmployees = 0U;
                continue;
            }
            NumberOfEmployees = numberOfEmployees;
            break;
        } while (true);
        Console.WriteLine("");
    }
    
    // homework 19.10.2026
    public static Magazine operator +(Magazine m, uint value)
    {
        if (m == null)
            throw new ArgumentNullException(nameof(m));
        m.NumberOfEmployees += value;
        return m;
    }
    public static Magazine operator +(uint value, Magazine m)
    {
        if (m == null)
            throw new ArgumentNullException(nameof(m));
        return m + value;
    }

    public static Magazine operator +(Magazine left, Magazine right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return new Magazine(
            left.Name,
            left.YearOfEstablishment,
            left.Description,
            left.PhoneNumber,
            left.EmailAddress,
            left.NumberOfEmployees + right.NumberOfEmployees);
    }

    public static Magazine operator -(Magazine m, uint value)
    {
        if (m == null)
            throw new ArgumentNullException(nameof(m));
        if (m.NumberOfEmployees > value)
        {
            m.NumberOfEmployees -= value;
        }
        else
        {
            m.NumberOfEmployees = 0;
        }
        return m;
    }
    public static Magazine operator -(uint value, Magazine m)
    {
        if (m == null)
            throw new ArgumentNullException(nameof(m));
        if (value > m.NumberOfEmployees)
        {
            m.NumberOfEmployees = value - m.NumberOfEmployees;
        }
        else
        {
            m.NumberOfEmployees = 0;
        }
        return m;
    }

    public static Magazine operator -(Magazine left, Magazine right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));

        uint newEmployees = 0;
        if (left.NumberOfEmployees > right.NumberOfEmployees)
            newEmployees = left.NumberOfEmployees - right.NumberOfEmployees;
        return new Magazine(
            left.Name,
            left.YearOfEstablishment,
            left.Description,
            left.PhoneNumber,
            left.EmailAddress,
            newEmployees
        );
    }

    public static bool operator ==(Magazine left, Magazine right)
    {
        if (ReferenceEquals(left, right))
            return true;
        if (left is null || right is null)
            return false;
        return left.NumberOfEmployees == right.NumberOfEmployees;
    }

    public static bool operator !=(Magazine left, Magazine right)
    {
        return !(left == right);
    }

    public static bool operator <(Magazine left, Magazine right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.NumberOfEmployees < right.NumberOfEmployees;
    }
    public static bool operator >(Magazine left, Magazine right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.NumberOfEmployees > right.NumberOfEmployees;
    }
    public static bool operator <=(Magazine left, Magazine right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.NumberOfEmployees <= right.NumberOfEmployees;
    }
    public static bool operator >=(Magazine left, Magazine right)
    {
        if(left is null ||  right is null)
            throw new ArgumentNullException(nameof(left));
        return left.NumberOfEmployees >= right.NumberOfEmployees;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Magazine);
    }

    public bool Equals(Magazine other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;
        return NumberOfEmployees == other.NumberOfEmployees;
    }
}