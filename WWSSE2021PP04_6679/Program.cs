/*
    Napisz program, który pyta użytkownika o podanie trzech liczb całkowitych (liczby te należy interpretować 
    jako kolejne współczynniki równania kwadratowego) i w wyniku wypisuje komunikat z pierwiastkami 
    tego równania lub komunikat o braku rozwiązania.
*/

Console.WriteLine("1. Podaj liczbe calkowitą (współczynnik a): ");
double a = double.Parse(Console.ReadLine());

if(a == 0)
{
    Console.WriteLine("Współczynnik 'a' nie może być równy zero.");
}
else
{
    Console.WriteLine("1. Podaj liczbe calkowitą (współczynnik b): ");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("1. Podaj liczbe calkowitą (współczynnik c): ");
    double c = double.Parse(Console.ReadLine());

    double delta = (b * b) - (4 * a * c);

    if(delta > 0) // dwa rozwiązania
    {
        Console.WriteLine("Pierwsze rozwiązanie: x = {0}", (-b - Math.Sqrt(delta)) / (2 * a));
        Console.WriteLine("Drugie rozwiązanie: x = {0}", (-b + Math.Sqrt(delta)) / (2 * a));
    }
    else if(delta == 0) // jedno rozwiązanie
    {
        Console.WriteLine("Jedno rozwiązanie: x = {0}", -b/(2 * a));
    }
    else if(delta < 0) // brak rozwiązań
    {
        Console.WriteLine("To równanie kwadratowe nie ma rozwiązań.");
    }
}