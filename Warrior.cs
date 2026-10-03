namespace ConsoleGame;

class Warrior : Character
{
    public int Armor { get; set; }

    public Warrior(string name, int health, int damage, int armor)
        : base(name, health, damage)
    {
        Armor = armor;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with a sword");
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
        target.TakeDamage(Damage);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Armor: {Armor}";
    }
}