using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    static class Factory
    {
   
        static Random rand = new Random();

        public static Client CreerClient()
        {
            List<string> listNom = new List<string>()
            {
            "Sophie Tremblay",
            "Maxime Gagnon",
            "Catherine Bouchard",
            "Simon Dubois",
            "Julie Girard",
            "Alexandre Blackburn",
            "Marie-Pierre Roy"
            };

            int rndnom = rand.Next(1, listNom.Count());
            int rndmont = rand.Next(5000, 50000);
            Client client = new Client(listNom[rndnom],rndmont);
            return client;    
            
            

        }
    }
}
