/// SWITCH CASE YAPISI İLE


Console.WriteLine("\nRÜYA MANAVIIII HOŞGELDİNİZZ.....Ne veriyim abime? Elma-Armut-Cilek-Muz???\n");
string istek = Console.ReadLine().ToLower();


switch (istek)
{
    case "elma":
        Console.WriteLine("\n Elma 2 lari");
        break;
    case "elma":
        Console.WriteLine("\n Armut 3 lari");
        break;
    case "elma":
        Console.WriteLine("\n Çilek 4 lari");
        break;
    case "elma":
        Console.WriteLine("\n Muz 5 lari");
        break;

    default:
        Console.WriteLine("doğru meyveyi girelim tşk");
        return;
}



/// IF-ELSE

Console.WriteLine("\nRÜYA MANAVIIII HOŞGELDİNİZZ.....Ne veriyim abime? Elma-Armut-Cilek-Muz???\n");
string istek = Console.ReadLine().ToLower();

if(istek == "elma")
{
    Console.WriteLine("Elma 2 lira hemşerim");
}
else if(istek =="armut")
{
    Console.WriteLine("Armut 3 lira hemşerim");
}
else if (istek == "cilek")
{
    Console.WriteLine("Cilek 4 lira hemşerim");
}
else if (istek == "muz")
{
    Console.WriteLine("Muz 5 lira hemşerim");
}
else
{
    Console.WriteLine("Meyve yanlış hemşooooo");
}
