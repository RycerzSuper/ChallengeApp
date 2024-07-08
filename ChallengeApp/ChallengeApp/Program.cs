using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();

Employee employee1 = new Employee("Adam", "Nowak", 45);

while (true)
{
    Console.WriteLine("Prosze o podanie ocene pracownika: ");
    Console.WriteLine("Nacisnij q zeby zakonczic");
    while (true)
    {
        var input = Console.ReadLine();
        if (input == "q" || input == "Q")
        {
            break;
        }
        employee1.AddGrade(input);
    }

    var statistics = employee1.GetStatistics();
    Console.WriteLine($"Srednia: {statistics.AverageLetter}");
    Console.WriteLine($"Najmniejsza: {statistics.Min}");
    Console.WriteLine($"Najwieksza: {statistics.Min}");
}