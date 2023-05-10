using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    static class Simulateur
    {
        static Random rand = new Random();
        public static Concessionnaire LeConc { get; set; }

        public static void Simuler()
        {
            SimulerTransaction();
            LeConc = new Concessionnaire("VM sports", 15000);
            Console.WriteLine(LeConc.ToString());
        }
        public static List<Client> GenererListClient()
        {
            int rnd = rand.Next(2, 5);
            List<Client> Clients = new List<Client>();
            for(int i = 0; i < rnd; i++)
            {
                Clients.Add(new Client());
            }
            return Clients;

        }
        public static List<Motomarine> ListeVehMotoMarine()
        {
            List<Motomarine> Vmar = new List<Motomarine>();
            for (int j = 0; j < LeConc.Vehicules.Count(); j++)
            { 
              Vmar.Add((Motomarine)LeConc.Vehicules[j]);
                
            }
            return Vmar;    
        }
        public static List<Vtt> ListeVehVtt()
        {
            List<Vtt> Vvtt = new List<Vtt>();
            for (int j = 0; j < LeConc.Vehicules.Count(); j++)
            {
                Vvtt.Add((Vtt)LeConc.Vehicules[j]);

            }
            return Vvtt;
        }
        public static void SimulerTransaction()
        {
            List<Client> Clients = GenererListClient();
            List<VehiculeMotorise> veh = ChoisirVehicule();
            for (int i = 0; i < Clients.Count; i++)
            {
                try
                {
                    if (Clients[i].MontantA < veh[i].PrixV)
                    {
                        throw new Exception($"\n Le client n'a pas les moyens \n {Clients[i].ToString()} ");
                    }
                    else
                    {
                        Facture fact = new Facture(Clients[i], veh[i]);
                        LeConc.Factures.Add(fact);
                        Clients[i].MontantA -= veh[i].PrixV;
                        LeConc.VendreVehicule(veh[i]);
                        fact.ToString();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public static List<VehiculeMotorise> ChoisirVehicule()
        {
            List<Client> Clients = GenererListClient();
            List<Motomarine> Vmar = ListeVehMotoMarine();
            List<Vtt> Vvtt = ListeVehVtt();
            

            List <VehiculeMotorise> bestveh = new List<VehiculeMotorise>() ;
            for (int i=0; i<Clients.Count; i++)
            {
                int rnd = rand.Next(1, 2);
                int rndMot1 = rand.Next(0, Vmar.Count() - 1);
                int rndMot2 = rand.Next(0, Vmar.Count() - 1);
                int rndVtt1 = rand.Next(0, Vvtt.Count() - 1);
                int rndVtt2 = rand.Next(0, Vvtt.Count() - 1);
                if (rnd == 1)
                {
                    Motomarine mt1 = Vmar[rndMot1];
                    Motomarine mt2 = Vmar[rndMot2];
                    Motomarine bestM = ((Motomarine)(mt1 > mt2));
                    bestveh.Add(bestM);

                }
                else if (rnd == 2)
                { 
                    Vtt vt1 = Vvtt[rndVtt1];
                    Vtt vt2 = Vvtt[rndVtt2];
                    Vtt bestV = ((Vtt)(vt1 > vt2));
                    bestveh.Add(bestV);   
                }
            }
            return bestveh; 
        }
    }
}
