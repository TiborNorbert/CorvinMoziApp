using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorvinMoziApp
{
    internal class Terem
    {
        string nev;
        Image nevadokep;
        int sorok;
        int szekek;
        char[,] ulesek;

        public string Nev { get => nev; set => nev = value; }
        public Image Nevadokep { get => nevadokep; set => nevadokep = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int Szekek { get => szekek; set => szekek = value; }
        public char[,] Ulesek { get => ulesek; set => ulesek = value; }

        public Terem(string nev, Image nevadokep, int sorok, int szekek, char[,] ulesek)
        {
            Nev = nev;
            Nevadokep = Image.FromFile(@"Kepek\" + nev + ".jpg");
            Sorok = sorok;
            Szekek = szekek;
            Ulesek = ulesek;
        }
    }
}
