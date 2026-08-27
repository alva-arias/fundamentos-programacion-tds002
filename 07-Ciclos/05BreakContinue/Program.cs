for (int i = 1; i <= 50; i++)
{
    if (i > 30 && i % 7 == 0)
    {
        break;
    }

    if (i % 3 == 0)
    {
        continue;
    }

    Console.WriteLine(i);
}
