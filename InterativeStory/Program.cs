

Console.WriteLine("Du bifiner dig vid en klippa");

Console.WriteLine("");

Console.WriteLine("går du fram eller går du iväg?");

string sv1 = Console.ReadLine();
string hop = "hopa";
string sv2 = "d";

if(sv1 == "Fram")
{
    Console.WriteLine("du är en idiot och faller långsamt till din död efter!");
    // Det här kommer att förklara sig sälv senare
}

else
{
    Console.WriteLine("Du bakkar iväg från klippan och när du vänder dig om ser du...");

    Console.WriteLine("När du vänder dig om ser du en grupp hungriga vargar...");

    Console.WriteLine("Vad ska du göra ,SLÅSS emot eller ,HOPA, av berget");

    hop = Console.ReadLine();
    
}

if(hop != "hopa")
{
    Console.WriteLine("Du trode du var en super hjälte och dog för det");
}

else
{
    Console.WriteLine("Du vaknar up i en skog...");
    Console.WriteLine("Efter du vakna så känner du grov smärta i benen...");
    Console.WriteLine("När du kollar ner ser du dina ben är brytna!");
    Console.WriteLine("Men när du ser mot dinna ben ser du något som ser ut som en stuga...");
    Console.WriteLine("Du tängker på två val stanna och dö eller försöka crypa...");
    Console.WriteLine("vad gör du ,stanna, eller ,crypa ");
    sv2 = Console.ReadLine();
    
    if(sv2 == "stanna")
    {
        Console.WriteLine("du valde att stanna men när du väntar på din död så ser du något i skogen...");
        Console.WriteLine("Du börjar att undra vad det är men har ingen energi från att du har väntat så länge..");
        Console.WriteLine("sen ser du mer saker komma från skogen du märker att det är varjar");
        Console.WriteLine("de ser ut som att de är hungriga och de var din sista tanke inan de började slita dig i bitar");
    }

    else
    {
        Console.WriteLine("du långsamt cryper mot stugan...");
        Console.WriteLine("varje stund käner du smärtan i benen blir värre men dit mål av stugan gör så att du forsäter");
        Console.WriteLine("när du är nästan vid stugan hör du något från skogen");
        Console.WriteLine("Du börjar att undra vad det är men har ingen energi från att du har crypt så länge..");
        Console.WriteLine("sen ser du mer saker komma från skogen du märker att det är varjar");
        Console.WriteLine("de ser ut som att de är hungriga och de var din sista tanke inan de började slita dig i bitar");
    
    }
}

Console.ReadLine();
