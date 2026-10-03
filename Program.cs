namespace ConsoleGame;

class Program
{
    static void Main()
    {
        Warrior warrior = new Warrior("Warrior", 100, 20, 10);
        Mage mage = new Mage("Mage", 80, 30, 50);
        Archer archer = new Archer("Archer", 70, 25, 10);

        Enemy enemy = new Enemy("Enemy", 60, 15, 1);
        StrongEnemy strongEnemy = new StrongEnemy("Strong Enemy", 120, 25, 3);
        FastEnemy fastEnemy = new FastEnemy("Fast Enemy", 50, 20, 2);
        Boss boss = new Boss("Boss", 150, 35, 5);

        List<Character> characters = new List<Character>();

        characters.Add(warrior);
        characters.Add(mage);
        characters.Add(archer);
        characters.Add(enemy);
        characters.Add(strongEnemy);
        characters.Add(fastEnemy);
        characters.Add(boss);

        Console.WriteLine("Attacks:");

        foreach (Character currentCharacter in characters)
        {
            currentCharacter.Attack();
        }

        Console.WriteLine();

        Console.WriteLine("Attacks on targets:");

        warrior.Attack(enemy);
        mage.Attack(strongEnemy);
        archer.Attack(fastEnemy);

        Console.WriteLine();

        Console.WriteLine("Character states:");

        foreach (Character currentCharacter in characters)
        {
            Console.WriteLine(currentCharacter.ToString());
        }

        Console.WriteLine();

        Console.WriteLine("is example:");

        Character testCharacter = mage;

        if (testCharacter is Mage)
        {
            Console.WriteLine(testCharacter.Name + " is a Mage");
        }

        Console.WriteLine();

        Console.WriteLine("Upcasting:");

        Character upcastCharacter = new Mage("Upcast Mage", 90, 25, 40);
        Console.WriteLine(upcastCharacter.ToString());

        Console.WriteLine();

        Console.WriteLine("override and new:");

        Character overrideCharacter = strongEnemy;
        overrideCharacter.Attack();

        NewEnemy newEnemy = new NewEnemy("New Enemy", 100, 20, 2);

        newEnemy.Attack();

        Character newCharacter = newEnemy;
        newCharacter.Attack();
    }
}