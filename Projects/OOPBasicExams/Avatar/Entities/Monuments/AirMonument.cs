
public class AirMonument : Monument
{
    public int AirAffinity { get; set; }

    public AirMonument(string name, int airAffinity) : base(name)
    {
        this.AirAffinity = airAffinity;
        base.Affinity = airAffinity;
    }

    public override string ToString()
    {
        string baseString = base.ToString();
        return $"{baseString} Air Affinity: {AirAffinity}";
    }
}

