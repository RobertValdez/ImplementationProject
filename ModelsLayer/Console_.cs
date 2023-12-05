using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Console_
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Controls { get; set; }
        public bool Available { get; set; }
        public List<string> lsGames = new List<string>();
    }

    public class lsConsole_
    {
        public static List<string> Games1 = new List<string>() { "Party Animals", "ARA", "Forza Sport" };
        public static List<string> Games2 = new List<string>() { "Frontier", "Flock", "EA sport" };
        public static List<string> Games3 = new List<string>() { "Golden Eye 007", "Mario Galaxy", "Mario Kart Wii" };
        public static List<string> Games4 = new List<string>() { "PEP", "Flint Lock", "Way Woods" };
        public static List<string> Games5 = new List<string>() { "Nino Kuni II", "Turnip Boy", "Age Mithology" };

        public List<Console_> lstConsole = new List<Console_>()
        {
            new Console_() { id = 1, Marca = "Xbox",     Model = "One S",         Year = 2016, Controls = 2, lsGames = Games1, Available = true  },
            new Console_() { id = 2, Marca = "Sony",     Model = "PlayStation 5", Year = 2020, Controls = 1, lsGames = Games2, Available = true  },
            new Console_() { id = 3, Marca = "Nintendo", Model = "Switch",        Year = 2017, Controls = 4, lsGames = Games3, Available = false },
            new Console_() { id = 4, Marca = "Xbox",     Model = "Series S",      Year = 2020, Controls = 5, lsGames = Games4, Available = false  },
            new Console_() { id = 5, Marca = "Xbox",     Model = "Series X",      Year = 2020, Controls = 4, lsGames = Games5, Available = true  },
        };
    }
}
