namespace Exercise;

public class Being
{
    private static int s_population;
    private int _age;
    
    public Being(int age)
    {
        _age = age;
        if (GetType() != typeof(Being))
        {
            s_population += 1;
        }
    }
    
   
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public static int Population
    {
        get { return s_population; }
    }
        
}