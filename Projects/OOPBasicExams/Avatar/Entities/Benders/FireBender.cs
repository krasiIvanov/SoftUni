
public class FireBender : Bender
{
    public double HeatAggression { get; set; }

    public FireBender(string name, int power,double heatAggression) : base(name, power)
    {
        this.HeatAggression = heatAggression;
        TotalPower = power * heatAggression;
    }
    public override string ToString()
    {
        string baseString = base.ToString();
        return $"{baseString}, Heat Aggression:{HeatAggression}";
    }
}

