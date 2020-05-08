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
                       orderby m.Strength
                       select m;

            foreach (var mage in list)
            {
                Console.WriteLine(mage);
            }
        }

        public static void Strongest2(this MageGuild mages)
        {
            var mage = mages.Where(m => m.Strength > 10).OrderBy(m => m.Strength);

            foreach (var m in mage)
            {
                Console.WriteLine(m);
            }
        }

        public static void Strongest3(this MageGuild mages)
        {
            var mage = Enumerable.Where(mages, m => m.Strength > 10).OrderBy(m => m.Strength);

            foreach (var m in mage)
            {
                Console.WriteLine(m);
            }
        }

        public static void Strongest4(this MageGuild mages)
        {
            var mage = mages.Where(delegate (Mage m) { return m.Strength > 10; }).OrderBy(m => m.Strength);

            foreach (var m in mage)
            {
                Console.WriteLine(m);
            }
        }
        public static void Strongest5(this MageGuild mages)
        {
            var mage = mages.Where(CheckMage).OrderBy(m => m.Strength);

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
            list.Sort(new MageComparer());
            foreach (var m in list)
            {
                Console.WriteLine(m);
            }
            
        }

    }
}
