public static class Bob
{
    public static string Response(string statement)
    {
        var trimmed = statement.Trim();

        if (trimmed == "")
        {
            return "Fine. Be that way!";
        }

        bool isQuestion = trimmed.EndsWith('?');
        bool hasLetter = trimmed.Any(char.IsLetter);
        bool isYell = hasLetter && trimmed == trimmed.ToUpper();

        if (isYell && isQuestion)
        {
            return "Calm down, I know what I'm doing!";
        }
        if (isYell)
        {
            return "Whoa, chill out!";
        }
        if (isQuestion)
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}