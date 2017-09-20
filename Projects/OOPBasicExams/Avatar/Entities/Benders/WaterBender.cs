
public class WaterBender : Bender
{
    public double WaterClarity { get; set; }

    public WaterBender(string name, int power, double waterClarity) : base(name, power)
    {
        this.WaterClarity = waterClarity;
        TotalPower = power * waterClarity;
    }
    public override string ToString()
    {
        string baseString = base.ToString();
        return $"{baseString}, Water Clarity:{WaterClarity}";
    }
}

