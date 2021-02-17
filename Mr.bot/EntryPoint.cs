using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mr.bot
{
    class EntryPoint
    {
        static void Main() => new MainLogic().MainAsync().GetAwaiter().GetResult();
    }
}
