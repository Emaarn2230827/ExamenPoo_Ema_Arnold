using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    enum TypeRef
    {
        air,
        liquide
    }
    internal class Moteur
    {
        public string MarqueM { get; set; }
        public int ForceM { get; set; }
        public TypeRef RefM { get; set; }

        public Moteur()
        {
            MarqueM = "Yamaha";
            ForceM = 50;
            RefM = TypeRef.air;
        }

        public Moteur(string marqueM, int forceM, TypeRef refM)
        {
            MarqueM = marqueM;
            ForceM = forceM;
            RefM = refM;
        }

        public override string ToString()
        {
            string info = $"\n ---INFO SUR LE MOTEUR--- \n Marque:{MarqueM} \n HP: {ForceM} \n Refroidissement: {RefM}";
            return info;
        }
    }
}
