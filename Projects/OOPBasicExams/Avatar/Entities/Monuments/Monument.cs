
public abstract class Monument
{
    public string Name { get; set; }
    public int Affinity { get; protected set; }
    public Monument(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return $"Monument:{Name},";
    }
}

