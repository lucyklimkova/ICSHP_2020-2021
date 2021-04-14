using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni05
{
    public class Hraci
    {

        public int pocet;
        public int Pocet
        {
            get { return SeznamHracu.pocetPrvku; }
            set { pocet = value; }
        }


        public SpojovySeznam SeznamHracu;

        public delegate void PocetHracuChangeEventHandler();

        public event PocetHracuChangeEventHandler PocetZmenen;

        public Hraci() {
            SeznamHracu = new SpojovySeznam();
        }

        public void Vymaz(int i) {
            SeznamHracu.RemoveAt(i);
            ZmenenPocetHracu();
        }

        public void Pridej(Hrac hrac) {
            SeznamHracu.Add(hrac);
            ZmenenPocetHracu();
        }

        public Hrac this[int index]
        {
            get => (Hrac)SeznamHracu.Return(index);
            set => SeznamHracu.Set(index, value);
        }

        public void NajdiNejlepsiKluby(out FotbalovyKlub[] kluby, out int goly) {
            kluby = new FotbalovyKlub[Enum.GetValues(typeof(FotbalovyKlub)).Length];
            int[] pole = new int[Enum.GetValues(typeof(FotbalovyKlub)).Length];

            int i = 0;
            for (int k = 0; k < SeznamHracu.Count; k++)
            {
                Hrac hrac = (Hrac)SeznamHracu.Return(k);
                if (hrac == null) 
                {
                    break;
                }
                if (kluby.Contains(hrac.FotbalovyKlub))
                {
                    pole[Array.IndexOf(kluby, hrac.FotbalovyKlub)] += hrac.Goly;
                }
                else 
                {
                    kluby[i] = hrac.FotbalovyKlub;
                    pole[i] += hrac.Goly;
                    i++;
                }                
            }

            goly = pole.Max();
            for (int j = 0; j < pole.Length; j++)
            {            
                if (pole[j] != goly) {
                    kluby[j] = FotbalovyKlub.None;
                }
            }

        }
        private void ZmenenPocetHracu()
        {
            PocetZmenen?.Invoke();
        }

    }
}
