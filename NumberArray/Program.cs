int[] numbers = new int[10];
Random rng = new Random();

int sum = 0;


for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rng.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach(int number in numbers)
{
   Console.WriteLine(number);
}

Console.WriteLine($"Total: {sum}");

