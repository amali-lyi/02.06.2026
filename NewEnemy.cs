namespace ConsoleGame;

class NewEnemy : Enemy
{
    public NewEnemy(string name, int health, int damage, int level)
        : base(name, health, damage, level)
    {
    }

    public new void Attack()
    {
        Console.WriteLine($"{Name} uses new Attack()");
    }
}