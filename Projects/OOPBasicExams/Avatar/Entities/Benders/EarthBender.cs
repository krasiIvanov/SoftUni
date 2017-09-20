
public class EarthBender : Bender
{
    public double GroundSaturation { get; set; }

    public EarthBender(string name, int power,double groundSaturation) : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
        TotalPower = power * groundSaturation;
    }
    public override string ToString()
    {
        string baseString = base.ToString();
        return $"{baseString}, Ground Saturation:{GroundSaturation}";
    }
}

