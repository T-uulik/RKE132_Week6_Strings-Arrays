string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian food", };

Random rng = new Random();

int randomIndex = rng.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}");