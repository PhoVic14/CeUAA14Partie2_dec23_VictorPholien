using System.Reflection;

namespace CeUaa14Partie2_dec23_VictorPholien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poche = 30;
            int chargeur = 0;
            strin reponse;
            bool continuer = true;
            string balles = "Vous avez un total de 30 balles dans votre poche et 0 balles dans le chargeur";
            Console.WriteLine("Bienvenue dans ce jeu de tir . . . Vous démarrez avec 30 balles");
            Console.WriteLine("===============================================================");
            while (continuer == true)
            {
                Console.WriteLine(balles);
                Console.WriteLine("Espace pour tirer,");
                Console.WriteLine("r pour recharger,");
                Console.WriteLine("+ pour reprendre des munitions,");
                Console.WriteLine("q pour quitter");
                Console.ReadLine();
                if(reponse = "r") 
                {
                    Console.Write(paintballGun.reload);
                }
                if(reponse = "Espace")
                {
                    Console.Write(paintballGun.tirer);
                }
                if(reponse = "+")
                {
                    Console.Write(paintballGun.reprendreMunition);
                }
                if (reponse = "q")
                {
                    Console.Write(paintballGun.quitter);
                }
                
            }
        }
    }
}