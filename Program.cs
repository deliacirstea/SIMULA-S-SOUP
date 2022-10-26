/*Solution from teacher
 * sadly not my work*/


Console.Title = "SIMULA’S SOUP";
(SoupType type, MainIngredient ingredient, Seasoning seasoning) soup = GetSoup();
Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");


(SoupType, MainIngredient, Seasoning) GetSoup()
{
    SoupType type = GetSoupType();
    MainIngredient ingredient = GetMainIngredient();
    Seasoning seasoning = GetSeasoning();
    return (type, ingredient, seasoning);
}


SoupType GetSoupType()
{
    Console.WriteLine("Soup type (soup, stew, gumbo): ");
    string input = Console.ReadLine();
    return input switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo,
    };
}

MainIngredient GetMainIngredient ()
{
    Console.WriteLine("Main ingredient (mushroom, chicken, carrot, potato):");
    string input = Console.ReadLine ();
    return input switch
    {
        "mushroom" => MainIngredient.Mushroom,
        "chicken" => MainIngredient.Chicken,
        "carrot" => MainIngredient.Carrot,
        "potato" => MainIngredient.Potato,

    };
}

Seasoning GetSeasoning ()
{
    Console.WriteLine("Seasoning (spicy, salty, sweet):");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet,
    };

}
enum SoupType { Soup, Stew, Gumbo}
enum MainIngredient { Mushroom,Chicken, Carrot, Potato}
enum Seasoning { Spicy, Salty, Sweet}
