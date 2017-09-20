
public class EarthMonument : Monument
{
    public int EarthAffinity { get; set; }

    public EarthMonument(string name, int earthAffinity) : base(name)
    {
        this.EarthAffinity = earthAffinity;
        base.Affinity = earthAffinity;
    }

    public override string ToString()
    {
        string baseString = base.ToString();
        return $"{baseString} Earth Affinity: {EarthAffinity}";
    }
}

