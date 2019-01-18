using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalPath.DataProviders;
using MinimalPath.Triangle;

namespace MinimalPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;

            if (args.Length == 0)
            {
                filePath = "tree.txt";
            }
            else
            {
                filePath = args[0];
            }

            Stopwatch watch = Stopwatch.StartNew();

            AppFacade facade = new AppFacade();

            try
            {
                TrianglePath trianglePath = facade.RunMinimumPathFinding(new FileDataProvider(filePath));

                Console.WriteLine("Minimal " + trianglePath.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error: {0}", e.Message.ToString());
            }

            watch.Stop();

            Debug.WriteLine(watch.Elapsed);

            Console.ReadKey();
        }
    }
}
