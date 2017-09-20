
public class WaterMonument : Monument
{
    public int WaterAffinity { get; set; }

    public WaterMonument(string name, int waterAffinity) : base(name)
    {
        this.WaterAffinity = waterAffinity;
        base.Affinity = waterAffinity;
    }
    public override string ToString()
    {
        string baseString = base.ToString();
        return $"{baseString} Water Affinity: {WaterAffinity}";
    }
}

