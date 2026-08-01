using System;

class PR_Nightmare
{
  static void Main()
  {
    int riskScore = 0;

    Console.WriteLine("How many days ago was the post made?");
    int days = int.Parse(Console.ReadLine());
    Console.WriteLine("How many people saw the post?");
    int saw = int.Parse(Console.ReadLine());
    Console.WriteLine("Did the celebrity already apologize? (yes/no)");
    string apologize = Console.ReadLine();
    Console.WriteLine("Is this the celebrity's first PR crisis? (yes/no)");
    string PRcrisis = Console.ReadLine();

    if(saw > 100000)
    {
      riskScore += 100;
    }
    else if(apologize == "no")
    {
      riskScore += 50;
    }
    else if(PRcrisis == "no")
    {
      riskScore += 25;
    }

    int sub = days*10;
    riskScore -= sub;

    if(riskScore < 50)
    {
      Console.WriteLine("No action needed yet. Wait and see. 😮‍💨");
    }
    else if(riskScore <= 149)
    {
      Console.WriteLine("Keep monitoring the situation. 👀");
    }
    else
    {
      Console.WriteLine("Release a public statement! 📢");
    }
  }
}

