using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    internal class VehiculeMotorise
    {
        public string NomV { get;  }
        public string MarqueV { get; }
        public double PrixV { get; }
        public Moteur LeMoteur { get; }

        public VehiculeMotorise(string nomV, string marque, double prix, Moteur leMoteur)
        {
            NomV = nomV;
            MarqueV = marque;
            PrixV = prix;
            LeMoteur = leMoteur;
        }

        public static VehiculeMotorise operator >(VehiculeMotorise v1, VehiculeMotorise v2)
        {
            if (v1.LeMoteur.ForceM > v2.LeMoteur.ForceM)
            {
                return v1;
            }
            else
            {
                return v2;
            }
        }
        public static VehiculeMotorise operator <(VehiculeMotorise v1, VehiculeMotorise v2)
        {
            if (v1.LeMoteur.ForceM < v2.LeMoteur.ForceM)
            {
                return v2;
            }
            else
            {
                return v1;
            }
        }

        public override string ToString()
        {
            string info = $"---INFO SUR LE VEHICULE--- \n Nom: {NomV} \n Marque: {MarqueV} \n Prix: {PrixV} $ ";
            info += LeMoteur.ToString();
            return info;
        }
    }
}
