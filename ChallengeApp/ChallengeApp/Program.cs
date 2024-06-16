using ChallengeApp;

Employee employee1 = new Employee("Adam", "Nowak", 45);

employee1.AddGrade(3);
employee1.AddGrade(8);
employee1.AddGrade("10");
employee1.AddGrade(7000);

var statistics = employee1.GetStatistics();
var statistics1 = employee1.GetStatisticsWithWhile();
var statistics2 = employee1.GetStatisticsWithDoWhile();
var statistics3 = employee1.GetStatisticsWithFor();

Console.WriteLine("Foreach");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");

Console.WriteLine("While");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min:N2}");
Console.WriteLine($"Max: {statistics1.Max:N2}");

Console.WriteLine("Dowhile");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min:N2}");
Console.WriteLine($"Max: {statistics2.Max:N2}");

Console.WriteLine("For");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min:N2}");
Console.WriteLine($"Max: {statistics3.Max:N2}");
