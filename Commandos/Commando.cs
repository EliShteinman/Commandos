namespace Commandos;

public class Commando
{
    protected string Name { get; set; }
    public string CodeName { get; protected set; }
    protected string[] Gear { get; set; }
    protected string Status { get; set; }
    
    public Commando(string name, string codeName)
    {
        Name = name;
        CodeName = codeName;
        Gear = new string[5];
        Status = "Standing";
    }

    public void Walk()
    {
        Status = "Walking";
        Console.WriteLine($"is {Status}");
    }

    public void Hide()
    {
        Status = "Hiding";
        Console.WriteLine($"is {Status}");
    }

    public virtual void Attack()
    {
        Console.WriteLine($"is attacking");  
    }
    
    public string SayName(string commanderRank)
    {
        return ClearanceHandler.GetName(commanderRank, Name, CodeName);
    }
}