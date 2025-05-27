namespace Commandos;

public class Weapon
{
    private string Name {get; set;}
    private string Manufacturer {get; set;}
    private int BulletCount {get; set;}
    
    public Weapon(string name, string manufacturer, int bulletCount)
    {
        Name = name;
        Manufacturer = manufacturer;
        BulletCount = bulletCount;
    }

    public void Shoot()
    {
        BulletCount--;
        Console.WriteLine("Bullet fired");
    }
}