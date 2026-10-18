namespace charp_homework4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- TASK 4 ---");
        Website site1 = new Website();
        site1.InputData();
        site1.Print();
        
        Website site2 = new Website("Kitten", "kittenpath", "Kitty Kitten Site", "228.288.288.288");
        site2.Print();
        
        Console.WriteLine("--- TASK 5 ---");
        Magazine magazine1 = new Magazine();
        magazine1.InputData();
        magazine1.Print();
        
        Console.WriteLine("--- TASK 6 ---");
        Shop shop = new Shop();
        shop.InputData();
        shop.Print();
    }
}