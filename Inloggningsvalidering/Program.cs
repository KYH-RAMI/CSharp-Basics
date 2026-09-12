Console.WriteLine("03 Inloggningsvalidering");
Console.WriteLine("======================");
Console.Write("Användarnamn: ");
string username = Console.ReadLine();
Console.Write("Lösenord: ");
string password = Console.ReadLine();

if (username == "admin" && password == "password") { 
    Console.WriteLine("True!");
}
else
{
    Console.WriteLine("False!"); 
}
Console.WriteLine("======================");
Console.WriteLine("\nTryck på en tangent för att avsluta...");
Console.ReadKey();