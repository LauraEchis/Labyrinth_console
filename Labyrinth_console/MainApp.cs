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


        public void Run(string size_test)
        {
            StreamReader reader = new StreamReader(size_test + "-test.in.txt");
            StreamWriter sw = new StreamWriter(size_test + "-test.out.txt");

            string[] splitN = { "\r\n" };
            int couStrFile = int.Parse(reader.ReadLine());
            //string input_string = "";
            //string output_string = "";
            var res = reader.ReadToEnd().Split(splitN, couStrFile, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(couStrFile);
            for (int j = 0; j < couStrFile; j++)
            {
                var enter = res[j].Split(' ')[0];
                var exit = res[j].Split(' ')[1];
                LabyrinthRunner builder = new LabyrinthRunner();
                builder.Generate(enter, exit);
                Console.WriteLine("Case #" + (j + 1));
                Console.WriteLine(builder.GetLabyrinthEncryption());


                sw.WriteLine("Case #" + (j + 1));
                sw.WriteLine(builder.GetLabyrinthEncryption());

            }
            sw.Close();

            //LabyrinthRunner builder = new LabyrinthRunner();
            ////WRWLWLWRWRRWLWLWRWLWLWWRRWLWWLWLWRRWRWLWLWRRWWRWRRWLWLWWLWRRWLWLWRWRWLWLWRWLW WRWLWLWRWLW
            //builder.Generate("WRWLWLWRWRRWLWLWRWLWLWWRRWLWWLWLWRRWRWLWLWRRWWRWRRWLWLWWLWRRWLWLWRWRWLWLWRWLW", "WRWLWLWRWLW");
            //var res = builder.GetLabyrinthEncryption();
            //Console.WriteLine(res);
            //Console.WriteLine("Нажмите Enter, чтобы завершить...");
            Console.ReadLine();
        }
    }
}