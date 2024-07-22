Random random = new Random();
int attackPoint = 0;

int heroHp = 10;
int monsterHp = 10;

string trun = "Hero";

do
{
    if (trun == "Hero")
    {
        attackPoint = random.Next(1, 11);
        monsterHp -= attackPoint;
        trun = "Monster";
        Console.WriteLine($"Monster was damaged and lost {attackPoint} health and now has {monsterHp} health.");
    }
    else
    {
        attackPoint = random.Next(1, 11);
        heroHp -= attackPoint;
        trun = "Hero";
        Console.WriteLine($"Hero was damaged and lost {attackPoint} health and now has {heroHp} health.");
    }
} while (monsterHp > 0 && heroHp > 0);


if (heroHp <= 0)
    Console.WriteLine("Hero loses...");
else
    Console.WriteLine("Hero wins!");


