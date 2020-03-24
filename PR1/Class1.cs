using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Class1
    {

        public List<Firma> a = new List<Firma> { };
        public void Vivod()
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine("_____________________");
                Console.WriteLine("Название {0}", a[i].nazvanie);
                Console.WriteLine("Адрес {0}", a[i].adress);
                Console.WriteLine("Год основания {0}", a[i].god_osnov);
            }
        }

        public void Zapis()
        {
            Console.WriteLine("Введите количество записей");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Введите название, адрес, год основания");
                a.Add(new Firma() 
                {
                    nazvanie = Console.ReadLine(),
                    adress = Console.ReadLine(),
                    god_osnov = Convert.ToInt32(Console.ReadLine()),
                });
            }
        }
    }
