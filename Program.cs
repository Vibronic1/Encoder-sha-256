using System;
using System.Threading;
using System.Security.Cryptography;
using System.Collections.Generic;
namespace EncoderSHA_256 {
  class Program {
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

    static void sovpadenie(string hesh, char firstSimv) {
      SHA256 mySHA256 = SHA256.Create();

      System.Text.StringBuilder Encrypt = new System.Text.StringBuilder("" + firstSimv + firstSimv + firstSimv + firstSimv + firstSimv);

      foreach(char simv2 in alphavite) {
        Encrypt[1] = simv2;
        foreach(char simv3 in alphavite) {
          Encrypt[2] = simv3;
          foreach(char simv4 in alphavite) {
            Encrypt[3] = simv4;
            foreach(char simv5 in alphavite) {
              Encrypt[4] = simv5;
              if ((BitConverter.ToString(mySHA256.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Encrypt.ToString().ToCharArray())))).Replace("-", "").ToLower() == hesh) {
                Console.WriteLine("Нашли: " + Encrypt.ToString());

              };

            }

          }

        }

      }

    }
    static void Main(string[] args) {
      List < Thread > myThread = new List < Thread > ();
      string Hesh;
      bool end = false;
      while (end == false) {
        Console.WriteLine("Введите кэш, пожалуйста");
        Hesh = Console.ReadLine();

        int i = 0;
        foreach(char n in alphavite) {
          Thread devthread = new Thread(() => sovpadenie(Hesh, n));
          devthread.Name = "thr" + i.ToString();
          myThread.Add(devthread);
          devthread.Start();
          i++;
        }

        while (myThread.Count != 0) {
          for (int b = 0; b < myThread.Count; b++) {
            if (!(myThread[b].IsAlive)) {
              myThread.RemoveAt(b);
            }

          }
          Thread.Sleep(200);

        }
        Console.WriteLine("хотите ещё?");
        string end1 = Console.ReadLine();
        if ((end1 == "да") || (end1 == "Да")) {} else {
          end = true;
        }
      }
    }
  }
}
