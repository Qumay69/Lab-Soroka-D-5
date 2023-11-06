////Средний уровень Вариант 23
//try
//{
//    Console.Write("Введите n:");
//    double n = double.Parse(Console.ReadLine());
//    double S = 0;
//    for (int k = 1; k <= n; k++)
//    {
//        double factorial = 1;
//        for (int i = 1; i <= k; i++)
//        {
//            factorial *= i;
//        }
//        S += (Math.Pow(k - 4, 3) * (k + 7)) / factorial;
//    }
//    Console.WriteLine($"S={S:F2}");
//}
//catch { Console.WriteLine("Ошибка"); }

////Высокий уровень Вариант 23
//Random rnd = new Random();
//int correct = 0;

//for (int i = 0; i < 10; i++)
//{
//    int a = rnd.Next(1, 10);
//    int b = rnd.Next(1, 10);
//    Console.Write($"{a}*{b}=");
//    int answer = int.Parse(Console.ReadLine());
//    if (answer == a * b)
//    {
//        correct++;
//    }
//}
//switch (correct)
//{
//    case 0: case 1: case 2: case 3: case 4: case 5: { Console.WriteLine("Плохо"); }; break;
//    case 6: case 7: { Console.WriteLine("Удовлетворительно"); }; break;
//    case 8: case 9: { Console.WriteLine("Хорошо"); }; break;
//    case 10: { Console.WriteLine("Отлично"); }; break;
//}
