using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = System.IO.File.ReadAllText(@"‪C:\Users\Hovhannes\Desktop\input.txt");
            Console.WriteLine("Մուտքագրել Լատինատառ Բառ");
            Console.WriteLine();
            Console.Write("Լատինատառ" + "  ");
            string str = "աբգդեզէըթժիլխծկհձղճմյնշոչպջռսվտրցուփքևօֆ";
            string str1 = "abcdefghjklmnopqrstuvwxyz";
            Dictionary<string, string> lettercollection = new Dictionary<string, string>();
            //lettercollection.Add("b", "է");
            lettercollection.Add("dz", "ձ");
            lettercollection.Add("ev", "և");
            lettercollection.Add("ch", "չ");
            //lettercollection.Add("ch", "ճ");
            lettercollection.Add("jh", "ժ");
            lettercollection.Add("gh", "ղ");
            lettercollection.Add("sh", "շ");
            lettercollection.Add(":)", "\u263A");
            lettercollection.Add("kh", "խ");

            lettercollection.Add("a", "ա"); lettercollection.Add("A", "Ա");
            lettercollection.Add("b", "բ"); lettercollection.Add("B", "Բ");
            lettercollection.Add("c", "ց"); lettercollection.Add("C", "Ց");
            lettercollection.Add("d", "դ"); lettercollection.Add("D", "Դ");
            lettercollection.Add("e", "ե"); lettercollection.Add("E", "Ե");
            lettercollection.Add("f", "ֆ"); lettercollection.Add("F", "Ֆ");
            lettercollection.Add("g", "գ"); lettercollection.Add("G", "Գ");
            lettercollection.Add("h", "հ"); lettercollection.Add("H", "Հ");
            lettercollection.Add("i", "ի"); lettercollection.Add("I", "Ի");
            lettercollection.Add("j", "ջ"); lettercollection.Add("J", "Ջ");
            lettercollection.Add("k", "կ"); lettercollection.Add("K", "Կ");
            lettercollection.Add("l", "լ"); lettercollection.Add("L", "Լ");
            lettercollection.Add("m", "մ"); lettercollection.Add("M", "Մ");
            lettercollection.Add("n", "ն"); lettercollection.Add("N", "Ն");
            lettercollection.Add("o", "օ"); lettercollection.Add("O", "Օ");
            lettercollection.Add("p", "պ"); lettercollection.Add("P", "Պ");
            lettercollection.Add("q", "ք"); lettercollection.Add("Q", "Ք");
            lettercollection.Add("r", "ռ"); lettercollection.Add("R", "Ռ");
            lettercollection.Add("s", "ս"); lettercollection.Add("S", "Ս");
            lettercollection.Add("t", "տ"); lettercollection.Add("T", "Տ");
            lettercollection.Add("u", "ու"); lettercollection.Add("U", "ՈՒ");
            lettercollection.Add("v", "վ"); lettercollection.Add("V", "Վ");
            lettercollection.Add("w", "ո"); lettercollection.Add("W", "Ո");
            lettercollection.Add("x", "խ"); lettercollection.Add("X", "Խ");
            lettercollection.Add("y", "յ"); lettercollection.Add("Y", "Յ");
            lettercollection.Add("z", "զ"); lettercollection.Add("Z", "Զ");
            lettercollection.Add("@", "ը"); 
            lettercollection.Add(" ", " ");
            string a = Console.ReadLine();
            string newstr = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i != a.Length - 1)
                {
                    if (a[i] == 's' && a[i + 1] == 'h') { newstr = newstr + lettercollection["sh"]; ++i; }
                    else
                    if (a[i] == 'g' && a[i + 1] == 'h') { newstr = newstr + lettercollection["gh"]; ++i; }
                    else
                        if (a[i] == 'j' && a[i + 1] == 'h') { newstr = newstr + lettercollection["jh"]; ++i; }
                    else
                        if (a[i] == 'e' && a[i + 1] == 'v') { newstr = newstr + lettercollection["ev"]; ++i; }
                    else
                        if (a[i] == 'd' && a[i + 1] == 'z') { newstr = newstr + lettercollection["dz"]; ++i; }
                    else
                        if (a[i] == 'k' && a[i + 1] == 'h') { newstr = newstr + lettercollection["kh"]; ++i; }
                    else
                        if (a[i] == 'c' && a[i + 1] == 'h') { i++; newstr = newstr + lettercollection["ch"]; ++i; }
                }
                newstr = newstr + lettercollection[a[i].ToString()];
            }
            foreach (var item in lettercollection)
            {
                a = a.Replace(item.Key, item.Value);
            }

            //System.IO.File.WriteAllText(@"‪C:\Users\Hovhannes\Desktop\output.txt", a);
            Console.Write("Հայատառ" + "  ");
            //Console.WriteLine(a);
            Console.WriteLine(newstr);
            Console.ReadKey();
            //1669003


            //GC.Collect();
            //int i;
            //int j = 10;
            //for (i = 0, Console.WriteLine("Start: {0}", i); i < j; i++, j--, Console.WriteLine("i={0}, j={1}", i, j))
            //{
            //    // Body of the loop.
            //}
            //int f = 2;
            //float c = 8.0f;
            //bool b=true;
            //if (f<c)
            //    Console.WriteLine(b);



        }
    }
}
