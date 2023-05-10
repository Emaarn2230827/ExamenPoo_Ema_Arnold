using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    internal class Facture
    {
        public Client LeClient { get; set; }
        public string Date { get; set; }
        public VehiculeMotorise Vehicule { get; set; }

        public Facture(Client leClient, VehiculeMotorise vehicule)
        {
            DateTime now = DateTime.Now;
            Date = now.ToString("dd/MM/yyyy HH:mm:ss");
            LeClient = leClient;
            Vehicule = vehicule;
        }

        public override string ToString()
        {
            string info = $"---FACTURE--- \n {Date} \n {LeClient.ToString()} \n {Vehicule.ToString()}";
            return info;
        }

    }
}
