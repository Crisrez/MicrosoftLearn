/*
1 - Enumere toda nuestra información de mascotas actual.
2 - Asigne valores a los campos de la matriz ourAnimals.
3 - Asegúrese de que las edades y las descripciones físicas de los animales estén completas.
4 - Asegúrese de que los alias y las descripciones de personalidad de los animales estén completos.
5 - Edite la edad de un animal.
6 - Edite la descripción de personalidad de un animal.
7 - Muestre todos los gatos con una característica especificada.
8 - Muestre todos los perros con una característica especificada.
*/

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

bool exit = false;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
Console.Clear();

do
{
    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    do
    {
        readResult = Console.ReadLine();
    } while (readResult == null);


    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    Console.WriteLine();
    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            ViewListAnimal();
            break;

        case "2":
            AddNewPet();
            break;

        case "3":
            VerificationAgePhysical();
            break;

        case "4":
            VerificationNicknamePersonality();
            break;

        case "5":
            EditAge();
            break;

        case "6":
            EditPersonality();
            break;

        case "7":
            ViewAllCatsSpecific();
            break;

        case "8":
            ViewAllDogsSpecific();
            break;

        case "exit":
            exit = true;
            break;
    };

} while (!exit);


void ViewListAnimal()
{
    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0].Substring(6) != "")
        {
            for (int j = 0; j < 6; j++)
            {
                Console.WriteLine(ourAnimals[i, j]);
            };
            Console.WriteLine();
        };
    };
    Console.WriteLine("Press the Enter key to continue");
    Console.ReadLine();
};

void AddNewPet()
{
    string anotherPet = "y";
    int petCount = 0;

    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0].Substring(6) == "")
        {
            petCount++;
        }
    }

    Console.WriteLine($"Tenemos {petCount} mascotas que buscan un hogar.");
    Console.WriteLine("Desea cargar una mascota nueva? (y/n)");

    do
    {
        readResult = Console.ReadLine();

        if (readResult != null)
        {
            anotherPet = readResult.ToLower();
        }

    } while (anotherPet != "y" && anotherPet != "n");

    if (petCount <= maxPets && anotherPet == "y")
    {
        Console.WriteLine("Ingrese la informacion del nuevo animal: ");

        for (int j = 1; j < 6; j++)
        {
            Console.Write($"{ourAnimals[petCount, j]}");

            do
            {
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    Console.WriteLine(readResult);
                    ourAnimals[petCount, j] += readResult.ToLower();
                }

            } while (readResult == null);

        }
    }
    
    else if (petCount == maxPets)
    {
        Console.WriteLine("No tenemos espacio suficiente para recibir nuevas mascotas.");
    }

    if (ourAnimals[petCount, 1].Contains("cat"))
    {
        petCount++;
        ourAnimals[petCount, 0] += "c" + petCount;
    }
    else if (ourAnimals[petCount, 1].Contains("dog"))
    {
        petCount++;
        ourAnimals[petCount, 0] += "d" + petCount;
    }

    Console.WriteLine();
    Console.WriteLine("Press the Enter key to continue");
    Console.ReadLine();


};

void VerificationAgePhysical()
{
    Console.WriteLine(ourAnimals.Length);
};

void VerificationNicknamePersonality()
{

};

void EditAge()
{

};

void EditPersonality()
{

};

void ViewAllCatsSpecific()
{

};

void ViewAllDogsSpecific()
{

};