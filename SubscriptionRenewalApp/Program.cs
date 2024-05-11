// See https://aka.ms/new-console-template for more information

using System;

namespace SubscriptionRenewalApp
{
  class Program
  {

    static void Main(string[] args)
    {

      Random random = new Random();
      int daysUntilExpiration = random.Next(12);
      int discountPercentage = 0;

      switch (daysUntilExpiration)
      {
        case 0:
          Console.WriteLine("Your subscription has expired.");
          break;

        case 1:
          discountPercentage = 20;
          Console.WriteLine($"Your subscription expires within a day!");
          break;

        case <= 5:
          discountPercentage = 10;
          Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
          break;

        case <= 10:
          Console.WriteLine("Your subscription will expire soon. Renew now!");
          break;

        default:
          Console.WriteLine("");
          break;
      }

      if (discountPercentage > 0)
      {
        Console.WriteLine($"Renew now and save {discountPercentage}%.");
      }

      // if (daysUntilExpiration > 10)
      // {
      //   Console.WriteLine("");
      // }
      // else if (daysUntilExpiration == 1)
      // {
      //   discountPercentage = 20;
      //   Console.WriteLine($"Your subscription expires within a day!");
      // }
      // else if (daysUntilExpiration == 0)
      // {
      //   Console.WriteLine("Your subscription has expired.");
      // }
      // else if (daysUntilExpiration <= 5)
      // {
      //   discountPercentage = 10;
      //   Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
      // }
      // else if (daysUntilExpiration <= 10)
      // {
      //   Console.WriteLine("Your subscription will expire soon. Renew now!");
      // }

      // if (discountPercentage > 0)
      // {
      //   Console.WriteLine($"Renew now and save {discountPercentage}%.");
      // }

    }
  }
}

