using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    internal class Concessionnaire
    {
        public string NomConc { get; set; }
        public List<VehiculeMotorise> Vehicules{ get; set; }
        public double MontantArgent { get; set; }
        public List<Facture> Factures { get; set; }

        public Concessionnaire(string nomConc, double montantArgent)
        {
            NomConc = nomConc;
            RemplirInventaire();
            MontantArgent = montantArgent;
            Factures = new List<Facture>();
        }

        public void AjouterVehicule(VehiculeMotorise vehicule)
        { 
            Vehicules.Add(vehicule);
        }

        public string GetInfoInventaire()
        {
            string info = "**** Liste véhicules du concessionnaire***";
            foreach (VehiculeMotorise veh in Vehicules)
            {
                info += $"{veh.ToString()}";
            }
            return info;
        }

        public void VendreVehicule( VehiculeMotorise vh)
        {
            MontantArgent += vh.PrixV;
            Vehicules.Remove(vh);
        }

        public void RemplirInventaire()
        {
            //motomarine
            Vehicules.Add(new Motomarine("Spark2","BRP",12000,new Moteur()));
            Vehicules.Add(new Motomarine("Spark GTI","BRP",14000,new Moteur()));
            Vehicules.Add(new Motomarine("Gp1800R","Yahama",11000,new Moteur()));
            Vehicules.Add(new Motomarine("GTX","BRP",15000,new Moteur("Rotax",230,TypeRef.air)));
            Vehicules.Add(new Motomarine("high","BRP",19000,new Moteur("V8",250,TypeRef.air)));
            Vehicules.Add(new Motomarine("BMW","GCG",22000,new Moteur("V8",350,TypeRef.liquide)));

            //vtt
            Vehicules.Add(new Vtt("Xp 1000", "Polaris", 32000, new Moteur()));
            Vehicules.Add(new Vtt("Foreman 500", "Honda", 10000, new Moteur()));
            Vehicules.Add(new Vtt("Raptor 700R", "Yamaha", 9000, new Moteur()));
            Vehicules.Add(new Vtt("Outlander 650", "Can-Am", 12000, new Moteur("V6", 460, TypeRef.air)));
            Vehicules.Add(new Vtt("Grizzly 700", "Yamaha", 11000, new Moteur()));
            Vehicules.Add(new Vtt("Ride Command", "Polaris", 15000, new Moteur("Evo",570,TypeRef.liquide)));


        }


        public override string ToString()
        {
            string info = $"---INFO CONCESSIONNAIRE--- \n Nom: {NomConc}\n ";
            info += $" Montant: {MontantArgent}";
            return info;
        }
    }
}
