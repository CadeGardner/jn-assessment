public static class BracketFinder
{
    public static void Main() { }

    public static bool HasMatchingBrackets(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;

        var bracketStack = new Stack<char>();
        // Add every left bracket to a stack
        // When a right bracket is encountered pop a left bracket off the stack
        // if stack is empty then, we should have all brackets matching

        foreach (char letter in input)
        {
            if (letter == '<')
                bracketStack.Push('<');

            if (letter == '>' && bracketStack.Count > 0)
                bracketStack.Pop();
        }
        return bracketStack.Count == 0;
    }
}
