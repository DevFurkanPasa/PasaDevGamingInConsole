using PasaDevGaming.Database;
using PasaDevGaming.Developments;
using PasaDevGaming.Games;
using PasaDevGaming.PasaDevPrograming;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasaDevGaming.ControlDatabase
{
    public class PasaDevDatabase
    {
        GameDatabase _gameDatabase = new GameDatabase();
        DevelopmentDatabase _developmentDatabase = new DevelopmentDatabase();
        
        public void ListOfGames()
        {
            List<Game> games = _gameDatabase.ReturnGames();
            int i = 1;
            foreach (Game game in games)
            {
                Console.WriteLine(game.GameId + ". " + game.GameName);
                Console.WriteLine(game.Description);
                Console.WriteLine();
                i++;
            }
        }
        public void ListOfDevelopments()
        {
            List<Development> developments = _developmentDatabase.ReturnDevelopment();
            int i = 1;
            foreach (Development development in developments)
            {
                Console.WriteLine(development.DevelopmentId + ". " + development.DevelopmentName);
                Console.WriteLine(development.About);
                Console.WriteLine();
                i++;
            }
        }
        public void DevelopmentToGames(int id)
        {
            List<Game> games = _gameDatabase.ReturnGames();
            List<Development> developments = _developmentDatabase.ReturnDevelopment();
            foreach (Development development in developments)
            {
                if (id == development.DevelopmentId)
                {
                    Console.WriteLine(development.DevelopmentName);
                    Console.WriteLine(development.About);
                    Console.WriteLine();
                    Console.WriteLine("Oyunları:");
                    Console.WriteLine();

                    foreach (int gameId in development.Games)
                    {
                        foreach (Game game in games)
                        {
                            if (gameId == game.GameId)
                            {
                                Console.WriteLine(game.GameName);
                                Console.WriteLine(game.Description);
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
        public void GameToDevelopment(int id)
        {
            List<Game> games = _gameDatabase.ReturnGames();
            List<Development> developments = _developmentDatabase.ReturnDevelopment();
            foreach (Game game in games)
            {
                if (id == game.GameId)
                {
                    Console.WriteLine(game.GameName);
                    Console.WriteLine(game.Description);
                    Console.WriteLine();
                    Console.WriteLine("Yapımcısı:");
                    Console.WriteLine();

                    foreach (Development development in developments)
                    {

                            if (game.DevelopmentId == development.DevelopmentId)
                            {
                                Console.WriteLine(development.DevelopmentName);
                                Console.WriteLine(development.About);
                                Console.WriteLine();
                            }

                    }
                }
            }
        }
        
    }
}
