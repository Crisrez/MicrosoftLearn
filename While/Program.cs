/*
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
    Console.WriteLine("Monster wins!");

*/

/*
string? readResult;
int readNumber;
bool validNumber = false;

Console.Write("Ingrese un valor entre 5 y 10: ");

do
{
    readResult = Console.ReadLine();
    int.TryParse(readResult, out readNumber);

    if (readNumber < 5 || readNumber > 10)
    {
        Console.WriteLine("Ha ingresado un valor erroneo.");
        Console.Write("Favor de ingresar un valor entre 5 y 10: ");
        validNumber = false;
    }
    else
    {
        validNumber = true;
    }
    
} while (!validNumber);

Console.WriteLine("Se ha aceptado el valor ingresado! Muchas Gracias.");
*/

/*
string? userRol;
string[] possibleRols = new[] { "administrador", "director", "usuario" };
bool validRol = false;

Console.WriteLine("Dados los siguientes roles: \n\tAdministrador.\n\tDirector.\n\tUsuario.");
Console.Write("Eliga un rol valido: ");

do
{
    userRol = Console.ReadLine();

    if (userRol != null)
    {
        foreach (string rol in possibleRols)
        {
            //validRol = rol == userRol ? true : false;
            if (userRol.Trim().ToLower() == rol)
                validRol = true;
        }   
    }
    
    if (!validRol)
        Console.Write($"El rol \"{userRol}\" no es valido, favor de ingresar un rol valido: ");

} while (!validRol);

Console.WriteLine("Se le ha asignado el rol solicitado. Muchas gracias.");
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];

    periodLocation = myString.IndexOf(".");
    
    while (periodLocation >= 0)
    {
        Console.WriteLine(myString.Remove(periodLocation));

        myString = myString.Substring(periodLocation + 1).TrimStart();

        periodLocation = myString.IndexOf(".");
    }

    Console.WriteLine(myString);
}