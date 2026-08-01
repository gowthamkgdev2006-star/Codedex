using System;

class karaoke
{
  static void Main ()
  {
    string artist = "Goku";
    int volume = 99;
    int energyDrinks = 2;

    if(artist =="Goku" && volume >= 70 && energyDrinks >= 1)
    {
      Console.WriteLine("Gimme that mic! 🎤");
    }
    else if(artist =="Goku" && volume < 70)
    {
      Console.WriteLine("I need a louder song! 🔊");
    }
    else
    {
      Console.WriteLine("Maybe next time... 😴");
    }
  }
} 
