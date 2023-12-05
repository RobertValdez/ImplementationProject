using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer
{
    public class Consoles : IConsole_x
    {
        public List<Console_> ShowConsoles()
        {
            lsConsole_ console_ = new lsConsole_();
            var Cons = console_.lstConsole.ToList();
            return Cons;
        }
    }
}
