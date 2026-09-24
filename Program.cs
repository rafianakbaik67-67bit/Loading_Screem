int TotalSteps = 10;

for (int step = 1; step <= TotalSteps; step++)
{
    Console.WriteLine($"Loading..step{step}of{TotalSteps}");
    if (step % 3 == 0)
        Console.WriteLine("Checkpoint reached");
}

Console.WriteLine("\nDungeon is ready. Enter now!");