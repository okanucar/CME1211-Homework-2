using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            var rank = new List<int> { 100, 96, 80, 70, 50, 40, 35, 16, 12, 10 };
            var rankname = new List<string> { "Remzi:", "Yeliz:", "Pelin:", "Sibel:", "Ali:", "Cem:", "Can:", "Kaan", "Nazan", "Ece" };
           
                
            StreamWriter f3 = File.CreateText("HighScoreTable.txt");         
            f3.Close();

            while (true)
            {

                string[] numbers = new string[] { "A", "B", "C", "D" };
                int[] color = new int[] { 1, 2, 3 };

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please Enter Player's Name.");
                Console.ForegroundColor = ConsoleColor.White;

                string isim = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("----------");

                int point = 0;

                ////////--------Random 

                Random clr = new Random();



                Random rnd = new Random();


                var harfler = new List<int> { };
                var renkler = new List<int> { };

                ////////////--------Döngü başlangıcı
                int r = 0;
                int b = 0;
                int g = 0;
                for (int i = 1; i < 10; i++)
                {
                    ///////////////----Harf Olasılıkları
                    int let = rnd.Next(0, 4);





                    ///////////////--Renklendirme
                    int colornum = clr.Next(0, 3);



                    if (color[colornum] == 1)
                    {

                        if (r >= 3)
                        {
                            i = i - 1;

                        }
                        else
                        {
                            r = r + 1;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(numbers[let]);
                            harfler.Add(let);
                            renkler.Add(colornum);
                        }

                    }
                    if (color[colornum] == 2)
                    {

                        if (b >= 3)
                        {
                            i = i - 1;

                        }
                        else
                        {
                            b = b + 1;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(numbers[let]);
                            harfler.Add(let);
                            renkler.Add(colornum);
                        }
                    }
                    if (color[colornum] == 3)
                    {

                        if (g >= 3)
                        {
                            i = i - 1;
                        }
                        else
                        {
                            g = g + 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(numbers[let]);
                            harfler.Add(let);
                            renkler.Add(colornum);
                        }
                    }


                }


                Console.WriteLine();
                for (int i = 0; i < harfler.Count - 2; i++)
                {

                    //3 Harf aynıysa
                    if (harfler[i] == harfler[i + 1] && harfler[i] == harfler[i + 2])
                    {
                        if (renkler[i] == renkler[i + 1] && renkler[i] == renkler[i + 2])
                        {
                            point += 33;
                        }
                        if (renkler[i] != renkler[i + 1] && renkler[i] != renkler[i + 2] && renkler[i + 1] != renkler[i + 2])
                        {
                            point += 28;

                        }
                        if (renkler[i] != renkler[i + 1] && renkler[i] != renkler[i + 2] && renkler[i + 1] != renkler[i + 2])
                        {


                        }
                        else
                        {
                            if (renkler[i] == renkler[i + 1] && renkler[i] == renkler[i + 2] && renkler[i + 1] == renkler[i + 2])
                            {

                            }
                            else
                            {
                                point += 22;
                            }

                        }
                    }


                    //3farklı ardışık aynı renk
                    if (harfler[i] != harfler[i + 1] && harfler[i] != harfler[i + 2] && harfler[i + 1] != harfler[i + 2])
                    {
                        if ((harfler[i] + harfler[i + 1] + harfler[i + 2]) % 3 == 0)
                        {
                            if (renkler[i] == renkler[i + 1] && renkler[i] == renkler[i + 2] && renkler[i + 1] == renkler[i + 2])
                            {
                                point += 18;
                            }
                        }
                    }

                    //3Farklı ardışık farklı renk
                    if (harfler[i] != harfler[i + 1] && harfler[i] != harfler[i + 2] && harfler[i + 1] != harfler[i + 2])
                    {
                        if ((harfler[i] + harfler[i + 1] + harfler[i + 2]) % 3 == 0)
                        {
                            if (renkler[i] != renkler[i + 1] && renkler[i] != renkler[i + 2] && renkler[i + 1] != renkler[i + 2])
                            {
                                point += 16;
                            }
                        }
                    }

                    //3Farklı harf ardışık farklı ve aynı renk değil
                    if (harfler[i] != harfler[i + 1] && harfler[i] != harfler[i + 2] && harfler[i + 1] != harfler[i + 2])
                    {
                        if ((harfler[i] + harfler[i + 1] + harfler[i + 2]) % 3 == 0)
                        {
                            if (renkler[i] != renkler[i + 1] && renkler[i] != renkler[i + 2] && renkler[i + 1] != renkler[i + 2])
                            {


                            }
                            else
                            {
                                if (renkler[i] == renkler[i + 1] && renkler[i] == renkler[i + 2] && renkler[i + 1] == renkler[i + 2])
                                {

                                }
                                else
                                {
                                    point += 14;

                                }

                            }
                        }
                    }


                    //3farklı ardışık olmayan aynı renk
                    if (harfler[i] != harfler[i + 1] && harfler[i] != harfler[i + 2] && harfler[i + 1] != harfler[i + 2])
                    {
                        if ((harfler[i] + harfler[i + 1] + harfler[i + 2]) % 3 != 0)
                        {
                            if (renkler[i] == renkler[i + 1] && renkler[i] == renkler[i + 2] && renkler[i + 1] == renkler[i + 2])
                            {
                                point += 12;
                            }
                        }


                    }

                    //3farklı ardışık olmayan farklı renk
                    if (harfler[i] != harfler[i + 1] && harfler[i] != harfler[i + 2] && harfler[i + 1] != harfler[i + 2])
                    {
                        if ((harfler[i] + harfler[i + 1] + harfler[i + 2]) % 3 != 0)
                        {
                            if (renkler[i] != renkler[i + 1] && renkler[i] != renkler[i + 2] && renkler[i + 1] != renkler[i + 2])
                            {
                                point += 10;
                            }

                        }
                    }

                }


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("----------");

                Console.WriteLine();
                Console.WriteLine($"{isim} isimli oyuncunun Puanı:{point}");


               

                for (int s = 1; s <= rank.Count-1; s++)
                {
                    if (point >= rank[s] && point <= rank[s - 1])
                    {
                        rank.RemoveAt(rank.Count() - 1);
                        rank.Insert(s, point);
                        rankname.RemoveAt(rankname.Count()-1);
                        rankname.Insert(s, isim);
                        break;
                    }
                }
                File.Delete("HighScoreTable.txt");


                StreamWriter f = File.AppendText("HighScoreTable.txt");

                for (int k = 0; k <= rank.Count - 1; k++)
                    f.WriteLine($"{rankname[k]} : {rank[k]}");
                f.Close();

              
                Console.WriteLine("\n" + "Do you want to play again? (Yes):Press Y or (No):Press N");
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    Console.WriteLine();

                    continue;

                }

                if (cki.Key == ConsoleKey.N)

                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Please Press Enter To Exit The Console");
                    break;

                }
                if (cki.Key != ConsoleKey.Y && cki.Key != ConsoleKey.N)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Pressed The Wrong Key.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n" + "Please Press Enter To Exit The Console");
                    break;
                }


            }




            Console.ReadLine();
        }
    }
}
