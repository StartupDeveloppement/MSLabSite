using System;
using System.Threading.Tasks;
using MSLab.OpenData.Paris.Connexion;
using System.Collections.Generic;
using MSLab.OpenData.Paris.Data;
using MSLab.OpenData.Paris.GeneratedClasses;
using System.Linq;

namespace MSLab.OpenData.Paris.ConsoleClient
{
    class TestApi
    {
        public static void Main(string[] args)
        {
            try
            {
                //ListeSubventions().Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ReadLine();
            }

        }

        /// <summary>
        /// //Affiche les prénoms les plus donnés à Paris de 2004 à 2013    
        /// </summary>
        /// <param name="nombrePrenomParAnnee">Le nombre de prénom </param>
        /// <returns></returns>
        private static async Task LesPrenomLesPlusDonnes(int nombrePrenomParAnnee)
        {
            using (var bdd = new ParisOpenDataContext())
            {
                //Groupement par année
                var requeteParAnnee = bdd.liste_des_prenoms_2004_a_2012Dataset.GroupBy(c => c.fields.annee).OrderBy(c => c.Key);
                foreach (var annee in requeteParAnnee)
                {
                    Console.WriteLine("{0} : ", annee.Key);
                    //Selectionne le prenom et le nombre de fois dont le prénom à été attribué
                    foreach (var item2 in annee.OrderByDescending(c => c.fields.nombre).Take(nombrePrenomParAnnee).Select(c => new { Prenom = c.fields.prenoms, Nombre = c.fields.nombre }))
                    {
                        Console.WriteLine("  -{0} : {1}", item2.Prenom, item2.Nombre);
                    }

                }
            }
        }

        /// <summary>
        /// Liste des libelle des associations parisiennes
        /// </summary>
        /// <returns></returns>
        private static async Task ListeAssociationsParisienne()
        {
            using (var bdd = new ParisOpenDataContext())
            {
                var requeteGlobale = bdd.liste_des_associations_parisiennesDataset.ToList();
                foreach (var item in requeteGlobale)
                {
                    Console.WriteLine(item.fields.pr_nom_statutaire);
                }
            }
        }

        /// <summary>
        /// Affiche la liste des associations qui recoivent le plus de subvention de la ville de Paris
        /// </summary>
        /// <param name="top">Nombre d'associations</param>
        /// <returns></returns>
        private static async Task ListeSubventions(int top)
        {
            using (var bdd = new ParisOpenDataContext())
            {
                var requete = bdd.subventionsverseesDataset.ToList();
                foreach (var item in requete.OrderByDescending(c => c.fields.montant_de_la_subvention).Take(top))
                {
                    Console.WriteLine("{0}", item.fields.nom_de_l_organisme_beneficiaire_d_une_subvention);
                    Console.WriteLine("   -Catégorie:{0}", item.fields.categorie);
                    Console.WriteLine("   -collectivite:{0}", item.fields.collectivite);
                    Console.WriteLine("   -cp:{0}", item.fields.cp);
                    Console.WriteLine("   -mise_a_disposition_locaux:{0}", item.fields.mise_a_disposition_locaux);
                    Console.WriteLine("   -mise_a_disposition_personnel:{0}", item.fields.mise_a_disposition_personnel);
                    Console.WriteLine("   -montant_de_la_subvention:{0}", item.fields.montant_de_la_subvention);
                    Console.WriteLine("   -nature_juridique:{0}", item.fields.nature_juridique);
                    Console.WriteLine("   -nom_de_la_rue:{0}", item.fields.nom_de_la_rue);
                    Console.WriteLine("   -prestations_diverses:{0}", item.fields.prestations_diverses);
                    Console.WriteLine("   -publication:{0}", item.fields.publication);
                    Console.WriteLine("   -ville:{0}", item.fields.ville);
                }
                Console.WriteLine("Nom total d'enregistrements : {0} ", requete.Count);
            }
        }

    }
}

