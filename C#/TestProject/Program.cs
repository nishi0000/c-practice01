
Random random = new Random();
int attackPoint = random.Next(1, 11);

int heroHp = 10;
int MonsHp = 10;

string trun = "Hero";

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);







