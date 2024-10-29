using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    using System;
    using System.Collections.Generic;

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
                // Listeyi sırala
                numbers.Sort();

                List<string> sequences = new List<string>();
                int start = numbers[0];
                int end = numbers[0];

                // Ardışık sayı gruplarını tespit et
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] == end + 1)
                    {
                        // Eğer sayı ardışık ise gruba dahil et
                        end = numbers[i];
                    }
                    else
                    {
                        // Ardışık sayı grubu tamamlandı, grubu listeye ekle
                        if (start == end)
                            sequences.Add(start.ToString());
                        else
                            sequences.Add($"{start}-{end}");

                        // Yeni gruba başla
                        start = numbers[i];
                        end = numbers[i];
                    }
                }

                // Son ardışık grubu ekle
                if (start == end)
                    sequences.Add(start.ToString());
                else
                    sequences.Add($"{start}-{end}");

                Console.WriteLine("Ardışık sayı grupları:");
                Console.WriteLine(string.Join(", ", sequences));
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
