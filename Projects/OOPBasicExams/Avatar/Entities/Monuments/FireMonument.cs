
public class FireMonument : Monument
{
    public int FireAffinity { get; set; }

    public FireMonument(string name,int fireAffinity) : base(name)
    {
        this.FireAffinity = fireAffinity;
        base.Affinity = fireAffinity;
    }
    public override string ToString()
    {
        string baseString = base.ToString();
        return $"{baseString} Fire Affinity: {FireAffinity}";
    }
}

