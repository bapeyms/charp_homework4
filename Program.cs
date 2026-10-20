namespace charp_homework4;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("--- TASK 4 ---");
        // Website site1 = new Website();
        // site1.InputData();
        // site1.Print();
        
        // Website site2 = new Website("Kitten", "kittenpath", "Kitty Kitten Site", "228.288.288.288");
        // site2.Print();
        
        Console.WriteLine("--- TASK 5 ---");
        Magazine m1 = new Magazine("Tech Today", 2020, "It and Innovations", "111-222-333-444", "it@email.com", 25);
        Magazine m2 = new Magazine("Fashion", 1999, "Fashion Today", "555-666-777-888", "fashiontoday@email.com", 99);
        m1.Print();
        m2.Print();
        
        Console.WriteLine("--- (+ / -) ---");
        Console.Write($"m1 ({m1.NumberOfEmployees}) + 10 = ");
        m1 = m1 + 10;
        Console.Write($"{m1.NumberOfEmployees}\n");
        
        Console.Write($"10 + m2 ({m2.NumberOfEmployees}) = ");
        m2 = 10 + m2;
        Console.Write($"{m2.NumberOfEmployees}\n");
        
        Console.Write($"m2 ({m2.NumberOfEmployees}) - 18 = ");
        m2 = m2 - 18;
        Console.Write($"{m2.NumberOfEmployees}\n");
        
        Console.Write($"66 - m1 ({m1.NumberOfEmployees}) = ");
        m1 = 66 - m1;
        Console.Write($"{m1.NumberOfEmployees}\n");

        Console.Write($"m1 ({m1.NumberOfEmployees}) + m2 ({m2.NumberOfEmployees}) = ");
        Magazine magSum = m1 + m2;
        Console.Write($"{magSum.NumberOfEmployees}\n");
        
        Console.Write($"m2 ({m2.NumberOfEmployees}) - m1 ({m1.NumberOfEmployees}) = ");
        Magazine magDiff = m2 - m1;
        Console.Write($"{magDiff.NumberOfEmployees}\n\n");
        
        Console.WriteLine("--- COMPARING ---");
        Console.Write($"m1 == m2: {m1 == m2}\n");
        Console.Write($"m1 > m2: {m1 > m2}\n");
        Console.Write($"m1 < m2: {m1 < m2}\n");
        Console.Write($"m1 >= m2: {m1 >= m2}\n");
        Console.Write($"m1 <= m2: {m1 <= m2}\n\n");
        
        Console.WriteLine("--- EQUALS ---");
        Console.WriteLine($"m1.Equals(m2): {m1.Equals(m2)}");
        Console.WriteLine($"m2.Equals(m1): {m2.Equals(m1)}\n");

        // Console.WriteLine("--- TASK 6 ---");
        // Shop shop = new Shop();
        // shop.InputData();
        // shop.Print();
    }
}