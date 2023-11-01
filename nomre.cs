using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("riazi");
            string imput = Console.ReadLine();
            double x1 =Convert.ToDouble(imput);
            if (x1 >= 0 && x1 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("arabi");
            string t = Console.ReadLine();
            double x2 = Convert.ToDouble(t);
            if (x2 >= 0 && x2<= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("shimi");
            string c = Console.ReadLine();
            double x3 = Convert.ToDouble(c);
            if (x3 >= 0 && x3 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("zaban");
            string b = Console.ReadLine();
            double x4= Convert.ToDouble(b);
            if (x4 >= 0 && x4 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("hesaban");
            string n = Console.ReadLine();
            double x5 = Convert.ToDouble(n);
            if (x5 >= 0 && x5 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("hendeseh");
            string j = Console.ReadLine();
            double x6 = Convert.ToDouble(j);
            if (x6 >= 0 && x6 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("gosasteh");
            string e = Console.ReadLine();
            double x7 = Convert.ToDouble(e);
            if (x7 >= 0 && x7<= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("farsi");
            string w= Console.ReadLine();
            double x8 = Convert.ToDouble(w);
            if (x8 >= 0 && x8 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("dini");
            string p = Console.ReadLine();
            double x9 = Convert.ToDouble(p);
            if (x9 >= 0 && x9 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            Console.WriteLine("lotfan nomreh dars ra vared konid");
            Console.WriteLine("varzesh");
            string u = Console.ReadLine();
            double x10 = Convert.ToDouble(u);
            if (x10 >= 0 && x10 <= 20) ;
            else { Console.WriteLine("please insert your score between 0 to 20"); }

            double sum = (x1 * 4) + (x2 * 3) + (x3 * 3) + (x4 * 3) + (x5 * 3) + (x6 * 3) + (x7 * 3) + (x8 * 3) + (x9 * 2) + (x10 * 2);
            double moadel = sum / 29;
            Console.WriteLine(moadel);













        }
    }
}
