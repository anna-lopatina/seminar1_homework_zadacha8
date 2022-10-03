// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine()!);
int x = 1;
while (x < N) {
    if (x % 2 == 0) { 
        Console.WriteLine("{0} четное число", x);
    }

    x += 1;
}