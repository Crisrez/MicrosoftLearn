/*string[] fraudulentOrderIDs = new string [3];

fraudulentOrderIDs [0] = "A123";
fraudulentOrderIDs [1] = "B456";
fraudulentOrderIDs [2] = "C789";

//fraudulentOrderIDs [3] = "D000";
*/

/*
string[] fraudulentOrderIDs = { "A123", "B456" , "C789" };


Console.WriteLine($"Primer: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Tercero: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs [0] = "F000";

Console.WriteLine($"Reasignacion del Primero: {fraudulentOrderIDs[0]}");

Console.WriteLine($"Se estan procesando {fraudulentOrderIDs.Length} ordenes fraudulentas.");
*/

/*
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

Console.Clear();

foreach (int item in inventory)
{
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Total acumulativo: {sum})");
}

Console.WriteLine($"Tenemos {sum} items en el inventario.");
*/

string[] fraudulentOrderIDs = 
{
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

Console.Clear();

foreach (string ID in fraudulentOrderIDs)
{
    if (ID.StartsWith("B"))
    {
        Console.WriteLine(ID);
    }
}