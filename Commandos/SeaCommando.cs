namespace Commandos;

public class SeaCommando : Commando
{
    public SeaCommando(string name, string codeName) : base(name, codeName)
    {
        
    }
    public void Swim()
    {
        this.Status = "Can swim";
        Console.WriteLine($"is {Status}");
    }

    public override void Attack()
    {
        Console.WriteLine("Sea commando soldier attacks!");
    }
}