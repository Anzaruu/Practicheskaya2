
namespace Praktich2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool a = true;

            Console.WriteLine("Мини - приложения.");
            Console.WriteLine("1 - Угадай число");
            Console.WriteLine("2 - Таблица умножения");
           // Console.WriteLine("3 - Вывод делителей числа");
            Console.WriteLine("4 - Выход из программы");

            do
            {
                Console.WriteLine("Введите номер операции, которую вы хотите сделать: ");
                string nomer = Console.ReadLine();
                int b = Convert.ToInt32(nomer);

                if (b == 1)
                {
                    Igra();
                }

                if (b == 2)
                {
                    Tablica();
                }

                /*
                if (b == 3)
                {

                }
                */

                if (b == 4)
                {
                    a = false;
                }
            }
            while (a == true);
        }

        static void Igra()
        {
            bool pravilno = true;

            Random rnd = new Random();
            int v = rnd.Next(0, 101);

            Console.WriteLine("Угадайте от 0 до 100: ");

            do
            {

                string chislo = Console.ReadLine();
                int c = Convert.ToInt32(chislo);

                if (c > v)
                {
                    Console.WriteLine("Надо меньше");
                }
                else if (c < v)
                {
                    Console.WriteLine("Надо больше");
                }
                else if (v == c)
                {
                    Console.WriteLine("Правильно");
                    pravilno = false;
                }
            }
            while (pravilno == true);
        }

        static void Tablica()
        {
            int[,] Tabl = new int[11, 10];

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Tabl[i, j] = i * j;
                    Console.Write(Tabl[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Delitel()
        {

        }
    }
}