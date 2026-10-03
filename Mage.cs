namespace ConsoleGame;

class Mage : Character
{
    public int Mana { get; set; }

    public Mage(string name, int health, int damage, int mana)
        : base(name, health, damage)
    {
        Mana = mana;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with magic");
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
        target.TakeDamage(Damage);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Mana: {Mana}";
    }
}