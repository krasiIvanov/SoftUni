using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    NationsBuilder builder;
    public Engine()
    {
        this.builder = new NationsBuilder();
    }
    public void Run()
    {
        
        string input = Console.ReadLine();

        while (input != "Quit")
        {
            List<string> inputArgs = input.Split(' ').ToList();
            ExecuteCommand(inputArgs);
            input = Console.ReadLine();
        }
        Console.WriteLine(builder.GetWarsRecord());
        
    }

    private void ExecuteCommand(List<string>args)
    {
        string cmd = args[0];

        switch (cmd)
        {
            case "Bender":
                builder.AssignBender(args);
                break;
            case "Monument":
                builder.AssignMonument(args);
                break;
            case "Status":
                string nationType = args[1];
                Console.WriteLine(builder.GetStatus(nationType));                
                break;
            case "War":
                string nation = args[1];
                builder.IssueWar(nation);
                break;
            default:
                break;
        }

    }
}

