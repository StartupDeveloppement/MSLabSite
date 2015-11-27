using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MSLab.OpenData.Paris.Data;
using MSLab.OpenData.Paris.Connexion;

namespace MSLab.OpenData.Paris.Business.GeneratedClasses
{	

	public class postespublicsdesbibliothequesdepret 
	{
        public static int recordNumber =230;

        public static string datasetid ="postes-publics-des-bibliotheques-de-pret";
		public string etablissement { get; set; }		
		public int nombre_d_ordinateurs { get; set; }		
		public string type_de_poste_public { get; set; }		
		public List<double> position { get; set; }		
		
	}

	public class budgetsvotesannexes 
	{
        public static int recordNumber =4201;

        public static string datasetid ="budgets-votes-annexes";
		public int exercice_comptable { get; set; }		
		public string budget { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_d_operation_r_o_i_m { get; set; }		
		public string type_du_vote { get; set; }		
		public string chapitre_budgetaire_cle { get; set; }		
		public string chapitre_budgetaire_texte { get; set; }		
		public string nature_budgetaire_cle { get; set; }		
		public string nature_budgetaire_texte { get; set; }		
		public double credits_votes_pmt { get; set; }		
		
	}

	public class formationparthemesbilansocial 
	{
        public static int recordNumber =30;

        public static string datasetid ="formation-par-themes-bilan-social";
		public string collectivite { get; set; }		
		public string titre { get; set; }		
		public string type_de_formation { get; set; }		
		public string nature_de_la_formation { get; set; }		
		public int stagiaires_femmes { get; set; }		
		public int stagiaires_hommes { get; set; }		
		public int jours { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class etatdupersonnel 
	{
        public static int recordNumber =800;

        public static string datasetid ="etat-du-personnel";
		public string collectivite { get; set; }		
		public string budget_de_reference { get; set; }		
		public string date_d_effet { get; set; }		
		public string titre { get; set; }		
		public string type_d_emploi { get; set; }		
		public string filiere { get; set; }		
		public string emplois { get; set; }		
		public string categories { get; set; }		
		public double emplois_budgetaires_emplois_permanents_a_temps_complet { get; set; }		
		public double emplois_budgetaires_emplois_permanents_a_temps_incomplet { get; set; }		
		public double effectifs_pourvus_sur_emplois_budgetaires_en_etpt_agents_titulaires { get; set; }		
		public double effectifs_pourvus_sur_emplois_budgetaires_en_etpt_agents_non_titulaires { get; set; }		
		public double effectifs_pourvus_sur_emplois_budgetaires_en_etp_agents_titulaires { get; set; }		
		public double effectifs_pourvus_sur_emplois_budgetaires_en_etp_agents_non_titulaires { get; set; }		
		
	}

	public class recrutementdirectbilansocial 
	{
        public static int recordNumber =35;

        public static string datasetid ="recrutement-direct-bilan-social";
		public string collectivite { get; set; }		
		public string titre { get; set; }		
		public string secteur_grade { get; set; }		
		public int postes_ouverts { get; set; }		
		public int inscrits { get; set; }		
		public int presents { get; set; }		
		public int nombre_de_femmes_recues { get; set; }		
		public int nombre_d_hommes_recus { get; set; }		
		public int nombre_de_femmes_recrutees { get; set; }		
		public int nombre_d_hommes_recrutes { get; set; }		
		public DateTime annee { get; set; }		
		public string column_24 { get; set; }		
		public string column_25 { get; set; }		
		public string column_26 { get; set; }		
		public string column_27 { get; set; }		
		public string column_28 { get; set; }		
		public string column_29 { get; set; }		
		public string column_30 { get; set; }		
		public string column_31 { get; set; }		
		public string column_32 { get; set; }		
		public string column_33 { get; set; }		
		public string column_34 { get; set; }		
		public string column_35 { get; set; }		
		public string column_36 { get; set; }		
		public string column_37 { get; set; }		
		public string column_38 { get; set; }		
		public string column_39 { get; set; }		
		public string column_40 { get; set; }		
		public string column_41 { get; set; }		
		public string column_42 { get; set; }		
		public string column_43 { get; set; }		
		public string column_44 { get; set; }		
		public string column_45 { get; set; }		
		public string column_46 { get; set; }		
		public string column_47 { get; set; }		
		public string column_48 { get; set; }		
		public string column_49 { get; set; }		
		public string column_50 { get; set; }		
		public string column_51 { get; set; }		
		public string column_52 { get; set; }		
		public string column_53 { get; set; }		
		
	}

	public class titreslesplusreservesbibliothequesspecialisees 
	{
        public static int recordNumber =1970;

        public static string datasetid ="titres-les-plus-reserves-bibliotheques-specialisees";
		public string auteur { get; set; }		
		public string titre { get; set; }		
		public string editeur { get; set; }		
		public string collection { get; set; }		
		public int annee_edition { get; set; }		
		public string categorie_documentaire { get; set; }		
		public int nb_de_reservations_2014 { get; set; }		
		
	}

	public class accidentdetravailetdetrajetparcorpsbilansocial 
	{
        public static int recordNumber =183;

        public static string datasetid ="accident-de-travail-et-de-trajet-par-corps-bilan-social";
		public DateTime annee { get; set; }		
		public string collectivite { get; set; }		
		public string corps { get; set; }		
		public int accident_de_travail_et_de_trajet_avec_arret { get; set; }		
		public int accident_de_travail_et_de_trajet_sans_arret { get; set; }		
		
	}

	public class budgetvotesapautotrisationsdeprogrammes 
	{
        public static int recordNumber =1337;

        public static string datasetid ="budget-votes-ap-autotrisations-de-programmes";
		public string empty { get; set; }		
		public int exercice_comptable { get; set; }		
		public string budget { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_de_fonds_texte { get; set; }		
		public string type_du_vote { get; set; }		
		public string mission_ap_cle { get; set; }		
		public string mission_ap_texte { get; set; }		
		public string mission_activite_ap_cle { get; set; }		
		public string mission_activte_ap_texte { get; set; }		
		public string individualisation_ap_cle { get; set; }		
		public string individualisation_texte_ville { get; set; }		
		public string sens_depense_recette0 { get; set; }		
		public double credits_votes_eng { get; set; }		
		
	}

	public class lesconseillersdeparisde1977a2014 
	{
        public static int recordNumber =985;

        public static string datasetid ="les-conseillers-de-paris-de-1977-a-2014";
		public string image { get; set; }		
		public string mandature { get; set; }		
		public string conseiller { get; set; }		
		public string civilite { get; set; }		
		public string prenom { get; set; }		
		public string nom { get; set; }		
		public string secteur { get; set; }		
		public string groupe_politique { get; set; }		
		public string groupe_politique_fonctions { get; set; }		
		public DateTime elu_e_le { get; set; }		
		public string deces { get; set; }		
		public string demission { get; set; }		
		public string remplacement { get; set; }		
		public string maire_de_paris { get; set; }		
		public string adjoint_au_maire { get; set; }		
		public string adjoint_au_maire_demission { get; set; }		
		public string delegation_1_adjoint { get; set; }		
		public string arrete_delegation_a1 { get; set; }		
		public string arrete_fin_delegation_a1 { get; set; }		
		public string delegation_2_adjoint { get; set; }		
		public string arrete_delegation_a2 { get; set; }		
		public string arrete_fin_delegation_a2 { get; set; }		
		public string delegation_3_adjoint { get; set; }		
		public string arrete_delegation_a3 { get; set; }		
		public string arrete_fin_delegation_a3 { get; set; }		
		public string delegation_4_adjoint { get; set; }		
		public string arrete_delegation_a4 { get; set; }		
		public string conseiller_delegue { get; set; }		
		public string delegation_1_conseiller_delegue { get; set; }		
		public string arrete_delegation_cd1 { get; set; }		
		public string arrete_fin_delegation_cd1 { get; set; }		
		public string delegation_2_conseiller_delegue { get; set; }		
		public string arrete_delegation_cd2 { get; set; }		
		public string arrete_fin_delegation_cd2 { get; set; }		
		public string delegation_3_conseiller_delegue { get; set; }		
		public string arrete_delegation_cd3 { get; set; }		
		public string arrete_fin_delegation_cd3 { get; set; }		
		public string mission_1_conseiller_de_paris { get; set; }		
		public string arrete_mission_cp1 { get; set; }		
		public string mission_2_conseiller_de_paris { get; set; }		
		public string arrete_mission_cp2 { get; set; }		
		public string fonction_au_conseil_general { get; set; }		
		public string arrondissement_fonction { get; set; }		
		public string arrondissement_arrete_pour_fonction { get; set; }		
		public string arrondissement_demission { get; set; }		
		public DateTime ne_e_le { get; set; }		
		public string ville_de_naissance { get; set; }		
		public string arrondt_departement_ou_pays { get; set; }		
		public string profession { get; set; }		
		public string avant_1977_au_conseil_de_paris { get; set; }		
		public string liste { get; set; }		
		public string conduite_par { get; set; }		
		
	}

	public class positionsstatutairesparticulieresautrequedetachementbilansocial 
	{
        public static int recordNumber =24;

        public static string datasetid ="positions-statutaires-particulieres-autre-que-detachement-bilan-social";
		public string collectivite { get; set; }		
		public string positions_statutaires_particulieres { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class tranchedagedetailleespour15corpsbilansocial 
	{
        public static int recordNumber =306;

        public static string datasetid ="tranche-dage-detaillees-pour-15-corps-bilan-social";
		public string corps { get; set; }		
		public string tranches_d_age { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		public DateTime date { get; set; }		
		
	}

	public class formationparcategoriesbilansocial 
	{
        public static int recordNumber =18;

        public static string datasetid ="formation-par-categories-bilan-social";
		public string collectivite { get; set; }		
		public string titre { get; set; }		
		public string categorie { get; set; }		
		public int femmes { get; set; }		
		public int hommes { get; set; }		
		public int jours_femmes { get; set; }		
		public int jours_hommes { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class recrutementsurconcoursbilansocial 
	{
        public static int recordNumber =243;

        public static string datasetid ="recrutement-sur-concours-bilan-social";
		public string collectivite { get; set; }		
		public string titre { get; set; }		
		public string type_de_concours { get; set; }		
		public string categorie { get; set; }		
		public string concours { get; set; }		
		public int postes { get; set; }		
		public int candidats_inscrits { get; set; }		
		public int candidats_presents_1ere_epreuve { get; set; }		
		public int recus_liste_principale { get; set; }		
		public int recus_liste_complementaire { get; set; }		
		public int recus_liste_principale_femmes { get; set; }		
		public int recus_liste_principale_hommes { get; set; }		
		public int recus_liste_complementaire_femmes { get; set; }		
		public int recus_liste_complementaire_hommes { get; set; }		
		public int nb_femmes_recrutees { get; set; }		
		public int nb_hommes_recrutes { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class utilisations_mensuelles_des_hotspots_paris_wifi 
	{
        public static int recordNumber =54;

        public static string datasetid ="utilisations_mensuelles_des_hotspots_paris_wi-fi";
		public string mois { get; set; }		
		public string annee { get; set; }		
		public int sites_ouverts_total { get; set; }		
		public int sites_ouverts_bibliotheques { get; set; }		
		public int sites_ouvertes_centre_culturel_s { get; set; }		
		public int sites_ouverts_hotel_de_ville { get; set; }		
		public int sites_ouverts_parcs_et_jardins { get; set; }		
		public int sites_ouverts_divers { get; set; }		
		public string trafic_en_minutes_total { get; set; }		
		public string trafic_en_minutes_bibliotheques { get; set; }		
		public string trafic_en_minutes_centre_culture { get; set; }		
		public string trafic_en_minutes_hotel_de_ville { get; set; }		
		public string trafic_en_minutes_parcs_et_jardi { get; set; }		
		public string trafic_en_minutes_divers { get; set; }		
		public int nombre_session_total { get; set; }		
		public int nombre_de_sessions_bibliotheques { get; set; }		
		public int nombre_de_sessions_centre_cultur { get; set; }		
		public int nombre_de_sessions_hotel_de_vill { get; set; }		
		public int nombre_session_parcs_et_jardins { get; set; }		
		public int nombre_de_sessions_divers { get; set; }		
		public int nombre_de_minutes_session { get; set; }		
		public string nbr_de_go_total { get; set; }		
		
	}

	public class les_references_les_plus_reservees_en_2011 
	{
        public static int recordNumber =1000;

        public static string datasetid ="les_references_les_plus_reservees_en_2011";
		public int id { get; set; }		
		public int nombre_de_reservations { get; set; }		
		public string type { get; set; }		
		public string titre { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class ordres_du_jour_du_conseil_general 
	{
        public static int recordNumber =6808;

        public static string datasetid ="ordres_du_jour_du_conseil_general";
		public string seance { get; set; }		
		public string reference { get; set; }		
		public string entite_depositaire { get; set; }		
		public string elu_depositaire { get; set; }		
		public string objet { get; set; }		
		public string type { get; set; }		
		public string rapporteur { get; set; }		
		
	}

	public class ordres_du_jour_du_conseil_municipal 
	{
        public static int recordNumber =32167;

        public static string datasetid ="ordres_du_jour_du_conseil_municipal";
		public string seance { get; set; }		
		public string reference { get; set; }		
		public string entite_depositaire { get; set; }		
		public string elu_depositaire { get; set; }		
		public string objet { get; set; }		
		public string type { get; set; }		
		public string rapporteur { get; set; }		
		
	}

	public class zonesderattachementdesbureauxdevoteen2012 
	{
        public static int recordNumber =869;

        public static string datasetid ="zones-de-rattachement-des-bureaux-de-vote-en-2012";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public int arrondisse { get; set; }		
		public int num_bv { get; set; }		
		public double shape_leng { get; set; }		
		public double shape_area { get; set; }		
		
	}

	public class petits_marchands_sur_l_espace_public 
	{
        public static int recordNumber =116;

        public static string datasetid ="petits_marchands_sur_l_espace_public";
		public int arrdt { get; set; }		
		public string emplacement { get; set; }		
		public string adresse_complete { get; set; }		
		public string categorie_de_commerce { get; set; }		
		public DateTime plages_horaires_autorisees { get; set; }		
		public string column_6 { get; set; }		
		
	}

	public class immobilisationsetatdessorties 
	{
        public static int recordNumber =3938;

        public static string datasetid ="immobilisations-etat-des-sorties";
		public string publication { get; set; }		
		public string collectivite { get; set; }		
		public string rubrique { get; set; }		
		public string detail { get; set; }		
		public string sous_detail { get; set; }		
		public string nature { get; set; }		
		public string ndeg_immobilisation { get; set; }		
		public int ndeg_subs { get; set; }		
		public string designation_du_bien { get; set; }		
		public DateTime date_d_acquisition { get; set; }		
		public DateTime date_de_cession { get; set; }		
		public double valeur_d_acquisition { get; set; }		
		public int duree_d_amort { get; set; }		
		public double cumul_amort_anterieurs { get; set; }		
		public double vnc_au_jour_de_cession { get; set; }		
		public string prix_de_cession { get; set; }		
		public string value { get; set; }		
		public string observations { get; set; }		
		
	}

	public class adresses_des_panneaux_cq 
	{
        public static int recordNumber =218;

        public static string datasetid ="adresses_des_panneaux_cq";
		public string arrondissement { get; set; }		
		public string adresse { get; set; }		
		public string precision { get; set; }		
		public string conseil_de_quartier_concerne { get; set; }		
		public string personnes_a_contacter { get; set; }		
		public string type_de_panneau_vitre_ou_sans_vitre { get; set; }		
		public List<double> latitude_longitude { get; set; }		
		
	}

	public class les_1000_titres_les_plus_reserves_en_2013 
	{
        public static int recordNumber =1000;

        public static string datasetid ="les_1000_titres_les_plus_reserves_en_2013";
		public double rang { get; set; }		
		public string type_de_document { get; set; }		
		public double nombre_de_reservations { get; set; }		
		public string titre_avec_lien_vers_le_catalogue { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class deliberationemploi 
	{
        public static int recordNumber =4309;

        public static string datasetid ="deliberation-emploi";
		public string collectivite { get; set; }		
		public string budget { get; set; }		
		public string type_de_budget { get; set; }		
		public string numero_de_deliberation { get; set; }		
		public string date_de_deliberation { get; set; }		
		public string direction_code { get; set; }		
		public string direction_texte { get; set; }		
		public string type_de_mouvement { get; set; }		
		public double ndeg_enreg { get; set; }		
		public string service_ou_equipement { get; set; }		
		public string filiere { get; set; }		
		public string corps_ou_emploi { get; set; }		
		public double nb_de_postes { get; set; }		
		public int nb_d_heures { get; set; }		
		public int nb_de_mois { get; set; }		
		public string date_d_effet { get; set; }		
		public DateTime annee { get; set; }		
		public string fonction_cle { get; set; }		
		public string fonction_texte { get; set; }		
		
	}

	public class subventionsaccordeesetrefusees 
	{
        public static int recordNumber =6491;

        public static string datasetid ="subventions-accordees-et-refusees";
		public string annee { get; set; }		
		public string nom_du_partenaire { get; set; }		
		public string ndeg_siret { get; set; }		
		public string adresse { get; set; }		
		public string code_postal { get; set; }		
		public string ville { get; set; }		
		public string intitule_de_la_demande { get; set; }		
		public string appel_a_projets { get; set; }		
		public string appel_a_projets_politique_ville { get; set; }		
		public int montant_demande { get; set; }		
		public double montant_vote_par_demande { get; set; }		
		public int total_vote_en_2013 { get; set; }		
		public int fonctionnement { get; set; }		
		public int subventions_sur_projet { get; set; }		
		public int subventions_d_equipement { get; set; }		
		public int subventions_sans_nature_specifiee { get; set; }		
		public string s_pr_numero_simpa { get; set; }		
		public string financee_non_financee { get; set; }		
		
	}

	public class liste_des_ouvrages_des_bibliotheques_en_janvier_2009 
	{
        public static int recordNumber =668392;

        public static string datasetid ="liste_des_ouvrages_des_bibliotheques_en_janvier_2009";
		public string langue { get; set; }		
		public string annee_d_edition { get; set; }		
		public string isbn { get; set; }		
		public string indice { get; set; }		
		public string auteur_personne_physique { get; set; }		
		public string auteur_collectivite { get; set; }		
		public string co_auteur { get; set; }		
		public string responsabilite { get; set; }		
		public string co_auteur_collectivite { get; set; }		
		public string co_auteur_congres { get; set; }		
		public string titre_de_forme { get; set; }		
		public string titre { get; set; }		
		public string titre_parallele { get; set; }		
		public string mention_d_edition { get; set; }		
		public string editeur { get; set; }		
		public string annee_d_edition_bis { get; set; }		
		public string pagination { get; set; }		
		public string illustration { get; set; }		
		public string format { get; set; }		
		public string format_complementaire { get; set; }		
		public string materiel { get; set; }		
		public string materiel_complement { get; set; }		
		public string collection { get; set; }		
		public string ndeg_de_collection { get; set; }		
		public string sous_collection { get; set; }		
		public int ndeg_de_sous_collection { get; set; }		
		public string notes_generales { get; set; }		
		public string notes_de_contenu { get; set; }		
		public string note_d_histoire_de_l_edition { get; set; }		
		public string notes_sur_les_annexes { get; set; }		
		public string genre_ou_theme { get; set; }		
				
		public string titre_original { get; set; }		
		public string sujet_personne_physique { get; set; }		
		public string sujet_collecivite { get; set; }		
		public string sujet { get; set; }		
		public string sujet_geographique { get; set; }		
		public string titre_de_regroupement { get; set; }		
		public string ndeg_du_titre_de_regroupement { get; set; }		
		public int grandes_bibs { get; set; }		
		public int localisations_sections_adultes { get; set; }		
		public int localisations_discotheques { get; set; }		
		public int localisations_fonds_specialises_ou_reserves { get; set; }		
		public int localisations_sections_jeunesse { get; set; }		
		public int localisations_videotheques { get; set; }		
		public int localisations_sections_poles_thematiques_ou_partitions { get; set; }		
		public int nombre_d_exemplaires_dans_le_support_majoritaire { get; set; }		
		public string support { get; set; }		
		public string support_regroupe { get; set; }		
		public string categorie_statistique { get; set; }		
		public string classification_dewey { get; set; }		
		public string type_de_document_deduit_d_apres_la_categorie_statistique { get; set; }		
		public int nombre_d_exemplaires_pris_en_compte_pour_la_categorie_stat { get; set; }		
		public int nombre_d_exemplaires { get; set; }		
		public double prets_realises_en_6_mois { get; set; }		
		public double pret_moyen_par_exemplaire_sur_6_mois { get; set; }		
		public int localisations { get; set; }		
		public int localisations_hors_reserve_centrale { get; set; }		
		public string amelie { get; set; }		
		public string andre_malraux { get; set; }		
		public string baudoyer { get; set; }		
		public string batignolles { get; set; }		
		public string beaugrenelle { get; set; }		
		public string benjamin_rabier { get; set; }		
		public string brochant_colette_vivier { get; set; }		
		public string buffon { get; set; }		
		public string chaptal { get; set; }		
		public string chateau_d_eau { get; set; }		
		public string clignancourt { get; set; }		
		public string comptoir_lame { get; set; }		
		public string courcelles { get; set; }		
		public string couronnes { get; set; }		
		public string crimee { get; set; }		
		public string diderot { get; set; }		
		public string drouot { get; set; }		
		public string edmond_rostand { get; set; }		
		public string europe { get; set; }		
		public string faidherbe { get; set; }		
		public string fessart { get; set; }		
		public string flandre { get; set; }		
		public string francois_villon { get; set; }		
		public string georges_brassens { get; set; }		
		public string glaciere { get; set; }		
		public string goutte_d_or { get; set; }		
		public string gutenberg { get; set; }		
		public string herge { get; set; }		
		public string heure_joyeuse { get; set; }		
		public string isle_saint_louis { get; set; }		
		public string italie { get; set; }		
		public string jean_pierre_melville { get; set; }		
		public string la_fontaine { get; set; }		
		public string lancry { get; set; }		
		public string louvre { get; set; }		
		public string marguerite_audoux { get; set; }		
		public string marguerite_yourcenar { get; set; }		
		public string maurice_genevoix { get; set; }		
		public string mediatheque_musicale_de_paris { get; set; }		
		public string mortier { get; set; }		
		public string mouffetard { get; set; }		
		public string musset { get; set; }		
		public string parmentier { get; set; }		
		public string personnel { get; set; }		
		public string picpus_helene_berr { get; set; }		
		public string place_des_fetes { get; set; }		
		public string plaisance_aime_cesaire { get; set; }		
		public string porte_montmartre { get; set; }		
		public string port_royal_rainer_maria_rilke { get; set; }		
		public string reserve_centrale { get; set; }		
		public string reunion_prefiguration { get; set; }		
		public string saint_blaise_fermee_fin_2009_collections_marguerite_duras { get; set; }		
		public string saint_eloi { get; set; }		
		public string saint_fargeau { get; set; }		
		public string saint_simon { get; set; }		
		public string sorbier { get; set; }		
		public string trocadero_germaine_tillion { get; set; }		
		public string valeyre { get; set; }		
		public string vandamme { get; set; }		
		public string vaugirard { get; set; }		
		public string vivienne_charlotte_delbo { get; set; }		
		
	}

	public class concessions_dans_les_jardins 
	{
        public static int recordNumber =118;

        public static string datasetid ="concessions_dans_les_jardins";
		public int arrondt { get; set; }		
		public string adresse_de_l_activite { get; set; }		
		public string type { get; set; }		
		public List<double> xy_ { get; set; }		
		
	}

	public class liste_des_places_de_livraison 
	{
        public static int recordNumber =8776;

        public static string datasetid ="liste_des_places_de_livraison";
		public string regpar { get; set; }		
		public string locnum { get; set; }		
		public int numvoi { get; set; }		
		public string type_de_voie { get; set; }		
		public string denomination_de_voie { get; set; }		
		public int arrdt { get; set; }		
		public string addresse_complete { get; set; }		
		public int bilan_nbre_de_place { get; set; }		
		public List<double> geo_coordinates { get; set; }		
		
	}

	public class touslesdocumentsdesbibliothequesdepret 
	{
        public static int recordNumber =766108;

        public static string datasetid ="tous-les-documents-des-bibliotheques-de-pret";
		public int id { get; set; }		
		public string cote { get; set; }		
		public string langue { get; set; }		
		public string titre { get; set; }		
		public string genre { get; set; }		
		public string theme { get; set; }		
		public string format { get; set; }		
		public string titre_de_serie { get; set; }		
		public string ndeg_du_titre_de_serie { get; set; }		
		public string sous_titre { get; set; }		
		public string sous_collection { get; set; }		
		public int numero_collection { get; set; }		
		public string collection { get; set; }		
		public string annee { get; set; }		
		public string auteur { get; set; }		
		public string indice { get; set; }		
		public string editeur { get; set; }		
		public string edition { get; set; }		
		public string genre_theme_type { get; set; }		
		public string isbn { get; set; }		
		public string type_de_document { get; set; }		
		public int nombre_de_localisations { get; set; }		
		public double nombre_de_prets_2014 { get; set; }		
		public double nombre_de_pret_total { get; set; }		
		public double prets_renouv { get; set; }		
		public string categorie_statistique_1 { get; set; }		
		public string categorie_statistique_2 { get; set; }		
		public double aime_cesaire { get; set; }		
		public int amelie { get; set; }		
		public double andree_chedid { get; set; }		
		public double andre_malraux { get; set; }		
		public double arthur_rimbaud { get; set; }		
		public double batignolles { get; set; }		
		public string baudoyer { get; set; }		
		public double benjamin_rabier { get; set; }		
		public double buffon { get; set; }		
		public int canopee { get; set; }		
		public double chaptal { get; set; }		
		public double charlotte_delbo { get; set; }		
		public double chateau_d_eau { get; set; }		
		public double colette_vivier { get; set; }		
		public double courcelles { get; set; }		
		public double couronnes { get; set; }		
		public double crimee { get; set; }		
		public string diderot { get; set; }		
		public string drouot { get; set; }		
		public double edmond_rostand { get; set; }		
		public string europe { get; set; }		
		public double faidherbe { get; set; }		
		public string fessart { get; set; }		
		public double claude_levi_strauss { get; set; }		
		public double francois_villon { get; set; }		
		public double francoise_sagan { get; set; }		
		public double georges_brassens { get; set; }		
		public double germaine_tillion { get; set; }		
		public double goutte_d_or { get; set; }		
		public double gutenberg { get; set; }		
		public double helene_berr { get; set; }		
		public double herge { get; set; }		
		public double heure_joyeuse { get; set; }		
		public double italie { get; set; }		
		public string jacqueline_de_romilly { get; set; }		
		public double lancry { get; set; }		
		public double louise_michel { get; set; }		
		public double louvre { get; set; }		
		public double jean_pierre_melville { get; set; }		
		public double marina_tsvetaieva_glaciere { get; set; }		
		public double marguerite_audoux { get; set; }		
		public double marguerite_duras { get; set; }		
		public double marguerite_yourcenar { get; set; }		
		public double maurice_genevoix { get; set; }		
		public double mediatheque_musicale { get; set; }		
		public double mohammed_arkoun { get; set; }		
		public double mortier { get; set; }		
		public double musset { get; set; }		
		public double oscar_wilde { get; set; }		
		public double parmentier { get; set; }		
		public double place_des_fetes { get; set; }		
		public double reserve_centrale { get; set; }		
		public double rainer_maria_rilke { get; set; }		
		public double robert_sabatier { get; set; }		
		public double sorbier { get; set; }		
		public double st_eloi { get; set; }		
		public string st_fargeau { get; set; }		
		public double st_simon { get; set; }		
		public double vaclav_havel { get; set; }		
		public double valeyre { get; set; }		
		public double vandamme { get; set; }		
		public double vaugirard { get; set; }		
		
	}

	public class titularisations 
	{
        public static int recordNumber =105;

        public static string datasetid ="titularisations";
		public string collectivite { get; set; }		
		public string categorie { get; set; }		
		public string corps { get; set; }		
		public int nombre_de_femmes_titularisees { get; set; }		
		public int nombre_d_hommes_titularises { get; set; }		
		public DateTime date { get; set; }		
		
	}

	public class statistiquesdesvotesenlignedubudgetparticipatif2014 
	{
        public static int recordNumber =104017;

        public static string datasetid ="statistiques-des-votes-en-ligne-du-budget-participatif-2014";
		public string id { get; set; }		
		public string projets { get; set; }		
		public DateTime date_de_vote { get; set; }		
		public int arrondissement { get; set; }		
		public int age { get; set; }		
		
	}

	public class voie 
	{
        public static int recordNumber =6421;

        public static string datasetid ="voie";
		public int n_sq_vo { get; set; }		
		public int c_coinsee { get; set; }		
		public string c_desi { get; set; }		
		public string c_liaison { get; set; }		
		public string l_voie { get; set; }		
		public string l_courtmin { get; set; }		
		public string l_longmin { get; set; }		
		public string c_voie { get; set; }		
		public string b_fantoir { get; set; }		
		public string b_off { get; set; }		
		public string c_voie_vp { get; set; }		
		public GeoShape geom { get; set; }		
		public int objectid { get; set; }		
		public string c_domoff { get; set; }		
		public int n_sq_co { get; set; }		
		public List<double> geom_x_y { get; set; }		
		
	}

	public class pointsdevotedubudgetparticipatif 
	{
        public static int recordNumber =131;

        public static string datasetid ="points-de-vote-du-budget-participatif";
		public string arr { get; set; }		
		public string column_2 { get; set; }		
		public string equipement { get; set; }		
		public string adresse { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo 
	{
        public static int recordNumber =99966;

        public static string datasetid ="mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne_-_donnees_geo";
		public string geometry { get; set; }		
		public int geometry_vertex_count { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		public int info_ft_style { get; set; }		
		public int libelle_ft_style { get; set; }		
		public string import_notes { get; set; }		
		
	}

	public class stationnementsurvoiepubliquezonestarifaires 
	{
        public static int recordNumber =2;

        public static string datasetid ="stationnement-sur-voie-publique-zones-tarifaires";
		public int objectid { get; set; }		
		public string zone { get; set; }		
		public double tarif { get; set; }		
		public double shape_area { get; set; }		
		public double shape_len { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class zones30 
	{
        public static int recordNumber =93;

        public static string datasetid ="zones-30";
		public int objectid { get; set; }		
		public string nom_zca { get; set; }		
		public int stv { get; set; }		
		public DateTime date_arr { get; set; }		
		public string type_arr { get; set; }		
		public int arrdt { get; set; }		
		public double shape_area { get; set; }		
		public double shape_len { get; set; }		
		public string reglement { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class inventairedesdocumentsnumerisesenligne 
	{
        public static int recordNumber =139;

        public static string datasetid ="inventaire-des-documents-numerises-en-ligne";
		public string etablissement { get; set; }		
		public string nom_du_lot { get; set; }		
		public string type_de_documents { get; set; }		
		public int nb_de_documents { get; set; }		
		public int nb_de_fichiers { get; set; }		
		public List<double> position { get; set; }		
		
	}

	public class touspe3 
	{
        public static int recordNumber =1190753;

        public static string datasetid ="touspe3";
		public string isbn { get; set; }		
		public string issn { get; set; }		
		public string langue_du_document { get; set; }		
		public string langue_de_l_oeuvre_originale { get; set; }		
		public string langue_des_sous_titres { get; set; }		
		public string titre { get; set; }		
		public string type_de_document { get; set; }		
		public string titre_parallele { get; set; }		
		public string complement_du_titre { get; set; }		
		public string numero_de_partie { get; set; }		
		public string titre_de_partie { get; set; }		
		public string lieu { get; set; }		
		public string editeur { get; set; }		
		public string date_publication { get; set; }		
		public string document { get; set; }		
		public string caracteristiques_materielles { get; set; }		
		public string format { get; set; }		
		public string materiel_d_accompagnement { get; set; }		
		public string titre_de_la_collection { get; set; }		
		public string est_publie_avec { get; set; }		
		public string est_une_traduction_de { get; set; }		
		public string genre { get; set; }		
		public string genre_forme { get; set; }		
		public string sujet_libre { get; set; }		
		public string co_auteur_nom { get; set; }		
		public string co_auteur_prenom { get; set; }		
		public string auteur_secondaire_nom { get; set; }		
		public string auteur_secondaire_prenom { get; set; }		
		public string auteur_collectivite_nom { get; set; }		
		public string auteur_collectivite_subdivision { get; set; }		
		public string co_auteur_collectivite_nom { get; set; }		
		public string co_auteur_collectivite_subdivision { get; set; }		
		public string auteur_secondaire_collectivite_nom { get; set; }		
		public string auteur_secondaire_collectivite_subdivision { get; set; }		
		public string ndeg_systeme { get; set; }		
		public string etat_de_collection_periodique { get; set; }		
		public string localisations { get; set; }		
		public string nombre_d_exemplaires { get; set; }		
		public string cote { get; set; }		
		public string numero_de_volume { get; set; }		
		public string categorie_documentaire { get; set; }		
		public string fonds { get; set; }		
		public string etat_de_collection { get; set; }		
		public string auteur_complet { get; set; }		
		public string co_auteur { get; set; }		
		
	}

	public class les_1000_titres_les_plus_empruntes_de_2013 
	{
        public static int recordNumber =1000;

        public static string datasetid ="les_1000_titres_les_plus_empruntes_de_2013";
		public double rang { get; set; }		
		public string type_de_document { get; set; }		
		public double nombre_de_prets { get; set; }		
		public string titre_avec_lien_vers_le_catalogue { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class comptederesultat 
	{
        public static int recordNumber =44;

        public static string datasetid ="compte-de-resultat";
		public string type_de_resultat { get; set; }		
		public string produit_charge { get; set; }		
		public string poste { get; set; }		
		public string detail_postes { get; set; }		
		public double exercice_2013 { get; set; }		
		public double exercice_2012 { get; set; }		
		public string empty { get; set; }		
		public string empty0 { get; set; }		
		public string empty1 { get; set; }		
		public string empty2 { get; set; }		
		public string empty3 { get; set; }		
		public string empty4 { get; set; }		
		
	}

	public class horloges_exterieures_et_interieures 
	{
        public static int recordNumber =1204;

        public static string datasetid ="horloges_exterieures_et_interieures";
		public string type_d_etablissement { get; set; }		
		public string appelation_etablissement { get; set; }		
		public string numero { get; set; }		
		public string voie { get; set; }		
		public string adresse { get; set; }		
		public int arrondissement { get; set; }		
		public string adresse_complete { get; set; }		
		public string type_d_appareil { get; set; }		
		public int nombre_de_timbre { get; set; }		
		public int nombre_de_cloches { get; set; }		
		public string gestionnaire { get; set; }		
		public string column_12 { get; set; }		
		public string column_13 { get; set; }		
		public string column_14 { get; set; }		
		public string column_15 { get; set; }		
		public string column_16 { get; set; }		
		public string column_17 { get; set; }		
		public string column_18 { get; set; }		
		public string column_19 { get; set; }		
		public string column_20 { get; set; }		
		public string column_21 { get; set; }		
		public string column_22 { get; set; }		
		public string column_23 { get; set; }		
		public string column_24 { get; set; }		
		public string column_25 { get; set; }		
		public string column_26 { get; set; }		
		public string column_27 { get; set; }		
		public string column_28 { get; set; }		
		public string column_29 { get; set; }		
		public string column_30 { get; set; }		
		public string column_31 { get; set; }		
		public string column_32 { get; set; }		
		public string column_33 { get; set; }		
		public string column_34 { get; set; }		
		public string column_35 { get; set; }		
		public string column_36 { get; set; }		
		public string column_37 { get; set; }		
		public string column_38 { get; set; }		
		public string column_39 { get; set; }		
		public string column_40 { get; set; }		
		public string column_41 { get; set; }		
		
	}

	public class bilansocialeffectifsnontitulairespermanents 
	{
        public static int recordNumber =340;

        public static string datasetid ="bilan-social-effectifs-non-titulaires-permanents";
		public DateTime annee { get; set; }		
		public string collectivite { get; set; }		
		public string type_de_contrat { get; set; }		
		public string emplois { get; set; }		
		public string niveau { get; set; }		
		public string specialite { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		
	}

	public class dettepropre 
	{
        public static int recordNumber =308;

        public static string datasetid ="dette-propre";
		public DateTime annee_de_publication { get; set; }		
		public string nature { get; set; }		
		public string organisme_preteur_ou_chef_de_file { get; set; }		
		public DateTime date_d_emission_ou_date_de_mobilisation { get; set; }		
		public DateTime date_de_derniere_echeance { get; set; }		
		public double capital_initial { get; set; }		
		public double capital_restant_du_au_31_12_2013 { get; set; }		
		public string type_de_taux_d_interet { get; set; }		
		public string index { get; set; }		
		public double taux_initial_niveau_de_taux { get; set; }		
		public double taux_initial_taux_actuariel { get; set; }		
		public string profil_d_amortissement { get; set; }		
		public string possibilite_de_remboursement { get; set; }		
		public string categorie_d_emprunt { get; set; }		
		
	}

	public class mobilierpropreteparis2011 
	{
        public static int recordNumber =1050;

        public static string datasetid ="mobilierpropreteparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public double nsq_ec { get; set; }		
		public string lb_etat_e { get; set; }		
		public string lb_comp { get; set; }		
		public string affecta { get; set; }		
		public string emplacemnt { get; set; }		
		public int ardt { get; set; }		
		public int frequence { get; set; }		
		public string dpe { get; set; }		
		public int pose { get; set; }		
		public DateTime datepose { get; set; }		
		public DateTime datedepose { get; set; }		
		public double ad_nvo { get; set; }		
		public string ad_clvo { get; set; }		
		public string voie { get; set; }		
		public string deplace { get; set; }		
		
	}

	public class murs_et_clotures 
	{
        public static int recordNumber =232106;

        public static string datasetid ="murs_et_clotures";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public double nsq_mu { get; set; }		
		public double igds_color { get; set; }		
		public int arrd { get; set; }		
		public double objectid { get; set; }		
		
	}

	public class budgetsvotesetatsspeciauxdarrondissements 
	{
        public static int recordNumber =28071;

        public static string datasetid ="budgets-votes-etats-speciaux-darrondissements";
		public DateTime exercice_comptable { get; set; }		
		public string arrondissement { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_d_operation_r_o_i_m { get; set; }		
		public string type_du_vote { get; set; }		
		public string chapitre_budgetaire_cle { get; set; }		
		public string chapitre_budgetaire_texte { get; set; }		
		public string nature_budgetaire_cle { get; set; }		
		public string nature_budgetaire_texte { get; set; }		
		public string fonction_cle { get; set; }		
		public string fonction_texte { get; set; }		
		public double credits_votes_pmt { get; set; }		
		
	}

	public class titreslespluspretesbibliothequesspecialiseesen2014 
	{
        public static int recordNumber =37246;

        public static string datasetid ="titres-les-plus-pretes-bibliotheques-specialisees-en-2014";
		public string auteur { get; set; }		
		public string titre { get; set; }		
		public string editeur { get; set; }		
		public string collection { get; set; }		
		public int annee_edition { get; set; }		
		public string categorie_documentaire { get; set; }		
		public int nb_prets_2014 { get; set; }		
		
	}

	public class bornes_et_arceaux_de_stationnement_a_paris 
	{
        public static int recordNumber =524414;

        public static string datasetid ="bornes_et_arceaux_de_stationnement_a_paris";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class lesjardinieres 
	{
        public static int recordNumber =724;

        public static string datasetid ="les-jardinieres";
		public List<double> geo_point_2d { get; set; }		
		public string label { get; set; }		
		public string arr { get; set; }		
		public int annee_crea { get; set; }		
		public int surf_tot { get; set; }		
		
	}

	public class resultatsdelelectionmunicipale20141ertour 
	{
        public static int recordNumber =7298;

        public static string datasetid ="resultats-de-lelection-municipale-2014-1er-tour";
		public string column_1 { get; set; }		
		public DateTime column_2 { get; set; }		
		public string column_3 { get; set; }		
		public string column_4 { get; set; }		
		public string column_5 { get; set; }		
		public string column_6 { get; set; }		
		public string column_7 { get; set; }		
		public int column_8 { get; set; }		
		public int column_9 { get; set; }		
		public int column_10 { get; set; }		
		public string column_13 { get; set; }		
		public string column_11 { get; set; }		
		public int column_16 { get; set; }		
		public List<double> coordonnees_geo_wgs84 { get; set; }		
		
	}

	public class stationnementsurvoiepubliquesecteursresidentiels 
	{
        public static int recordNumber =160;

        public static string datasetid ="stationnement-sur-voie-publique-secteurs-residentiels";
		public int objectid { get; set; }		
		public string nom { get; set; }		
		public double shape_area { get; set; }		
		public double shape_len { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class lesparcellesforestieresdesbois 
	{
        public static int recordNumber =32;

        public static string datasetid ="les-parcelles-forestieres-des-bois";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public int num_bois { get; set; }		
		public string nom_bois { get; set; }		
		public double surface { get; set; }		
		
	}

	public class zonesderattachementdesbureauxdevoteen2014 
	{
        public static int recordNumber =869;

        public static string datasetid ="zones-de-rattachement-des-bureaux-de-vote-en-2014";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public int arrondisse { get; set; }		
		public int num_bv { get; set; }		
		public double shape_leng { get; set; }		
		public double shape_area { get; set; }		
		
	}

	public class panneaux_indicateurs_de_signalisation_routiere_et_pietonne 
	{
        public static int recordNumber =4237;

        public static string datasetid ="panneaux_indicateurs_de_signalisation_routiere_et_pietonne";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class bugdetvotesprincipaux 
	{
        public static int recordNumber =21731;

        public static string datasetid ="bugdet-votes-principaux";
		public string exercice_comptable { get; set; }		
		public string budget { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_d_operation_r_o_i_m { get; set; }		
		public string type_du_vote { get; set; }		
		public string chapitre_budgetaire_cle { get; set; }		
		public string chapitre_budgetaire_texte { get; set; }		
		public string nature_budgetaire_cle { get; set; }		
		public string nature_budgetaire_texte { get; set; }		
		public string fonction_cle { get; set; }		
		public string fonction_texte { get; set; }		
		public int credits_votes_pmt { get; set; }		
		
	}

	public class comptesadministratifsautorisationsdeprogrammesapvilledepartement 
	{
        public static int recordNumber =14829;

        public static string datasetid ="comptes-administratifs-autorisations-de-programmes-ap-ville-departement";
		public DateTime exercice_comptable { get; set; }		
		public string budget { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_d_operation_r_o_i_m { get; set; }		
		public string mission_ap_cle { get; set; }		
		public string mission_ap_texte { get; set; }		
		public string activite_ap { get; set; }		
		public string mission_activite_texte { get; set; }		
		public string direction_gestionnaire_cle { get; set; }		
		public string direction_gestionnaire_texte { get; set; }		
		public string autorisation_de_programme_cle { get; set; }		
		public string autorisation_de_programme_texte { get; set; }		
		public string nature_budgetaire_cle { get; set; }		
		public string nature_budgetaire_texte { get; set; }		
		public string cle_fonction_reglementaire { get; set; }		
		public string texte_fonction_reglementaire { get; set; }		
		public double mandate_titre_apres_regul { get; set; }		
		
	}

	public class catalogue_des_cours_municipaux_d_adultes 
	{
        public static int recordNumber =1435;

        public static string datasetid ="catalogue_des_cours_municipaux_d_adultes";
		public string departement_d_enseignement { get; set; }		
		public string formation { get; set; }		
		public string module { get; set; }		
		public string annee_scolaire { get; set; }		
		public string code_etablissement_cours { get; set; }		
		public string nom_etablissement_cours { get; set; }		
		public DateTime date_debut_cours { get; set; }		
		public DateTime date_fin_cours { get; set; }		
		
	}

	public class paris_taxis_stations 
	{
        public static int recordNumber =120;

        public static string datasetid ="paris_taxis_stations";
		public string station_id { get; set; }		
		public string station_name { get; set; }		
		public int station_number { get; set; }		
		public string address { get; set; }		
		public string address_precision { get; set; }		
		public string zip_code { get; set; }		
		public string city { get; set; }		
		public List<double> geo_coordinates { get; set; }		
		
	}

	public class poteaux_divers_sur_voie_publique 
	{
        public static int recordNumber =1080;

        public static string datasetid ="poteaux_divers_sur_voie_publique";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class listedescafesauneuro 
	{
        public static int recordNumber =181;

        public static string datasetid ="liste-des-cafes-a-un-euro";
		public DateTime date { get; set; }		
		public string nom_du_cafe { get; set; }		
		public string adresse { get; set; }		
		public int arrondissement { get; set; }		
		public int prix_comptoir { get; set; }		
		public string prix_salle { get; set; }		
		public string prix_terasse { get; set; }		
		public List<double> geoloc { get; set; }		
		
	}

	public class volumes_d_eau_distribues 
	{
        public static int recordNumber =12;

        public static string datasetid ="volumes_d_eau_distribues";
		public string mois { get; set; }		
		public string volumes_d_eau_distribues_m3 { get; set; }		
		
	}

	public class nomenclature_du_tri_selectif 
	{
        public static int recordNumber =0;

        public static string datasetid ="nomenclature_du_tri_selectif";
		public string empty { get; set; }		
		public string file { get; set; }		
		
	}

	public class mobilierelectriqueparis2011 
	{
        public static int recordNumber =1146;

        public static string datasetid ="mobilierelectriqueparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class quartier_paris 
	{
        public static int recordNumber =80;

        public static string datasetid ="quartier_paris";
		public int n_sq_qu { get; set; }		
		public int c_qu { get; set; }		
		public int c_quinsee { get; set; }		
		public string l_qu { get; set; }		
		public int c_ar { get; set; }		
		public int n_sq_ar { get; set; }		
		public double perimetre { get; set; }		
		public double surface { get; set; }		
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public int objectid { get; set; }		
		public double longueur { get; set; }		
		
	}

	public class petits_marchands_sur_l_espace_public_en_2012 
	{
        public static int recordNumber =120;

        public static string datasetid ="petits_marchands_sur_l_espace_public_en_2012";
		public int arrdt { get; set; }		
		public string emplacement { get; set; }		
		public string categorie_de_commerce { get; set; }		
		public DateTime plages_horaires { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class maneges_et_jeux_2012 
	{
        public static int recordNumber =29;

        public static string datasetid ="maneges_et_jeux_2012";
		public int arrt { get; set; }		
		public string lieux { get; set; }		
		public string categorie_de_jeux_forains { get; set; }		
		public string horaires { get; set; }		
		public string adresse { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class arrondissements 
	{
        public static int recordNumber =20;

        public static string datasetid ="arrondissements";
		public int n_sq_ar { get; set; }		
		public int c_ar { get; set; }		
		public int c_arinsee { get; set; }		
		public string l_ar { get; set; }		
		public string l_aroff { get; set; }		
		public int n_sq_co { get; set; }		
		public double surface { get; set; }		
		public double perimetre { get; set; }		
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public int objectid { get; set; }		
		public double longueur { get; set; }		
		
	}

	public class volumesbatisparis2011 
	{
        public static int recordNumber =352292;

        public static string datasetid ="volumesbatisparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string c_nat_b { get; set; }		
		public string l_nat_b { get; set; }		
		public string c_src { get; set; }		
		public string l_src { get; set; }		
		public double m2 { get; set; }		
		public int nb_pl { get; set; }		
		public double m2_pl_tot { get; set; }		
		public int b_rdc { get; set; }		
		public int c_plan_h_i { get; set; }		
		public double y { get; set; }		
		public string l_plan_h_i { get; set; }		
		public double x { get; set; }		
		public DateTime d_cre { get; set; }		
		public string l_b_u { get; set; }		
		public DateTime d_maj { get; set; }		
		public int n_ar { get; set; }		
		public string l_plan_h { get; set; }		
		public int h_et_max { get; set; }		
		public int n_qu { get; set; }		
		
	}

	public class statistiques_de_creation_d_actes_d_etat_civil 
	{
        public static int recordNumber =141;

        public static string datasetid ="statistiques_de_creation_d_actes_d_etat_civil";
		public string tableaux_de_bord_etat_civil { get; set; }		
		public string column_2 { get; set; }		
		public string column_3 { get; set; }		
		public string column_4 { get; set; }		
		public string column_5 { get; set; }		
		public string column_6 { get; set; }		
		public string column_7 { get; set; }		
		public string column_8 { get; set; }		
		public string column_9 { get; set; }		
		
	}

	public class listedesmarchesdelacollectiviteparisienne 
	{
        public static int recordNumber =3312;

        public static string datasetid ="liste-des-marches-de-la-collectivite-parisienne";
		public DateTime annee_de_notification { get; set; }		
		public string ndeg_marche { get; set; }		
		public string objet_du_marche { get; set; }		
		public string nature_du_marche { get; set; }		
		public string fournisseur_nom { get; set; }		
		public string fournisseur_siret { get; set; }		
		public string fournisseur_code_postal { get; set; }		
		public string fournisseur_ville { get; set; }		
		public double montant_min { get; set; }		
		public double montant_max { get; set; }		
		public DateTime date_de_notification { get; set; }		
		public DateTime date_de_debut { get; set; }		
		public DateTime date_de_fin { get; set; }		
		public double duree_du_marche_en_jours { get; set; }		
		public string perimetre_financier { get; set; }		
		public string article_cmp { get; set; }		
		public string categorie_d_achat_cle { get; set; }		
		public string categorie_d_achat_texte { get; set; }		
		
	}

	public class troncon_voie 
	{
        public static int recordNumber =24785;

        public static string datasetid ="troncon_voie";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public int n_sq_tv { get; set; }		
		public int c_niveau { get; set; }		
		public string b_voiedup { get; set; }		
		public int n_voieaddg { get; set; }		
		public string c_suf1addg { get; set; }		
		public int n_voieadfg { get; set; }		
		public string c_suf1adfg { get; set; }		
		public int n_voieaddd { get; set; }		
		public string c_suf1addd { get; set; }		
		public int n_voieadfd { get; set; }		
		public string c_suf1adfd { get; set; }		
		public int c_coinsee { get; set; }		
		public int n_sq_vo { get; set; }		
		public int objectid { get; set; }		
		public int c_tvniv1 { get; set; }		
		public int c_tvniv2 { get; set; }		
		public string c_domofftv { get; set; }		
		public int n_sq_co { get; set; }		
		
	}

	public class duvertpresdechezmoi 
	{
        public static int recordNumber =1605;

        public static string datasetid ="du-vert-pres-de-chez-moi";
		public string etat_de_la_proposition { get; set; }		
		public string numero { get; set; }		
		public int arrd { get; set; }		
		public string type_de_vegetalisation { get; set; }		
		public string adresse { get; set; }		
		public string commentaire_accompagnant_la_proposition { get; set; }		
		public string propositions_non_realisables_avis_de_la_deve { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class mobilierstationnementparis2011 
	{
        public static int recordNumber =13728;

        public static string datasetid ="mobilierstationnementparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class relief_naturel 
	{
        public static int recordNumber =16358;

        public static string datasetid ="relief_naturel";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class adresse_paris 
	{
        public static int recordNumber =145459;

        public static string datasetid ="adresse_paris";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public int n_sq_ad { get; set; }		
		public int n_voie { get; set; }		
		public string c_suf1 { get; set; }		
		public string c_suf2 { get; set; }		
		public string c_suf3 { get; set; }		
		public int c_ar { get; set; }		
		public double a_nvoie { get; set; }		
		public string b_angle { get; set; }		
		public string b_offstdf { get; set; }		
		public string b_affstdf { get; set; }		
		public string b_hors75 { get; set; }		
		public string l_nvoie { get; set; }		
		public string l_adr { get; set; }		
		public int n_sq_ar { get; set; }		
		public int n_sq_vo { get; set; }		
		public int objectid { get; set; }		
		
	}

	public class liste_des_bureaux_de_vote_2013_liste_des_bureaux 
	{
        public static int recordNumber =870;

        public static string datasetid ="liste_des_bureaux_de_vote_2013_liste_des_bureaux";
		public int bureau_id { get; set; }		
		public int bureau_arrondissement { get; set; }		
		public int bureau_numero { get; set; }		
		public string bureau_nom { get; set; }		
		public string bureau_localisation { get; set; }		
		public string bureau_addr_num { get; set; }		
		public string bureau_addr { get; set; }		
		public int bureau_addr_arron { get; set; }		
		public string column_9 { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class conseilsquartiers 
	{
        public static int recordNumber =121;

        public static string datasetid ="conseils-quartiers";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string no_consqrt { get; set; }		
		public double area { get; set; }		
		public string nom_quart { get; set; }		
		public int nar { get; set; }		
		public double nsq_ca { get; set; }		
		public int objectid { get; set; }		
		public double shape_area { get; set; }		
		public double shape_len { get; set; }		
		
	}

	public class parcsetjardinsparis2010 
	{
        public static int recordNumber =942;

        public static string datasetid ="parcsetjardinsparis2010";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public int annee_ouve { get; set; }		
		public int annee_reno { get; set; }		
		public int annee_chan { get; set; }		
		public string nom_ev { get; set; }		
		public string ancien_nom { get; set; }		
		public int adresse_nu { get; set; }		
		public string ouvert_fer { get; set; }		
		public double surface_to { get; set; }		
		public string adresse { get; set; }		
		public int ardt { get; set; }		
		
	}

	public class filiationvoiesparis2012 
	{
        public static int recordNumber =8623;

        public static string datasetid ="filiationvoiesparis2012";
		public string typvoie { get; set; }		
		public string nomvoie { get; set; }		
		public string texte { get; set; }		
		
	}

	public class comptesadministratifsprincipauxvilledepartement 
	{
        public static int recordNumber =16735;

        public static string datasetid ="comptes-administratifs-principaux-ville-departement";
		public string exercice_comptable { get; set; }		
		public string budget { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_d_operation_r_o_i_m { get; set; }		
		public string chapitre_budgetaire_cle { get; set; }		
		public string chapitre_niveau_vote_texte_descriptif { get; set; }		
		public int nature_budgetaire_cle { get; set; }		
		public string nature_budgetaire_texte { get; set; }		
		public string fonction_cle { get; set; }		
		public string fonction_texte { get; set; }		
		public double mandate_titre_apres_regul { get; set; }		
		
	}

	public class liste_des_sites_des_hotspots_paris_wifi 
	{
        public static int recordNumber =318;

        public static string datasetid ="liste_des_sites_des_hotspots_paris_wifi";
		public int objectid { get; set; }		
		public string nom_site { get; set; }		
		public string adresse { get; set; }		
		public string code_site { get; set; }		
		public string arrondissement { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class liste_des_associations_parisiennes 
	{
        public static int recordNumber =69992;

        public static string datasetid ="liste_des_associations_parisiennes";
		public string pr_nom_statutaire { get; set; }		
		public int cp_adresse_code_postal { get; set; }		
		public string cp_adresse_ville { get; set; }		
		public string sa_secteur_d_activit_1 { get; set; }		
		public string sa_secteur_d_activit_2 { get; set; }		
		public string sa_secteur_d_activit_3 { get; set; }		
		public string sa_libell_domaine_d_activit { get; set; }		
		public string sa_libell_secteur_d_activit { get; set; }		
		public string pv_public_vis { get; set; }		
		public string sg_secteur_gographique { get; set; }		
		public int cl_id_partenaire { get; set; }		
		
	}

	public class les1000titreslesplusreservesdanslesbibliothequesdepret 
	{
        public static int recordNumber =1000;

        public static string datasetid ="les-1000-titres-les-plus-reserves-dans-les-bibliotheques-de-pret";
		public int rang { get; set; }		
		public string support { get; set; }		
		public int nombre_de_reservations { get; set; }		
		public string titre { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class accessibilite_des_equipements_de_la_ville_de_paris 
	{
        public static int recordNumber =2324;

        public static string datasetid ="accessibilite_des_equipements_de_la_ville_de_paris";
		public string type { get; set; }		
		public string nom { get; set; }		
		public int numero { get; set; }		
		public string voie { get; set; }		
		public int code_postal { get; set; }		
		public string remarques { get; set; }		
		public int handicap_moteur { get; set; }		
		public int handicap_visuel { get; set; }		
		public int handicap_auditif { get; set; }		
		public string lien { get; set; }		
		public double coordx_wgs { get; set; }		
		public double coordy_wgs { get; set; }		
		public List<double> column_14 { get; set; }		
		
	}

	public class parcsdestationnementconcedesdelavilledeparis 
	{
        public static int recordNumber =148;

        public static string datasetid ="parcs-de-stationnement-concedes-de-la-ville-de-paris";
		public int identifiant { get; set; }		
		public string nom_du_parc_de_stationnement { get; set; }		
		public string adresse { get; set; }		
		public int arrdt { get; set; }		
		public string delegataire { get; set; }		
		public string site_du_delegataire { get; set; }		
		public string telephone { get; set; }		
		public int hauteur_des_parcs_cm { get; set; }		
		public string type_de_parc { get; set; }		
		public string horaires_ouvertures_pour_les_usagers_non_abonnes { get; set; }		
		public string ascenseur_debouchant_en_surface { get; set; }		
		public string acces_motos { get; set; }		
		public string acces_velos { get; set; }		
		public string vehicule_electrique_avec_dispositif_de_recharge { get; set; }		
		public string station_autopartage { get; set; }		
		public string date_d_application_du_tarif_abonnement { get; set; }		
		public double abonnement_1_mois { get; set; }		
		public int abonnement_1_an { get; set; }		
		public string tarif_petit_rouleur { get; set; }		
		public double tarif_petits_rouleurs_annuel_minimum { get; set; }		
		public double tarif_petits_rouleurs_annuel_maximum { get; set; }		
		public string tarif_resident { get; set; }		
		public string tarif_resident_annuel { get; set; }		
		public DateTime date_d_application_du_tarif_horaire { get; set; }		
		public string tarif_1_4_heure { get; set; }		
		public string tarif_1_2_heure { get; set; }		
		public string tarif_1_heure { get; set; }		
		public string tarif_1_5_h { get; set; }		
		public string tarif_2h { get; set; }		
		public string tarif_3h { get; set; }		
		public string tarif_4h { get; set; }		
		public string tarif_7h { get; set; }		
		public string tarif_8h { get; set; }		
		public string tarif_9h { get; set; }		
		public string tarif_10h { get; set; }		
		public string tarif_11h { get; set; }		
		public string tarif_12h { get; set; }		
		public string tarif_24h { get; set; }		
		public int nombre_de_places_pmr_accessibles { get; set; }		
		public string abonnement_mensuel_pmr { get; set; }		
		public string abonnement_trimestriel_pmr { get; set; }		
		public string abonnement_annuel_pmr { get; set; }		
		public string ascenseur_pmr_debouchant_en_surface { get; set; }		
		public string abonnement_mensuel_vehicule_electrique { get; set; }		
		public string abonnement_trimestriel_vehicule_electrique { get; set; }		
		public string abonnement_annuel_vehicule_electrique { get; set; }		
		public int nombre_de_places_moto { get; set; }		
		public string tarif_1ere_heure_moto { get; set; }		
		public string abonnement_mensuel_moto { get; set; }		
		public string abonnement_trimestriel_moto { get; set; }		
		public string abonnement_annuel_moto { get; set; }		
		public string velo_mensuel { get; set; }		
		public List<double> xy { get; set; }		
		
	}

	public class reseaucyclable 
	{
        public static int recordNumber =9223;

        public static string datasetid ="reseau-cyclable";
		public int objectid { get; set; }		
		public int arrdt { get; set; }		
		public string bois { get; set; }		
		public string type_voie { get; set; }		
		public string nom_voie { get; set; }		
		public string statut { get; set; }		
		public string typologie { get; set; }		
		public string sens_velo { get; set; }		
		public string typologie_simple { get; set; }		
		public double shape_len { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class logements_sociaux_finances_a_paris 
	{
        public static int recordNumber =2765;

        public static string datasetid ="logements_sociaux_finances_a_paris";
		public string nature_du_programme { get; set; }		
		public int annee_agrement { get; set; }		
		public string bailleur { get; set; }		
		public int nombre_total_de_logements_finances { get; set; }		
		public int dont_nombre_de_logements_plus { get; set; }		
		public int dont_nombre_de_logements_plus_cd { get; set; }		
		public int dont_nombre_de_logements_pla_i { get; set; }		
		public int dont_nombre_de_logements_pls { get; set; }		
		public string mode_de_realisation { get; set; }		
		public string commentaires { get; set; }		
		public int arrondissement { get; set; }		
		public string adresse_principale { get; set; }		
		public string adresse_2 { get; set; }		
		public string adresse_3 { get; set; }		
		public string adresse_4 { get; set; }		
		public List<double> xy { get; set; }		
		
	}

	public class resultatsdesvotesbudgetparticipatif 
	{
        public static int recordNumber =624;

        public static string datasetid ="resultats-des-votes-budget-participatif";
		public double identifiant { get; set; }		
		public string projets { get; set; }		
		public int montant { get; set; }		
		public int localisation { get; set; }		
		public double votes_par_internet { get; set; }		
		public double votes_physiques { get; set; }		
		public double total { get; set; }		
		public string projets_gagnants_non_retenus { get; set; }		
		public string theme { get; set; }		
		public List<double> xy { get; set; }		
		
	}

	public class listedesantenneswifi 
	{
        public static int recordNumber =84;

        public static string datasetid ="liste-des-antennes-wifi";
		public int objectid { get; set; }		
		public string localisation { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class arbresalignementparis2010 
	{
        public static int recordNumber =104025;

        public static string datasetid ="arbresalignementparis2010";
		public List<double> geom_x_y { get; set; }		
		public double circonfere { get; set; }		
		public string adresse { get; set; }		
		public double hauteurenm { get; set; }		
		public string espece { get; set; }		
		public string varieteouc { get; set; }		
		public DateTime dateplanta { get; set; }		
		
	}

	public class postespublicsdesbibliothequesspecialisees 
	{
        public static int recordNumber =29;

        public static string datasetid ="postes-publics-des-bibliotheques-specialisees";
		public string type_de_poste { get; set; }		
		public string localisation { get; set; }		
		public int nombre_d_ordinateurs { get; set; }		
		public List<double> position { get; set; }		
		
	}

	public class positionsstatutairesparticulieresdetachementsbilansocial 
	{
        public static int recordNumber =46;

        public static string datasetid ="positions-statutaires-particulieres-detachements-bilan-social";
		public string collectivite { get; set; }		
		public string statut { get; set; }		
		public string type_de_detachement { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class bilancomptable 
	{
        public static int recordNumber =69;

        public static string datasetid ="bilan-comptable";
		public string actif_passif { get; set; }		
		public string poste { get; set; }		
		public string detail { get; set; }		
				
				
				
				
		public string empty { get; set; }		
		public string empty0 { get; set; }		
		public string empty1 { get; set; }		
		
	}

	public class immobilisationsetatdesentrees 
	{
        public static int recordNumber =6859;

        public static string datasetid ="immobilisations-etat-des-entrees";
		public string publication { get; set; }		
		public string collectivite { get; set; }		
		public string rubrique { get; set; }		
		public string detail { get; set; }		
		public string sous_detail { get; set; }		
		public string nature { get; set; }		
		public string ndeg_immobilisation { get; set; }		
		public string ndeg_subs { get; set; }		
		public string designation_du_bien_amenageurs { get; set; }		
		public DateTime date_d_acquisition { get; set; }		
		public double valeur_d_acquisition { get; set; }		
		public double variation_sur_exercice_en_cours { get; set; }		
		public int duree_d_amort { get; set; }		
		public string observations { get; set; }		
		
	}

	public class immobilisationsetatdesamortissements 
	{
        public static int recordNumber =30557;

        public static string datasetid ="immobilisations-etat-des-amortissements";
		public string publication { get; set; }		
		public string collectivite { get; set; }		
		public string nature { get; set; }		
		public DateTime date_d_acquisition { get; set; }		
		public string site { get; set; }		
		public string ndeg_immobilisation { get; set; }		
		public string ndeg_subs { get; set; }		
		public string designation_des_ensembles { get; set; }		
		public string observation { get; set; }		
		public double valeur_d_acquisition { get; set; }		
		public string duree_amort { get; set; }		
		public double cumul_amort_anterieurs { get; set; }		
		public double vnc_debut_exercice { get; set; }		
		public double amort_exercice { get; set; }		
		public double vnc_fin_exercice { get; set; }		
		
	}

	public class statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement 
	{
        public static int recordNumber =880;

        public static string datasetid ="statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement";
		public string type_d_acte { get; set; }		
		public int annee { get; set; }		
		public string arrondissement { get; set; }		
		public int nombre { get; set; }		
		
	}

	public class concessionsredevancespercues 
	{
        public static int recordNumber =1003;

        public static string datasetid ="concessions-redevances-percues";
		public int numero { get; set; }		
		public DateTime exercice_comptable { get; set; }		
		public string direction { get; set; }		
		public string ndeg_contrat { get; set; }		
		public string nature_du_contrat { get; set; }		
		public string code_nature_du_contrat { get; set; }		
		public DateTime deb_valid { get; set; }		
		public DateTime fin_valid { get; set; }		
		public string objet_du_contrat { get; set; }		
		public string libelle_du_tiers { get; set; }		
		public string code_reference_du_tiers { get; set; }		
		public string redevance_disponible_non_disponible { get; set; }		
		public double somme_de_montant_liquide_2014 { get; set; }		
		
	}

	public class evolutiondescorpslesplusetlesmoinsfeminises 
	{
        public static int recordNumber =21;

        public static string datasetid ="evolution-des-corps-les-plus-et-les-moins-feminises";
		public string type_de_corps { get; set; }		
		public string corps { get; set; }		
		public int femmes { get; set; }		
		public int hommes { get; set; }		
		public DateTime date { get; set; }		
		
	}

	public class statistiques_de_creation_d_actes_d_etat_civil_par_mois 
	{
        public static int recordNumber =528;

        public static string datasetid ="statistiques_de_creation_d_actes_d_etat_civil_par_mois";
		public string mois { get; set; }		
		public string type_d_acte { get; set; }		
		public string annee { get; set; }		
		public int nombre { get; set; }		
		
	}

	public class effectifspermanentspartranchedagebilansocial 
	{
        public static int recordNumber =87;

        public static string datasetid ="effectifs-permanents-par-tranche-dage-bilan-social";
		public string collectivite { get; set; }		
		public string statut { get; set; }		
		public string nature_du_temps_de_travail { get; set; }		
		public string tranche_d_age { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class bilancomptablesynthetique 
	{
        public static int recordNumber =29;

        public static string datasetid ="bilan-comptable-synthetique";
		public string actif_passif { get; set; }		
		public string detail { get; set; }		
		public string sous_detail { get; set; }		
		public double montant { get; set; }		
		public string empty1 { get; set; }		
		
	}

	public class hydro_ev 
	{
        public static int recordNumber =80;

        public static string datasetid ="hydro_ev";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public double sum_area { get; set; }		
		public string milieu { get; set; }		
		public string faune { get; set; }		
		public string nom_ev { get; set; }		
		public string caract { get; set; }		
		public string type_zone { get; set; }		
		public int ardt { get; set; }		
		
	}

	public class emargementmunicipal 
	{
        public static int recordNumber =1305;

        public static string datasetid ="emargement-municipal";
		public string elus { get; set; }		
		public string session { get; set; }		
		public string etat { get; set; }		
		public int nombre_de_demijournees_excusees { get; set; }		
		public string nombre_de_demijournees_ri { get; set; }		
		public int nombre_de_demijournees_absent { get; set; }		
		public int annee { get; set; }		
		
	}

	public class lescimetieresdivisions 
	{
        public static int recordNumber =873;

        public static string datasetid ="les-cimetieres-divisions";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public int num_div { get; set; }		
		public double shape_leng { get; set; }		
		public double surface { get; set; }		
		
	}

	public class les_1000_titres_les_plus_empruntes_de_2012 
	{
        public static int recordNumber =1000;

        public static string datasetid ="les_1000_titres_les_plus_empruntes_de_2012";
		public int rang { get; set; }		
		public string type_de_document { get; set; }		
		public int prets { get; set; }		
		public string titre { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class les_1000_titres_les_plus_recherches_en_2013 
	{
        public static int recordNumber =1000;

        public static string datasetid ="les_1000_titres_les_plus_recherches_en_2013";
		public double rang { get; set; }		
		public string type_de_document { get; set; }		
		public double nombre_de_recherches { get; set; }		
		public string titre_avec_lien_vers_le_catalogue { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class promotionsdegradesuiteaexamenprofessionnel 
	{
        public static int recordNumber =27;

        public static string datasetid ="promotions-de-grade-suite-a-examen-professionnel";
		public string collectivite { get; set; }		
		public string categorie { get; set; }		
		public string grade { get; set; }		
		public int inscrits_femmes { get; set; }		
		public int inscrits_hommes { get; set; }		
		public int nombre_de_postes_offerts { get; set; }		
		public int femmes_promues { get; set; }		
		public int hommes_promus { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class subventionsversees 
	{
        public static int recordNumber =6473;

        public static string datasetid ="subventions-versees";
		public string publication { get; set; }		
		public string collectivite { get; set; }		
		public string categorie { get; set; }		
		public string nature_juridique { get; set; }		
		public string nom_de_l_organisme_beneficiaire_d_une_subvention { get; set; }		
		public string nom_de_la_rue { get; set; }		
		public string ville { get; set; }		
		public string cp { get; set; }		
		public int montant_de_la_subvention { get; set; }		
		public int mise_a_disposition_locaux { get; set; }		
		public int mise_a_disposition_personnel { get; set; }		
		public int prestations_diverses { get; set; }		
		
	}

	public class tempsdetravaildeseffectifstitulairespermanentsbilansocial 
	{
        public static int recordNumber =45;

        public static string datasetid ="temps-de-travail-des-effectifs-titulaires-permanents-bilan-social";
		public string collectivite { get; set; }		
		public string categorie { get; set; }		
		public int quotite_de_temps_de_travail { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class les1000titreslespluspretesparsupport 
	{
        public static int recordNumber =23078;

        public static string datasetid ="les-1000-titres-les-plus-pretes-par-support";
		public string support { get; set; }		
		public string auteur { get; set; }		
		public string titre { get; set; }		
		public double prets_2014 { get; set; }		
		
	}

	public class attractions_foraines_sur_l_espace_public 
	{
        public static int recordNumber =29;

        public static string datasetid ="attractions_foraines_sur_l_espace_public";
		public int arrt { get; set; }		
		public string lieux { get; set; }		
		public string categorie_de_jeux_forains { get; set; }		
		public string horaires_de_fin_d_activite { get; set; }		
		
	}

	public class listedesstationsdeservicesdevehicules 
	{
        public static int recordNumber =113;

        public static string datasetid ="liste-des-stations-de-services-de-vehicules";
		public int arr { get; set; }		
		public string adresse_precision_streetview { get; set; }		
		public string commentaires { get; set; }		
		public List<double> geo_point { get; set; }		
		
	}

	public class dettegarantie 
	{
        public static int recordNumber =42573;

        public static string datasetid ="dette-garantie";
		public DateTime annee_de_publication { get; set; }		
		public string collectivite { get; set; }		
		public string nature { get; set; }		
		public DateTime annee_de_mobilisation { get; set; }		
		public string profil_d_amort_de_l_emprunt { get; set; }		
		public string designation_du_beneficiaire { get; set; }		
		public string objet_de_l_emprunt_garanti { get; set; }		
		public string organisme_preteur_ou_chef_de_file { get; set; }		
		public double montant_initial { get; set; }		
		public double capital_restant_du_au_31_12_de_l_annee_de_publication { get; set; }		
		public double duree_residuelle { get; set; }		
		public string periodicite_des_remboursements { get; set; }		
		public string taux_initial_taux { get; set; }		
		public string taux_initial_index { get; set; }		
		public double taux_initial_taux_actuariel { get; set; }		
		public string taux_a_la_date_du_vote_du_budget_ou_taux_moyen_constate_sur_l_annee_taux { get; set; }		
		public string taux_a_la_date_du_vote_du_budget_ou_taux_moyen_constate_sur_l_annee_index { get; set; }		
		public double taux_a_la_date_du_vote_du_budget_ou_taux_moyen_constate_sur_l_annee_niveau_de_taux { get; set; }		
		public double annuite_garantie_au_cours_de_l_exercice_en_interets { get; set; }		
		public double annuite_garantie_au_cours_de_l_exercice_en_capital { get; set; }		
		
	}

	public class cheminement_d_assainissement 
	{
        public static int recordNumber =34529;

        public static string datasetid ="cheminement_d_assainissement";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class mobiliers_de_voies_routieres_de_type_barriere 
	{
        public static int recordNumber =134277;

        public static string datasetid ="mobiliers_de_voies_routieres_de_type_barriere";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class panneaux_d_affichage_associatifs 
	{
        public static int recordNumber =288;

        public static string datasetid ="panneaux_d_affichage_associatifs";
		public string localisation_des_panneaux_d_affichage { get; set; }		
		public string precision { get; set; }		
		public int r { get; set; }		
		public int format_1m2 { get; set; }		
		public int format_2m2 { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class equipements_de_proximite 
	{
        public static int recordNumber =2193;

        public static string datasetid ="equipements_de_proximite";
		public string mairie_gestionnaire { get; set; }		
		public string type_d_equipement { get; set; }		
		public string designation_longue { get; set; }		
		public int ap_num { get; set; }		
		public string ap_cnu { get; set; }		
		public int ap_cp { get; set; }		
		public string ap_voie { get; set; }		
		
	}

	public class tonnages_de_la_collecte_du_verre 
	{
        public static int recordNumber =21;

        public static string datasetid ="tonnages_de_la_collecte_du_verre";
		public int granularite { get; set; }		
		public string janv_11 { get; set; }		
		public string fevr_11 { get; set; }		
		public string mars_11 { get; set; }		
		public string avr_11 { get; set; }		
		public string mai_11 { get; set; }		
		public string juin_11 { get; set; }		
		public string juil_11 { get; set; }		
		public DateTime aout_11 { get; set; }		
		public string sept_11 { get; set; }		
		public string oct_11 { get; set; }		
		public string nov_11 { get; set; }		
		public string dec_11 { get; set; }		
		public List<double> total_arrondissement_2011 { get; set; }		
		
	}

	public class effectifstitulairespermanents 
	{
        public static int recordNumber =1291;

        public static string datasetid ="effectifs-titulaires-permanents";
		public string collectivite { get; set; }		
		public string corps_et_emplois { get; set; }		
		public string grade { get; set; }		
		public string specialite { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class distributeurspreservatifsmasculinsparis2012 
	{
        public static int recordNumber =31;

        public static string datasetid ="distributeurspreservatifsmasculinsparis2012";
		public string annee_installation { get; set; }		
		public string site { get; set; }		
		public string adresse { get; set; }		
		public int arrond { get; set; }		
		public string adresse_complete { get; set; }		
		public string acces { get; set; }		
		public string horaires_normal { get; set; }		
		public string horaires_vacances_ete { get; set; }		
		public string horaires_vacances_hiver { get; set; }		
		public List<double> xy { get; set; }		
		
	}

	public class pim 
	{
        public static int recordNumber =46;

        public static string datasetid ="pim";
		public string politique_publique { get; set; }		
		public string detail { get; set; }		
				
		
	}

	public class volumesnonbatisparis2011 
	{
        public static int recordNumber =125140;

        public static string datasetid ="volumesnonbatisparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string c_nat_nb { get; set; }		
		public string l_nat_nb { get; set; }		
		public string c_src { get; set; }		
		public string l_src { get; set; }		
		public double m2 { get; set; }		
		public double x { get; set; }		
		public double y { get; set; }		
		public int n_ar { get; set; }		
		public int n_qu { get; set; }		
		public DateTime d_cre { get; set; }		
		public DateTime d_maj { get; set; }		
		
	}

	public class detail_du_bati 
	{
        public static int recordNumber =487476;

        public static string datasetid ="detail_du_bati";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class liste_des_bureaux_de_vote_2013_voies_de_paris 
	{
        public static int recordNumber =7612;

        public static string datasetid ="liste_des_bureaux_de_vote_2013_voies_de_paris";
		public string voie_id { get; set; }		
		public int arrondissement { get; set; }		
		public string libelle_voie_long { get; set; }		
		public string type_voie_court { get; set; }		
		public string denomination_voie_court { get; set; }		
		public List<double> column_6 { get; set; }		
		
	}

	public class promotionsparcategoriehommesfemmes 
	{
        public static int recordNumber =9;

        public static string datasetid ="promotions-par-categorie-hommes-femmes";
		public string categorie { get; set; }		
		public int nombre_total_de_femmes { get; set; }		
		public int nombre_total_d_hommes { get; set; }		
		public int nombre_de_femmes_promouvables { get; set; }		
		public int nombre_d_hommes_promouvables { get; set; }		
		public int femmes_promues { get; set; }		
		public int hommes_promus { get; set; }		
		public DateTime annee { get; set; }		
		
	}

	public class tempsdetravaildeseffectifsnontitulairespermanentsbilansocial 
	{
        public static int recordNumber =33;

        public static string datasetid ="temps-de-travail-des-effectifs-non-titulaires-permanents-bilan-social";
		public string collectivite { get; set; }		
		public string categorie { get; set; }		
		public double quotite_de_temps_de_travail { get; set; }		
		public int nombre_de_femmes { get; set; }		
		public int nombre_d_hommes { get; set; }		
		public DateTime date { get; set; }		
		
	}

	public class consultations_des_centres_de_sante 
	{
        public static int recordNumber =5189;

        public static string datasetid ="consultations_des_centres_de_sante";
		public string nom_de_lactivite { get; set; }		
		public string specialite { get; set; }		
		public string description { get; set; }		
		public string nom_du_centre_de_sante { get; set; }		
		public string jour { get; set; }		
		public string heure_de_debut { get; set; }		
		public string heure_de_fin { get; set; }		
		public string adresse_nom_du_centre { get; set; }		
		public string adresse_rue { get; set; }		
		public string adresse_code_postal { get; set; }		
		public string adresse_ville { get; set; }		
		public string numero_de_telephone { get; set; }		
		public string adresse_mail { get; set; }		
		public string site_internet { get; set; }		
		public double latitude { get; set; }		
		public double longitude { get; set; }		
		public List<double> coordonnees_geographiques { get; set; }		
		
	}

	public class tonnages_des_dechets_bacs_verts 
	{
        public static int recordNumber =21;

        public static string datasetid ="tonnages_des_dechets_bacs_verts";
		public int granularite { get; set; }		
		public string janv_11 { get; set; }		
		public string fevr_11 { get; set; }		
		public string mars_11 { get; set; }		
		public string avr_11 { get; set; }		
		public string mai_11 { get; set; }		
		public string juin_11 { get; set; }		
		public string juil_11 { get; set; }		
		public string aout_11 { get; set; }		
		public string sept_11 { get; set; }		
		public string oct_11 { get; set; }		
		public string nov_11 { get; set; }		
		public string dec_11 { get; set; }		
		public string total_arrondissement_2011 { get; set; }		
		
	}

	public class listemuseesdefranceaparis 
	{
        public static int recordNumber =59;

        public static string datasetid ="liste-musees-de-france-a-paris";
		public string nomreg { get; set; }		
		public string nomdep { get; set; }		
		public string ferme { get; set; }		
		public string annreouv { get; set; }		
		public string annexe { get; set; }		
		public string nom_du_musee { get; set; }		
		public string adr { get; set; }		
		public int cp { get; set; }		
		public string ville { get; set; }		
		public string sitweb { get; set; }		
		public string fermeture_annuelle { get; set; }		
		public string periode_ouverture { get; set; }		
		public string jours_nocturnes { get; set; }		
		public List<double> coordonnees_ { get; set; }		
		
	}

	public class zonesderencontre 
	{
        public static int recordNumber =31;

        public static string datasetid ="zones-de-rencontre";
		public int objectid { get; set; }		
		public string nom_zca { get; set; }		
		public double shape_area { get; set; }		
		public double shape_len { get; set; }		
		public int first_arrdt { get; set; }		
		public DateTime first_date_arr { get; set; }		
		public string first_type_arr { get; set; }		
		public int first_stv { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class mobiliereaupotableparis2011 
	{
        public static int recordNumber =65966;

        public static string datasetid ="mobiliereaupotableparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class eclairagepublicsignalisationtricolore 
	{
        public static int recordNumber =357470;

        public static string datasetid ="eclairagepublicsignalisationtricolore";
		public int objectid { get; set; }		
		public string cod_ouvrag { get; set; }		
		public string foyer { get; set; }		
		public string lib_domain { get; set; }		
		public string lib_ouvrag { get; set; }		
		public string observatio { get; set; }		
		public double posx_ouvra { get; set; }		
		public double posy_ouvra { get; set; }		
		public string lib_regime { get; set; }		
		public string lib_tarif { get; set; }		
		public string voieent_vo { get; set; }		
		public string faceop_ouv { get; set; }		
		public string numvoie_ou { get; set; }		
		public string bister_ouv { get; set; }		
		public string nature_voi { get; set; }		
		public string lib_voie { get; set; }		
		public string lib_voiedo { get; set; }		
		public string lib_secteu { get; set; }		
		public string lib_region { get; set; }		
		public string lib_regi_1 { get; set; }		
		public string cod_suppor { get; set; }		
		public string lib_suppor { get; set; }		
		public double hauteur_su { get; set; }		
		public double dureevie_s { get; set; }		
		public string unitevie_s { get; set; }		
		public string lib_supp_1 { get; set; }		
		public string cod_lumina { get; set; }		
		public string lib_lumina { get; set; }		
		public string modele_lum { get; set; }		
		public double dureevie_l { get; set; }		
		public string unitevie_l { get; set; }		
		public string lib_lumi_1 { get; set; }		
		public string lib_fourni { get; set; }		
		public string cod_lampe { get; set; }		
		public string lib_lampe { get; set; }		
		public double pw_lampe { get; set; }		
		public string lib_lampef { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class abrivoyageursecranstactilesconnectes 
	{
        public static int recordNumber =78;

        public static string datasetid ="abri-voyageurs-ecrans-tactiles-connectes";
		public string ndeg_mobilier { get; set; }		
		public string latitude { get; set; }		
		public string longitude { get; set; }		
		public string adresse { get; set; }		
		public string codee_insee { get; set; }		
		public string code_postal { get; set; }		
		public string arrondissement { get; set; }		
		public string adresse0 { get; set; }		
		public string complement_adresse { get; set; }		
		public List<double> xy { get; set; }		
		
	}

	public class zonesdecirculationapaiseeaparis 
	{
        public static int recordNumber =124;

        public static string datasetid ="zones-de-circulation-apaisee-a-paris";
		public int objectid { get; set; }		
		public string nom_zca { get; set; }		
		public int stv { get; set; }		
		public DateTime date_arr { get; set; }		
		public string type_arr { get; set; }		
		public int arrdt { get; set; }		
		public double shape_area { get; set; }		
		public double shape_len { get; set; }		
		public string reglement { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret 
	{
        public static int recordNumber =1000;

        public static string datasetid ="les-1000-titres-les-plus-recherches-au-catalogue-des-bibliotheques-de-pret";
		public int rang { get; set; }		
		public string support { get; set; }		
		public int nombre_de_recherches { get; set; }		
		public string titre { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class domiciliationdesagentsbilansocial 
	{
        public static int recordNumber =38053;

        public static string datasetid ="domiciliation-des-agents-bilan-social";
		public double ndeg_enregitrement { get; set; }		
		public DateTime date { get; set; }		
		public string collectivite { get; set; }		
		public string sexe { get; set; }		
		public string categorie { get; set; }		
		public string nature { get; set; }		
		public string zone { get; set; }		
		public int code_postal { get; set; }		
		public string departement { get; set; }		
		public string ville { get; set; }		
		public int effectif { get; set; }		
		public string direction { get; set; }		
		public List<double> geoloc { get; set; }		
		
	}

	public class stationnementvoiepubliqueemplacements 
	{
        public static int recordNumber =116344;

        public static string datasetid ="stationnement-voie-publique-emplacements";
		public int objectid_1 { get; set; }		
		public string zonres { get; set; }		
		public string regpri { get; set; }		
		public string regpar { get; set; }		
		public string typsta { get; set; }		
		public string typ { get; set; }		
		public double lon { get; set; }		
		public double lar { get; set; }		
		public string numvoi { get; set; }		
		public string arrond { get; set; }		
		public string typvoie { get; set; }		
		public string nomvoie { get; set; }		
		public double plaval { get; set; }		
		public double shape_area { get; set; }		
		public double shape_len { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public List<double> geo_point_2d { get; set; }		
		
	}

	public class voiesactuellesparis2012 
	{
        public static int recordNumber =6357;

        public static string datasetid ="voiesactuellesparis2012";
		public string typvoie { get; set; }		
		public string prevoie { get; set; }		
		public string nomvoie { get; set; }		
		public string typo { get; set; }		
		public DateTime date_arret { get; set; }		
		public string cdgi { get; set; }		
		public string histo { get; set; }		
		public string texte { get; set; }		
		public string quartier { get; set; }		
		public string arron { get; set; }		
		public List<double> geo_coordinates { get; set; }		
		
	}

	public class comptesadministratifsetatsspeciauxdarrondissement 
	{
        public static int recordNumber =13713;

        public static string datasetid ="comptes-administratifs-etats-speciaux-darrondissement";
		public DateTime exercice_comptable { get; set; }		
		public string budget { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_d_operation_r_o_i_m { get; set; }		
		public string chapitre_budgetaire_cle { get; set; }		
		public string chapitre_budgetaire_texte { get; set; }		
		public string nature_budgetaire_cle { get; set; }		
		public string nature_budgetaire_texte { get; set; }		
		public string fonction_cle { get; set; }		
		public string fonction_texte { get; set; }		
		public double mandate_titre_apres_regul { get; set; }		
		
	}

	public class paris_taxis_data 
	{
        public static int recordNumber =122;

        public static string datasetid ="paris_taxis_data";
		public string station_id { get; set; }		
		public int declared_taxis { get; set; }		
		public int declared_users { get; set; }		
		public string city { get; set; }		
		public int station_number { get; set; }		
		public string address_precision { get; set; }		
		public string address { get; set; }		
		public List<double> geo_coordinates { get; set; }		
		public string station_name { get; set; }		
		public string zip_code { get; set; }		
		public DateTime last_updated { get; set; }		
		
	}

	public class arretesinsalubriteparis2010 
	{
        public static int recordNumber =276;

        public static string datasetid ="arretesinsalubriteparis2010";
		public DateTime date_controle { get; set; }		
		public int numero { get; set; }		
		public string type { get; set; }		
		public string voie { get; set; }		
		public int arrdt { get; set; }		
		public string arrete { get; set; }		
		public DateTime date_signature { get; set; }		
		public DateTime date_notification { get; set; }		
		public List<double> geo_coordinates { get; set; }		
		
	}

	public class les_1000_titres_les_plus_empruntes_2012_par_bibliotheque 
	{
        public static int recordNumber =57174;

        public static string datasetid ="les_1000_titres_les_plus_empruntes_2012_par_bibliotheque";
		public string bibliotheque { get; set; }		
		public int rang { get; set; }		
		public int prets { get; set; }		
		public string type_de_document { get; set; }		
		public string titre { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class etalages_et_terrasses_autorisees_a_paris 
	{
        public static int recordNumber =18745;

        public static string datasetid ="etalages_et_terrasses_autorisees_a_paris";
		public string dossier { get; set; }		
		public int arrondissement { get; set; }		
		public string adresse { get; set; }		
		public string lieu { get; set; }		
		public string libelle_type_objet { get; set; }		
		public double dima { get; set; }		
		public double dimb { get; set; }		
		public string dosred { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class resultats_electoraux 
	{
        public static int recordNumber =124736;

        public static string datasetid ="resultats_electoraux";
		public string libelle_du_scrutin { get; set; }		
		public DateTime date_du_scrutin_jj_mm_ssaa { get; set; }		
		public int numero_d_arrondissement_01_a_20 { get; set; }		
		public int numero_de_bureau_de_vote_000_a_999 { get; set; }		
		public int numero_de_la_circonscription_01_a_18_a_partir_de_2012_ou_21_avant_2012 { get; set; }		
		public string code_commune_insee_751_01_a_20 { get; set; }		
		public List<double> coordonnees_geo { get; set; }		
		public string commune_paris_01_a_20 { get; set; }		
		public string nombre_d_inscrits_du_bureau_de_vote { get; set; }		
		public int nombre_de_votants_du_bureau_de_vote { get; set; }		
		public int nombre_d_exprimes_du_bureau_de_vote { get; set; }		
		public int numero_de_depot_du_candidat_ou_liste { get; set; }		
		public string nom_du_candidat_ou_liste { get; set; }		
		public string prenom_du_candidat_ou_liste { get; set; }		
		public int nombre_de_voix_du_candidat_ou_liste_obtenues_pour_le_bureau_de_vote { get; set; }		
		public string nombre_de_blancs_uniquement_du_bureau_de_vote { get; set; }		
		public string nombre_de_nuls_uniquement_du_bureau_de_vote { get; set; }		
		public string nombre_de_procurations_du_bureau_de_vote { get; set; }		
		
	}

	public class plan_de_l_hemicycle_du_conseil_de_paris 
	{
        public static int recordNumber =326;

        public static string datasetid ="plan_de_l_hemicycle_du_conseil_de_paris";
		public int place_dans_l_hemicycle { get; set; }		
		public string civilite { get; set; }		
		public string prenom { get; set; }		
		public string nom { get; set; }		
		public string groupe_politique { get; set; }		
		public string president_de_groupe { get; set; }		
		public string maire_de_paris_adjoint_e_au_maire_conseillere_deleguee { get; set; }		
		public string maire_d_arrondissement { get; set; }		
		
	}

	public class etiquettes_energetiques_des_batiments_municipaux 
	{
        public static int recordNumber =1743;

        public static string datasetid ="etiquettes_energetiques_des_batiments_municipaux";
		public int ndeg_equipement { get; set; }		
		public string type_d_equipement { get; set; }		
		public string ndeg { get; set; }		
		public string adresse { get; set; }		
		public int code_postal { get; set; }		
		public string ville { get; set; }		
		public string annee { get; set; }		
		public string adresse_complete { get; set; }		
		public string etiquette_energie { get; set; }		
		public string etiquette_climat { get; set; }		
		public string observation { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class accidentologie 
	{
        public static int recordNumber =13630;

        public static string datasetid ="accidentologie";
		public DateTime date { get; set; }		
		public string heure { get; set; }		
		public int dept { get; set; }		
		public int com { get; set; }		
		public string adresse { get; set; }		
		public int code_postal { get; set; }		
		public string carr { get; set; }		
		public int segm { get; set; }		
		public string lieu_1_nomv { get; set; }		
		public string lieu_2_nomv { get; set; }		
		public string vehicule_1_cadmin { get; set; }		
		public string vehicule_1_lveh { get; set; }		
		public string vehicle_2_cadmin { get; set; }		
		public string vehicule_2_lveh { get; set; }		
		public string vehicule_3_cadmin { get; set; }		
		public string vehicule_3_lveh { get; set; }		
		public string usager_1_catu { get; set; }		
		public string usager_1_grav { get; set; }		
		public string usager_1_lveh { get; set; }		
		public string usager_2_catu { get; set; }		
		public string usager_2_grav { get; set; }		
		public string usager_2_lveh { get; set; }		
		public string usager_3_catu { get; set; }		
		public string usager_3_grav { get; set; }		
		public string usager_3_lveh { get; set; }		
		public string usager_4_catu { get; set; }		
		public string usager_4_grav { get; set; }		
		public string usager_4_lveh { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class lescimetieresemprises 
	{
        public static int recordNumber =20;

        public static string datasetid ="les-cimetieres-emprises";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public string nom_ev { get; set; }		
		public int annee_crea { get; set; }		
		public int annee_reno { get; set; }		
		public string horaire { get; set; }		
		public string acces { get; set; }		
		public int nb_divisio { get; set; }		
		public double surf_divis { get; set; }		
		public int nb_sepult { get; set; }		
		public double surf_tot { get; set; }		
		
	}

	public class mobilierenvironnementparis2011 
	{
        public static int recordNumber =47088;

        public static string datasetid ="mobilierenvironnementparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class liste_des_etablissements_scolaires2 
	{
        public static int recordNumber =670;

        public static string datasetid ="liste_des_etablissements_scolaires2";
		public string n_etablissement { get; set; }		
		public string nom { get; set; }		
		public string type { get; set; }		
		public string adresse { get; set; }		
		public string ville { get; set; }		
		public int code_postal { get; set; }		
		public List<double> adresse_complete { get; set; }		
		
	}

	public class profil_petite_ceinture 
	{
        public static int recordNumber =523;

        public static string datasetid ="profil_petite_ceinture";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public string profil { get; set; }		
		public double longueur { get; set; }		
		public int ardt { get; set; }		
		
	}

	public class lessurfacesboisees 
	{
        public static int recordNumber =1491;

        public static string datasetid ="les-surfaces-boisees";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public double surface { get; set; }		
		public string typo { get; set; }		
		public string bois { get; set; }		
		public int n_bois { get; set; }		
		
	}

	public class liste_des_jardins_partages_a_paris 
	{
        public static int recordNumber =90;

        public static string datasetid ="liste_des_jardins_partages_a_paris";
		public List<double> geo_point_2d { get; set; }		
		public GeoShape geo_shape { get; set; }		
		public string type_jard { get; set; }		
		public string nom_ev { get; set; }		
		public string adresse { get; set; }		
		public int arrdt { get; set; }		
		public string nom_gerant { get; set; }		
		public string adr_gerant { get; set; }		
		public string charte { get; set; }		
		
	}

	public class sanisettesparis2011 
	{
        public static int recordNumber =398;

        public static string datasetid ="sanisettesparis2011";
		public List<double> geom_x_y { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		public GeoShape geom { get; set; }		
		
	}

	public class comptesadministratifsbudgetsannexes 
	{
        public static int recordNumber =423;

        public static string datasetid ="comptes-administratifs-budgets-annexes";
		public DateTime exercice_comptable { get; set; }		
		public string budget { get; set; }		
		public string section_budgetaire_i_f { get; set; }		
		public string sens_depense_recette { get; set; }		
		public string type_d_operation_r_o_i_m { get; set; }		
		public string chapitre_budgetaire_cle { get; set; }		
		public string chapitre_budgetaire_texte { get; set; }		
		public string nature_budgetaire_cle { get; set; }		
		public string nature_budgetaire_texte { get; set; }		
		public double mandate_titre_apres_regul { get; set; }		
		public string empty { get; set; }		
		public string empty0 { get; set; }		
		
	}

	public class cinemasaparis 
	{
        public static int recordNumber =88;

        public static string datasetid ="cinemas-a-paris";
		public int ndegauto { get; set; }		
		public string nom_etablissement { get; set; }		
		public int ecrans { get; set; }		
		public string fauteuils { get; set; }		
		public string art_et_essai { get; set; }		
		public string adresse { get; set; }		
		public int arrondissement { get; set; }		
		public List<double> coordonnees { get; set; }		
		
	}

	public class lestitreslespluspretes 
	{
        public static int recordNumber =815;

        public static string datasetid ="les-titres-les-plus-pretes";
		public string support { get; set; }		
		public int nombre_de_prets { get; set; }		
		public string titre { get; set; }		
		public string auteur { get; set; }		
		
	}

	public class tonnages_des_dechets_bacs_jaunes 
	{
        public static int recordNumber =21;

        public static string datasetid ="tonnages_des_dechets_bacs_jaunes";
		public string granularite { get; set; }		
		public string janv_11 { get; set; }		
		public string fevr_11 { get; set; }		
		public string mars_11 { get; set; }		
		public string avr_11 { get; set; }		
		public string mai_11 { get; set; }		
		public string juin_11 { get; set; }		
		public string juil_11 { get; set; }		
		public string aout_11 { get; set; }		
		public string sept_11 { get; set; }		
		public string oct_11 { get; set; }		
		public string nov_11 { get; set; }		
		public string dec_11 { get; set; }		
		public List<double> total_arrondissement_2011 { get; set; }		
		
	}

	public class mobiliertransportsparis2011 
	{
        public static int recordNumber =1866;

        public static string datasetid ="mobiliertransportsparis2011";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class lesarbres 
	{
        public static int recordNumber =90348;

        public static string datasetid ="les-arbres";
		public List<double> geo_point_2d { get; set; }		
		public string localisati { get; set; }		
		public string adresse { get; set; }		
		public double circonfere { get; set; }		
		public double hauteurenm { get; set; }		
		public string espece { get; set; }		
		public string varieteouc { get; set; }		
		public DateTime dateplanta { get; set; }		
		
	}

	public class liste_des_marches_de_quartier_a_paris 
	{
        public static int recordNumber =94;

        public static string datasetid ="liste_des_marches_de_quartier_a_paris";
		public string type { get; set; }		
		public string societe_gestionnaire { get; set; }		
		public string marche { get; set; }		
		public int arrondissement { get; set; }		
		public string localisation { get; set; }		
		public string adresse_complete_poi_approchant { get; set; }		
		public string lundi { get; set; }		
		public string mardi { get; set; }		
		public string mercredi { get; set; }		
		public string jeudi { get; set; }		
		public string vendredi { get; set; }		
		public string samedi { get; set; }		
		public string dimanche { get; set; }		
		public string jour_ferie { get; set; }		
		public List<double> geo_coordinates { get; set; }		
		
	}

	public class annuaire_immobilier_de_l_enseignement_superieur 
	{
        public static int recordNumber =589;

        public static string datasetid ="annuaire_immobilier_de_l_enseignement_superieur";
		public int ndeg_identifiant { get; set; }		
		public int cp { get; set; }		
		public string adresse { get; set; }		
		public string parcelle { get; set; }		
		public int surface_de_la_parcelle { get; set; }		
		public string proprietaire { get; set; }		
		public string occupant { get; set; }		
		public string type { get; set; }		
		public string tutelle_pedagogique { get; set; }		
		public string statut_public_prive_ville_de_paris { get; set; }		
		public string pres { get; set; }		
		
	}

	public class plaques_commemoratives_19391945 
	{
        public static int recordNumber =1219;

        public static string datasetid ="plaques_commemoratives_1939-1945";
		public int identifiant { get; set; }		
		public string commemore { get; set; }		
		public string adresse_complete { get; set; }		
		public string precision_adresse { get; set; }		
		public int column_5 { get; set; }		
		public List<double> coordonnees_geo { get; set; }		
		
	}

	public class liste_des_kiosques_presse_a_paris 
	{
        public static int recordNumber =401;

        public static string datasetid ="liste_des_kiosques_presse_a_paris";
		public string adresse { get; set; }		
		public int arrdt { get; set; }		
		public string type_de_kiosque { get; set; }		
		
	}

	public class resultatsdelelectionmunicipale20142emetour 
	{
        public static int recordNumber =1536;

        public static string datasetid ="resultats-de-lelection-municipale-2014-2eme-tour";
		public string column_1 { get; set; }		
		public DateTime column_2 { get; set; }		
		public string column_3 { get; set; }		
		public string column_4 { get; set; }		
		public string column_5 { get; set; }		
		public string column_6 { get; set; }		
		public string column_7 { get; set; }		
		public int column_8 { get; set; }		
		public int column_9 { get; set; }		
		public int column_10 { get; set; }		
		public string column_13 { get; set; }		
		public string column_11 { get; set; }		
		public int column_16 { get; set; }		
		public List<double> coordonnees_geo_wgs84 { get; set; }		
		
	}

	public class bati_donnees_geographiques 
	{
        public static int recordNumber =28573;

        public static string datasetid ="bati_donnees_geographiques";
		public List<double> geom_x_y { get; set; }		
		public GeoShape geom { get; set; }		
		public string niveau { get; set; }		
		public string info { get; set; }		
		public string libelle { get; set; }		
		
	}

	public class arbresremarquablesparis2011 
	{
        public static int recordNumber =97;

        public static string datasetid ="arbresremarquablesparis2011";
		public List<double> geom_x_y { get; set; }		
		public string arrondisse { get; set; }		
		public string genre { get; set; }		
		public string espece { get; set; }		
		public string famille { get; set; }		
		public string annee_pla { get; set; }		
		public double hauteur { get; set; }		
		public double circonf { get; set; }		
		public string adresse { get; set; }		
		public string nom_commun { get; set; }		
		public string variete { get; set; }		
		public int objectid { get; set; }		
		public string nom_ev { get; set; }		
		
	}

	public class stationsvelibdisponibilitesentempsreel 
	{
        public static int recordNumber =3581;

        public static string datasetid ="stations-velib-disponibilites-en-temps-reel";
		public int number { get; set; }		
		public string name { get; set; }		
		public string address { get; set; }		
		public List<double> position { get; set; }		
		public string banking { get; set; }		
		public string bonus { get; set; }		
		public string status { get; set; }		
		public string contract_name { get; set; }		
		public int bike_stands { get; set; }		
		public int available_bike_stands { get; set; }		
		public int available_bikes { get; set; }		
		public DateTime last_update { get; set; }		
		
	}

	public class stations_et_espaces_autolib_de_la_metropole_parisienne 
	{
        public static int recordNumber =869;

        public static string datasetid ="stations_et_espaces_autolib_de_la_metropole_parisienne";
		public string id { get; set; }		
		public string identifiant_autolib { get; set; }		
		public string rue { get; set; }		
		public int code_postal { get; set; }		
		public string ville { get; set; }		
		public List<double> field13 { get; set; }		
		public string emplacement { get; set; }		
		public int autolib { get; set; }		
		public int tiers { get; set; }		
		public int abri { get; set; }		
		
	}

	public class liste_des_prenoms_2004_a_2012 
	{
        public static int recordNumber =11000;

        public static string datasetid ="liste_des_prenoms_2004_a_2012";
		public string prenoms { get; set; }		
		public int nombre { get; set; }		
		public string sexe { get; set; }		
		public int annee { get; set; }		
		
	}

	public class evenementsaparis 
	{
        public static int recordNumber =71163;

        public static string datasetid ="evenements-a-paris";
		public string uid { get; set; }		
		public string link { get; set; }		
		public DateTime updated_at { get; set; }		
		public string space_time_info { get; set; }		
		public string image { get; set; }		
		public string image_thumb { get; set; }		
		public string share_url { get; set; }		
		public string lang { get; set; }		
		public string title { get; set; }		
		public string description { get; set; }		
		public string free_text { get; set; }		
		public string tags { get; set; }		
		public List<double> latlon { get; set; }		
		public string placename { get; set; }		
		public string address { get; set; }		
		public string department { get; set; }		
		public string region { get; set; }		
		public string city { get; set; }		
		public DateTime date_start { get; set; }		
		public DateTime date_end { get; set; }		
		public string pricing_info { get; set; }		
		public string program_uid { get; set; }		
		
	}
	public class ParisOpenDataContext : IDisposable
	{
		private MediaTypeWithQualityHeaderValue jsonHeader ;
		private ParisOpenData dataParis;
		private bool disposed = false;

		public ParisOpenDataContext()
        {
            dataParis = new ParisOpenData();
            jsonHeader = new MediaTypeWithQualityHeaderValue("application/json");
        }
	
		public IEnumerable<Record<postespublicsdesbibliothequesdepret>> postespublicsdesbibliothequesdepretDataset
		{ 
			get 
			{
				List<Record<postespublicsdesbibliothequesdepret>> result = new List<Record<postespublicsdesbibliothequesdepret>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < postespublicsdesbibliothequesdepret.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(postespublicsdesbibliothequesdepret.datasetid, postespublicsdesbibliothequesdepret.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<postespublicsdesbibliothequesdepret>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<budgetsvotesannexes>> budgetsvotesannexesDataset
		{ 
			get 
			{
				List<Record<budgetsvotesannexes>> result = new List<Record<budgetsvotesannexes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < budgetsvotesannexes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(budgetsvotesannexes.datasetid, budgetsvotesannexes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<budgetsvotesannexes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<formationparthemesbilansocial>> formationparthemesbilansocialDataset
		{ 
			get 
			{
				List<Record<formationparthemesbilansocial>> result = new List<Record<formationparthemesbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < formationparthemesbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(formationparthemesbilansocial.datasetid, formationparthemesbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<formationparthemesbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<etatdupersonnel>> etatdupersonnelDataset
		{ 
			get 
			{
				List<Record<etatdupersonnel>> result = new List<Record<etatdupersonnel>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < etatdupersonnel.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(etatdupersonnel.datasetid, etatdupersonnel.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<etatdupersonnel>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<recrutementdirectbilansocial>> recrutementdirectbilansocialDataset
		{ 
			get 
			{
				List<Record<recrutementdirectbilansocial>> result = new List<Record<recrutementdirectbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < recrutementdirectbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(recrutementdirectbilansocial.datasetid, recrutementdirectbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<recrutementdirectbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<titreslesplusreservesbibliothequesspecialisees>> titreslesplusreservesbibliothequesspecialiseesDataset
		{ 
			get 
			{
				List<Record<titreslesplusreservesbibliothequesspecialisees>> result = new List<Record<titreslesplusreservesbibliothequesspecialisees>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < titreslesplusreservesbibliothequesspecialisees.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(titreslesplusreservesbibliothequesspecialisees.datasetid, titreslesplusreservesbibliothequesspecialisees.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<titreslesplusreservesbibliothequesspecialisees>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<accidentdetravailetdetrajetparcorpsbilansocial>> accidentdetravailetdetrajetparcorpsbilansocialDataset
		{ 
			get 
			{
				List<Record<accidentdetravailetdetrajetparcorpsbilansocial>> result = new List<Record<accidentdetravailetdetrajetparcorpsbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < accidentdetravailetdetrajetparcorpsbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(accidentdetravailetdetrajetparcorpsbilansocial.datasetid, accidentdetravailetdetrajetparcorpsbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<accidentdetravailetdetrajetparcorpsbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<budgetvotesapautotrisationsdeprogrammes>> budgetvotesapautotrisationsdeprogrammesDataset
		{ 
			get 
			{
				List<Record<budgetvotesapautotrisationsdeprogrammes>> result = new List<Record<budgetvotesapautotrisationsdeprogrammes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < budgetvotesapautotrisationsdeprogrammes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(budgetvotesapautotrisationsdeprogrammes.datasetid, budgetvotesapautotrisationsdeprogrammes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<budgetvotesapautotrisationsdeprogrammes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lesconseillersdeparisde1977a2014>> lesconseillersdeparisde1977a2014Dataset
		{ 
			get 
			{
				List<Record<lesconseillersdeparisde1977a2014>> result = new List<Record<lesconseillersdeparisde1977a2014>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lesconseillersdeparisde1977a2014.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lesconseillersdeparisde1977a2014.datasetid, lesconseillersdeparisde1977a2014.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lesconseillersdeparisde1977a2014>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<positionsstatutairesparticulieresautrequedetachementbilansocial>> positionsstatutairesparticulieresautrequedetachementbilansocialDataset
		{ 
			get 
			{
				List<Record<positionsstatutairesparticulieresautrequedetachementbilansocial>> result = new List<Record<positionsstatutairesparticulieresautrequedetachementbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < positionsstatutairesparticulieresautrequedetachementbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(positionsstatutairesparticulieresautrequedetachementbilansocial.datasetid, positionsstatutairesparticulieresautrequedetachementbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<positionsstatutairesparticulieresautrequedetachementbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<tranchedagedetailleespour15corpsbilansocial>> tranchedagedetailleespour15corpsbilansocialDataset
		{ 
			get 
			{
				List<Record<tranchedagedetailleespour15corpsbilansocial>> result = new List<Record<tranchedagedetailleespour15corpsbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < tranchedagedetailleespour15corpsbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(tranchedagedetailleespour15corpsbilansocial.datasetid, tranchedagedetailleespour15corpsbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<tranchedagedetailleespour15corpsbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<formationparcategoriesbilansocial>> formationparcategoriesbilansocialDataset
		{ 
			get 
			{
				List<Record<formationparcategoriesbilansocial>> result = new List<Record<formationparcategoriesbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < formationparcategoriesbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(formationparcategoriesbilansocial.datasetid, formationparcategoriesbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<formationparcategoriesbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<recrutementsurconcoursbilansocial>> recrutementsurconcoursbilansocialDataset
		{ 
			get 
			{
				List<Record<recrutementsurconcoursbilansocial>> result = new List<Record<recrutementsurconcoursbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < recrutementsurconcoursbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(recrutementsurconcoursbilansocial.datasetid, recrutementsurconcoursbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<recrutementsurconcoursbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<utilisations_mensuelles_des_hotspots_paris_wifi>> utilisations_mensuelles_des_hotspots_paris_wifiDataset
		{ 
			get 
			{
				List<Record<utilisations_mensuelles_des_hotspots_paris_wifi>> result = new List<Record<utilisations_mensuelles_des_hotspots_paris_wifi>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < utilisations_mensuelles_des_hotspots_paris_wifi.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(utilisations_mensuelles_des_hotspots_paris_wifi.datasetid, utilisations_mensuelles_des_hotspots_paris_wifi.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<utilisations_mensuelles_des_hotspots_paris_wifi>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les_references_les_plus_reservees_en_2011>> les_references_les_plus_reservees_en_2011Dataset
		{ 
			get 
			{
				List<Record<les_references_les_plus_reservees_en_2011>> result = new List<Record<les_references_les_plus_reservees_en_2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les_references_les_plus_reservees_en_2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les_references_les_plus_reservees_en_2011.datasetid, les_references_les_plus_reservees_en_2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les_references_les_plus_reservees_en_2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<ordres_du_jour_du_conseil_general>> ordres_du_jour_du_conseil_generalDataset
		{ 
			get 
			{
				List<Record<ordres_du_jour_du_conseil_general>> result = new List<Record<ordres_du_jour_du_conseil_general>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < ordres_du_jour_du_conseil_general.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(ordres_du_jour_du_conseil_general.datasetid, ordres_du_jour_du_conseil_general.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<ordres_du_jour_du_conseil_general>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<ordres_du_jour_du_conseil_municipal>> ordres_du_jour_du_conseil_municipalDataset
		{ 
			get 
			{
				List<Record<ordres_du_jour_du_conseil_municipal>> result = new List<Record<ordres_du_jour_du_conseil_municipal>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < ordres_du_jour_du_conseil_municipal.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(ordres_du_jour_du_conseil_municipal.datasetid, ordres_du_jour_du_conseil_municipal.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<ordres_du_jour_du_conseil_municipal>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<zonesderattachementdesbureauxdevoteen2012>> zonesderattachementdesbureauxdevoteen2012Dataset
		{ 
			get 
			{
				List<Record<zonesderattachementdesbureauxdevoteen2012>> result = new List<Record<zonesderattachementdesbureauxdevoteen2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < zonesderattachementdesbureauxdevoteen2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(zonesderattachementdesbureauxdevoteen2012.datasetid, zonesderattachementdesbureauxdevoteen2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<zonesderattachementdesbureauxdevoteen2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<petits_marchands_sur_l_espace_public>> petits_marchands_sur_l_espace_publicDataset
		{ 
			get 
			{
				List<Record<petits_marchands_sur_l_espace_public>> result = new List<Record<petits_marchands_sur_l_espace_public>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < petits_marchands_sur_l_espace_public.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(petits_marchands_sur_l_espace_public.datasetid, petits_marchands_sur_l_espace_public.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<petits_marchands_sur_l_espace_public>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<immobilisationsetatdessorties>> immobilisationsetatdessortiesDataset
		{ 
			get 
			{
				List<Record<immobilisationsetatdessorties>> result = new List<Record<immobilisationsetatdessorties>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < immobilisationsetatdessorties.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(immobilisationsetatdessorties.datasetid, immobilisationsetatdessorties.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<immobilisationsetatdessorties>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<adresses_des_panneaux_cq>> adresses_des_panneaux_cqDataset
		{ 
			get 
			{
				List<Record<adresses_des_panneaux_cq>> result = new List<Record<adresses_des_panneaux_cq>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < adresses_des_panneaux_cq.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(adresses_des_panneaux_cq.datasetid, adresses_des_panneaux_cq.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<adresses_des_panneaux_cq>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les_1000_titres_les_plus_reserves_en_2013>> les_1000_titres_les_plus_reserves_en_2013Dataset
		{ 
			get 
			{
				List<Record<les_1000_titres_les_plus_reserves_en_2013>> result = new List<Record<les_1000_titres_les_plus_reserves_en_2013>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les_1000_titres_les_plus_reserves_en_2013.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les_1000_titres_les_plus_reserves_en_2013.datasetid, les_1000_titres_les_plus_reserves_en_2013.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les_1000_titres_les_plus_reserves_en_2013>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<deliberationemploi>> deliberationemploiDataset
		{ 
			get 
			{
				List<Record<deliberationemploi>> result = new List<Record<deliberationemploi>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < deliberationemploi.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(deliberationemploi.datasetid, deliberationemploi.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<deliberationemploi>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<subventionsaccordeesetrefusees>> subventionsaccordeesetrefuseesDataset
		{ 
			get 
			{
				List<Record<subventionsaccordeesetrefusees>> result = new List<Record<subventionsaccordeesetrefusees>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < subventionsaccordeesetrefusees.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(subventionsaccordeesetrefusees.datasetid, subventionsaccordeesetrefusees.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<subventionsaccordeesetrefusees>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_ouvrages_des_bibliotheques_en_janvier_2009>> liste_des_ouvrages_des_bibliotheques_en_janvier_2009Dataset
		{ 
			get 
			{
				List<Record<liste_des_ouvrages_des_bibliotheques_en_janvier_2009>> result = new List<Record<liste_des_ouvrages_des_bibliotheques_en_janvier_2009>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_ouvrages_des_bibliotheques_en_janvier_2009.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_ouvrages_des_bibliotheques_en_janvier_2009.datasetid, liste_des_ouvrages_des_bibliotheques_en_janvier_2009.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_ouvrages_des_bibliotheques_en_janvier_2009>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<concessions_dans_les_jardins>> concessions_dans_les_jardinsDataset
		{ 
			get 
			{
				List<Record<concessions_dans_les_jardins>> result = new List<Record<concessions_dans_les_jardins>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < concessions_dans_les_jardins.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(concessions_dans_les_jardins.datasetid, concessions_dans_les_jardins.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<concessions_dans_les_jardins>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_places_de_livraison>> liste_des_places_de_livraisonDataset
		{ 
			get 
			{
				List<Record<liste_des_places_de_livraison>> result = new List<Record<liste_des_places_de_livraison>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_places_de_livraison.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_places_de_livraison.datasetid, liste_des_places_de_livraison.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_places_de_livraison>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<touslesdocumentsdesbibliothequesdepret>> touslesdocumentsdesbibliothequesdepretDataset
		{ 
			get 
			{
				List<Record<touslesdocumentsdesbibliothequesdepret>> result = new List<Record<touslesdocumentsdesbibliothequesdepret>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < touslesdocumentsdesbibliothequesdepret.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(touslesdocumentsdesbibliothequesdepret.datasetid, touslesdocumentsdesbibliothequesdepret.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<touslesdocumentsdesbibliothequesdepret>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<titularisations>> titularisationsDataset
		{ 
			get 
			{
				List<Record<titularisations>> result = new List<Record<titularisations>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < titularisations.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(titularisations.datasetid, titularisations.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<titularisations>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<statistiquesdesvotesenlignedubudgetparticipatif2014>> statistiquesdesvotesenlignedubudgetparticipatif2014Dataset
		{ 
			get 
			{
				List<Record<statistiquesdesvotesenlignedubudgetparticipatif2014>> result = new List<Record<statistiquesdesvotesenlignedubudgetparticipatif2014>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < statistiquesdesvotesenlignedubudgetparticipatif2014.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(statistiquesdesvotesenlignedubudgetparticipatif2014.datasetid, statistiquesdesvotesenlignedubudgetparticipatif2014.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<statistiquesdesvotesenlignedubudgetparticipatif2014>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<voie>> voieDataset
		{ 
			get 
			{
				List<Record<voie>> result = new List<Record<voie>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < voie.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(voie.datasetid, voie.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<voie>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<pointsdevotedubudgetparticipatif>> pointsdevotedubudgetparticipatifDataset
		{ 
			get 
			{
				List<Record<pointsdevotedubudgetparticipatif>> result = new List<Record<pointsdevotedubudgetparticipatif>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < pointsdevotedubudgetparticipatif.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(pointsdevotedubudgetparticipatif.datasetid, pointsdevotedubudgetparticipatif.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<pointsdevotedubudgetparticipatif>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo>> mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geoDataset
		{ 
			get 
			{
				List<Record<mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo>> result = new List<Record<mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo.datasetid, mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<stationnementsurvoiepubliquezonestarifaires>> stationnementsurvoiepubliquezonestarifairesDataset
		{ 
			get 
			{
				List<Record<stationnementsurvoiepubliquezonestarifaires>> result = new List<Record<stationnementsurvoiepubliquezonestarifaires>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < stationnementsurvoiepubliquezonestarifaires.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(stationnementsurvoiepubliquezonestarifaires.datasetid, stationnementsurvoiepubliquezonestarifaires.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<stationnementsurvoiepubliquezonestarifaires>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<zones30>> zones30Dataset
		{ 
			get 
			{
				List<Record<zones30>> result = new List<Record<zones30>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < zones30.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(zones30.datasetid, zones30.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<zones30>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<inventairedesdocumentsnumerisesenligne>> inventairedesdocumentsnumerisesenligneDataset
		{ 
			get 
			{
				List<Record<inventairedesdocumentsnumerisesenligne>> result = new List<Record<inventairedesdocumentsnumerisesenligne>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < inventairedesdocumentsnumerisesenligne.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(inventairedesdocumentsnumerisesenligne.datasetid, inventairedesdocumentsnumerisesenligne.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<inventairedesdocumentsnumerisesenligne>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<touspe3>> touspe3Dataset
		{ 
			get 
			{
				List<Record<touspe3>> result = new List<Record<touspe3>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < touspe3.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(touspe3.datasetid, touspe3.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<touspe3>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les_1000_titres_les_plus_empruntes_de_2013>> les_1000_titres_les_plus_empruntes_de_2013Dataset
		{ 
			get 
			{
				List<Record<les_1000_titres_les_plus_empruntes_de_2013>> result = new List<Record<les_1000_titres_les_plus_empruntes_de_2013>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les_1000_titres_les_plus_empruntes_de_2013.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les_1000_titres_les_plus_empruntes_de_2013.datasetid, les_1000_titres_les_plus_empruntes_de_2013.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les_1000_titres_les_plus_empruntes_de_2013>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<comptederesultat>> comptederesultatDataset
		{ 
			get 
			{
				List<Record<comptederesultat>> result = new List<Record<comptederesultat>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < comptederesultat.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(comptederesultat.datasetid, comptederesultat.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<comptederesultat>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<horloges_exterieures_et_interieures>> horloges_exterieures_et_interieuresDataset
		{ 
			get 
			{
				List<Record<horloges_exterieures_et_interieures>> result = new List<Record<horloges_exterieures_et_interieures>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < horloges_exterieures_et_interieures.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(horloges_exterieures_et_interieures.datasetid, horloges_exterieures_et_interieures.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<horloges_exterieures_et_interieures>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<bilansocialeffectifsnontitulairespermanents>> bilansocialeffectifsnontitulairespermanentsDataset
		{ 
			get 
			{
				List<Record<bilansocialeffectifsnontitulairespermanents>> result = new List<Record<bilansocialeffectifsnontitulairespermanents>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < bilansocialeffectifsnontitulairespermanents.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(bilansocialeffectifsnontitulairespermanents.datasetid, bilansocialeffectifsnontitulairespermanents.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<bilansocialeffectifsnontitulairespermanents>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<dettepropre>> dettepropreDataset
		{ 
			get 
			{
				List<Record<dettepropre>> result = new List<Record<dettepropre>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < dettepropre.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(dettepropre.datasetid, dettepropre.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<dettepropre>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobilierpropreteparis2011>> mobilierpropreteparis2011Dataset
		{ 
			get 
			{
				List<Record<mobilierpropreteparis2011>> result = new List<Record<mobilierpropreteparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobilierpropreteparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobilierpropreteparis2011.datasetid, mobilierpropreteparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobilierpropreteparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<murs_et_clotures>> murs_et_cloturesDataset
		{ 
			get 
			{
				List<Record<murs_et_clotures>> result = new List<Record<murs_et_clotures>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < murs_et_clotures.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(murs_et_clotures.datasetid, murs_et_clotures.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<murs_et_clotures>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<budgetsvotesetatsspeciauxdarrondissements>> budgetsvotesetatsspeciauxdarrondissementsDataset
		{ 
			get 
			{
				List<Record<budgetsvotesetatsspeciauxdarrondissements>> result = new List<Record<budgetsvotesetatsspeciauxdarrondissements>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < budgetsvotesetatsspeciauxdarrondissements.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(budgetsvotesetatsspeciauxdarrondissements.datasetid, budgetsvotesetatsspeciauxdarrondissements.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<budgetsvotesetatsspeciauxdarrondissements>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<titreslespluspretesbibliothequesspecialiseesen2014>> titreslespluspretesbibliothequesspecialiseesen2014Dataset
		{ 
			get 
			{
				List<Record<titreslespluspretesbibliothequesspecialiseesen2014>> result = new List<Record<titreslespluspretesbibliothequesspecialiseesen2014>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < titreslespluspretesbibliothequesspecialiseesen2014.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(titreslespluspretesbibliothequesspecialiseesen2014.datasetid, titreslespluspretesbibliothequesspecialiseesen2014.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<titreslespluspretesbibliothequesspecialiseesen2014>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<bornes_et_arceaux_de_stationnement_a_paris>> bornes_et_arceaux_de_stationnement_a_parisDataset
		{ 
			get 
			{
				List<Record<bornes_et_arceaux_de_stationnement_a_paris>> result = new List<Record<bornes_et_arceaux_de_stationnement_a_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < bornes_et_arceaux_de_stationnement_a_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(bornes_et_arceaux_de_stationnement_a_paris.datasetid, bornes_et_arceaux_de_stationnement_a_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<bornes_et_arceaux_de_stationnement_a_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lesjardinieres>> lesjardinieresDataset
		{ 
			get 
			{
				List<Record<lesjardinieres>> result = new List<Record<lesjardinieres>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lesjardinieres.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lesjardinieres.datasetid, lesjardinieres.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lesjardinieres>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<resultatsdelelectionmunicipale20141ertour>> resultatsdelelectionmunicipale20141ertourDataset
		{ 
			get 
			{
				List<Record<resultatsdelelectionmunicipale20141ertour>> result = new List<Record<resultatsdelelectionmunicipale20141ertour>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < resultatsdelelectionmunicipale20141ertour.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(resultatsdelelectionmunicipale20141ertour.datasetid, resultatsdelelectionmunicipale20141ertour.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<resultatsdelelectionmunicipale20141ertour>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<stationnementsurvoiepubliquesecteursresidentiels>> stationnementsurvoiepubliquesecteursresidentielsDataset
		{ 
			get 
			{
				List<Record<stationnementsurvoiepubliquesecteursresidentiels>> result = new List<Record<stationnementsurvoiepubliquesecteursresidentiels>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < stationnementsurvoiepubliquesecteursresidentiels.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(stationnementsurvoiepubliquesecteursresidentiels.datasetid, stationnementsurvoiepubliquesecteursresidentiels.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<stationnementsurvoiepubliquesecteursresidentiels>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lesparcellesforestieresdesbois>> lesparcellesforestieresdesboisDataset
		{ 
			get 
			{
				List<Record<lesparcellesforestieresdesbois>> result = new List<Record<lesparcellesforestieresdesbois>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lesparcellesforestieresdesbois.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lesparcellesforestieresdesbois.datasetid, lesparcellesforestieresdesbois.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lesparcellesforestieresdesbois>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<zonesderattachementdesbureauxdevoteen2014>> zonesderattachementdesbureauxdevoteen2014Dataset
		{ 
			get 
			{
				List<Record<zonesderattachementdesbureauxdevoteen2014>> result = new List<Record<zonesderattachementdesbureauxdevoteen2014>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < zonesderattachementdesbureauxdevoteen2014.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(zonesderattachementdesbureauxdevoteen2014.datasetid, zonesderattachementdesbureauxdevoteen2014.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<zonesderattachementdesbureauxdevoteen2014>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<panneaux_indicateurs_de_signalisation_routiere_et_pietonne>> panneaux_indicateurs_de_signalisation_routiere_et_pietonneDataset
		{ 
			get 
			{
				List<Record<panneaux_indicateurs_de_signalisation_routiere_et_pietonne>> result = new List<Record<panneaux_indicateurs_de_signalisation_routiere_et_pietonne>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < panneaux_indicateurs_de_signalisation_routiere_et_pietonne.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(panneaux_indicateurs_de_signalisation_routiere_et_pietonne.datasetid, panneaux_indicateurs_de_signalisation_routiere_et_pietonne.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<panneaux_indicateurs_de_signalisation_routiere_et_pietonne>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<bugdetvotesprincipaux>> bugdetvotesprincipauxDataset
		{ 
			get 
			{
				List<Record<bugdetvotesprincipaux>> result = new List<Record<bugdetvotesprincipaux>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < bugdetvotesprincipaux.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(bugdetvotesprincipaux.datasetid, bugdetvotesprincipaux.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<bugdetvotesprincipaux>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<comptesadministratifsautorisationsdeprogrammesapvilledepartement>> comptesadministratifsautorisationsdeprogrammesapvilledepartementDataset
		{ 
			get 
			{
				List<Record<comptesadministratifsautorisationsdeprogrammesapvilledepartement>> result = new List<Record<comptesadministratifsautorisationsdeprogrammesapvilledepartement>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < comptesadministratifsautorisationsdeprogrammesapvilledepartement.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(comptesadministratifsautorisationsdeprogrammesapvilledepartement.datasetid, comptesadministratifsautorisationsdeprogrammesapvilledepartement.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<comptesadministratifsautorisationsdeprogrammesapvilledepartement>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<catalogue_des_cours_municipaux_d_adultes>> catalogue_des_cours_municipaux_d_adultesDataset
		{ 
			get 
			{
				List<Record<catalogue_des_cours_municipaux_d_adultes>> result = new List<Record<catalogue_des_cours_municipaux_d_adultes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < catalogue_des_cours_municipaux_d_adultes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(catalogue_des_cours_municipaux_d_adultes.datasetid, catalogue_des_cours_municipaux_d_adultes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<catalogue_des_cours_municipaux_d_adultes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<paris_taxis_stations>> paris_taxis_stationsDataset
		{ 
			get 
			{
				List<Record<paris_taxis_stations>> result = new List<Record<paris_taxis_stations>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < paris_taxis_stations.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(paris_taxis_stations.datasetid, paris_taxis_stations.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<paris_taxis_stations>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<poteaux_divers_sur_voie_publique>> poteaux_divers_sur_voie_publiqueDataset
		{ 
			get 
			{
				List<Record<poteaux_divers_sur_voie_publique>> result = new List<Record<poteaux_divers_sur_voie_publique>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < poteaux_divers_sur_voie_publique.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(poteaux_divers_sur_voie_publique.datasetid, poteaux_divers_sur_voie_publique.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<poteaux_divers_sur_voie_publique>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<listedescafesauneuro>> listedescafesauneuroDataset
		{ 
			get 
			{
				List<Record<listedescafesauneuro>> result = new List<Record<listedescafesauneuro>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < listedescafesauneuro.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(listedescafesauneuro.datasetid, listedescafesauneuro.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<listedescafesauneuro>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<volumes_d_eau_distribues>> volumes_d_eau_distribuesDataset
		{ 
			get 
			{
				List<Record<volumes_d_eau_distribues>> result = new List<Record<volumes_d_eau_distribues>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < volumes_d_eau_distribues.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(volumes_d_eau_distribues.datasetid, volumes_d_eau_distribues.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<volumes_d_eau_distribues>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<nomenclature_du_tri_selectif>> nomenclature_du_tri_selectifDataset
		{ 
			get 
			{
				List<Record<nomenclature_du_tri_selectif>> result = new List<Record<nomenclature_du_tri_selectif>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < nomenclature_du_tri_selectif.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(nomenclature_du_tri_selectif.datasetid, nomenclature_du_tri_selectif.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<nomenclature_du_tri_selectif>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobilierelectriqueparis2011>> mobilierelectriqueparis2011Dataset
		{ 
			get 
			{
				List<Record<mobilierelectriqueparis2011>> result = new List<Record<mobilierelectriqueparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobilierelectriqueparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobilierelectriqueparis2011.datasetid, mobilierelectriqueparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobilierelectriqueparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<quartier_paris>> quartier_parisDataset
		{ 
			get 
			{
				List<Record<quartier_paris>> result = new List<Record<quartier_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < quartier_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(quartier_paris.datasetid, quartier_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<quartier_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<petits_marchands_sur_l_espace_public_en_2012>> petits_marchands_sur_l_espace_public_en_2012Dataset
		{ 
			get 
			{
				List<Record<petits_marchands_sur_l_espace_public_en_2012>> result = new List<Record<petits_marchands_sur_l_espace_public_en_2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < petits_marchands_sur_l_espace_public_en_2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(petits_marchands_sur_l_espace_public_en_2012.datasetid, petits_marchands_sur_l_espace_public_en_2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<petits_marchands_sur_l_espace_public_en_2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<maneges_et_jeux_2012>> maneges_et_jeux_2012Dataset
		{ 
			get 
			{
				List<Record<maneges_et_jeux_2012>> result = new List<Record<maneges_et_jeux_2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < maneges_et_jeux_2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(maneges_et_jeux_2012.datasetid, maneges_et_jeux_2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<maneges_et_jeux_2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<arrondissements>> arrondissementsDataset
		{ 
			get 
			{
				List<Record<arrondissements>> result = new List<Record<arrondissements>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < arrondissements.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(arrondissements.datasetid, arrondissements.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<arrondissements>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<volumesbatisparis2011>> volumesbatisparis2011Dataset
		{ 
			get 
			{
				List<Record<volumesbatisparis2011>> result = new List<Record<volumesbatisparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < volumesbatisparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(volumesbatisparis2011.datasetid, volumesbatisparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<volumesbatisparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<statistiques_de_creation_d_actes_d_etat_civil>> statistiques_de_creation_d_actes_d_etat_civilDataset
		{ 
			get 
			{
				List<Record<statistiques_de_creation_d_actes_d_etat_civil>> result = new List<Record<statistiques_de_creation_d_actes_d_etat_civil>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < statistiques_de_creation_d_actes_d_etat_civil.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(statistiques_de_creation_d_actes_d_etat_civil.datasetid, statistiques_de_creation_d_actes_d_etat_civil.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<statistiques_de_creation_d_actes_d_etat_civil>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<listedesmarchesdelacollectiviteparisienne>> listedesmarchesdelacollectiviteparisienneDataset
		{ 
			get 
			{
				List<Record<listedesmarchesdelacollectiviteparisienne>> result = new List<Record<listedesmarchesdelacollectiviteparisienne>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < listedesmarchesdelacollectiviteparisienne.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(listedesmarchesdelacollectiviteparisienne.datasetid, listedesmarchesdelacollectiviteparisienne.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<listedesmarchesdelacollectiviteparisienne>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<troncon_voie>> troncon_voieDataset
		{ 
			get 
			{
				List<Record<troncon_voie>> result = new List<Record<troncon_voie>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < troncon_voie.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(troncon_voie.datasetid, troncon_voie.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<troncon_voie>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<duvertpresdechezmoi>> duvertpresdechezmoiDataset
		{ 
			get 
			{
				List<Record<duvertpresdechezmoi>> result = new List<Record<duvertpresdechezmoi>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < duvertpresdechezmoi.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(duvertpresdechezmoi.datasetid, duvertpresdechezmoi.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<duvertpresdechezmoi>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobilierstationnementparis2011>> mobilierstationnementparis2011Dataset
		{ 
			get 
			{
				List<Record<mobilierstationnementparis2011>> result = new List<Record<mobilierstationnementparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobilierstationnementparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobilierstationnementparis2011.datasetid, mobilierstationnementparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobilierstationnementparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<relief_naturel>> relief_naturelDataset
		{ 
			get 
			{
				List<Record<relief_naturel>> result = new List<Record<relief_naturel>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < relief_naturel.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(relief_naturel.datasetid, relief_naturel.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<relief_naturel>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<adresse_paris>> adresse_parisDataset
		{ 
			get 
			{
				List<Record<adresse_paris>> result = new List<Record<adresse_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < adresse_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(adresse_paris.datasetid, adresse_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<adresse_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_bureaux_de_vote_2013_liste_des_bureaux>> liste_des_bureaux_de_vote_2013_liste_des_bureauxDataset
		{ 
			get 
			{
				List<Record<liste_des_bureaux_de_vote_2013_liste_des_bureaux>> result = new List<Record<liste_des_bureaux_de_vote_2013_liste_des_bureaux>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_bureaux_de_vote_2013_liste_des_bureaux.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_bureaux_de_vote_2013_liste_des_bureaux.datasetid, liste_des_bureaux_de_vote_2013_liste_des_bureaux.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_bureaux_de_vote_2013_liste_des_bureaux>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<conseilsquartiers>> conseilsquartiersDataset
		{ 
			get 
			{
				List<Record<conseilsquartiers>> result = new List<Record<conseilsquartiers>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < conseilsquartiers.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(conseilsquartiers.datasetid, conseilsquartiers.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<conseilsquartiers>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<parcsetjardinsparis2010>> parcsetjardinsparis2010Dataset
		{ 
			get 
			{
				List<Record<parcsetjardinsparis2010>> result = new List<Record<parcsetjardinsparis2010>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < parcsetjardinsparis2010.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(parcsetjardinsparis2010.datasetid, parcsetjardinsparis2010.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<parcsetjardinsparis2010>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<filiationvoiesparis2012>> filiationvoiesparis2012Dataset
		{ 
			get 
			{
				List<Record<filiationvoiesparis2012>> result = new List<Record<filiationvoiesparis2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < filiationvoiesparis2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(filiationvoiesparis2012.datasetid, filiationvoiesparis2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<filiationvoiesparis2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<comptesadministratifsprincipauxvilledepartement>> comptesadministratifsprincipauxvilledepartementDataset
		{ 
			get 
			{
				List<Record<comptesadministratifsprincipauxvilledepartement>> result = new List<Record<comptesadministratifsprincipauxvilledepartement>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < comptesadministratifsprincipauxvilledepartement.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(comptesadministratifsprincipauxvilledepartement.datasetid, comptesadministratifsprincipauxvilledepartement.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<comptesadministratifsprincipauxvilledepartement>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_sites_des_hotspots_paris_wifi>> liste_des_sites_des_hotspots_paris_wifiDataset
		{ 
			get 
			{
				List<Record<liste_des_sites_des_hotspots_paris_wifi>> result = new List<Record<liste_des_sites_des_hotspots_paris_wifi>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_sites_des_hotspots_paris_wifi.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_sites_des_hotspots_paris_wifi.datasetid, liste_des_sites_des_hotspots_paris_wifi.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_sites_des_hotspots_paris_wifi>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_associations_parisiennes>> liste_des_associations_parisiennesDataset
		{ 
			get 
			{
				List<Record<liste_des_associations_parisiennes>> result = new List<Record<liste_des_associations_parisiennes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_associations_parisiennes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_associations_parisiennes.datasetid, liste_des_associations_parisiennes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_associations_parisiennes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les1000titreslesplusreservesdanslesbibliothequesdepret>> les1000titreslesplusreservesdanslesbibliothequesdepretDataset
		{ 
			get 
			{
				List<Record<les1000titreslesplusreservesdanslesbibliothequesdepret>> result = new List<Record<les1000titreslesplusreservesdanslesbibliothequesdepret>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les1000titreslesplusreservesdanslesbibliothequesdepret.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les1000titreslesplusreservesdanslesbibliothequesdepret.datasetid, les1000titreslesplusreservesdanslesbibliothequesdepret.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les1000titreslesplusreservesdanslesbibliothequesdepret>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<accessibilite_des_equipements_de_la_ville_de_paris>> accessibilite_des_equipements_de_la_ville_de_parisDataset
		{ 
			get 
			{
				List<Record<accessibilite_des_equipements_de_la_ville_de_paris>> result = new List<Record<accessibilite_des_equipements_de_la_ville_de_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < accessibilite_des_equipements_de_la_ville_de_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(accessibilite_des_equipements_de_la_ville_de_paris.datasetid, accessibilite_des_equipements_de_la_ville_de_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<accessibilite_des_equipements_de_la_ville_de_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<parcsdestationnementconcedesdelavilledeparis>> parcsdestationnementconcedesdelavilledeparisDataset
		{ 
			get 
			{
				List<Record<parcsdestationnementconcedesdelavilledeparis>> result = new List<Record<parcsdestationnementconcedesdelavilledeparis>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < parcsdestationnementconcedesdelavilledeparis.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(parcsdestationnementconcedesdelavilledeparis.datasetid, parcsdestationnementconcedesdelavilledeparis.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<parcsdestationnementconcedesdelavilledeparis>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<reseaucyclable>> reseaucyclableDataset
		{ 
			get 
			{
				List<Record<reseaucyclable>> result = new List<Record<reseaucyclable>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < reseaucyclable.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(reseaucyclable.datasetid, reseaucyclable.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<reseaucyclable>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<logements_sociaux_finances_a_paris>> logements_sociaux_finances_a_parisDataset
		{ 
			get 
			{
				List<Record<logements_sociaux_finances_a_paris>> result = new List<Record<logements_sociaux_finances_a_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < logements_sociaux_finances_a_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(logements_sociaux_finances_a_paris.datasetid, logements_sociaux_finances_a_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<logements_sociaux_finances_a_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<resultatsdesvotesbudgetparticipatif>> resultatsdesvotesbudgetparticipatifDataset
		{ 
			get 
			{
				List<Record<resultatsdesvotesbudgetparticipatif>> result = new List<Record<resultatsdesvotesbudgetparticipatif>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < resultatsdesvotesbudgetparticipatif.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(resultatsdesvotesbudgetparticipatif.datasetid, resultatsdesvotesbudgetparticipatif.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<resultatsdesvotesbudgetparticipatif>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<listedesantenneswifi>> listedesantenneswifiDataset
		{ 
			get 
			{
				List<Record<listedesantenneswifi>> result = new List<Record<listedesantenneswifi>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < listedesantenneswifi.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(listedesantenneswifi.datasetid, listedesantenneswifi.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<listedesantenneswifi>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<arbresalignementparis2010>> arbresalignementparis2010Dataset
		{ 
			get 
			{
				List<Record<arbresalignementparis2010>> result = new List<Record<arbresalignementparis2010>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < arbresalignementparis2010.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(arbresalignementparis2010.datasetid, arbresalignementparis2010.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<arbresalignementparis2010>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<postespublicsdesbibliothequesspecialisees>> postespublicsdesbibliothequesspecialiseesDataset
		{ 
			get 
			{
				List<Record<postespublicsdesbibliothequesspecialisees>> result = new List<Record<postespublicsdesbibliothequesspecialisees>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < postespublicsdesbibliothequesspecialisees.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(postespublicsdesbibliothequesspecialisees.datasetid, postespublicsdesbibliothequesspecialisees.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<postespublicsdesbibliothequesspecialisees>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<positionsstatutairesparticulieresdetachementsbilansocial>> positionsstatutairesparticulieresdetachementsbilansocialDataset
		{ 
			get 
			{
				List<Record<positionsstatutairesparticulieresdetachementsbilansocial>> result = new List<Record<positionsstatutairesparticulieresdetachementsbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < positionsstatutairesparticulieresdetachementsbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(positionsstatutairesparticulieresdetachementsbilansocial.datasetid, positionsstatutairesparticulieresdetachementsbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<positionsstatutairesparticulieresdetachementsbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<bilancomptable>> bilancomptableDataset
		{ 
			get 
			{
				List<Record<bilancomptable>> result = new List<Record<bilancomptable>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < bilancomptable.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(bilancomptable.datasetid, bilancomptable.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<bilancomptable>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<immobilisationsetatdesentrees>> immobilisationsetatdesentreesDataset
		{ 
			get 
			{
				List<Record<immobilisationsetatdesentrees>> result = new List<Record<immobilisationsetatdesentrees>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < immobilisationsetatdesentrees.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(immobilisationsetatdesentrees.datasetid, immobilisationsetatdesentrees.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<immobilisationsetatdesentrees>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<immobilisationsetatdesamortissements>> immobilisationsetatdesamortissementsDataset
		{ 
			get 
			{
				List<Record<immobilisationsetatdesamortissements>> result = new List<Record<immobilisationsetatdesamortissements>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < immobilisationsetatdesamortissements.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(immobilisationsetatdesamortissements.datasetid, immobilisationsetatdesamortissements.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<immobilisationsetatdesamortissements>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement>> statistiques_de_creation_d_actes_d_etat_civil_par_arrondissementDataset
		{ 
			get 
			{
				List<Record<statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement>> result = new List<Record<statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement.datasetid, statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<concessionsredevancespercues>> concessionsredevancespercuesDataset
		{ 
			get 
			{
				List<Record<concessionsredevancespercues>> result = new List<Record<concessionsredevancespercues>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < concessionsredevancespercues.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(concessionsredevancespercues.datasetid, concessionsredevancespercues.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<concessionsredevancespercues>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<evolutiondescorpslesplusetlesmoinsfeminises>> evolutiondescorpslesplusetlesmoinsfeminisesDataset
		{ 
			get 
			{
				List<Record<evolutiondescorpslesplusetlesmoinsfeminises>> result = new List<Record<evolutiondescorpslesplusetlesmoinsfeminises>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < evolutiondescorpslesplusetlesmoinsfeminises.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(evolutiondescorpslesplusetlesmoinsfeminises.datasetid, evolutiondescorpslesplusetlesmoinsfeminises.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<evolutiondescorpslesplusetlesmoinsfeminises>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<statistiques_de_creation_d_actes_d_etat_civil_par_mois>> statistiques_de_creation_d_actes_d_etat_civil_par_moisDataset
		{ 
			get 
			{
				List<Record<statistiques_de_creation_d_actes_d_etat_civil_par_mois>> result = new List<Record<statistiques_de_creation_d_actes_d_etat_civil_par_mois>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < statistiques_de_creation_d_actes_d_etat_civil_par_mois.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(statistiques_de_creation_d_actes_d_etat_civil_par_mois.datasetid, statistiques_de_creation_d_actes_d_etat_civil_par_mois.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<statistiques_de_creation_d_actes_d_etat_civil_par_mois>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<effectifspermanentspartranchedagebilansocial>> effectifspermanentspartranchedagebilansocialDataset
		{ 
			get 
			{
				List<Record<effectifspermanentspartranchedagebilansocial>> result = new List<Record<effectifspermanentspartranchedagebilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < effectifspermanentspartranchedagebilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(effectifspermanentspartranchedagebilansocial.datasetid, effectifspermanentspartranchedagebilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<effectifspermanentspartranchedagebilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<bilancomptablesynthetique>> bilancomptablesynthetiqueDataset
		{ 
			get 
			{
				List<Record<bilancomptablesynthetique>> result = new List<Record<bilancomptablesynthetique>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < bilancomptablesynthetique.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(bilancomptablesynthetique.datasetid, bilancomptablesynthetique.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<bilancomptablesynthetique>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<hydro_ev>> hydro_evDataset
		{ 
			get 
			{
				List<Record<hydro_ev>> result = new List<Record<hydro_ev>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < hydro_ev.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(hydro_ev.datasetid, hydro_ev.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<hydro_ev>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<emargementmunicipal>> emargementmunicipalDataset
		{ 
			get 
			{
				List<Record<emargementmunicipal>> result = new List<Record<emargementmunicipal>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < emargementmunicipal.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(emargementmunicipal.datasetid, emargementmunicipal.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<emargementmunicipal>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lescimetieresdivisions>> lescimetieresdivisionsDataset
		{ 
			get 
			{
				List<Record<lescimetieresdivisions>> result = new List<Record<lescimetieresdivisions>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lescimetieresdivisions.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lescimetieresdivisions.datasetid, lescimetieresdivisions.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lescimetieresdivisions>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les_1000_titres_les_plus_empruntes_de_2012>> les_1000_titres_les_plus_empruntes_de_2012Dataset
		{ 
			get 
			{
				List<Record<les_1000_titres_les_plus_empruntes_de_2012>> result = new List<Record<les_1000_titres_les_plus_empruntes_de_2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les_1000_titres_les_plus_empruntes_de_2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les_1000_titres_les_plus_empruntes_de_2012.datasetid, les_1000_titres_les_plus_empruntes_de_2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les_1000_titres_les_plus_empruntes_de_2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les_1000_titres_les_plus_recherches_en_2013>> les_1000_titres_les_plus_recherches_en_2013Dataset
		{ 
			get 
			{
				List<Record<les_1000_titres_les_plus_recherches_en_2013>> result = new List<Record<les_1000_titres_les_plus_recherches_en_2013>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les_1000_titres_les_plus_recherches_en_2013.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les_1000_titres_les_plus_recherches_en_2013.datasetid, les_1000_titres_les_plus_recherches_en_2013.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les_1000_titres_les_plus_recherches_en_2013>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<promotionsdegradesuiteaexamenprofessionnel>> promotionsdegradesuiteaexamenprofessionnelDataset
		{ 
			get 
			{
				List<Record<promotionsdegradesuiteaexamenprofessionnel>> result = new List<Record<promotionsdegradesuiteaexamenprofessionnel>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < promotionsdegradesuiteaexamenprofessionnel.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(promotionsdegradesuiteaexamenprofessionnel.datasetid, promotionsdegradesuiteaexamenprofessionnel.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<promotionsdegradesuiteaexamenprofessionnel>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<subventionsversees>> subventionsverseesDataset
		{ 
			get 
			{
				List<Record<subventionsversees>> result = new List<Record<subventionsversees>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < subventionsversees.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(subventionsversees.datasetid, subventionsversees.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<subventionsversees>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<tempsdetravaildeseffectifstitulairespermanentsbilansocial>> tempsdetravaildeseffectifstitulairespermanentsbilansocialDataset
		{ 
			get 
			{
				List<Record<tempsdetravaildeseffectifstitulairespermanentsbilansocial>> result = new List<Record<tempsdetravaildeseffectifstitulairespermanentsbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < tempsdetravaildeseffectifstitulairespermanentsbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(tempsdetravaildeseffectifstitulairespermanentsbilansocial.datasetid, tempsdetravaildeseffectifstitulairespermanentsbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<tempsdetravaildeseffectifstitulairespermanentsbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les1000titreslespluspretesparsupport>> les1000titreslespluspretesparsupportDataset
		{ 
			get 
			{
				List<Record<les1000titreslespluspretesparsupport>> result = new List<Record<les1000titreslespluspretesparsupport>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les1000titreslespluspretesparsupport.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les1000titreslespluspretesparsupport.datasetid, les1000titreslespluspretesparsupport.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les1000titreslespluspretesparsupport>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<attractions_foraines_sur_l_espace_public>> attractions_foraines_sur_l_espace_publicDataset
		{ 
			get 
			{
				List<Record<attractions_foraines_sur_l_espace_public>> result = new List<Record<attractions_foraines_sur_l_espace_public>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < attractions_foraines_sur_l_espace_public.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(attractions_foraines_sur_l_espace_public.datasetid, attractions_foraines_sur_l_espace_public.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<attractions_foraines_sur_l_espace_public>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<listedesstationsdeservicesdevehicules>> listedesstationsdeservicesdevehiculesDataset
		{ 
			get 
			{
				List<Record<listedesstationsdeservicesdevehicules>> result = new List<Record<listedesstationsdeservicesdevehicules>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < listedesstationsdeservicesdevehicules.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(listedesstationsdeservicesdevehicules.datasetid, listedesstationsdeservicesdevehicules.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<listedesstationsdeservicesdevehicules>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<dettegarantie>> dettegarantieDataset
		{ 
			get 
			{
				List<Record<dettegarantie>> result = new List<Record<dettegarantie>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < dettegarantie.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(dettegarantie.datasetid, dettegarantie.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<dettegarantie>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<cheminement_d_assainissement>> cheminement_d_assainissementDataset
		{ 
			get 
			{
				List<Record<cheminement_d_assainissement>> result = new List<Record<cheminement_d_assainissement>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < cheminement_d_assainissement.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(cheminement_d_assainissement.datasetid, cheminement_d_assainissement.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<cheminement_d_assainissement>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobiliers_de_voies_routieres_de_type_barriere>> mobiliers_de_voies_routieres_de_type_barriereDataset
		{ 
			get 
			{
				List<Record<mobiliers_de_voies_routieres_de_type_barriere>> result = new List<Record<mobiliers_de_voies_routieres_de_type_barriere>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobiliers_de_voies_routieres_de_type_barriere.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobiliers_de_voies_routieres_de_type_barriere.datasetid, mobiliers_de_voies_routieres_de_type_barriere.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobiliers_de_voies_routieres_de_type_barriere>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<panneaux_d_affichage_associatifs>> panneaux_d_affichage_associatifsDataset
		{ 
			get 
			{
				List<Record<panneaux_d_affichage_associatifs>> result = new List<Record<panneaux_d_affichage_associatifs>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < panneaux_d_affichage_associatifs.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(panneaux_d_affichage_associatifs.datasetid, panneaux_d_affichage_associatifs.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<panneaux_d_affichage_associatifs>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<equipements_de_proximite>> equipements_de_proximiteDataset
		{ 
			get 
			{
				List<Record<equipements_de_proximite>> result = new List<Record<equipements_de_proximite>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < equipements_de_proximite.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(equipements_de_proximite.datasetid, equipements_de_proximite.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<equipements_de_proximite>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<tonnages_de_la_collecte_du_verre>> tonnages_de_la_collecte_du_verreDataset
		{ 
			get 
			{
				List<Record<tonnages_de_la_collecte_du_verre>> result = new List<Record<tonnages_de_la_collecte_du_verre>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < tonnages_de_la_collecte_du_verre.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(tonnages_de_la_collecte_du_verre.datasetid, tonnages_de_la_collecte_du_verre.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<tonnages_de_la_collecte_du_verre>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<effectifstitulairespermanents>> effectifstitulairespermanentsDataset
		{ 
			get 
			{
				List<Record<effectifstitulairespermanents>> result = new List<Record<effectifstitulairespermanents>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < effectifstitulairespermanents.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(effectifstitulairespermanents.datasetid, effectifstitulairespermanents.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<effectifstitulairespermanents>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<distributeurspreservatifsmasculinsparis2012>> distributeurspreservatifsmasculinsparis2012Dataset
		{ 
			get 
			{
				List<Record<distributeurspreservatifsmasculinsparis2012>> result = new List<Record<distributeurspreservatifsmasculinsparis2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < distributeurspreservatifsmasculinsparis2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(distributeurspreservatifsmasculinsparis2012.datasetid, distributeurspreservatifsmasculinsparis2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<distributeurspreservatifsmasculinsparis2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<pim>> pimDataset
		{ 
			get 
			{
				List<Record<pim>> result = new List<Record<pim>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < pim.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(pim.datasetid, pim.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<pim>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<volumesnonbatisparis2011>> volumesnonbatisparis2011Dataset
		{ 
			get 
			{
				List<Record<volumesnonbatisparis2011>> result = new List<Record<volumesnonbatisparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < volumesnonbatisparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(volumesnonbatisparis2011.datasetid, volumesnonbatisparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<volumesnonbatisparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<detail_du_bati>> detail_du_batiDataset
		{ 
			get 
			{
				List<Record<detail_du_bati>> result = new List<Record<detail_du_bati>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < detail_du_bati.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(detail_du_bati.datasetid, detail_du_bati.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<detail_du_bati>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_bureaux_de_vote_2013_voies_de_paris>> liste_des_bureaux_de_vote_2013_voies_de_parisDataset
		{ 
			get 
			{
				List<Record<liste_des_bureaux_de_vote_2013_voies_de_paris>> result = new List<Record<liste_des_bureaux_de_vote_2013_voies_de_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_bureaux_de_vote_2013_voies_de_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_bureaux_de_vote_2013_voies_de_paris.datasetid, liste_des_bureaux_de_vote_2013_voies_de_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_bureaux_de_vote_2013_voies_de_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<promotionsparcategoriehommesfemmes>> promotionsparcategoriehommesfemmesDataset
		{ 
			get 
			{
				List<Record<promotionsparcategoriehommesfemmes>> result = new List<Record<promotionsparcategoriehommesfemmes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < promotionsparcategoriehommesfemmes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(promotionsparcategoriehommesfemmes.datasetid, promotionsparcategoriehommesfemmes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<promotionsparcategoriehommesfemmes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<tempsdetravaildeseffectifsnontitulairespermanentsbilansocial>> tempsdetravaildeseffectifsnontitulairespermanentsbilansocialDataset
		{ 
			get 
			{
				List<Record<tempsdetravaildeseffectifsnontitulairespermanentsbilansocial>> result = new List<Record<tempsdetravaildeseffectifsnontitulairespermanentsbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < tempsdetravaildeseffectifsnontitulairespermanentsbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(tempsdetravaildeseffectifsnontitulairespermanentsbilansocial.datasetid, tempsdetravaildeseffectifsnontitulairespermanentsbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<tempsdetravaildeseffectifsnontitulairespermanentsbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<consultations_des_centres_de_sante>> consultations_des_centres_de_santeDataset
		{ 
			get 
			{
				List<Record<consultations_des_centres_de_sante>> result = new List<Record<consultations_des_centres_de_sante>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < consultations_des_centres_de_sante.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(consultations_des_centres_de_sante.datasetid, consultations_des_centres_de_sante.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<consultations_des_centres_de_sante>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<tonnages_des_dechets_bacs_verts>> tonnages_des_dechets_bacs_vertsDataset
		{ 
			get 
			{
				List<Record<tonnages_des_dechets_bacs_verts>> result = new List<Record<tonnages_des_dechets_bacs_verts>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < tonnages_des_dechets_bacs_verts.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(tonnages_des_dechets_bacs_verts.datasetid, tonnages_des_dechets_bacs_verts.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<tonnages_des_dechets_bacs_verts>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<listemuseesdefranceaparis>> listemuseesdefranceaparisDataset
		{ 
			get 
			{
				List<Record<listemuseesdefranceaparis>> result = new List<Record<listemuseesdefranceaparis>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < listemuseesdefranceaparis.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(listemuseesdefranceaparis.datasetid, listemuseesdefranceaparis.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<listemuseesdefranceaparis>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<zonesderencontre>> zonesderencontreDataset
		{ 
			get 
			{
				List<Record<zonesderencontre>> result = new List<Record<zonesderencontre>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < zonesderencontre.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(zonesderencontre.datasetid, zonesderencontre.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<zonesderencontre>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobiliereaupotableparis2011>> mobiliereaupotableparis2011Dataset
		{ 
			get 
			{
				List<Record<mobiliereaupotableparis2011>> result = new List<Record<mobiliereaupotableparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobiliereaupotableparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobiliereaupotableparis2011.datasetid, mobiliereaupotableparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobiliereaupotableparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<eclairagepublicsignalisationtricolore>> eclairagepublicsignalisationtricoloreDataset
		{ 
			get 
			{
				List<Record<eclairagepublicsignalisationtricolore>> result = new List<Record<eclairagepublicsignalisationtricolore>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < eclairagepublicsignalisationtricolore.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(eclairagepublicsignalisationtricolore.datasetid, eclairagepublicsignalisationtricolore.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<eclairagepublicsignalisationtricolore>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<abrivoyageursecranstactilesconnectes>> abrivoyageursecranstactilesconnectesDataset
		{ 
			get 
			{
				List<Record<abrivoyageursecranstactilesconnectes>> result = new List<Record<abrivoyageursecranstactilesconnectes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < abrivoyageursecranstactilesconnectes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(abrivoyageursecranstactilesconnectes.datasetid, abrivoyageursecranstactilesconnectes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<abrivoyageursecranstactilesconnectes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<zonesdecirculationapaiseeaparis>> zonesdecirculationapaiseeaparisDataset
		{ 
			get 
			{
				List<Record<zonesdecirculationapaiseeaparis>> result = new List<Record<zonesdecirculationapaiseeaparis>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < zonesdecirculationapaiseeaparis.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(zonesdecirculationapaiseeaparis.datasetid, zonesdecirculationapaiseeaparis.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<zonesdecirculationapaiseeaparis>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret>> les1000titreslesplusrecherchesaucataloguedesbibliothequesdepretDataset
		{ 
			get 
			{
				List<Record<les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret>> result = new List<Record<les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret.datasetid, les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<domiciliationdesagentsbilansocial>> domiciliationdesagentsbilansocialDataset
		{ 
			get 
			{
				List<Record<domiciliationdesagentsbilansocial>> result = new List<Record<domiciliationdesagentsbilansocial>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < domiciliationdesagentsbilansocial.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(domiciliationdesagentsbilansocial.datasetid, domiciliationdesagentsbilansocial.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<domiciliationdesagentsbilansocial>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<stationnementvoiepubliqueemplacements>> stationnementvoiepubliqueemplacementsDataset
		{ 
			get 
			{
				List<Record<stationnementvoiepubliqueemplacements>> result = new List<Record<stationnementvoiepubliqueemplacements>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < stationnementvoiepubliqueemplacements.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(stationnementvoiepubliqueemplacements.datasetid, stationnementvoiepubliqueemplacements.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<stationnementvoiepubliqueemplacements>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<voiesactuellesparis2012>> voiesactuellesparis2012Dataset
		{ 
			get 
			{
				List<Record<voiesactuellesparis2012>> result = new List<Record<voiesactuellesparis2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < voiesactuellesparis2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(voiesactuellesparis2012.datasetid, voiesactuellesparis2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<voiesactuellesparis2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<comptesadministratifsetatsspeciauxdarrondissement>> comptesadministratifsetatsspeciauxdarrondissementDataset
		{ 
			get 
			{
				List<Record<comptesadministratifsetatsspeciauxdarrondissement>> result = new List<Record<comptesadministratifsetatsspeciauxdarrondissement>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < comptesadministratifsetatsspeciauxdarrondissement.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(comptesadministratifsetatsspeciauxdarrondissement.datasetid, comptesadministratifsetatsspeciauxdarrondissement.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<comptesadministratifsetatsspeciauxdarrondissement>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<paris_taxis_data>> paris_taxis_dataDataset
		{ 
			get 
			{
				List<Record<paris_taxis_data>> result = new List<Record<paris_taxis_data>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < paris_taxis_data.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(paris_taxis_data.datasetid, paris_taxis_data.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<paris_taxis_data>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<arretesinsalubriteparis2010>> arretesinsalubriteparis2010Dataset
		{ 
			get 
			{
				List<Record<arretesinsalubriteparis2010>> result = new List<Record<arretesinsalubriteparis2010>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < arretesinsalubriteparis2010.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(arretesinsalubriteparis2010.datasetid, arretesinsalubriteparis2010.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<arretesinsalubriteparis2010>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<les_1000_titres_les_plus_empruntes_2012_par_bibliotheque>> les_1000_titres_les_plus_empruntes_2012_par_bibliothequeDataset
		{ 
			get 
			{
				List<Record<les_1000_titres_les_plus_empruntes_2012_par_bibliotheque>> result = new List<Record<les_1000_titres_les_plus_empruntes_2012_par_bibliotheque>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < les_1000_titres_les_plus_empruntes_2012_par_bibliotheque.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(les_1000_titres_les_plus_empruntes_2012_par_bibliotheque.datasetid, les_1000_titres_les_plus_empruntes_2012_par_bibliotheque.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<les_1000_titres_les_plus_empruntes_2012_par_bibliotheque>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<etalages_et_terrasses_autorisees_a_paris>> etalages_et_terrasses_autorisees_a_parisDataset
		{ 
			get 
			{
				List<Record<etalages_et_terrasses_autorisees_a_paris>> result = new List<Record<etalages_et_terrasses_autorisees_a_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < etalages_et_terrasses_autorisees_a_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(etalages_et_terrasses_autorisees_a_paris.datasetid, etalages_et_terrasses_autorisees_a_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<etalages_et_terrasses_autorisees_a_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<resultats_electoraux>> resultats_electorauxDataset
		{ 
			get 
			{
				List<Record<resultats_electoraux>> result = new List<Record<resultats_electoraux>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < resultats_electoraux.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(resultats_electoraux.datasetid, resultats_electoraux.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<resultats_electoraux>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<plan_de_l_hemicycle_du_conseil_de_paris>> plan_de_l_hemicycle_du_conseil_de_parisDataset
		{ 
			get 
			{
				List<Record<plan_de_l_hemicycle_du_conseil_de_paris>> result = new List<Record<plan_de_l_hemicycle_du_conseil_de_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < plan_de_l_hemicycle_du_conseil_de_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(plan_de_l_hemicycle_du_conseil_de_paris.datasetid, plan_de_l_hemicycle_du_conseil_de_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<plan_de_l_hemicycle_du_conseil_de_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<etiquettes_energetiques_des_batiments_municipaux>> etiquettes_energetiques_des_batiments_municipauxDataset
		{ 
			get 
			{
				List<Record<etiquettes_energetiques_des_batiments_municipaux>> result = new List<Record<etiquettes_energetiques_des_batiments_municipaux>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < etiquettes_energetiques_des_batiments_municipaux.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(etiquettes_energetiques_des_batiments_municipaux.datasetid, etiquettes_energetiques_des_batiments_municipaux.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<etiquettes_energetiques_des_batiments_municipaux>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<accidentologie>> accidentologieDataset
		{ 
			get 
			{
				List<Record<accidentologie>> result = new List<Record<accidentologie>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < accidentologie.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(accidentologie.datasetid, accidentologie.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<accidentologie>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lescimetieresemprises>> lescimetieresemprisesDataset
		{ 
			get 
			{
				List<Record<lescimetieresemprises>> result = new List<Record<lescimetieresemprises>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lescimetieresemprises.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lescimetieresemprises.datasetid, lescimetieresemprises.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lescimetieresemprises>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobilierenvironnementparis2011>> mobilierenvironnementparis2011Dataset
		{ 
			get 
			{
				List<Record<mobilierenvironnementparis2011>> result = new List<Record<mobilierenvironnementparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobilierenvironnementparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobilierenvironnementparis2011.datasetid, mobilierenvironnementparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobilierenvironnementparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_etablissements_scolaires2>> liste_des_etablissements_scolaires2Dataset
		{ 
			get 
			{
				List<Record<liste_des_etablissements_scolaires2>> result = new List<Record<liste_des_etablissements_scolaires2>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_etablissements_scolaires2.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_etablissements_scolaires2.datasetid, liste_des_etablissements_scolaires2.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_etablissements_scolaires2>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<profil_petite_ceinture>> profil_petite_ceintureDataset
		{ 
			get 
			{
				List<Record<profil_petite_ceinture>> result = new List<Record<profil_petite_ceinture>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < profil_petite_ceinture.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(profil_petite_ceinture.datasetid, profil_petite_ceinture.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<profil_petite_ceinture>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lessurfacesboisees>> lessurfacesboiseesDataset
		{ 
			get 
			{
				List<Record<lessurfacesboisees>> result = new List<Record<lessurfacesboisees>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lessurfacesboisees.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lessurfacesboisees.datasetid, lessurfacesboisees.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lessurfacesboisees>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_jardins_partages_a_paris>> liste_des_jardins_partages_a_parisDataset
		{ 
			get 
			{
				List<Record<liste_des_jardins_partages_a_paris>> result = new List<Record<liste_des_jardins_partages_a_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_jardins_partages_a_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_jardins_partages_a_paris.datasetid, liste_des_jardins_partages_a_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_jardins_partages_a_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<sanisettesparis2011>> sanisettesparis2011Dataset
		{ 
			get 
			{
				List<Record<sanisettesparis2011>> result = new List<Record<sanisettesparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < sanisettesparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(sanisettesparis2011.datasetid, sanisettesparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<sanisettesparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<comptesadministratifsbudgetsannexes>> comptesadministratifsbudgetsannexesDataset
		{ 
			get 
			{
				List<Record<comptesadministratifsbudgetsannexes>> result = new List<Record<comptesadministratifsbudgetsannexes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < comptesadministratifsbudgetsannexes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(comptesadministratifsbudgetsannexes.datasetid, comptesadministratifsbudgetsannexes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<comptesadministratifsbudgetsannexes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<cinemasaparis>> cinemasaparisDataset
		{ 
			get 
			{
				List<Record<cinemasaparis>> result = new List<Record<cinemasaparis>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < cinemasaparis.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(cinemasaparis.datasetid, cinemasaparis.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<cinemasaparis>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lestitreslespluspretes>> lestitreslespluspretesDataset
		{ 
			get 
			{
				List<Record<lestitreslespluspretes>> result = new List<Record<lestitreslespluspretes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lestitreslespluspretes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lestitreslespluspretes.datasetid, lestitreslespluspretes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lestitreslespluspretes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<tonnages_des_dechets_bacs_jaunes>> tonnages_des_dechets_bacs_jaunesDataset
		{ 
			get 
			{
				List<Record<tonnages_des_dechets_bacs_jaunes>> result = new List<Record<tonnages_des_dechets_bacs_jaunes>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < tonnages_des_dechets_bacs_jaunes.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(tonnages_des_dechets_bacs_jaunes.datasetid, tonnages_des_dechets_bacs_jaunes.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<tonnages_des_dechets_bacs_jaunes>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<mobiliertransportsparis2011>> mobiliertransportsparis2011Dataset
		{ 
			get 
			{
				List<Record<mobiliertransportsparis2011>> result = new List<Record<mobiliertransportsparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < mobiliertransportsparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(mobiliertransportsparis2011.datasetid, mobiliertransportsparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<mobiliertransportsparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<lesarbres>> lesarbresDataset
		{ 
			get 
			{
				List<Record<lesarbres>> result = new List<Record<lesarbres>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < lesarbres.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(lesarbres.datasetid, lesarbres.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<lesarbres>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_marches_de_quartier_a_paris>> liste_des_marches_de_quartier_a_parisDataset
		{ 
			get 
			{
				List<Record<liste_des_marches_de_quartier_a_paris>> result = new List<Record<liste_des_marches_de_quartier_a_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_marches_de_quartier_a_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_marches_de_quartier_a_paris.datasetid, liste_des_marches_de_quartier_a_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_marches_de_quartier_a_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<annuaire_immobilier_de_l_enseignement_superieur>> annuaire_immobilier_de_l_enseignement_superieurDataset
		{ 
			get 
			{
				List<Record<annuaire_immobilier_de_l_enseignement_superieur>> result = new List<Record<annuaire_immobilier_de_l_enseignement_superieur>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < annuaire_immobilier_de_l_enseignement_superieur.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(annuaire_immobilier_de_l_enseignement_superieur.datasetid, annuaire_immobilier_de_l_enseignement_superieur.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<annuaire_immobilier_de_l_enseignement_superieur>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<plaques_commemoratives_19391945>> plaques_commemoratives_19391945Dataset
		{ 
			get 
			{
				List<Record<plaques_commemoratives_19391945>> result = new List<Record<plaques_commemoratives_19391945>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < plaques_commemoratives_19391945.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(plaques_commemoratives_19391945.datasetid, plaques_commemoratives_19391945.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<plaques_commemoratives_19391945>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_kiosques_presse_a_paris>> liste_des_kiosques_presse_a_parisDataset
		{ 
			get 
			{
				List<Record<liste_des_kiosques_presse_a_paris>> result = new List<Record<liste_des_kiosques_presse_a_paris>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_kiosques_presse_a_paris.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_kiosques_presse_a_paris.datasetid, liste_des_kiosques_presse_a_paris.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_kiosques_presse_a_paris>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<resultatsdelelectionmunicipale20142emetour>> resultatsdelelectionmunicipale20142emetourDataset
		{ 
			get 
			{
				List<Record<resultatsdelelectionmunicipale20142emetour>> result = new List<Record<resultatsdelelectionmunicipale20142emetour>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < resultatsdelelectionmunicipale20142emetour.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(resultatsdelelectionmunicipale20142emetour.datasetid, resultatsdelelectionmunicipale20142emetour.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<resultatsdelelectionmunicipale20142emetour>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<bati_donnees_geographiques>> bati_donnees_geographiquesDataset
		{ 
			get 
			{
				List<Record<bati_donnees_geographiques>> result = new List<Record<bati_donnees_geographiques>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < bati_donnees_geographiques.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(bati_donnees_geographiques.datasetid, bati_donnees_geographiques.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<bati_donnees_geographiques>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<arbresremarquablesparis2011>> arbresremarquablesparis2011Dataset
		{ 
			get 
			{
				List<Record<arbresremarquablesparis2011>> result = new List<Record<arbresremarquablesparis2011>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < arbresremarquablesparis2011.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(arbresremarquablesparis2011.datasetid, arbresremarquablesparis2011.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<arbresremarquablesparis2011>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<stationsvelibdisponibilitesentempsreel>> stationsvelibdisponibilitesentempsreelDataset
		{ 
			get 
			{
				List<Record<stationsvelibdisponibilitesentempsreel>> result = new List<Record<stationsvelibdisponibilitesentempsreel>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < stationsvelibdisponibilitesentempsreel.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(stationsvelibdisponibilitesentempsreel.datasetid, stationsvelibdisponibilitesentempsreel.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<stationsvelibdisponibilitesentempsreel>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<stations_et_espaces_autolib_de_la_metropole_parisienne>> stations_et_espaces_autolib_de_la_metropole_parisienneDataset
		{ 
			get 
			{
				List<Record<stations_et_espaces_autolib_de_la_metropole_parisienne>> result = new List<Record<stations_et_espaces_autolib_de_la_metropole_parisienne>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < stations_et_espaces_autolib_de_la_metropole_parisienne.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(stations_et_espaces_autolib_de_la_metropole_parisienne.datasetid, stations_et_espaces_autolib_de_la_metropole_parisienne.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<stations_et_espaces_autolib_de_la_metropole_parisienne>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<liste_des_prenoms_2004_a_2012>> liste_des_prenoms_2004_a_2012Dataset
		{ 
			get 
			{
				List<Record<liste_des_prenoms_2004_a_2012>> result = new List<Record<liste_des_prenoms_2004_a_2012>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < liste_des_prenoms_2004_a_2012.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(liste_des_prenoms_2004_a_2012.datasetid, liste_des_prenoms_2004_a_2012.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<liste_des_prenoms_2004_a_2012>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		public IEnumerable<Record<evenementsaparis>> evenementsaparisDataset
		{ 
			get 
			{
				List<Record<evenementsaparis>> result = new List<Record<evenementsaparis>>();
                List<string> resultatJsonBrut = new List<string>();
				for (int i = 0; i < evenementsaparis.recordNumber; i+=10000)
                {
                    resultatJsonBrut.Add(dataParis.getRecords(evenementsaparis.datasetid, evenementsaparis.recordNumber,i));
                }

				if (resultatJsonBrut==null)
				{
					return null;
				}
				else
				{
					foreach (var jsonResult in resultatJsonBrut)
					{
						foreach (var recordList in JsonConvert.DeserializeObject<DatasetData<evenementsaparis>>(jsonResult).records)
						{
							result.Add(recordList);
						} 
					}
					return result;
				}			
			}
		}
		
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
				}
				disposed = true;
			}
		}
	}
}

