
using System.Collections.Generic;
using System.Text;

public class Nation
{

    public string Name { get; set; }
    private List<Bender> benders;
    private List<Monument> monuments;

    public Nation(string name)
    {
        this.Name = name;
        this.benders = new List<Bender>();
        this.monuments = new List<Monument>();
    }

    public void AddBender(Bender bender)
    {
        benders.Add(bender);
    }
    public void AddMonment(Monument monument)
    {
        monuments.Add(monument);
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Name} Nation");
        
        if (benders.Count==0)
        {
            sb.AppendLine($"Benders:None");
            
        }
        else
        {
            sb.AppendLine($"Benders:");
            foreach (var ben in benders)
            {
                sb.AppendLine($"###{Name} {ben.ToString()}");
            }
        }
        
        if (monuments.Count == 0)
        {
            sb.AppendLine("Monuments:None");
            
        }
        else
        {
            sb.AppendLine("Monuments:");
            foreach (var mon in monuments)
            {
                sb.AppendLine($"###{Name} {mon.ToString()}");
            }
        }

        return sb.ToString().Trim();
    }

   public double totalPower()
    {
        double totalBenderPower=0;
        foreach (var ben in benders)
        {
            totalBenderPower += ben.TotalPower;
        }
        int affinitySum = 0;
        foreach (var mon in monuments)
        {
            affinitySum += mon.Affinity;
        }
        double increase = (totalBenderPower / 100) * affinitySum;
        double result = totalBenderPower + increase;
        return result;

    }
    public void RemoveBenderAndMonuments()
    {
        benders=new List<Bender>();
        monuments = new List<Monument>();
    }
}

