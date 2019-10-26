using System;


namespace бинарный_поиск
{
    class Program
    {
        static int binPoisk(int b, int[] a)
        {
            int k;
            int L = 0;
            int R = a.Length - 1;
            k = (R + L) / 2;
            while (L < R - 1)
            {
                k = (R + L) / 2;
                if (a[k] == b)
                    return k;
                if (a[k] < b)
                    L = k;
                else
                    R = k;
            }
            if (a[k] != b)
            {
                if (a[L] == b)
                    k = L;
                else
                {
                    if (a[R] == b)
                        k = R;
                    else
                        k = -1;
                }
            }
            return k;
        }


        
        static void Main(string[] args)
        {
            int colvo;
            Console.WriteLine("Введите количество чисел в массиве натуральным числом");
            colvo = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[colvo];
            Random r = new Random();
            Console.WriteLine("Неотсортированный массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = r.Next(0, 100);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            int k;
            for (int i = 0; i < colvo - 1; i++)
            {
                for (int j = i + 1; j < colvo; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        k = mas[i];
                        mas[i] = mas[j];
                        mas[j] = k;
                    }
                }
            }
            
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < colvo; i++)
            {
                Console.Write("число ");
                Console.Write(mas[i] +  " ");
            }
            Console.WriteLine();
            for (int i = 0; i < colvo; i++)
            {
                Console.Write("Индекс: ");
                Console.Write(i + " ");
            }
            do
            {
                Console.Write("\n Введите элемент для поиска: ");
                try
                {
                    int b = Convert.ToInt32(Console.ReadLine());
                    int g = binPoisk(b, mas);
                    if (g > -1)
                        Console.WriteLine("Индекc элемента = {0}", g);
                    else
                        Console.WriteLine("Данного элемента нет в массиве");
                }
                catch (Exception osh)
                {
                    Console.WriteLine("\n Введены некорректные данные: " + osh.Message + "\n");
                }
                Console.WriteLine("Для повторного запуска поиска нажмите q для выхода любую другую");
            }
            while (Console.ReadLine() == "q");


        }
    }
}

