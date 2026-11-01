static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string str = department?.ToUpper() ?? "OWNER";
        if(id == null)
        {
            return $"{name} - {str}";
        }
        else
        {
            return $"[{id}] - {name} - {str}";
        }
    }
}
