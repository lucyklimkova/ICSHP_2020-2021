using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Cviceni04
{
    class Words
    { 
        private List<String> listSlova;
        Random rand;

        public Words()
        {
            listSlova = new List<string>(System.IO.File.ReadAllText("..\\..\\words.txt").Split('\n'));
            //listSlova = new List<string>(System.IO.File.ReadAllText("..\\..\\slova.txt").Split('\n'));
            rand = new Random();
            Debug.WriteLine(GetRandomWord());
        }
        

        public string GetRandomWord()
        {
            int randomInt = rand.Next(0, listSlova.Count-1);
            return listSlova[randomInt].Trim();
        }
    }
}
