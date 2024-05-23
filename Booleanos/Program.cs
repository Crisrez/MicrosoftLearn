/*
Random coin = new();

Console.WriteLine($"{(coin.Next(2) == 0 ? "heads" : "tails")}");
*/

Random dice = new();

string permission = (dice.Next(100) % 2 == 0 ? "Admin" : "Manager");
int level = dice.Next(100);

string message = "";

if (level >= 55 && permission.Contains("Admin"))
    message = "Welcome, Super Admin user.";
else if (level < 55 && permission.Contains("Admin"))
    message = "Welcome, Admin user.";
else if (level >= 20 && permission.Contains("Manager"))
    message = "Contact an Admin for access.";
else if (level < 20 && permission.Contains("Manager"))
    message = "You do not have sufficient privileges.";
else
    message = "You do not have sufficient privileges.";

Console.WriteLine($"{permission}\t{level}:");
Console.WriteLine(message);