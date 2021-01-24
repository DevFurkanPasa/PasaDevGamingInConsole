using PasaDevGaming.ControlDatabase;
using PasaDevGaming.Database;
using PasaDevGaming.Developments;
using PasaDevGaming.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PasaDevGaming.Utilities
{
     class Processes
    {
        GameDatabase _gameDatabase = new GameDatabase();
        int i = 5;
        int j = 6;
        private void GameInfo()
        {


        }
        public void GameAdd()
        {
            int gameId = j;
            j++;
            GameDatabase gameDatabase = new GameDatabase();
            DevelopmentDatabase developmentDatabase = new DevelopmentDatabase();
            Game game = new Game();
            Console.Clear();
            PasaDevDatabase devDatabase = new PasaDevDatabase();
            devDatabase.ListOfDevelopments();
            Console.WriteLine("Yüklemek istediğiniz oyun yukarıdaki");
            Console.WriteLine("yapımcılardan birine aitse -----> sol taraftaki sayıyı");
            Console.WriteLine("değilse ------------------------> 0'a tıklayın");
            try
            {
                int result = Convert.ToInt32(Console.ReadLine());
                foreach (Development development in developmentDatabase.ReturnDevelopment())
                {
                    if (result==development.DevelopmentId)
                    {
                        development.Games.Add(gameId);
                        Console.WriteLine("Oyununuzun ismi :");
                        string gameName = Console.ReadLine().ToString();
                        Console.WriteLine("Oyununuzu açıklayın :");
                        string gameDescription = Console.ReadLine().ToString();
                        game.Description = gameDescription;
                        game.GameName = gameName;
                        _gameDatabase.ReturnGames().Add(game);
                        break;
                    }
                    else if (result == 0)
                    {
                        DevelopmentAdd(gameId);
                        Console.WriteLine("Oyununuzun ismi :");
                        string gameName = Console.ReadLine().ToString();
                        Console.WriteLine("Oyununuzu açıklayın :");
                        string gameDescription = Console.ReadLine().ToString();
                        game.Description = gameDescription;
                        game.GameName = gameName;
                        _gameDatabase.ReturnGames().Add(game);
                        break;
                    }

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
        public void DevelopmentAdd(int gameId)
        {
            int developmentId = i;
            i++;
            DevelopmentDatabase database = new DevelopmentDatabase();
            Development development = new Development();

            Console.WriteLine("Yapımcı şirketin adını girin.");
            string developmentName = Console.ReadLine().ToString();
            Console.WriteLine("Şirketiniz hakkında bilgi verin.");
            string developmentAbout = Console.ReadLine().ToString();

            development.DevelopmentId = developmentId;
            development.DevelopmentName = developmentName;
            development.About = developmentAbout;

            database.ReturnDevelopment().Add(development);
        }
        public void GameRemove()
        {
            GameDatabase gameDatabase = new GameDatabase();
            Console.Clear();
            PasaDevDatabase devDatabase = new PasaDevDatabase();
            devDatabase.ListOfGames();
            Console.WriteLine("Hangi oyunu silmek istiyorsanız -----> sol taraftaki sayıya");
            Console.WriteLine("Ana menüye dönmek için ------------------> 0'a tıklayın");
            try
            {
                int result = Convert.ToInt32(Console.ReadLine());
                foreach (Game game in gameDatabase.ReturnGames())
                {
                    if (result==game.GameId)
                    {
                        gameDatabase.ReturnGames().Remove(game);
                        Console.WriteLine("İstediğiniz oyun silinmiştir.");
                        Thread.Sleep(2000);
                    }
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
