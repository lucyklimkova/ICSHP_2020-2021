using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
   public enum Fakulta
    {
        FES, FF, FEI, FCHT, FZS, DFJP
    }
    public class Student
    {
        private string jmeno;
        public string Jmeno 
        {  
            get { return jmeno; }
            set { jmeno = value; }
        }

        private int cislo;
        public int Cislo
        {
            get { return cislo; }
            set { cislo = value; }
        }

        private Fakulta fakulta;
        public Fakulta Fakulta 
        {
            get { return fakulta; }
            set { fakulta = value; }
        }

        public Student(string jmeno, int cislo, Fakulta fakulta)
        {
            this.fakulta = fakulta;
            this.jmeno = jmeno;
            this.cislo = cislo;
        }

        public override string ToString()
        {
            return $"Jméno studenta: {jmeno} \nČíslo studenta: {cislo} \nFakulta: {fakulta.ToString()}\n";
        }
    }
}
