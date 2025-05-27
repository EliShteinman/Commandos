namespace Commandos;

public class Commando
{
    private string Name {get; set;}
    private string CodeName {get; set;}
    private string[] Gear {get; set;}
    private string Status {get; set;}
    
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
        Console.WriteLine($"{Name} is walking");
    }

    public void Hide()
    {
        Status = "Hiding";
        Console.WriteLine($"{Name} is hiding");
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} is attacking");  
    }
}