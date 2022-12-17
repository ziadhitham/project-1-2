int startingNumber, endingNumbeer;
Console.WriteLine("Get All Perfect In Range of Between two Number");
Console.Write("Enter Starting Number : ");
startingNumber = int.Parse(Console.ReadLine());
Console.Write("Enter Ending Number : ");
endingNumbeer = int.Parse(Console.ReadLine());

Console.WriteLine("Below are the perfect number between " + startingNumber + " and " + endingNumbeer);

for (int i = startingNumber; i <= endingNumbeer; i++)
{
    decimal sum = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
            sum = sum + j;
    }
    if (sum == i)
        Console.WriteLine("\t" + i);
}

Console.ReadKey();