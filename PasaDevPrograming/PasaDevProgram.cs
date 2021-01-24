using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using PasaDevGaming.ControlDatabase;
using PasaDevGaming.Database;
using PasaDevGaming.Utilities;

namespace PasaDevGaming.PasaDevPrograming
{
    public class PasaDevProgram
    {
        public void Intro()
        {
            Console.Write("Kaydınız Onaylanıyor!");
            Thread.Sleep(1250);
            Console.Write(".");
            Thread.Sleep(1250);
            Console.Write(".");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("PasaDevGaming'e Hoşgeldiniz!");
            Thread.Sleep(1250);
            Console.Write(".");
            Thread.Sleep(1250);
            Console.Write(".");
            Thread.Sleep(1250);
            Console.Write(".");
            Thread.Sleep(1250);
        }
        public void StartProgram()
        {
            PasaDevDatabase devDatabase = new PasaDevDatabase();
            GameDatabase gameDatabase = new GameDatabase();
            Processes processes = new Processes();
            
            for (int i = 0; i < 10; i--)
            {
                Console.Clear();
                Console.WriteLine("-------PasaDevGaming-------");
                Console.WriteLine("Mağzada gezinmek için -------> 1'e tıklayın.");
                Console.WriteLine("Yapımcıları görmek için -----> 2'ye tıklayın.");
                Console.WriteLine("Oyun eklemek için -----------> 3'ye tıklayın.");
                Console.WriteLine("Oyun silmek için ------------> 4'ye tıklayın.");
                Console.WriteLine("Programı kapatmak için ------> 5'ye tıklayın.");
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result == 1)
                    {
                        Console.Clear();
                        devDatabase.ListOfGames();
                        Console.WriteLine("Oyun sayfasına erişmek için sol tarafındaki sayıyı yazın.");
                        Console.WriteLine("Ana ekrana dönmek için 0'a tıklayın.");
                        int result1 = Convert.ToInt32(Console.ReadLine());
                        if (result1 > 0)
                        {
                            Console.Clear();
                            devDatabase.GameToDevelopment(result1);
                            Console.ReadLine();
                        }

                    }
                    else if (result == 2)
                    {
                        Console.Clear();
                        devDatabase.ListOfDevelopments();
                        Console.WriteLine("Yapımcı sayfasına erişmek için sol tarafındaki sayıyı yazın.");
                        Console.WriteLine("Ana ekrana dönmek için 0'a tıklayın.");
                        int result1 = Convert.ToInt32(Console.ReadLine());
                        if (result1 > 0)
                        {
                            Console.Clear();
                            devDatabase.DevelopmentToGames(result1);
                            Console.ReadLine();
                        }
                    }
                    else if (result == 3)
                    {
                        Console.Clear();
                        processes.GameAdd();
                    }
                    else if (result == 4)
                    {
                        Console.Clear();
                        processes.GameRemove();
                    }
                    else if (result == 5)
                    {
                        i = 11;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Lütfen doğru sayıyı giriniz.");
                        Thread.Sleep(1500);
                    }
                }
                catch
                {
                    Console.WriteLine("Sistem beklenmedik bir hata ile karşılaştı!");
                    Thread.Sleep(1500);
                    Console.WriteLine("Sistem yeniden başlatılıyor!");
                    Thread.Sleep(1500);
                }
                
            }
        }

    }
}
