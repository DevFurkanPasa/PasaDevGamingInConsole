using PasaDevGaming.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace PasaDevGaming.Developments
{
    public class Development
    {
        public int DevelopmentId { get; set; }
        public string DevelopmentName { get; set; }
        public List<int> Games { get; set; }
        public string About { get; set; }
    }
}
