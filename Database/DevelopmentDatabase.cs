using PasaDevGaming.Developments;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasaDevGaming.Database
{
    public class DevelopmentDatabase : IDatabaseService
    {
        public List<Development> ReturnDevelopment()
        {
            Development development1 = new ElectronicArts();
            development1.DevelopmentId = 1;
            development1.DevelopmentName = "Electronic Arts";
            development1.About = "Electronic Arts Inc., merkezi Redwood, Kaliforniya'da bulunan Amerikalı bir video oyun şirketi.";
            development1.Games = new List<int> {4};

            Development development2 = new CdProjectRed();
            development2.DevelopmentId = 2;
            development2.DevelopmentName = "CD Project Red";
            development2.About = "CD Projekt, Varşova merkezli Polonyalı video oyunu geliştiricisi ve yayımcısı firma.";
            development2.Games = new List<int> {2,3};

            Development development3 = new StardockEntertainment();
            development3.DevelopmentId = 3;
            development3.DevelopmentName = "Stardock Entertainment";
            development3.About = "Stardock Corporation, 1991 yılında kurulmuş ve 1993 yılında Stardock Systems olarak kurulmuş bir yazılım geliştirme şirketidir.";
            development3.Games = new List<int> {1};

            Development development4 = new Ubisoft();
            development4.DevelopmentId = 4;
            development4.DevelopmentName = "Ubisoft";
            development4.About = "Ubisoft, Ubisoft Entertainment Fransız video oyun geliştiricisi ve yayımcısıdır.";
            development4.Games = new List<int> {5};

            List<Development> developments = new List<Development> 
            {
                development1,
                development2,
                development3,
                development4
            };

            return developments;

        }
    }
}
