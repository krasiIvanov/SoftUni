
public abstract class Bender
{

    public string Name { get; set; }
    public int Power { get; set; }
    public double TotalPower { get; protected set; }
    public Bender(string name,int power)
    {

        this.Name = name;
        this.Power = power;

    }

    public override string ToString()
    {
        return $"Bender:{Name}, Power:{Power}";
    }

}

