﻿using System;

namespace Conversion
{
    internal class OldSwedishVolume
    {
        public static double LitersToSpann()
        {
            Console.WriteLine("Hur många liter? ");
            double liter = Convert.ToDouble(Console.ReadLine());
            double spann = Math.Round(liter / 73.7, 2);
            Console.WriteLine("= {0}", spann);
            return spann;
        }
        public static double SpannToLiters()
        {
            Console.WriteLine("Hur många spann? ");
            double spann = Convert.ToDouble(Console.ReadLine());
            double liter = Math.Round(spann * 73.7, 2);
            Console.WriteLine("= {0}", liter);
            return liter;
        }
        public static double LitersToKappe()
        {
            Console.WriteLine("Hur många liter? ");
            double liter = Convert.ToDouble(Console.ReadLine());
            double kappe = Math.Round(liter / 4.6, 2);
            Console.WriteLine("= {0}", kappe);
            return kappe;
        }
        public static double KappeToLiters()
        {
            Console.WriteLine("Hur många kappe? ");
            double kappe = Convert.ToDouble(Console.ReadLine());
            double liter = Math.Round(kappe * 4.6, 2);
            Console.WriteLine("= {0}", liter);
            return liter;
        }
        public static double LitersToKanna()
        {
            Console.WriteLine("Hur många liter? ");
            double liter = Convert.ToDouble(Console.ReadLine());
            double kanna = Math.Round(liter / 2.6, 2);
            Console.WriteLine("= {0}", kanna);
            return kanna;
        }
        public static double KannaToLiters()
        {
            Console.WriteLine("Hur många kanna? ");
            double kanna = Convert.ToDouble(Console.ReadLine());
            double liter = Math.Round(kanna * 2.6, 2);
            Console.WriteLine("= {0}", liter);
            return liter;
        }
        public static double DecilitersToKvarter()
        {
            Console.WriteLine("Hur många deciliter? ");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double kvarter = Math.Round(deciliter / 3.3, 2);
            Console.WriteLine("= {0}", kvarter);
            return kvarter;
        }
        public static double KvarterToDeciliters()
        {
            Console.WriteLine("Hur många kvarter? ");
            double kvarter = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(kvarter * 3.3, 2);
            Console.WriteLine("= {0}", deciliter);
            return deciliter;
        }
        public static double DecilitersToTekopp()
        {
            Console.WriteLine("Hur många deciliter? ");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double tekopp = Math.Round(deciliter / 2.5, 2);
            Console.WriteLine("= {0}", tekopp);
            return tekopp;
        }
        public static double TekoppToDeciliters()
        {
            Console.WriteLine("Hur många tekopp? ");
            double tekopp = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(tekopp * 2.5, 2);
            Console.WriteLine("= {0}", deciliter);
            return deciliter;
        }
        public static double DecilitersToKaffekopp()
        {
            Console.WriteLine("Hur många deciliter? ");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double kaffekopp = Math.Round(deciliter / 1.5, 2);
            Console.WriteLine("= {0}", kaffekopp);
            return kaffekopp;
        }
        public static double KaffekoppToDeciliters()
        {
            Console.WriteLine("Hur många kaffekopp? ");
            double kaffekopp = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(kaffekopp * 1.5, 2);
            Console.WriteLine("= {0}", deciliter);
            return deciliter;
        }
        public static double DecilitersToJungfru()
        {
            Console.WriteLine("Hur många deciliter? ");
            double deciliter = Convert.ToDouble(Console.ReadLine());
            double jungfru = Math.Round(deciliter / 0.8, 2);
            Console.WriteLine("= {0}", jungfru);
            return jungfru;
        }
        public static double JungfruToDeciliters()
        {
            Console.WriteLine("Hur många jungfru? ");
            double jungfru = Convert.ToDouble(Console.ReadLine());
            double deciliter = Math.Round(jungfru * 0.8, 2);
            Console.WriteLine("= {0}", deciliter);
            return deciliter;
        }
    }
}
