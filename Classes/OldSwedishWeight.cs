using System;

namespace Conversion
{
    public class OldSwedishWeight
    {
        public static double GramsToSkålpund()
        {
            Console.WriteLine("Hur många gram? ");
            double gram = Convert.ToDouble(Console.ReadLine());
            double skålpund = Math.Round(gram / 425, 2);
            Console.WriteLine("= {0}", skålpund);
            return skålpund;
        }
        public static double SkålpundToGrams()
        {
            Console.WriteLine("Hur många skålpund? ");
            double skålpund = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(skålpund * 425, 2);
            Console.WriteLine("= {0}", gram);
            return gram;
        }
        public static double GramsToLod()
        {
            Console.WriteLine("Hur många gram? ");
            double gram = Convert.ToDouble(Console.ReadLine());
            double lod = Math.Round(gram / 13.3, 2);
            Console.WriteLine("= {0}", lod);
            return lod;
        }
        public static double LodToGrams()
        {
            Console.WriteLine("Hur många lod? ");
            double lod = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(lod * 13.3, 2);
            Console.WriteLine("= {0}", gram);
            return gram;
        }
        public static double GramsToOrt()
        {
            Console.WriteLine("Hur många gram? ");
            double gram = Convert.ToDouble(Console.ReadLine());
            double ort = Math.Round(gram / 4.3, 2);
            Console.WriteLine("= {0}", ort);
            return ort;
        }
        public static double OrtToGrams()
        {
            Console.WriteLine("Hur många ort? ");
            double ort = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(ort * 4.3, 2);
            Console.WriteLine("= {0}", gram);
            return gram;
        }
        public static double GramsToKvintin()
        {
            Console.WriteLine("Hur många gram? ");
            double gram = Convert.ToDouble(Console.ReadLine());
            double kvintin = Math.Round(gram / 3.3, 2);
            Console.WriteLine("= {0}", kvintin);
            return kvintin;
        }
        public static double KvintinToGrams()
        {
            Console.WriteLine("Hur många kvintin? ");
            double kvintin = Convert.ToDouble(Console.ReadLine());
            double gram = Math.Round(kvintin * 3.3, 2);
            Console.WriteLine("= {0}", gram);
            return gram;
        }


    }
}
