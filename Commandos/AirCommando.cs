namespace Commandos;

public class AirCommando : Commando
{
    public AirCommando(string name, string codeName) : base(name, codeName)
    {
        
    }
    
    public void Parachute()
    {
        this.status = "Can parachute";
        Console.WriteLine($"is {status}");
    }
}