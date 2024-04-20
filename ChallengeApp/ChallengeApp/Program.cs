using ChallengeApp;

int score = 0,
    highestScore = 0,
    employeeIndex = 0;

Employee[] employees = { new("Wojtek", "Jarzynski", 48), new("Filip", "Nowak", 67), new("Jacek", "Lewandowski", 21), new("Damian", "Mickiewicz", 14) };

// Nadawanie pracownikom ocen
employees[0].AddScore(1);
employees[0].AddScore(7);
employees[0].AddScore(3);
employees[0].AddScore(4);

employees[1].AddScore(9);
employees[1].AddScore(10);
employees[1].AddScore(1);
employees[1].AddScore(7);

employees[2].AddScore(5);
employees[2].AddScore(2);
employees[2].AddScore(8);
employees[2].AddScore(5);

// Wyszukiwanie pracownika z najwieksza suma ocen
for (int i = 0; i < employees.Length; i++)
{
    score = employees[i].Result;
    if (score > highestScore)
    {
        highestScore = score;
        employeeIndex = i;
    }
}

// Wyswietlenie danych i wyniku najlepszego pracownika (z najwieksza liczba sumy ocen)
Console.WriteLine($"Najlepszym pracownikiem jest {employees[employeeIndex].FirstName} " +
    $"{employees[employeeIndex].LastName} ktory ma  {employees[employeeIndex].Age} lat z wynikiem {highestScore}");