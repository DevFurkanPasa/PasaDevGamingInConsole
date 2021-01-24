using System;
using PasaDevGaming.Games;
using System.Collections.Generic;
using System.Text;
using PasaDevGaming.Developments;

namespace PasaDevGaming.Database
{
    public class GameDatabase:IDatabaseService
    {
        public List<Game> ReturnGames()
        {
            Game game1 = new Civilzation()
            {
                GameId = 1,
                DevelopmentId = 3,
                GameName = "Civilation",
                Description = "Civilization, Sid Meier'in yaptığı bir sıra tabanlı strateji oyunudur."
            };
            Game game2 = new Cyberpunk()
            {
                GameId = 2,
                DevelopmentId =2,
                GameName = "Cyberpunk 2077",
                Description = "Cyberpunk 2077, CD Projekt Red tarafından geliştirilen ve CD Projekt yayınlanan 2020 rol yapma türündeki video oyunudur."
            };
            Game game3 = new TheWitcher()
            {
                GameId = 3,
                DevelopmentId = 2,
                GameName = "The Witcher",
                Description = "The Witcher, CD Projekt Red tarafından geliştirilen ve CD Projekt tarafından yayınlanan bir dizi fantastik aksiyon rol yapma oyunudur."
            };
            Game game4 = new Nfs()
            {
                GameId = 4,
                DevelopmentId =1,
                GameName = "Need For Speed: Most Wanted",
                Description = "Need for Speed: Most Wanted, Need for Speed serisinin dokuzuncu oyunudur."
            };
            Game game5 = new TheCrew()
            {
                GameId = 5,
                DevelopmentId = 4,
                GameName = "The Crew",
                Description = "The Crew, Ivory Tower liderliğinde, Ubisoft Reflections ile birlikte geliştirilen, Ubisoft tarafından ise yayımcılığı yapılan yarış oyunudur."
            };

            List<Game> games = new List<Game> 
            { 
                game1,
                game2,
                game3,
                game4,
                game5
            };

            return games;
        }
    }
}
