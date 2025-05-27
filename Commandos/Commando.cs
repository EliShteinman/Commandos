namespace Commandos;

public class Commando
{
    private string name;
    private string codeName { get; set; }
    private string[] gear;
    private string status;
    
    public Commando(string name, string codeName)
    {
        this.name = name;
        this.codeName = codeName;
        this.gear = new string[5];
        status = "Standing";
    }

    public void Walk()
    {
        status = "Walking";
        Console.WriteLine($"is {status}");
    }

    public void Hide()
    {
        status = "Hiding";
        Console.WriteLine($"is {status}");
    }

    public void Attack()
    {
        Console.WriteLine($"is attacking");  
    }
    
    public string SayName(string commanderRank)
    {
        switch (commanderRank.ToUpper())
        {
            case "GENERAL":
                return name;
            case "COLONEL":
                return codeName;
            default:
                return "Your level is too low to receive the information.";
        }
    }
}