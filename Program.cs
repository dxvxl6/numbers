using System;

class Program
{
    // Объявление констант
    const int SequenceLength = 1000; // Количество чисел в последовательности
    const int MaxValue = 10000;       // Максимальное значение для каждого числа
    const int Divisor = 14;           // Делитель для проверки кратности
    const int InvalidResult = -1;     // Значение для обозначения отсутствия результата

    static void Main()
    {
        // Инициализация массива случайных чисел
        int[] sequence = new int[SequenceLength];
        Random randomGenerator = new Random();

        // Заполнение массива случайными неотрицательными целыми числами
        for (int i = 0; i < SequenceLength; i++)
        {
            sequence[i] = randomGenerator.Next(0, MaxValue + 1);
        }

        // Переменные для хранения максимального произведения, кратного 14
        int maxProduct = InvalidResult; // Изначально считаем, что результат недоступен

        // Поиск максимального произведения двух различных элементов массива
        for (int i = 0; i < SequenceLength; i++)
        {
            for (int j = i + 1; j < SequenceLength; j++)
            {
                int product = sequence[i] * sequence[j];

                // Проверяем, кратно ли произведение нужному делителю и больше ли оно текущего максимума
                if (product % Divisor == 0)
                {
                    if (product > maxProduct)
                    {
                        maxProduct = product; // Обновляем максимальное произведение
                    }
                }
            }
        }

        // Вывод результата пользователю
        if (maxProduct != InvalidResult)
        {
            Console.WriteLine($"Максимальное произведение двух различных элементов, кратное {Divisor}: {maxProduct}");
        }
        else
        {
            Console.WriteLine($"Не удалось найти максимальное произведение, удовлетворяющее условиям.");
        }
    }
}
