using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni05
{
    public class Hraci
    {
        private int index;
        public int Pocet { get; set; }
        public Hrac[] PoleHracu { get; set; }

        public delegate void PocetHracuChangeEventHandler();

        public event PocetHracuChangeEventHandler PocetZmenen;

        public Hraci() {
            Pocet = 20;
            PoleHracu = new Hrac[Pocet];
        }

        public void Vymaz(int i) {
            PoleHracu[i] = PoleHracu[index - 1];
            PoleHracu[index - 1] = null;
            index--;
            ZmenenPocetHracu();
        }

        public void Pridej(Hrac hrac) {
            PoleHracu[index] = hrac;
            index++;
            ZmenenPocetHracu();
        }

        public Hrac this[int index]
        {
            get { return PoleHracu[index]; }
            set { PoleHracu[index] = value; }
        }

        public void NajdiNejlepsiKluby(out FotbalovyKlub[] kluby, out int goly) {
            kluby = new FotbalovyKlub[Enum.GetValues(typeof(FotbalovyKlub)).Length];
            int[] pole = new int[Enum.GetValues(typeof(FotbalovyKlub)).Length];
            int i = 0;
            foreach (var polozka in PoleHracu)
            {
                if (polozka == null) {
                    break;
                }
                if (kluby.Contains(polozka.FotbalovyKlub))
                {
                    pole[Array.IndexOf(kluby, polozka.FotbalovyKlub)] += polozka.Goly;
                }
                else {
                    kluby[i] = polozka.FotbalovyKlub;
                    pole[i] += polozka.Goly;
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
