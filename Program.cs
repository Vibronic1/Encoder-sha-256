using System;
using System.Threading;
using System.Security.Cryptography;
using System.Collections.Generic;
//Брестер Андрей Николаевич БББО-07-19
namespace EncoderSHA_256
{
    class Program
    {
        static bool nashel = false;
        static char[] alphavite = {
      'a',
      'b',
      'c',
      'd',
      'e',
      'f',
      'g',
      'h',
      'i',
      'j',
      'k',
      'l',
      'm',
      'n',
      'o',
      'p',
      'q',
      'r',
      's',
      't',
      'u',
      'v',
      'w',
      'x',
      'y',
      'z',
    };

        static void sovpadenie(string hesh, int Nach, int End)
        {
            char Simv;
            SHA256 mySHA256 = SHA256.Create();
            for (int j = Nach; j < End; j++)
            {
                Simv = alphavite[j];
                System.Text.StringBuilder Encrypt = new System.Text.StringBuilder("" + Simv + Simv + Simv + Simv + Simv);
                foreach (char simv2 in alphavite)
                {
                    Encrypt[1] = simv2;
                    foreach (char simv3 in alphavite)
                    {
                        Encrypt[2] = simv3;
                        foreach (char simv4 in alphavite)
                        {
                            Encrypt[3] = simv4;
                            foreach (char simv5 in alphavite)
                            {
                                Encrypt[4] = simv5;
                                if ((BitConverter.ToString(mySHA256.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Encrypt.ToString().ToCharArray())))).Replace("-", "").ToLower() == hesh)
                                {
                                    Console.WriteLine("Нашли: " + Encrypt.ToString());
                                    nashel = true;
                                    return;
                                };
                            }
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<Thread> myThread = new List<Thread>();
            string Hesh;
            int n = 26;
            bool end = false;
            while (end == false)
            {
                Console.WriteLine("Введите кэш, пожалуйста");
                Hesh = Console.ReadLine();
                n = 26;
                while ((n > 25) || (n < 1))
                {
                    Console.WriteLine("Введите сколько потоков вы выделите на это, пожалуйста");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    Thread devthread;
                    if (((i + 1) * 26) / n > 26)
                    {
                        devthread = new Thread(() => sovpadenie(Hesh, i * 26 / n, 26));
                    }
                    else
                    {
                        int nach = (i * 26) / n, End = ((i + 1) * 26) / n;
                        devthread = new Thread(() => sovpadenie(Hesh, nach, End));
                    }
                    devthread.Name = "thr" + i.ToString();
                    myThread.Add(devthread);
                    devthread.Start();
                }
                while (myThread.Count != 0)
                {
                    for (int b = 0; b < myThread.Count; b++)
                    {
                        if (!(myThread[b].IsAlive) || (nashel == true))
                        {
                            myThread.RemoveAt(b);
                        }
                    }
                    Thread.Sleep(200);
                }
                nashel = false;
                Console.WriteLine("хотите ещё?");
                string end1 = Console.ReadLine();
                if ((end1 == "да") || (end1 == "Да")) { }
                else
                {
                    end = true;
                }
            }
        }
    }
}