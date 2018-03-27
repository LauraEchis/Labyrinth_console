using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth_console
{
    class Labyrinth
    {
        public Cell[,] arr;
        public int size = 0;
        public int counter;


        public Labyrinth(int count_cell)
        {
            this.size = count_cell * 2 + 1;
            arr = new Cell[count_cell * 2 + 1, count_cell * 2 + 1];
            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    arr[i, j] = new Cell();
                }
            }
        }

        public string Encrypting_Cells()
        {
            string ans = "";
            string res = "";
            int len_i = 0;
            int len_j = 0;
            for (int i = 0; i < size; i++)
            {
                res = "";
                len_j = 0;
                for (int j = 0; j < size; j++)
                {
                    if (arr[i, j] != null)
                    {
                        res += arr[i, j].Encrypt();
                        len_j++;
                    }
                }

                if (res.Replace("f", "").Length == 0)
                {
                    res = "";
                }

                ans += res;
                if (res.Length != 0)
                {
                    ans += "\r\n";
                }

                len_i++;
            }

            ans = ans.Replace("f", " ");

            //var buf2 = ans.Split('\n');
            //ans = "";
            //int index_first = 0;
            //int index_j = 0;
            //for (int i = 0; i < len_j; i++)
            //{
            //    if (index_j < len_i && buf2[i].Length!=0)
            //    {
            //        if (!buf2[i][index_j].Equals(' '))
            //        {
            //            index_first = i;
            //            break;
            //        }

            //        index_j++;
            //    }
            //    else
            //    {
            //        index_j = 0;
            //    }
            //}

            //foreach (var k in buf2)
            //{
            //    k.Substring(index_first);
            //    ans += k;
            //    ans += "\r\n";
            //}

            //var buf2 = ans.Split('\n');
            //int max_buf2 = 0;
            //foreach (var n in buf2)
            //{
            //    string buf3 = "";
            //    buf3 = n.Replace(" ", "");
            //    if (max_buf2 < buf3.Length)
            //    {
            //        max_buf2 = buf3.Length;
            //    }
            //}

            //foreach (var n in buf2)
            //{
            //    n = n.
            //}

            //Console.WriteLine(len_a.ToString() + " " + "\r\n");
            //Console.WriteLine("ffffffffffffffffffffffffffffffac5ffffffffffffffffffffffffffffffff".Length.ToString() +
            //                  " " + "\r\n");

            return ans;
        }
    }
}
