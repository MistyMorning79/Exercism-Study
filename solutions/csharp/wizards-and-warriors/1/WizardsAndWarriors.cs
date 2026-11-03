abstract class Character
{
    protected int _shanghai;
    protected bool _cuiruo = false;
    protected string _characterType;
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return _cuiruo;
    }

    public virtual string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(target is Wizard)
        {
            Wizard wizardTarget = target as Wizard;
            return wizardTarget.Vulnerable()? 10 : 6;
        }
        return 6;
    }
}

class Wizard : Character
{
    private bool _zhunbeifashu = false;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        return _zhunbeifashu? 12 : 3;
    }

    public void PrepareSpell()
    {
        _shanghai = 12;
        _zhunbeifashu = true;
    }
    public override bool Vulnerable()
    {
        return _zhunbeifashu? _cuiruo : !_cuiruo;
    }
}
