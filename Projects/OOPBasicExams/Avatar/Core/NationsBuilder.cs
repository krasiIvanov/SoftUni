using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    List<Nation> nations;
    List<string> warIssued;

    public NationsBuilder()
    {
        warIssued = new List<string>();
        nations = new List<Nation>()
        {
            new Nation("Air"),
            new Nation("Fire"),
            new Nation("Water"),
            new Nation("Earth")

        };
    }

    public void AssignBender(List<string> benderArgs)
    {
        string type = benderArgs[1];
        string name = benderArgs[2];
        int power = int.Parse(benderArgs[3]);
        double secondaryParameter = double.Parse(benderArgs[4]);
        try
        {
            Bender bender = BenderFactory.CreateBender(type, name, power, secondaryParameter);
            nations.Where(n => n.Name == type).FirstOrDefault().AddBender(bender);
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
        
       


    }
    public void AssignMonument(List<string> monumentArgs)
    {
        string type = monumentArgs[1];
        string name = monumentArgs[2];
        int affinity = int.Parse(monumentArgs[3]);

        try
        {
            Monument monument = MonumentFactory.CreateMonument(type, name, affinity);
            nations.Where(n => n.Name == type).FirstOrDefault().AddMonment(monument);

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
       

    }
    public string GetStatus(string nationsType)
    {

        return nations.Where(n => n.Name == nationsType).FirstOrDefault().ToString();
        
    }
    public void IssueWar(string nationsType)
    {
        warIssued.Add(nationsType);
        var result = nations.OrderBy(p => p.totalPower()).ToList();
        for (int i = 1; i < result.Count; i++)
        {
            result[i].RemoveBenderAndMonuments();
        }
    }
    public string GetWarsRecord()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < warIssued.Count; i++)
        {
            sb.AppendLine($"War {i+1} issued by {warIssued[i]} ");
        }
        return sb.ToString().Trim();
    }

    
}

