Random dice = new();

int heroHealth = 10;
int monsterHealth = 10;

do
{
    int damage = dice.Next(10);
    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

    if (monsterHealth > 0)
    {
        damage = dice.Next(10);
        heroHealth -= damage;
        Console.WriteLine($"Hero was damaged and lost {damage} health and now has {monsterHealth} health.");
    }
    
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth > 0)
    Console.WriteLine("Hero wins!");
else if (monsterHealth > 0)
    Console.WriteLine("Mosnter wins!");