using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    internal class Vtt: VehiculeMotorise
    {
        public Roue RoueVtt { get; set; }
        public Vtt(string nomV, string marque, double prix, Moteur leMoteur, Roue roueVtt) : base(nomV, marque, prix, leMoteur)
        {
            RoueVtt = roueVtt;
        }

        public Vtt(string nomV, string marque, double prix, Moteur leMoteur) : base(nomV, marque, prix, leMoteur)
        {
            RoueVtt = new Roue();
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $"{RoueVtt.ToString()}";
            return info;
        }


    }
}
