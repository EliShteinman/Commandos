namespace Commandos;

class Program
{
    static void Main()
    {
        Commando commando = new Commando("John Mason", "Shadow");
        SeaCommando seaCommando = new SeaCommando("Lena Torres", "Falcon");
        AirCommando airCommando = new AirCommando("David Adler", "Ghost");
        Commando[] commandos = [commando, seaCommando, airCommando];
        foreach (Commando soldier in commandos)
        {
            soldier.Attack();
        }
        
        
    }
}