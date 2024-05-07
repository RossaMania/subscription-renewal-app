// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

//  If the user's subscription will expire in 10 days or less, display the message: Your subscription will expire soon. Renew now!

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

//  If the user's subscription will expire in five days or less, display the messages: Your subscription expires in _ days.
// Renew now and save 10%!
// Be sure to replace the _ character displayed in the message above with the value stored in the variable daysUntilExpiration when you construct your message output.

if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}

// If the user's subscription will expire in one day, display the messages:
// Your subscription expires within a day!
// Renew now and save 20%!

if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
}

// If the user's subscription has expired, display the message:
// Your subscription has expired.

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}

// If the user's subscription doesn't expire in 10 days or less, display nothing.

if (daysUntilExpiration > 10)
{
    Console.WriteLine("");
}