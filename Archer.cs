namespace ConsoleGame;

class Archer : Character
{
    public int Arrows { get; set; }

    public Archer(string name, int health, int damage, int arrows)
        : base(name, health, damage)
    {
        Arrows = arrows;
    }

    public override void Attack()
    {
        if (Arrows > 0)
        {
            Console.WriteLine($"{Name} attacks with a bow");
        }
        else
        {
            Console.WriteLine($"{Name} has no arrows");
        }
    }

    public override void Attack(Character target)
    {
        if (Arrows > 0)
        {
            Console.WriteLine($"{Name} attacks {target.Name}");
            target.TakeDamage(Damage);
            Arrows--;
        }
        else
        {
            Console.WriteLine($"{Name} has no arrows");
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Arrows: {Arrows}";
    }
}