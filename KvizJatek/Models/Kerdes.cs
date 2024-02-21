using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace KvizJatek.Models
{
    public class Kerdes
    {
        public int Id { get; set; }
        public string KerdesSzoveg { get; set; }
        public string Valasz1 { get; set; }
        public string Valasz2 { get; set; }
        public string Valasz3 { get; set; }
        public string Valasz4 { get; set; }
        public  string Kategoria { get; set; }
        public  byte Pontszam { get; set; }

        [NotMapped]
        public List<string> Valaszok { get; set; }

        public Kerdes()
        {
            Valaszok = new List<string>();
            Valaszok.Add(Valasz1);
            Valaszok.Add(Valasz2);
            Valaszok.Add(Valasz3);
            Valaszok.Add(Valasz4);

        }
    }
}
