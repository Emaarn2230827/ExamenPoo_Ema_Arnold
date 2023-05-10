using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    enum TypeMotoMar
    { 
        Jet_Ski,
        Sea_Doo
    }
    internal class Motomarine: VehiculeMotorise
    {
        public TypeMotoMar TypeMM { get; set; }
        public Motomarine(string nomV, string marque, double prix, Moteur leMoteur,TypeMotoMar typeMM = TypeMotoMar.Sea_Doo) : base(nomV, marque, prix, leMoteur)
        {
            TypeMM = typeMM;
        }

        public override string ToString()
        {
            string info = base.ToString();
            info += $"Type motomarine: {TypeMM}";
            return info;
        }
    }
}
