using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bolum:Ientity
    {
        public int PerID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int BolumID { get; set; }
    }
}
