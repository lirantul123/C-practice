namespace Exercise;

public class Martian : SpaceMan
{
    private readonly string _sentence;// not changeable

    public Martian(string sentence, int age) : base(age)
    {
        _sentence = sentence;
    }

    public override string Speak()
    {
        string ans = "";
        string currWord = "";

        foreach (char c in _sentence)
        {
            if (c != ' ')
            {
                currWord = c + currWord;
            }
            else
            {
                ans += currWord + " ";
                currWord = ""; 
            }
        }

        ans += currWord; // Adding the last word(because there is not space after it)
        return ans; 
    }

}