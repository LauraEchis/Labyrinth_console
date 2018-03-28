using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class MainApp
    {
        StreamReader reader = new StreamReader("small-test.in.txt");

        public void Run()
        {
            string[] splitter = { "\r\n" };
            int string_res = int.Parse(reader.ReadLine());
            string input_string = "";
            string output_string = "";
            //var res = reader.ReadToEnd().Split(splitN, couStrFile, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(couStrFile);
            //for (int j = 1; j < couStrFile; j++)
            //{
            //    enter = res[j].Split(' ')[0];
            //    exit = res[j].Split(' ')[1];
            //    LabyrinthRunner builder = new LabyrinthRunner();
            //    builder.Generate(enter, exit);
            //    Console.WriteLine(builder.GetLabyrinthEncryption());
            //}
            LabyrinthRunner builder = new LabyrinthRunner();
            builder.Generate("WRWWLWWLWWLWLWRRWRWWWRWWRWLW", "WWRRWLWLWWLWWLWWRWWRWWLW");
            var res = builder.GetLabyrinthEncryption();
            Console.WriteLine(res);
            Console.WriteLine("Нажмите Enter, чтобы завершить...");
            Console.ReadLine();
        }
    }
}