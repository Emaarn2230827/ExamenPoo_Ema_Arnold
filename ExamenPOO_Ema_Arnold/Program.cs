using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO_Ema_Arnold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Moteur m1 = new Moteur();
            Roue roue = new Roue(); 
            Motomarine mtest = new Motomarine("Spark","Tesla",12000,m1,TypeMotoMar.Jet_Ski);
            Vtt vtest = new Vtt("Ride","Nissan",15000,m1,roue);
            Console.WriteLine(mtest.ToString());
            Console.WriteLine();
            Console.WriteLine(vtest.ToString());*/
            Simulateur.Simuler();
        }
    }
}
