for (int i = 1; i <= 100; i++)
{
    string categoria = " - ";
    
    if (i % 3 == 0) categoria += "Fizz";
    if (i % 5 == 0) categoria += "Buzz";

    if (categoria == " - ") Console.WriteLine($"{i}");
    else Console.WriteLine($"{i}{categoria}");
}