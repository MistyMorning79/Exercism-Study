public class Player
{
    public int RollDie()
    {
        Random a = new Random();
        int shaizi = a.Next(1,19);
        return shaizi;
    }

    public double GenerateSpellStrength()
    {
        Random a = new Random();
        double fashu = a.NextDouble();
        return fashu * 100;
    }
}
