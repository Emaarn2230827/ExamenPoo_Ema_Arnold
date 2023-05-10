using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    internal class Roue
    {
        public string MarqueRoue { get; set; }
        public int GrandRoue { get; set; }

        public Roue(string marqueRoue, int grandRoue)
        {
            MarqueRoue = marqueRoue;
            GrandRoue = grandRoue;
        }
        public Roue()
        {
            MarqueRoue = "Noname";
            GrandRoue = 12;
        }

        public override string ToString()
        {
            string info = $"\n ---INFO ROUE--- \n Marque: {MarqueRoue} \n Grandeur: {GrandRoue}";

            return info;
        }
    }
}
