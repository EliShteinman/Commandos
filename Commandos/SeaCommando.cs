namespace Commandos;

public class SeaCommando : Commando
{
    public SeaCommando(string name, string codeName) : base(name, codeName)
    {
        
    }
    public void Swim()
    {
        this.status = "Can swim";
        Console.WriteLine($"is {status}");
    }

    public override void Attack()
    {
        Console.WriteLine("Sea commando soldier attacks!");
    }
}