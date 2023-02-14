//From 1 to 100
//If a number is divisible by 3, the print “fizz” rather than the number.
//If a number is divisible by 5, print “buzz” rather than the number.
//If a number is divisible by both, print “fizzbuzz”
//Else print the number

for (int i = 1; i <= 100; i++)
{
    string print = string.Empty;

    if (i % 3 == 0)
    {
        print += "fizz";
    }

    if (i % 5 == 0)
    {
        print += "buzz";
    }

    if (string.IsNullOrEmpty(print))
    {
        print += i;
    }

    Console.WriteLine($"{print}");
}

// avec ternaire
for (int i = 1; i <= 100; i++)
{
    string print = string.Empty;

    print += i % 3 == 0 && i % 5 == 0 ? "fizzbuzz"
            : i % 3 == 0 ? "fizz"
            : i % 5 == 0 ? print += "buzz"
            : i.ToString();

    Console.WriteLine($"{print}");
}