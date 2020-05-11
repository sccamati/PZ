using lab8lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8console
{
    static class MageExtension
    {
        public static void Strongest1(this MageGuild mages)
        {
            var list = from m in mages
                       where m.Strength > 10
                       orderby m.Strength descending
                       select m;

            foreach (var mage in list)
            {
                Console.WriteLine(mage);
            }
        }

        public static void Strongest2(this MageGuild mages)
        {
            var mage = mages.Where(m => m.Strength > 10).OrderByDescending(m => m.Strength);

            foreach (var m in mage)
            {
                Console.WriteLine(m);
            }
        }

        public static void Strongest3(this MageGuild mages)
        {
            var mage = Enumerable.OrderByDescending(Enumerable.Where(mages, m => m.Strength > 10), m => m.Strength );

            foreach (var m in mage)
            {
                Console.WriteLine(m);
            }
        }

        public static void Strongest4(this MageGuild mages)
        {
            var mage = mages.Where(delegate (Mage m) { return m.Strength > 10; })
                .OrderByDescending(m => m.Strength);

            foreach (var m in mage)
            {
                Console.WriteLine(m);
            }
        }
        public static void Strongest5(this MageGuild mages)
        {
            var mage = mages.Where(CheckMage).OrderByDescending(m => m.Strength);

            foreach (var m in mage)
            {
                Console.WriteLine(m);
            }
        }

        public static bool CheckMage(Mage mage)
        {
            return mage.Strength > 10;
        }

        public static void Strongest6(this MageGuild mages)
        {
            List<Mage> list = new List<Mage>();
            foreach (var m in mages)
            {
                if(m.Strength > 10)
                {
                    list.Add(m);
                }
            }
            for (int j = 0; j < list.Count - 1; j++)
            {
                for (int i = 0; i < list.Count - j - 1; i++)
                {
                    if (list[i].Strength < list[i + 1].Strength)
                    {

                        Mage mage = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = mage;
                    }
                }
            }
            foreach (var m in list)
            {
                Console.WriteLine(m);
            }
            
        }

    }
}
