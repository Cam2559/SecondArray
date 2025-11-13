int[] speechLevel = { 1, 5, 10, 15, 20, 25, 30, 40, 50 };
int[] sneakLevel = { 1, 10, 20, 30, 40, 50 };
string characterName = "Srimm Plim";


Console.WriteLine(" Speech Level Check");

for (int i = 0; i < speechLevel.Length; i++)
{
    int level = speechLevel[i];

    if (level < 10)
    {
        Console.WriteLine($"[{characterName}]: I don't quite trust ya' just yet. You'll have to wait out here. (Speech level: {level})");
    }
    else if (level >= 10 && level < 25)
    {
        Console.WriteLine($"[{characterName}]: You ain't as bad as I thought but i'm still gonna keep my eye on you. (Speech level: {level})");
    }
    else if (level >= 25 && level < 40)
    {
        Console.WriteLine($"[{characterName}]: You go on and head in i'll be in momentarlily.  (Speech level: {level})");
    }
    else
    {
        Console.WriteLine($"[{characterName}]: Got a gift waiting for you inside, hurry on now. (Speech level: {level})");
    }
}


Console.WriteLine("\nSneak Level Check");

for (int i = 0; i < sneakLevel.Length; i++)
    {
        int sneak = sneakLevel[i];

        switch (sneak)
        {
            case int n when (n > 40):
                Console.WriteLine($"[{characterName}]: Well you fooled me, I'd never had seen ya' if ya' hadn't talked to me.  (Sneak level: {sneak})");
                break;

            case int n when (n >= 40  && n < 25 ):
                Console.WriteLine($"[{characterName}]: Well hey, thats pretty good, but it's gonna take a bit more effort than that. (Sneak level: {sneak})");
                break;

            case int n when (n <= 25 && n > 10):
                Console.WriteLine($"[{characterName}]:If I had a bit more oil in these bolts you might've gotten by. (Sneak level: {sneak})");
                break;

            default:
                Console.WriteLine($"[{characterName}]: You are about as quite as a mouse gettin' it's tail steped on.  (Sneak level: {sneak})");
                break;
        }
    }

 Console.WriteLine("\nCharacter check completed.");
