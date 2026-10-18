namespace charp_homework4;

public class Website
{
    public string Name { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;

    public Website() {}
    public Website(string name, string path, string description, string ipAddress)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(nameof(name));
        }
        if (string.IsNullOrWhiteSpace(path))
        {
            throw new ArgumentException(nameof(path));
        }
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException(nameof(description));
        }
        if (string.IsNullOrWhiteSpace(ipAddress))
        {
            throw new ArgumentException(nameof(ipAddress));
        }
        Name = name;
        Path = path;
        Description = description;
        IpAddress = ipAddress;
    }

    public void Print()
    {
        Console.WriteLine("--- WEBSITE INFORMATION ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Path: {Path}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Ip Address: {IpAddress}");
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
            Console.Write("Path: ");
            Path = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Path))
            {
                Console.WriteLine("ERROR: Path is empty");
            }
        } while (string.IsNullOrWhiteSpace(Path));
        
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
            Console.Write("IP Address: ");
            IpAddress = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(IpAddress))
            {
                Console.WriteLine("ERROR: IP Address is empty");
            }
        } while (string.IsNullOrWhiteSpace(IpAddress));
        Console.WriteLine("");
    }
}