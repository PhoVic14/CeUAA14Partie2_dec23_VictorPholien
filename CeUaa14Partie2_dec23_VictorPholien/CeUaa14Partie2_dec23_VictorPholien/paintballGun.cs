using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeUaa14Partie2_dec23_VictorPholien
{
    internal class paintballGun
    {
        /// <summary>
        /// Permet de recharger l'arme
        /// </summary>
        /// <param name="chargeur">Le chargeur</param>
        /// <param name="balles">le nombre de balle</param>
        public void reload (int chargeur, int balles)
        {
                chargeur = chargeur + 16;
                if (chargeur > 30)
                {
                    Console.WriteLine("Vous ne pouvez pas avoir plus de 30 balles dans votre chargeur");
                }
                else
                {
                    Console.WriteLine(balles);
                }  
        }

        /// <summary>
        /// permet de tirer avec espace
        /// </summary>
        /// <param name="chargeur">Le chargeur de l'arme</param>
        /// <param name="balles">Le nombre de balles</param>
        public void tirer(int chargeur, int balles)
        {
            if (chargeur <= 0)
            {
                Console.WriteLine("Vous n'avez pas de balles dans votre chargeur");
            }
            else
            {
                Console.WriteLine("=> Tir effectué");
                Console.WriteLine(balles);
            }
        }

        /// <summary>
        /// Reprendre des munitions dans la poche
        /// </summary>
        /// <param name="poche">poche contenant les balles</param>
        /// <param name="balles">nombre de balle</param>
        public void reprendreMunition(int poche, int balles)
        {
            poche = poche + 30;
            Console.WriteLine(balles);
        }

        /// <summary>
        /// Permet de quitter le programme
        /// </summary>
        /// <param name="continuer">boucle pour continuer</param>
        public void quitter(bool continuer)
        {
            continuer = false;
        }
    }
}



