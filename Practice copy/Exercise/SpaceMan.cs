namespace Exercise;

public abstract class SpaceMan : Being// Abstracted class for bases classes Martian and Selenite
{
    protected int _age;

    protected SpaceMan(int age) : base(age)
    { 
        _age = age;
    }

    public abstract string Speak();
}