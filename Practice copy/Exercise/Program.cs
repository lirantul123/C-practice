namespace Exercise;

public class Program
{
    public static void Main()
    {        
        Being b1 = new Being(30);
        // "--------------------A.--------------------"
        Martian martian = new Martian("I am an 18 year old martian", 18);
        
        // "--------------------B.--------------------"
        Console.WriteLine(Being.Population + " .B");
        
        // "--------------------C.--------------------"
        var sentence1 = new[]
        {
            new[] { 'I' }, 
            new[] { 'l', 'o', 'v', 'e' },  
            new[] { 'l', 'i', 'g', 'h', 't' }  
        };
        Selenite selenite1 = new Selenite(sentence1, 16, true);

        // "--------------------D.--------------------"
        var sentence2 = new[]
        {
            new[] { 'R', 'o', 'c', 'k' }, 
            new[] { 'a', 'n', 'd' },  
            new[] { 'r', 'o', 'l', 'l' }  
        };
        Selenite selenite2 = new Selenite(sentence2, 101, false);
        
        // "--------------------E.--------------------"
        Tribesperson tribesperson = new Tribesperson(85);
        
        // "--------------------F.--------------------"
        Console.WriteLine(Being.Population + " .F");

        // "--------------------G.--------------------")
        Talk(tribesperson, new SpaceMan[] { martian, selenite1, selenite2 });
    
        // "--------------------H.--------------------"
        Console.WriteLine("Memory of the Tribesperson: .H");
        Tribesperson.Sing(tribesperson.Memory);  

    }

    static void Talk(Tribesperson tribesperson, SpaceMan[] spaceMan)
    {
        foreach (var sm in spaceMan)
        {
            tribesperson.Listen(sm.Speak());
        }
    }
}