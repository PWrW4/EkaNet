using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkaNet_5.Creatures;

namespace EkaNet_5
{
    class Program
    {
        private static void FileWrite()
        {
            FileStream fileStream = new FileStream("wymiaryokna.txt",FileMode.Create,FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);


            streamWriter.WriteLine("20");
            streamWriter.WriteLine("40");
            streamWriter.Close();
            fileStream.Close();
        }

        private static void ReadFile()
        {
            FileStream fileStream = new FileStream("wymiaryokna.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            int height = int.Parse(streamReader.ReadLine());
            int width = int.Parse(streamReader.ReadLine());
            fileStream.Close();
            streamReader.Close();

        }


        static void Main(string[] args)
        {
            FileWrite();

            World World = new World();

            World.RunWorld();
            Console.ReadKey();
        }
    }
}
