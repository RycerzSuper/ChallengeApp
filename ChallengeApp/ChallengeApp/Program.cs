int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
int count5 = 0;
int count6 = 0;
int count7 = 0;
int count8 = 0;
int count9 = 0;
int count0 = 0;

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

foreach (char letter in letters)
{
    if (letter == '1')
    {
        count1++;
    }
    else if (letter == '2')
    {
        count2++;
    }
    else if (letter == '3')
    {
        count3++;
    }
    else if (letter == '4')
    {
        count4++;
    }
    else if (letter == '5')
    {
        count5++;
    }
    else if (letter == '6') 
    {
        count6++;
    }
    else if (letter == '7')
    {
        count7++;
    }
    else if (letter == '8')
    {
        count8++;
    }
    else if (letter == '9')
    {
        count9++;
    }
    else if (letter == '0') 
    {
        count0++;
    }
}

Console.WriteLine("Ilość 0:");
Console.WriteLine(count0);
Console.WriteLine("Ilość 1:");
Console.WriteLine(count1);
Console.WriteLine("Ilość 2:");
Console.WriteLine(count2);
Console.WriteLine("Ilość 3:");
Console.WriteLine(count3);
Console.WriteLine("Ilość 4:");
Console.WriteLine(count4);
Console.WriteLine("Ilość 5:");
Console.WriteLine(count5);
Console.WriteLine("Ilość 6:");
Console.WriteLine(count6);
Console.WriteLine("Ilość 7:");
Console.WriteLine(count7);
Console.WriteLine("Ilość 8:");
Console.WriteLine(count8);
Console.WriteLine("Ilość 9:");
Console.WriteLine(count9);
