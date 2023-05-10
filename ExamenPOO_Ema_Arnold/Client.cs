using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    internal class Client
    {
        public string NomClient { get; set; }
        public double MontantA { get; set; }

        public Client(string nomClient, double montantA)
        {
            NomClient = nomClient;
            MontantA = montantA;
        }

        public Client()
        { 
            Factory.CreerClient();
        }
        public override string ToString()
        {
            string info = $"---INFO SUR LE CLIENT--- \n Nom: {NomClient} \n Montant: {MontantA} $ ";
            return info;
        }
    }
}
