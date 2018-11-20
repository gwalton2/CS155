using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture11Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, NameInfo> boys = new Dictionary<string, NameInfo>();
            Dictionary<string, NameInfo> girls = new Dictionary<string, NameInfo>();

            using(StreamReader boysreader = new StreamReader("boynames.txt"))
            {
                string line = boysreader.ReadLine();
                for(int i = 0;  line != null; i++, line = boysreader.ReadLine())
                {
                    string[] info = line.Split(' ');
                    NameInfo nameinfo = new NameInfo(info[0], "boy", i + 1, Int32.Parse(info[1]));
                    boys.Add(info[0], nameinfo);
                }
            }

            using (StreamReader girlsreader = new StreamReader("girlnames.txt"))
            {
                string line = girlsreader.ReadLine();
                for (int i = 0; line != null; i++, line = girlsreader.ReadLine())
                {
                    string[] info = line.Split(' ');
                    NameInfo nameinfo = new NameInfo(info[0], "girl", i + 1, Int32.Parse(info[1]));
                    girls.Add(info[0], nameinfo);
                }
            }

            string input = Console.ReadLine();
            while (!input.Equals("STOP"))
            {
                try
                {
                    Console.WriteLine(girls[input].ToString());
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine("{0} is not ranked among the top 1000 girl names.", input);
                }

                try
                {
                    Console.WriteLine(boys[input].ToString());
                }
                catch (KeyNotFoundException e)
                {
                    Console.WriteLine("{0} is not ranked among the top 1000 boy names.", input);
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
