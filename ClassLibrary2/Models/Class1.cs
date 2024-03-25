using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Models
{
    internal class Class1
    {
        
    public class Adatok
        {

            public string Nev { get; set; }
            public int Kor { get; set; }
            public string Lakhely { get; set; }
            public string Munka { get; set; }
            public string ErdeklodesiKor { get; set; }
            public Adatok() 
            { 

            }

            public Adatok(string sor)
            {
                string[] a = sor.Split(';');
                Nev = a[0];
                Kor = Convert.ToInt32(a[1]);
                Lakhely = a[2];
                Munka = a[3];
                ErdeklodesiKor = a[4];
            }

            public override string? ToString()
            {
                return Nev + ", " + Kor + ", " + Lakhely +", "+ Munka +", "+ErdeklodesiKor;
            }
        }

    }
}

