using System;

class argument
{
  static void Main()
  {
    int numberOfSources = 3;
    bool hasPhotos = true;
    bool hasWitness  = false;
    double percentageKeptSerious = 0.77;

    if(numberOfSources >= 3 && hasPhotos || hasWitness && percentageKeptSerious >= 0.75)
    {
      Console.WriteLine("I'm starting to believe you... 🤔");
    }
    else
    {
      Console.WriteLine("I'm not convinced. 😅");
    }
  }
}
