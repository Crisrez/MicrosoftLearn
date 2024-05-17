/*Random dice = new();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;*/

Console.Clear();

/*Console.WriteLine($"Tirada de Dados: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 ==  roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Has conseguido un triple!! +6 Puntos extras al total");
        total += 6; 
    }
    else
    {
    Console.WriteLine("Has conseguido un doble!! +2 Puntos extras al total");
    total += 2;
    }
    Console.WriteLine($"Tu total sumando los puntos extras es de: {total}");
}

if (total >= 15)
{
    Console.WriteLine("Ganaste!!");
}
else
{
    Console.WriteLine("Lo siento, has perdido...");
}

if (total >= 16)
{
    Console.WriteLine("Ganaste un auto nuevo!!");
}
else if (total >= 10)
{
    Console.WriteLine("Ganaste una netbook nuevo!!");
}
else if (total == 7)
{
    Console.WriteLine("Ganaste un viaje!!");
}
else
{
    Console.WriteLine("Ganaste un gatito!!");
}*/

Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine($"Your subscription will expire soon. Renew now!");
}
Console.WriteLine(daysUntilExpiration);
