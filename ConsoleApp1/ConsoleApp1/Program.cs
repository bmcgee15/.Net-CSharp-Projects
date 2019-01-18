using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Read(5);
            Console.WriteLine("What is going on?");

           



        }

        static void Read(int x)
        {
            FileStream fp = new FileStream("employees.txt", FileMode.Open, FileAccess.Read);
            StreamReader data = new StreamReader(fp);
            String line;

            while ((line = data.ReadLine()) != null)
            {
                String[] exploded = line.Split(',');
                Console.WriteLine(exploded[0]);
            }

            Console.WriteLine(x);

            data.Close();

            Console.ReadLine();
        }
    }
}
