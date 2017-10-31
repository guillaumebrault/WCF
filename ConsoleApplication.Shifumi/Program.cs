using ConsoleApplication.Shifumi.ServiceReferenceShiFuMi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Shifumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client serviceClient = new Service1Client();
            string s = serviceClient.GetData(10);


                Partie p = new Partie();
                Joueur j = new Humain();
                Joueur m = new Machine();
                while (!j.AGagne && !m.AGagne)
                {
                    j.ChoixProposition();
                    m.ChoixProposition();
                    p.Comparaison(j, m);
                    Framework.Console.WriteLine("{2}\t{0}:{1}", j.Score, m.Score, m.Choix.ToString());
                }
                if (m.AGagne)
                    Framework.Console.WriteLine("la machine a gagné");
                else
                    Framework.Console.WriteLine("Vous avez gagné");

                Framework.Console.Read();
            }
        }


        public enum FCPEnum { Feuille = 1, Pierre = 2, Ciseau = 3, None = 0 }
        public class Joueur
        {
            public int Score = 0;
            public FCPEnum Choix = FCPEnum.None;

            public virtual void ChoixProposition() { }
            public bool AGagne
            {
                get
                {
                    return Score >= 3;
                }
            }
        }
        internal class Humain : Joueur
        {
            public override void ChoixProposition()
            {
                int i = 0;
                while (i == 0)
                {
                    Framework.Console.WriteLine("Proposition ? (1. Feuille 2. Pierre 3. Ciseau");
                    string saisie = Framework.Console.ReadLine();
                    if (!int.TryParse(saisie, out i) || i < 0 || i > 3)
                    {
                        Framework.Console.WriteLine("Recommencez !");
                        i = 0;
                    }
                }
                Choix = (FCPEnum)i;
            }
        }
        internal class Machine : Joueur
        {
            private Framework.Random Alea = new Framework.Random();

            public override void ChoixProposition()
            {
                Choix = (FCPEnum)Alea.Next(1, 4);
            }
        }

        internal class Partie
        {
            internal void Comparaison(Joueur j, Joueur m)
            {
                if (
                    (j.Choix == FCPEnum.Ciseau && m.Choix == FCPEnum.Feuille) ||
                    (j.Choix == FCPEnum.Feuille && m.Choix == FCPEnum.Pierre) ||
                    (j.Choix == FCPEnum.Pierre && m.Choix == FCPEnum.Ciseau)
                    )
                    j.Score++;

                if (
                    (j.Choix == FCPEnum.Ciseau && m.Choix == FCPEnum.Pierre) ||
                    (j.Choix == FCPEnum.Feuille && m.Choix == FCPEnum.Ciseau) ||
                    (j.Choix == FCPEnum.Pierre && m.Choix == FCPEnum.Feuille)
                    )
                    m.Score++;
            }
        }
    }
}
