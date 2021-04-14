using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni05
{
    public class Hrac
    {
        public string Jmeno { get; set; }
        public FotbalovyKlub FotbalovyKlub { get; set; }
        public int Goly { get; set; }

        public Hrac(string jmeno, FotbalovyKlub fotbalovyKlub, int goly)
        {
            Jmeno = jmeno ?? throw new ArgumentNullException(nameof(jmeno));
            FotbalovyKlub = fotbalovyKlub;
            Goly = goly;
        }

        public override string ToString()
        {
            return ($"{Jmeno} {FotbalovyKlub} {Goly}");
        }
    }
}
