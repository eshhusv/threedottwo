Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int answer = 0;

int i = 1;
do
{
    if (num % i == 0) answer = i;
    i++;
} while (i < num);

Console.Write(answer);