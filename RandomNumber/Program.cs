
Random rnd = new Random();

int MyRandomnum;

int randomSum = 0;


for (int i = 1; i < 5;  i++)
{
   MyRandomnum = rnd.Next(0, 50);// 0 - 10
    randomSum = randomSum + MyRandomnum;
    Console.WriteLine($"My random number is: {MyRandomnum}");
}
Console.WriteLine($"Random sum total: {randomSum}");