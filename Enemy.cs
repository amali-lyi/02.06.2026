namespace ConsoleGame;

class Enemy : Character
{
    public int Level { get; set; }

    public Enemy(string name, int health, int damage, int level)
        : base(name, health, damage)
    {
        Level = level;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks");
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
        target.TakeDamage(Damage);
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Level: {Level}";
    }
}