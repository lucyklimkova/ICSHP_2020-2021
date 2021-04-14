using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni05
{
    static class FotbalovyKlubInfo
    {
        static readonly int pocet = Enum.GetValues(typeof(FotbalovyKlub)).Length;

        public static string DejNazev(int konst) {
            string nazev = Enum.GetName(typeof(FotbalovyKlub), konst);
            return nazev;
        }

    }
}
