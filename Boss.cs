namespace ConsoleGame;

sealed class Boss : Enemy
{
    public Boss(string name, int health, int damage, int level)
        : base(name, health, damage, level)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks as a boss!");
    }
}