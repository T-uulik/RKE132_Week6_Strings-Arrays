string hello = "Hello, world!".ToLower();

int counter = 0;

for(int i = 0; i < 13; i++)
{
    if (hello[i] == 'l')
    {
        counter++;
    }
}
Console.WriteLine($"There are {counter} l's in the string \"{hello}\"");