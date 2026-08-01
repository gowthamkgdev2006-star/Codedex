using System;

class Pokemon
{
  static void Main()
  {
    Console.WriteLine("What Pokémon card do you have?");
    string trade = Console.ReadLine();
    
    if(trade == "MewTwo")
    {
      Console.WriteLine("Trade accepted! 🤝");
    }
    else
    {
      Console.WriteLine("Sorry, I don't want that card. 🙂‍↔️");
    }
  }
}
