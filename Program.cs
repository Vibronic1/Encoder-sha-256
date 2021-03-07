using System;
using System.Threading;
using System.Security.Cryptography;
namespace EncoderSHA_256
{
    class Program
    {
        static char[] alphavite = {
                                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
                                'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                
                            };

        public static void Tread0(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[0]);
            
        }
        public static void Tread1(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[1]);
            
        }
        public static void Tread2(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[2]);
            
        }
        public static void Tread3(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[3]);
            
        }
        public static void Tread4(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[4]);
            
        }

        public static void Tread5(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[5]);
           
        }
        public static void Tread6(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[6]);
           
        }
        public static void Tread7(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[7]);
            
        }
        public static void Tread8(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[8]);
            
        }
        public static void Tread9(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[9]);
            
        }
        public static void Tread10(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[10]);
            
        }
        public static void Tread11(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[11]);
            
        }
        public static void Tread12(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[12]);
            
        }
        public static void Tread13(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[13]);
            
        }
        public static void Tread14(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[14]);
            

        }
        public static void Tread15(string Hesh)
        {
            string otv = "no";
                otv = sovpadenie(Hesh, alphavite[15]);
            
        }
        public static void Tread16(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[16]);
            
        }
        public static void Tread17(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[17]);
            
        }
        public static void Tread18(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[18]);
            
        }
        public static void Tread19(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[19]);
            
        }
        public static void Tread20(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[20]);
            
        }
        public static void Tread21(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[21]);
            
        }
        public static void Tread22(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[22]);
            
        }
        public static void Tread23(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[23]);
           
        }
        public static void Tread24(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[24]);
            
        }
        public static void Tread25(string Hesh)
        {
            string otv = "no";
            otv = sovpadenie(Hesh, alphavite[25]);
            
        }
        

        static string sovpadenie(string hesh, char firstSimv)
        {
            SHA256 mySHA256 = SHA256.Create();

            System.Text.StringBuilder Encrypt = new System.Text.StringBuilder("" + firstSimv + firstSimv + firstSimv + firstSimv + firstSimv);

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
                            if ((BitConverter.ToString(mySHA256.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Encrypt.ToString().ToCharArray())))).Replace("-","").ToLower() == hesh) { 
                                Console.WriteLine("Нашли: " + Encrypt.ToString());
                                return Encrypt.ToString();
                            };
                            
                        }

                    }

                }

            }
            return "no";

        }
        static void Main(string[] args)
        {
             string Hesh;
            Console.WriteLine("Введите кэш, пожалуйста");
            Hesh = Console.ReadLine();
            
            
            var myThread1 = new Thread(() => Tread1(Hesh));
            myThread1.Start();
            var myThread2 = new Thread(() => Tread2(Hesh));
            myThread2.Start();
            var myThread3 = new Thread(() => Tread3(Hesh));
            myThread3.Start();
            var myThread4 = new Thread(() => Tread4(Hesh));
            myThread4.Start();
            var myThread5 = new Thread(() => Tread5(Hesh));
            myThread5.Start();
            var myThread6 = new Thread(() => Tread6(Hesh));
            myThread6.Start();
            var myThread7 = new Thread(() => Tread7(Hesh));
            myThread7.Start();
            var myThread8 = new Thread(() => Tread8(Hesh));
            myThread8.Start();
            var myThread9 = new Thread(() => Tread9(Hesh));
            myThread9.Start();
            var myThread10 = new Thread(() => Tread10(Hesh));
            myThread10.Start();
            var myThread11 = new Thread(() => Tread11(Hesh));
            myThread11.Start();
            var myThread12 = new Thread(() => Tread12(Hesh));
            myThread12.Start();
            var myThread13 = new Thread(() => Tread13(Hesh));
            myThread13.Start();
            var myThread14= new Thread(() => Tread14(Hesh));
            myThread14.Start();
            var myThread15= new Thread(() => Tread15(Hesh));
            myThread15.Start();
            var myThread16= new Thread(() => Tread16(Hesh));
            myThread16.Start();
            var myThread17= new Thread(() => Tread17(Hesh));
            myThread17.Start();
            var myThread18= new Thread(() => Tread18(Hesh));
            myThread18.Start();
            var myThread19= new Thread(() => Tread19(Hesh));
            myThread19.Start();
            var myThread20= new Thread(() => Tread20(Hesh));
            myThread20.Start();
            var myThread21= new Thread(() => Tread21(Hesh));
            myThread21.Start();
            var myThread22= new Thread(() => Tread22(Hesh));
            myThread22.Start();
            var myThread23= new Thread(() => Tread23(Hesh));
            myThread23.Start();
            var myThread24= new Thread(() => Tread24(Hesh));
            myThread24.Start();
            var myThread25= new Thread(() => Tread25(Hesh));
            myThread25.Start();
            var myThread26= new Thread(() => Tread0(Hesh));
            myThread26.Start();
            Console.ReadLine();
        }
    }
}
