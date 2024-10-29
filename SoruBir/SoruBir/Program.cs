using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruBir
{
    class Program
    {
        static void Main()
        {
            // Kullanıcıdan dizi elemanlarını al
            Console.Write("Kaç tane sayı gireceksiniz?: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dizinin {i + 1}. elemanını girin: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Diziyi sırala
            Array.Sort(numbers);
            Console.WriteLine("Sıralanmış dizi: " + string.Join(", ", numbers));

            // Kullanıcıdan aramak istediği sayıyı al
            Console.Write("Aramak istediğiniz sayıyı girin: ");
            int target = int.Parse(Console.ReadLine());

            // İkili arama algoritması ile sayıyı kontrol et
            bool found = BinarySearch(numbers, target);

            // Sonucu ekrana yazdır
            if (found)
            {
                Console.WriteLine($"{target} dizide bulundu.");
            }
            else
            {
                Console.WriteLine($"{target} dizide bulunamadı.");
            }
            Console.ReadLine();
        }

        // İkili arama algoritması
        static bool BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == target)
                    return true;
                else if (array[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return false;

        }
    }
}

