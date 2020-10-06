using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class Modele
    {
        private static connectMusicAtout maConnexion;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new connectMusicAtout();
        }
        public static List<VILLE> listeville()
        {
            return maConnexion.VILLE.ToList();
        }
        public static List<SALLE> listeSalle()
        {
            return maConnexion.SALLE.ToList();
        }
        public static List<BATIMENT> listeBat()
        {
            return maConnexion.BATIMENT.ToList();
        }
        public static List<TYPEOEUVRE> listeTOeuvre()
        {
            return maConnexion.TYPEOEUVRE.ToList();
        }

        public static List<NATIONALITE> listeNation()
        {
            return maConnexion.NATIONALITE.ToList();
        }

        public static Object CompositeurParNationalite(int idNation)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                           .Where(x => x.idNation == idNation)
                           .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque })
                           .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();

        }

        public static List<COMPOSITEUR> Compositeurs()
        {
            return maConnexion.COMPOSITEUR.ToList();
        }

        public static List<STYLE> Style()
        {
            return maConnexion.STYLE.ToList();
        }
    }
}
