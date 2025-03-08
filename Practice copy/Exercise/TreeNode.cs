namespace Exercise;

public class TreeNode
{
    public string Sentence { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
    
    public TreeNode(string sentence)
    {  
        Sentence = sentence;
        Left = null;
        Right = null;
    }

    public void Insert(TreeNode node, string sentence)
    {
        if (CompareOrder(sentence, node.Sentence) > 0) 
        {
            if (node.Right == null) { node.Right = new TreeNode(sentence); }
            else { Insert(node.Right, sentence); }
        }
        else 
        {
            if (node.Left == null) { node.Left = new TreeNode(sentence); }
            else { Insert(node.Left, sentence); }
        }
    }

    static int CompareOrder(string sentence1, string sentence2)
    {
        string str1 = sentence1.ToLower();
        string str2 = sentence2.ToLower();

        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] != str2[i])
            {
                return str1[i] > str2[i] ? 1 : -1;
            }
        }

        if (str1.Length > str2.Length) return 1;
        if (str1.Length < str2.Length) return -1;

        return 0;
    }
}
