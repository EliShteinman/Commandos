namespace Commandos;

public class AirCommando : Commando
{
    public AirCommando(string name, string codeName) : base(name, codeName)
    {
        
    }
    
    public void Parachute()
    {
        this.Status = "Can parachute";
        Console.WriteLine($"is {Status}");
    }

    public override void Attack()
    {
        Console.WriteLine("Air commando soldier attacks!");
    }
}