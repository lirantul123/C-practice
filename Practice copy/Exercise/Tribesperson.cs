namespace Exercise;

public class Tribesperson : Being 
{
    public TreeNode? Memory;
    private int _age;

    public Tribesperson(int age) : base(age)
    {
        Memory = null;
        _age = age;
    }
    
    public void Listen(string sentence)
    {
        Stack<char> stack = new Stack<char>();
        string newSentence = "";
        string currWord = "";

        foreach (var ch in sentence)
        {
            if (ch != ' ') // As long as it is not the last words, continues to push
            {
                stack.Push(ch);
            }
            else
            {
                // Extracts the letters from the stack in the opposite direction
                while (stack.Count > 0)// stack not over
                {
                    currWord += stack.Pop();
                }

                newSentence += currWord + " ";// Summing into a new sentence
                currWord = "";
            }
        }

        // Handle the last word 
        while (stack.Count > 0)
        {
            currWord += stack.Pop();
        }
        newSentence += currWord; 

        // Storing
        if (Memory == null)
        {
            Memory = new TreeNode(newSentence);
        }
        else
        {
            Memory.Insert(Memory, newSentence);
        }
    }

    public static void Sing(TreeNode? node)
    {
        // Prints Inorder - left subtree then, curr node, then right subtree
        if (node == null) return;

        Sing(node.Left);
        Console.WriteLine(node.Sentence);
        Sing(node.Right);
    }
}