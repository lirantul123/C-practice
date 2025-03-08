namespace Exercise;

public class Selenite : SpaceMan
{
    private char[][] _sentence;
    private readonly bool _isFromTheDarkSide;// not changeable

    public Selenite(char[][] sentence, int age, bool isFromTheDarkSide) : base(age)
    {
        _sentence = sentence;
        _isFromTheDarkSide = isFromTheDarkSide;
    }

    public string SpeakWord(char[] word)
    {
        var ans = new char[word.Length];
        var j = 0;
        for (var i = word.Length - 1; i >= 0; i--)
        {
            if (word[i] == ' ') continue;
            ans[j++] = word[i];
        }
        
        if (!_isFromTheDarkSide) return new string(ans);
        for (var i = 0; i < ans.Length; i++)
        {
            if (ans[i] < 'a' || ans[i] > 'z') continue;
            ans[i] = (char)((ans[i]) - 32);
        }

        return new string(ans);
    }

    public override string Speak()
    {
        var sentence = "";
        
        for (var i = 0; i < _sentence.Length; i++)
        {
            sentence += SpeakWord(_sentence[i]);

            if (i < _sentence.Length - 1)
            {
                sentence += ' ';
            }
        }

        return sentence;
    }
}