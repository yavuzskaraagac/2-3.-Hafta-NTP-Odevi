using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            int number;

            // Kullanıcıdan pozitif tam sayılar al
            Console.WriteLine("Pozitif tam sayılar girin (Durdurmak için 0 girin):");
            while (true)
            {
                number = int.Parse(Console.ReadLine());

                if (number == 0)
                    break;

                if (number > 0)
                    numbers.Add(number);
                else
                    Console.WriteLine("Lütfen pozitif bir tam sayı girin.");
            }

            if (numbers.Count > 0)
            {
                // Ortalama hesapla
                double average = numbers.Average();

                // Medyan hesapla
                numbers.Sort();
                double median;
                int count = numbers.Count;

                if (count % 2 == 0)
                {
                    // Çift sayıda eleman varsa ortadaki iki sayının ortalamasını al
                    median = (numbers[count / 2 - 1] + numbers[count / 2]) / 2.0;
                }
                else
                {
                    // Tek sayıda eleman varsa ortadaki elemanı al
                    median = numbers[count / 2];
                }

                Console.WriteLine($"Ortalama: {average}");
                Console.WriteLine($"Medyan: {median}");
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girilmedi.");
            }

            // Programın kapanmasını önlemek için bekleyin
            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
}
