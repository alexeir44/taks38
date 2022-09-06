int [] RandomArray = {0, 0, 0, 0, 0, 0, 0, 0};
byte i; 
int result = 0;

// Проверка на нечетность индекса
bool UnHonestIndex(int index)
{
    if (index%2 != 0)
        return (true);
    else
        return (false);
}

// Код программы
for (i = 0; i<RandomArray.Length; i++)
{
    RandomArray[i] = new Random().Next(1, 100);
    Console.Write($"{RandomArray[i]} ");
}
Console.WriteLine("");

for (i = 0; i<RandomArray.Length; i++)
{
    if (UnHonestIndex(i)==true)
    result += RandomArray[i];
}

Console.Write($"Сумма эелемнтов нечетных индексов = {result}");