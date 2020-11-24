using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public static class Modele
    {
        private static connectMusicAtout maConnexion;
        private static int actionGestionCompositeur;
        private static COMPOSITEUR compositeurChoisi;
        private static UTILISATEUR utilisateurConnecte;
        private static bool connexionValide;

        public static int ActionGestionCompositeur { get => actionGestionCompositeur; set => actionGestionCompositeur = value; }
        public static COMPOSITEUR CompositeurChoisi { get => compositeurChoisi; set => compositeurChoisi = value; }
        public static UTILISATEUR UtilisateurConnecte { get => utilisateurConnecte; set => utilisateurConnecte = value; }
        public static bool ConnexionValide { get => connexionValide; set => connexionValide = value; }

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

        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public static string validConnexion(string id, string mp)
        {
            string message = "";
            connexionValide = false;

            if(.Equals(id))
            {
                if (utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp)))
                {
                    utilisateurConnecte.idUtilisateur = id;
                    utilisateurConnecte.passwd = mp;
                    message = "Connexion validée";
                    connexionValide = true;
                }
                else
                {
                    message = "Connexion rejetée";
                    connexionValide = false;
                }
            }
            else
            {
                message = "Connexion rejetée";
            }

            // Ecrire le code qui renvoie le message à afficher et mets à jour les variables 
            // utilisateurConnecte et connexionValide, la comparaison des mots de passes se fera 
            // via utilisateurConnecte.passwd.Substring(2).Equals(GetMd5Hash(mp))
            return message;
        }

        public static Object CompositeurParNationalite(int idNation)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                           .Where(x => x.idNation == idNation)
                           .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.STYLE.libStyle, x.anNais, x.anMort, x.remarque, x.idCompositeur })
                           .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();

        }

        public static COMPOSITEUR CompositeurParID(int ID)
        {
            var compositeur = maConnexion.COMPOSITEUR.Find(ID);
            return compositeur;
        }

        public static bool AjoutCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle) // Méthode pour insérer un nouveau compositeur
        {
            bool vretour = true;
            try
            {
                compositeurChoisi = new COMPOSITEUR();
                compositeurChoisi.nomCompositeur = nom;
                compositeurChoisi.prenomCompositeur = prenom;
                compositeurChoisi.remarque = remarque;
                compositeurChoisi.anNais = anNais;
                compositeurChoisi.anMort = anMort;
                compositeurChoisi.idNation = idNation;
                compositeurChoisi.idStyle = idStyle;
                maConnexion.COMPOSITEUR.Add(compositeurChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception e)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool ModifCompositeur(string nom, string prenom, string remarque, int anNais, int anMort, int idNation, int idStyle)
        {
            bool vretour = true;
            try
            {
                compositeurChoisi.nomCompositeur = nom;
                compositeurChoisi.prenomCompositeur = prenom;
                compositeurChoisi.remarque = remarque;
                compositeurChoisi.anNais = anNais;
                compositeurChoisi.anMort = anMort;
                compositeurChoisi.idNation = idNation;
                compositeurChoisi.idStyle = idStyle;
                maConnexion.SaveChanges();
            }
            catch(Exception e)
            {
                vretour = false;
            }
            return vretour;
        }

        public static bool SuppCompositeur()
        {
            bool vretour = true;
            try
            {
                maConnexion.COMPOSITEUR.Remove(compositeurChoisi);
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " + ex.InnerException.InnerException.Message);
                maConnexion.Dispose();
                init();
                vretour = false;
            }
            return vretour;
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
