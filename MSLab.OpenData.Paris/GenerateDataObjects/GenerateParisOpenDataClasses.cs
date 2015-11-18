using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MSLab.OpenData.Paris.Data;

namespace MSLab.OpenData.Paris.Connexion
{	

	public class postespublicsdesbibliothequesdepret	
	{
		public string className {get {return "postes-publics-des-bibliotheques-de-pret" ;} }
		
		public string _etablissement { get; set; }
	
		
		public int _nombre_d_ordinateurs { get; set; }
	
		
		public string _type_de_poste_public { get; set; }
	
		
		public List<double> _position { get; set; }
	
		
	}

	public class bilansocialeffectifsnontitulairespermanents	
	{
		public string className {get {return "bilan-social-effectifs-non-titulaires-permanents" ;} }
		
		public DateTime _annee { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _type_de_contrat { get; set; }
	
		
		public string _emplois { get; set; }
	
		
		public string _niveau { get; set; }
	
		
		public string _specialite { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
	}

	public class deliberationemploi	
	{
		public string className {get {return "deliberation-emploi" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _type_de_budget { get; set; }
	
		
		public string _numero_de_deliberation { get; set; }
	
		
		public string _date_de_deliberation { get; set; }
	
		
		public string _direction_code { get; set; }
	
		
		public string _direction_texte { get; set; }
	
		
		public string _type_de_mouvement { get; set; }
	
		
		public double _ndeg_enreg { get; set; }
	
		
		public string _service_ou_equipement { get; set; }
	
		
		public string _filiere { get; set; }
	
		
		public string _corps_ou_emploi { get; set; }
	
		
		public double _nb_de_postes { get; set; }
	
		
		public int _nb_d_heures { get; set; }
	
		
		public int _nb_de_mois { get; set; }
	
		
		public string _date_d_effet { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
		public string _fonction_cle { get; set; }
	
		
		public string _fonction_texte { get; set; }
	
		
	}

	public class budgetsvotesannexes	
	{
		public string className {get {return "budgets-votes-annexes" ;} }
		
		public int _exercice_comptable { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_d_operation_r_o_i_m { get; set; }
	
		
		public string _type_du_vote { get; set; }
	
		
		public string _chapitre_budgetaire_cle { get; set; }
	
		
		public string _chapitre_budgetaire_texte { get; set; }
	
		
		public string _nature_budgetaire_cle { get; set; }
	
		
		public string _nature_budgetaire_texte { get; set; }
	
		
		public double _credits_votes_pmt { get; set; }
	
		
	}

	public class bugdetvotesprincipaux	
	{
		public string className {get {return "bugdet-votes-principaux" ;} }
		
		public string _exercice_comptable { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_d_operation_r_o_i_m { get; set; }
	
		
		public string _type_du_vote { get; set; }
	
		
		public string _chapitre_budgetaire_cle { get; set; }
	
		
		public string _chapitre_budgetaire_texte { get; set; }
	
		
		public string _nature_budgetaire_cle { get; set; }
	
		
		public string _nature_budgetaire_texte { get; set; }
	
		
		public string _fonction_cle { get; set; }
	
		
		public string _fonction_texte { get; set; }
	
		
		public int _credits_votes_pmt { get; set; }
	
		
	}

	public class immobilisationsetatdessorties	
	{
		public string className {get {return "immobilisations-etat-des-sorties" ;} }
		
		public string _publication { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _rubrique { get; set; }
	
		
		public string _detail { get; set; }
	
		
		public string _sous_detail { get; set; }
	
		
		public string _nature { get; set; }
	
		
		public string _ndeg_immobilisation { get; set; }
	
		
		public int _ndeg_subs { get; set; }
	
		
		public string _designation_du_bien { get; set; }
	
		
		public DateTime _date_d_acquisition { get; set; }
	
		
		public DateTime _date_de_cession { get; set; }
	
		
		public double _valeur_d_acquisition { get; set; }
	
		
		public int _duree_d_amort { get; set; }
	
		
		public double _cumul_amort_anterieurs { get; set; }
	
		
		public double _vnc_au_jour_de_cession { get; set; }
	
		
		public string _prix_de_cession { get; set; }
	
		
		public string _value { get; set; }
	
		
		public string _observations { get; set; }
	
		
	}

	public class comptesadministratifsprincipauxvilledepartement	
	{
		public string className {get {return "comptes-administratifs-principaux-ville-departement" ;} }
		
		public string _exercice_comptable { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_d_operation_r_o_i_m { get; set; }
	
		
		public string _chapitre_budgetaire_cle { get; set; }
	
		
		public string _chapitre_niveau_vote_texte_descriptif { get; set; }
	
		
		public int _nature_budgetaire_cle { get; set; }
	
		
		public string _nature_budgetaire_texte { get; set; }
	
		
		public string _fonction_cle { get; set; }
	
		
		public string _fonction_texte { get; set; }
	
		
		public double _mandate_titre_apres_regul { get; set; }
	
		
	}

	public class pointsdevotedubudgetparticipatif	
	{
		public string className {get {return "points-de-vote-du-budget-participatif" ;} }
		
		public string _arr { get; set; }
	
		
		public string _column_2 { get; set; }
	
		
		public string _equipement { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class formationparthemesbilansocial	
	{
		public string className {get {return "formation-par-themes-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _type_de_formation { get; set; }
	
		
		public string _nature_de_la_formation { get; set; }
	
		
		public int _stagiaires_femmes { get; set; }
	
		
		public int _stagiaires_hommes { get; set; }
	
		
		public int _jours { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class titularisations	
	{
		public string className {get {return "titularisations" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public string _corps { get; set; }
	
		
		public int _nombre_de_femmes_titularisees { get; set; }
	
		
		public int _nombre_d_hommes_titularises { get; set; }
	
		
		public DateTime _date { get; set; }
	
		
	}

	public class etatdupersonnel	
	{
		public string className {get {return "etat-du-personnel" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _budget_de_reference { get; set; }
	
		
		public string _date_d_effet { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _type_d_emploi { get; set; }
	
		
		public string _filiere { get; set; }
	
		
		public string _emplois { get; set; }
	
		
		public string _categories { get; set; }
	
		
		public double _emplois_budgetaires_emplois_permanents_a_temps_complet { get; set; }
	
		
		public double _emplois_budgetaires_emplois_permanents_a_temps_incomplet { get; set; }
	
		
		public double _effectifs_pourvus_sur_emplois_budgetaires_en_etpt_agents_titulaires { get; set; }
	
		
		public double _effectifs_pourvus_sur_emplois_budgetaires_en_etpt_agents_non_titulaires { get; set; }
	
		
		public double _effectifs_pourvus_sur_emplois_budgetaires_en_etp_agents_titulaires { get; set; }
	
		
		public double _effectifs_pourvus_sur_emplois_budgetaires_en_etp_agents_non_titulaires { get; set; }
	
		
	}

	public class recrutementdirectbilansocial	
	{
		public string className {get {return "recrutement-direct-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _secteur_grade { get; set; }
	
		
		public int _postes_ouverts { get; set; }
	
		
		public int _inscrits { get; set; }
	
		
		public int _presents { get; set; }
	
		
		public int _nombre_de_femmes_recues { get; set; }
	
		
		public int _nombre_d_hommes_recus { get; set; }
	
		
		public int _nombre_de_femmes_recrutees { get; set; }
	
		
		public int _nombre_d_hommes_recrutes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
		public string _column_24 { get; set; }
	
		
		public string _column_25 { get; set; }
	
		
		public string _column_26 { get; set; }
	
		
		public string _column_27 { get; set; }
	
		
		public string _column_28 { get; set; }
	
		
		public string _column_29 { get; set; }
	
		
		public string _column_30 { get; set; }
	
		
		public string _column_31 { get; set; }
	
		
		public string _column_32 { get; set; }
	
		
		public string _column_33 { get; set; }
	
		
		public string _column_34 { get; set; }
	
		
		public string _column_35 { get; set; }
	
		
		public string _column_36 { get; set; }
	
		
		public string _column_37 { get; set; }
	
		
		public string _column_38 { get; set; }
	
		
		public string _column_39 { get; set; }
	
		
		public string _column_40 { get; set; }
	
		
		public string _column_41 { get; set; }
	
		
		public string _column_42 { get; set; }
	
		
		public string _column_43 { get; set; }
	
		
		public string _column_44 { get; set; }
	
		
		public string _column_45 { get; set; }
	
		
		public string _column_46 { get; set; }
	
		
		public string _column_47 { get; set; }
	
		
		public string _column_48 { get; set; }
	
		
		public string _column_49 { get; set; }
	
		
		public string _column_50 { get; set; }
	
		
		public string _column_51 { get; set; }
	
		
		public string _column_52 { get; set; }
	
		
		public string _column_53 { get; set; }
	
		
	}

	public class stationnementsurvoiepubliquezonestarifaires	
	{
		public string className {get {return "stationnement-sur-voie-publique-zones-tarifaires" ;} }
		
		public int _objectid { get; set; }
	
		
		public string _zone { get; set; }
	
		
		public double _tarif { get; set; }
	
		
		public double _shape_area { get; set; }
	
		
		public double _shape_len { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public List<double> _geo_point_2d { get; set; }
	
		
	}

	public class inventairedesdocumentsnumerisesenligne	
	{
		public string className {get {return "inventaire-des-documents-numerises-en-ligne" ;} }
		
		public string _etablissement { get; set; }
	
		
		public string _nom_du_lot { get; set; }
	
		
		public string _type_de_documents { get; set; }
	
		
		public int _nb_de_documents { get; set; }
	
		
		public int _nb_de_fichiers { get; set; }
	
		
		public List<double> _position { get; set; }
	
		
	}

	public class titreslesplusreservesbibliothequesspecialisees	
	{
		public string className {get {return "titres-les-plus-reserves-bibliotheques-specialisees" ;} }
		
		public string _auteur { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _editeur { get; set; }
	
		
		public string _collection { get; set; }
	
		
		public int _annee_edition { get; set; }
	
		
		public string _categorie_documentaire { get; set; }
	
		
		public int _nb_de_reservations_2014 { get; set; }
	
		
	}

	public class titreslespluspretesbibliothequesspecialiseesen2014	
	{
		public string className {get {return "titres-les-plus-pretes-bibliotheques-specialisees-en-2014" ;} }
		
		public string _auteur { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _editeur { get; set; }
	
		
		public string _collection { get; set; }
	
		
		public int _annee_edition { get; set; }
	
		
		public string _categorie_documentaire { get; set; }
	
		
		public int _nb_prets_2014 { get; set; }
	
		
	}

	public class accidentdetravailetdetrajetparcorpsbilansocial	
	{
		public string className {get {return "accident-de-travail-et-de-trajet-par-corps-bilan-social" ;} }
		
		public DateTime _annee { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _corps { get; set; }
	
		
		public int _accident_de_travail_et_de_trajet_avec_arret { get; set; }
	
		
		public int _accident_de_travail_et_de_trajet_sans_arret { get; set; }
	
		
	}

	public class budgetsvotesetatsspeciauxdarrondissements	
	{
		public string className {get {return "budgets-votes-etats-speciaux-darrondissements" ;} }
		
		public DateTime _exercice_comptable { get; set; }
	
		
		public string _arrondissement { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_d_operation_r_o_i_m { get; set; }
	
		
		public string _type_du_vote { get; set; }
	
		
		public string _chapitre_budgetaire_cle { get; set; }
	
		
		public string _chapitre_budgetaire_texte { get; set; }
	
		
		public string _nature_budgetaire_cle { get; set; }
	
		
		public string _nature_budgetaire_texte { get; set; }
	
		
		public string _fonction_cle { get; set; }
	
		
		public string _fonction_texte { get; set; }
	
		
		public double _credits_votes_pmt { get; set; }
	
		
	}

	public class dettepropre	
	{
		public string className {get {return "dette-propre" ;} }
		
		public DateTime _annee_de_publication { get; set; }
	
		
		public string _nature { get; set; }
	
		
		public string _organisme_preteur_ou_chef_de_file { get; set; }
	
		
		public DateTime _date_d_emission_ou_date_de_mobilisation { get; set; }
	
		
		public DateTime _date_de_derniere_echeance { get; set; }
	
		
		public double _capital_initial { get; set; }
	
		
		public double _capital_restant_du_au_31_12_2013 { get; set; }
	
		
		public string _type_de_taux_d_interet { get; set; }
	
		
		public string _index { get; set; }
	
		
		public double _taux_initial_niveau_de_taux { get; set; }
	
		
		public double _taux_initial_taux_actuariel { get; set; }
	
		
		public string _profil_d_amortissement { get; set; }
	
		
		public string _possibilite_de_remboursement { get; set; }
	
		
		public string _categorie_d_emprunt { get; set; }
	
		
	}

	public class budgetvotesapautotrisationsdeprogrammes	
	{
		public string className {get {return "budget-votes-ap-autotrisations-de-programmes" ;} }
		
		public string _empty { get; set; }
	
		
		public int _exercice_comptable { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_de_fonds_texte { get; set; }
	
		
		public string _type_du_vote { get; set; }
	
		
		public string _mission_ap_cle { get; set; }
	
		
		public string _mission_ap_texte { get; set; }
	
		
		public string _mission_activite_ap_cle { get; set; }
	
		
		public string _mission_activte_ap_texte { get; set; }
	
		
		public string _individualisation_ap_cle { get; set; }
	
		
		public string _individualisation_texte_ville { get; set; }
	
		
		public string _sens_depense_recette0 { get; set; }
	
		
		public double _credits_votes_eng { get; set; }
	
		
	}

	public class lesparcellesforestieresdesbois	
	{
		public string className {get {return "les-parcelles-forestieres-des-bois" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public int _num_bois { get; set; }
	
		
		public string _nom_bois { get; set; }
	
		
		public double _surface { get; set; }
	
		
	}

	public class lesconseillersdeparisde1977a2014	
	{
		public string className {get {return "les-conseillers-de-paris-de-1977-a-2014" ;} }
		
		public string _image { get; set; }
	
		
		public string _mandature { get; set; }
	
		
		public string _conseiller { get; set; }
	
		
		public string _civilite { get; set; }
	
		
		public string _prenom { get; set; }
	
		
		public string _nom { get; set; }
	
		
		public string _secteur { get; set; }
	
		
		public string _groupe_politique { get; set; }
	
		
		public string _groupe_politique_fonctions { get; set; }
	
		
		public DateTime _elu_e_le { get; set; }
	
		
		public string _deces { get; set; }
	
		
		public string _demission { get; set; }
	
		
		public string _remplacement { get; set; }
	
		
		public string _maire_de_paris { get; set; }
	
		
		public string _adjoint_au_maire { get; set; }
	
		
		public string _adjoint_au_maire_demission { get; set; }
	
		
		public string _delegation_1_adjoint { get; set; }
	
		
		public string _arrete_delegation_a1 { get; set; }
	
		
		public string _arrete_fin_delegation_a1 { get; set; }
	
		
		public string _delegation_2_adjoint { get; set; }
	
		
		public string _arrete_delegation_a2 { get; set; }
	
		
		public string _arrete_fin_delegation_a2 { get; set; }
	
		
		public string _delegation_3_adjoint { get; set; }
	
		
		public string _arrete_delegation_a3 { get; set; }
	
		
		public string _arrete_fin_delegation_a3 { get; set; }
	
		
		public string _delegation_4_adjoint { get; set; }
	
		
		public string _arrete_delegation_a4 { get; set; }
	
		
		public string _conseiller_delegue { get; set; }
	
		
		public string _delegation_1_conseiller_delegue { get; set; }
	
		
		public string _arrete_delegation_cd1 { get; set; }
	
		
		public string _arrete_fin_delegation_cd1 { get; set; }
	
		
		public string _delegation_2_conseiller_delegue { get; set; }
	
		
		public string _arrete_delegation_cd2 { get; set; }
	
		
		public string _arrete_fin_delegation_cd2 { get; set; }
	
		
		public string _delegation_3_conseiller_delegue { get; set; }
	
		
		public string _arrete_delegation_cd3 { get; set; }
	
		
		public string _arrete_fin_delegation_cd3 { get; set; }
	
		
		public string _mission_1_conseiller_de_paris { get; set; }
	
		
		public string _arrete_mission_cp1 { get; set; }
	
		
		public string _mission_2_conseiller_de_paris { get; set; }
	
		
		public string _arrete_mission_cp2 { get; set; }
	
		
		public string _fonction_au_conseil_general { get; set; }
	
		
		public string _arrondissement_fonction { get; set; }
	
		
		public string _arrondissement_arrete_pour_fonction { get; set; }
	
		
		public string _arrondissement_demission { get; set; }
	
		
		public DateTime _ne_e_le { get; set; }
	
		
		public string _ville_de_naissance { get; set; }
	
		
		public string _arrondt_departement_ou_pays { get; set; }
	
		
		public string _profession { get; set; }
	
		
		public string _avant_1977_au_conseil_de_paris { get; set; }
	
		
		public string _liste { get; set; }
	
		
		public string _conduite_par { get; set; }
	
		
	}

	public class positionsstatutairesparticulieresautrequedetachementbilansocial	
	{
		public string className {get {return "positions-statutaires-particulieres-autre-que-detachement-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _positions_statutaires_particulieres { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class paris_taxis_stations	
	{
		public string className {get {return "paris_taxis_stations" ;} }
		
		public string _station_id { get; set; }
	
		
		public string _station_name { get; set; }
	
		
		public int _station_number { get; set; }
	
		
		public string _address { get; set; }
	
		
		public string _address_precision { get; set; }
	
		
		public string _zip_code { get; set; }
	
		
		public string _city { get; set; }
	
		
		public List<double> _geo_coordinates { get; set; }
	
		
	}

	public class recrutementsurconcoursbilansocial	
	{
		public string className {get {return "recrutement-sur-concours-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _type_de_concours { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public string _concours { get; set; }
	
		
		public int _postes { get; set; }
	
		
		public int _candidats_inscrits { get; set; }
	
		
		public int _candidats_presents_1ere_epreuve { get; set; }
	
		
		public int _recus_liste_principale { get; set; }
	
		
		public int _recus_liste_complementaire { get; set; }
	
		
		public int _recus_liste_principale_femmes { get; set; }
	
		
		public int _recus_liste_principale_hommes { get; set; }
	
		
		public int _recus_liste_complementaire_femmes { get; set; }
	
		
		public int _recus_liste_complementaire_hommes { get; set; }
	
		
		public int _nb_femmes_recrutees { get; set; }
	
		
		public int _nb_hommes_recrutes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class subventionsaccordeesetrefusees	
	{
		public string className {get {return "subventions-accordees-et-refusees" ;} }
		
		public string _annee { get; set; }
	
		
		public string _nom_du_partenaire { get; set; }
	
		
		public string _ndeg_siret { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _code_postal { get; set; }
	
		
		public string _ville { get; set; }
	
		
		public string _intitule_de_la_demande { get; set; }
	
		
		public string _appel_a_projets { get; set; }
	
		
		public string _appel_a_projets_politique_ville { get; set; }
	
		
		public int _montant_demande { get; set; }
	
		
		public double _montant_vote_par_demande { get; set; }
	
		
		public int _total_vote_en_2013 { get; set; }
	
		
		public int _fonctionnement { get; set; }
	
		
		public int _subventions_sur_projet { get; set; }
	
		
		public int _subventions_d_equipement { get; set; }
	
		
		public int _subventions_sans_nature_specifiee { get; set; }
	
		
		public string _s_pr_numero_simpa { get; set; }
	
		
		public string _financee_non_financee { get; set; }
	
		
	}

	public class listedesmarchesdelacollectiviteparisienne	
	{
		public string className {get {return "liste-des-marches-de-la-collectivite-parisienne" ;} }
		
		public DateTime _annee_de_notification { get; set; }
	
		
		public string _ndeg_marche { get; set; }
	
		
		public string _objet_du_marche { get; set; }
	
		
		public string _nature_du_marche { get; set; }
	
		
		public string _fournisseur_nom { get; set; }
	
		
		public string _fournisseur_siret { get; set; }
	
		
		public string _fournisseur_code_postal { get; set; }
	
		
		public string _fournisseur_ville { get; set; }
	
		
		public double _montant_min { get; set; }
	
		
		public double _montant_max { get; set; }
	
		
		public DateTime _date_de_notification { get; set; }
	
		
		public DateTime _date_de_debut { get; set; }
	
		
		public DateTime _date_de_fin { get; set; }
	
		
		public double _duree_du_marche_en_jours { get; set; }
	
		
		public string _perimetre_financier { get; set; }
	
		
		public string _article_cmp { get; set; }
	
		
		public string _categorie_d_achat_cle { get; set; }
	
		
		public string _categorie_d_achat_texte { get; set; }
	
		
	}

	public class tranchedagedetailleespour15corpsbilansocial	
	{
		public string className {get {return "tranche-dage-detaillees-pour-15-corps-bilan-social" ;} }
		
		public string _corps { get; set; }
	
		
		public string _tranches_d_age { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
		public DateTime _date { get; set; }
	
		
	}

	public class formationparcategoriesbilansocial	
	{
		public string className {get {return "formation-par-categories-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public int _femmes { get; set; }
	
		
		public int _hommes { get; set; }
	
		
		public int _jours_femmes { get; set; }
	
		
		public int _jours_hommes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class statistiquesdesvotesenlignedubudgetparticipatif2014	
	{
		public string className {get {return "statistiques-des-votes-en-ligne-du-budget-participatif-2014" ;} }
		
		public string _id { get; set; }
	
		
		public string _projets { get; set; }
	
		
		public DateTime _date_de_vote { get; set; }
	
		
		public int _arrondissement { get; set; }
	
		
		public int _age { get; set; }
	
		
	}

	public class lesjardinieres	
	{
		public string className {get {return "les-jardinieres" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public string _label { get; set; }
	
		
		public string _arr { get; set; }
	
		
		public int _annee_crea { get; set; }
	
		
		public int _surf_tot { get; set; }
	
		
	}

	public class zones30	
	{
		public string className {get {return "zones-30" ;} }
		
		public int _objectid { get; set; }
	
		
		public string _nom_zca { get; set; }
	
		
		public int _stv { get; set; }
	
		
		public DateTime _date_arr { get; set; }
	
		
		public string _type_arr { get; set; }
	
		
		public int _arrdt { get; set; }
	
		
		public double _shape_area { get; set; }
	
		
		public double _shape_len { get; set; }
	
		
		public string _reglement { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public List<double> _geo_point_2d { get; set; }
	
		
	}

	public class touspe3	
	{
		public string className {get {return "touspe3" ;} }
		
		public string _isbn { get; set; }
	
		
		public string _issn { get; set; }
	
		
		public string _langue_du_document { get; set; }
	
		
		public string _langue_de_l_oeuvre_originale { get; set; }
	
		
		public string _langue_des_sous_titres { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _type_de_document { get; set; }
	
		
		public string _titre_parallele { get; set; }
	
		
		public string _complement_du_titre { get; set; }
	
		
		public string _numero_de_partie { get; set; }
	
		
		public string _titre_de_partie { get; set; }
	
		
		public string _lieu { get; set; }
	
		
		public string _editeur { get; set; }
	
		
		public string _date_publication { get; set; }
	
		
		public string _document { get; set; }
	
		
		public string _caracteristiques_materielles { get; set; }
	
		
		public string _format { get; set; }
	
		
		public string _materiel_d_accompagnement { get; set; }
	
		
		public string _titre_de_la_collection { get; set; }
	
		
		public string _est_publie_avec { get; set; }
	
		
		public string _est_une_traduction_de { get; set; }
	
		
		public string _genre { get; set; }
	
		
		public string _genre_forme { get; set; }
	
		
		public string _sujet_libre { get; set; }
	
		
		public string _co_auteur_nom { get; set; }
	
		
		public string _co_auteur_prenom { get; set; }
	
		
		public string _auteur_secondaire_nom { get; set; }
	
		
		public string _auteur_secondaire_prenom { get; set; }
	
		
		public string _auteur_collectivite_nom { get; set; }
	
		
		public string _auteur_collectivite_subdivision { get; set; }
	
		
		public string _co_auteur_collectivite_nom { get; set; }
	
		
		public string _co_auteur_collectivite_subdivision { get; set; }
	
		
		public string _auteur_secondaire_collectivite_nom { get; set; }
	
		
		public string _auteur_secondaire_collectivite_subdivision { get; set; }
	
		
		public string _ndeg_systeme { get; set; }
	
		
		public string _etat_de_collection_periodique { get; set; }
	
		
		public string _localisations { get; set; }
	
		
		public string _nombre_d_exemplaires { get; set; }
	
		
		public string _cote { get; set; }
	
		
		public string _numero_de_volume { get; set; }
	
		
		public string _categorie_documentaire { get; set; }
	
		
		public string _fonds { get; set; }
	
		
		public string _etat_de_collection { get; set; }
	
		
		public string _auteur_complet { get; set; }
	
		
		public string _co_auteur { get; set; }
	
		
	}

	public class voie	
	{
		public string className {get {return "voie" ;} }
		
		public int _n_sq_vo { get; set; }
	
		
		public int _c_coinsee { get; set; }
	
		
		public string _c_desi { get; set; }
	
		
		public string _c_liaison { get; set; }
	
		
		public string _l_voie { get; set; }
	
		
		public string _l_courtmin { get; set; }
	
		
		public string _l_longmin { get; set; }
	
		
		public string _c_voie { get; set; }
	
		
		public string _b_fantoir { get; set; }
	
		
		public string _b_off { get; set; }
	
		
		public string _c_voie_vp { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public int _objectid { get; set; }
	
		
		public string _c_domoff { get; set; }
	
		
		public int _n_sq_co { get; set; }
	
		
		public List<double> _geom_x_y { get; set; }
	
		
	}

	public class horloges_exterieures_et_interieures	
	{
		public string className {get {return "horloges_exterieures_et_interieures" ;} }
		
		public string _type_d_etablissement { get; set; }
	
		
		public string _appelation_etablissement { get; set; }
	
		
		public string _numero { get; set; }
	
		
		public string _voie { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _arrondissement { get; set; }
	
		
		public string _adresse_complete { get; set; }
	
		
		public string _type_d_appareil { get; set; }
	
		
		public int _nombre_de_timbre { get; set; }
	
		
		public int _nombre_de_cloches { get; set; }
	
		
		public string _gestionnaire { get; set; }
	
		
		public string _column_12 { get; set; }
	
		
		public string _column_13 { get; set; }
	
		
		public string _column_14 { get; set; }
	
		
		public string _column_15 { get; set; }
	
		
		public string _column_16 { get; set; }
	
		
		public string _column_17 { get; set; }
	
		
		public string _column_18 { get; set; }
	
		
		public string _column_19 { get; set; }
	
		
		public string _column_20 { get; set; }
	
		
		public string _column_21 { get; set; }
	
		
		public string _column_22 { get; set; }
	
		
		public string _column_23 { get; set; }
	
		
		public string _column_24 { get; set; }
	
		
		public string _column_25 { get; set; }
	
		
		public string _column_26 { get; set; }
	
		
		public string _column_27 { get; set; }
	
		
		public string _column_28 { get; set; }
	
		
		public string _column_29 { get; set; }
	
		
		public string _column_30 { get; set; }
	
		
		public string _column_31 { get; set; }
	
		
		public string _column_32 { get; set; }
	
		
		public string _column_33 { get; set; }
	
		
		public string _column_34 { get; set; }
	
		
		public string _column_35 { get; set; }
	
		
		public string _column_36 { get; set; }
	
		
		public string _column_37 { get; set; }
	
		
		public string _column_38 { get; set; }
	
		
		public string _column_39 { get; set; }
	
		
		public string _column_40 { get; set; }
	
		
		public string _column_41 { get; set; }
	
		
	}

	public class catalogue_des_cours_municipaux_d_adultes	
	{
		public string className {get {return "catalogue_des_cours_municipaux_d_adultes" ;} }
		
		public string _departement_d_enseignement { get; set; }
	
		
		public string _formation { get; set; }
	
		
		public string _module { get; set; }
	
		
		public string _annee_scolaire { get; set; }
	
		
		public string _code_etablissement_cours { get; set; }
	
		
		public string _nom_etablissement_cours { get; set; }
	
		
		public DateTime _date_debut_cours { get; set; }
	
		
		public DateTime _date_fin_cours { get; set; }
	
		
	}

	public class ordres_du_jour_du_conseil_general	
	{
		public string className {get {return "ordres_du_jour_du_conseil_general" ;} }
		
		public string _seance { get; set; }
	
		
		public string _reference { get; set; }
	
		
		public string _entite_depositaire { get; set; }
	
		
		public string _elu_depositaire { get; set; }
	
		
		public string _objet { get; set; }
	
		
		public string _type { get; set; }
	
		
		public string _rapporteur { get; set; }
	
		
	}

	public class ordres_du_jour_du_conseil_municipal	
	{
		public string className {get {return "ordres_du_jour_du_conseil_municipal" ;} }
		
		public string _seance { get; set; }
	
		
		public string _reference { get; set; }
	
		
		public string _entite_depositaire { get; set; }
	
		
		public string _elu_depositaire { get; set; }
	
		
		public string _objet { get; set; }
	
		
		public string _type { get; set; }
	
		
		public string _rapporteur { get; set; }
	
		
	}

	public class statistiques_de_creation_d_actes_d_etat_civil	
	{
		public string className {get {return "statistiques_de_creation_d_actes_d_etat_civil" ;} }
		
		public string _tableaux_de_bord_etat_civil { get; set; }
	
		
		public string _column_2 { get; set; }
	
		
		public string _column_3 { get; set; }
	
		
		public string _column_4 { get; set; }
	
		
		public string _column_5 { get; set; }
	
		
		public string _column_6 { get; set; }
	
		
		public string _column_7 { get; set; }
	
		
		public string _column_8 { get; set; }
	
		
		public string _column_9 { get; set; }
	
		
	}

	public class filiationvoiesparis2012	
	{
		public string className {get {return "filiationvoiesparis2012" ;} }
		
		public string _typvoie { get; set; }
	
		
		public string _nomvoie { get; set; }
	
		
		public string _texte { get; set; }
	
		
	}

	public class utilisations_mensuelles_des_hotspots_paris_wifi	
	{
		public string className {get {return "utilisations_mensuelles_des_hotspots_paris_wi-fi" ;} }
		
		public string _mois { get; set; }
	
		
		public string _annee { get; set; }
	
		
		public int _sites_ouverts_total { get; set; }
	
		
		public int _sites_ouverts_bibliotheques { get; set; }
	
		
		public int _sites_ouvertes_centre_culturel_s { get; set; }
	
		
		public int _sites_ouverts_hotel_de_ville { get; set; }
	
		
		public int _sites_ouverts_parcs_et_jardins { get; set; }
	
		
		public int _sites_ouverts_divers { get; set; }
	
		
		public string _trafic_en_minutes_total { get; set; }
	
		
		public string _trafic_en_minutes_bibliotheques { get; set; }
	
		
		public string _trafic_en_minutes_centre_culture { get; set; }
	
		
		public string _trafic_en_minutes_hotel_de_ville { get; set; }
	
		
		public string _trafic_en_minutes_parcs_et_jardi { get; set; }
	
		
		public string _trafic_en_minutes_divers { get; set; }
	
		
		public int _nombre_session_total { get; set; }
	
		
		public int _nombre_de_sessions_bibliotheques { get; set; }
	
		
		public int _nombre_de_sessions_centre_cultur { get; set; }
	
		
		public int _nombre_de_sessions_hotel_de_vill { get; set; }
	
		
		public int _nombre_session_parcs_et_jardins { get; set; }
	
		
		public int _nombre_de_sessions_divers { get; set; }
	
		
		public int _nombre_de_minutes_session { get; set; }
	
		
		public string _nbr_de_go_total { get; set; }
	
		
	}

	public class adresse_paris	
	{
		public string className {get {return "adresse_paris" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public int _n_sq_ad { get; set; }
	
		
		public int _n_voie { get; set; }
	
		
		public string _c_suf1 { get; set; }
	
		
		public string _c_suf2 { get; set; }
	
		
		public string _c_suf3 { get; set; }
	
		
		public int _c_ar { get; set; }
	
		
		public double _a_nvoie { get; set; }
	
		
		public string _b_angle { get; set; }
	
		
		public string _b_offstdf { get; set; }
	
		
		public string _b_affstdf { get; set; }
	
		
		public string _b_hors75 { get; set; }
	
		
		public string _l_nvoie { get; set; }
	
		
		public string _l_adr { get; set; }
	
		
		public int _n_sq_ar { get; set; }
	
		
		public int _n_sq_vo { get; set; }
	
		
		public int _objectid { get; set; }
	
		
	}

	public class murs_et_clotures	
	{
		public string className {get {return "murs_et_clotures" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public double _nsq_mu { get; set; }
	
		
		public double _igds_color { get; set; }
	
		
		public int _arrd { get; set; }
	
		
		public double _objectid { get; set; }
	
		
	}

	public class touslesdocumentsdesbibliothequesdepret	
	{
		public string className {get {return "tous-les-documents-des-bibliotheques-de-pret" ;} }
		
		public int _id { get; set; }
	
		
		public string _cote { get; set; }
	
		
		public string _langue { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _genre { get; set; }
	
		
		public string _theme { get; set; }
	
		
		public string _format { get; set; }
	
		
		public string _titre_de_serie { get; set; }
	
		
		public string _ndeg_du_titre_de_serie { get; set; }
	
		
		public string _sous_titre { get; set; }
	
		
		public string _sous_collection { get; set; }
	
		
		public int _numero_collection { get; set; }
	
		
		public string _collection { get; set; }
	
		
		public string _annee { get; set; }
	
		
		public string _auteur { get; set; }
	
		
		public string _indice { get; set; }
	
		
		public string _editeur { get; set; }
	
		
		public string _edition { get; set; }
	
		
		public string _genre_theme_type { get; set; }
	
		
		public string _isbn { get; set; }
	
		
		public string _type_de_document { get; set; }
	
		
		public int _nombre_de_localisations { get; set; }
	
		
		public double _nombre_de_prets_2014 { get; set; }
	
		
		public double _nombre_de_pret_total { get; set; }
	
		
		public double _prets_renouv { get; set; }
	
		
		public string _categorie_statistique_1 { get; set; }
	
		
		public string _categorie_statistique_2 { get; set; }
	
		
		public double _aime_cesaire { get; set; }
	
		
		public int _amelie { get; set; }
	
		
		public double _andree_chedid { get; set; }
	
		
		public double _andre_malraux { get; set; }
	
		
		public double _arthur_rimbaud { get; set; }
	
		
		public double _batignolles { get; set; }
	
		
		public string _baudoyer { get; set; }
	
		
		public double _benjamin_rabier { get; set; }
	
		
		public double _buffon { get; set; }
	
		
		public int _canopee { get; set; }
	
		
		public double _chaptal { get; set; }
	
		
		public double _charlotte_delbo { get; set; }
	
		
		public double _chateau_d_eau { get; set; }
	
		
		public double _colette_vivier { get; set; }
	
		
		public double _courcelles { get; set; }
	
		
		public double _couronnes { get; set; }
	
		
		public double _crimee { get; set; }
	
		
		public string _diderot { get; set; }
	
		
		public string _drouot { get; set; }
	
		
		public double _edmond_rostand { get; set; }
	
		
		public string _europe { get; set; }
	
		
		public double _faidherbe { get; set; }
	
		
		public string _fessart { get; set; }
	
		
		public double _claude_levi_strauss { get; set; }
	
		
		public double _francois_villon { get; set; }
	
		
		public double _francoise_sagan { get; set; }
	
		
		public double _georges_brassens { get; set; }
	
		
		public double _germaine_tillion { get; set; }
	
		
		public double _goutte_d_or { get; set; }
	
		
		public double _gutenberg { get; set; }
	
		
		public double _helene_berr { get; set; }
	
		
		public double _herge { get; set; }
	
		
		public double _heure_joyeuse { get; set; }
	
		
		public double _italie { get; set; }
	
		
		public string _jacqueline_de_romilly { get; set; }
	
		
		public double _lancry { get; set; }
	
		
		public double _louise_michel { get; set; }
	
		
		public double _louvre { get; set; }
	
		
		public double _jean_pierre_melville { get; set; }
	
		
		public double _marina_tsvetaieva_glaciere { get; set; }
	
		
		public double _marguerite_audoux { get; set; }
	
		
		public double _marguerite_duras { get; set; }
	
		
		public double _marguerite_yourcenar { get; set; }
	
		
		public double _maurice_genevoix { get; set; }
	
		
		public double _mediatheque_musicale { get; set; }
	
		
		public double _mohammed_arkoun { get; set; }
	
		
		public double _mortier { get; set; }
	
		
		public double _musset { get; set; }
	
		
		public double _oscar_wilde { get; set; }
	
		
		public double _parmentier { get; set; }
	
		
		public double _place_des_fetes { get; set; }
	
		
		public double _reserve_centrale { get; set; }
	
		
		public double _rainer_maria_rilke { get; set; }
	
		
		public double _robert_sabatier { get; set; }
	
		
		public double _sorbier { get; set; }
	
		
		public double _st_eloi { get; set; }
	
		
		public string _st_fargeau { get; set; }
	
		
		public double _st_simon { get; set; }
	
		
		public double _vaclav_havel { get; set; }
	
		
		public double _valeyre { get; set; }
	
		
		public double _vandamme { get; set; }
	
		
		public double _vaugirard { get; set; }
	
		
	}

	public class volumes_d_eau_distribues	
	{
		public string className {get {return "volumes_d_eau_distribues" ;} }
		
		public string _mois { get; set; }
	
		
		public string _volumes_d_eau_distribues_m3 { get; set; }
	
		
	}

	public class parcsdestationnementconcedesdelavilledeparis	
	{
		public string className {get {return "parcs-de-stationnement-concedes-de-la-ville-de-paris" ;} }
		
		public int _identifiant { get; set; }
	
		
		public string _nom_du_parc_de_stationnement { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _arrdt { get; set; }
	
		
		public string _delegataire { get; set; }
	
		
		public string _site_du_delegataire { get; set; }
	
		
		public string _telephone { get; set; }
	
		
		public int _hauteur_des_parcs_cm { get; set; }
	
		
		public string _type_de_parc { get; set; }
	
		
		public string _horaires_ouvertures_pour_les_usagers_non_abonnes { get; set; }
	
		
		public string _ascenseur_debouchant_en_surface { get; set; }
	
		
		public string _acces_motos { get; set; }
	
		
		public string _acces_velos { get; set; }
	
		
		public string _vehicule_electrique_avec_dispositif_de_recharge { get; set; }
	
		
		public string _station_autopartage { get; set; }
	
		
		public string _date_d_application_du_tarif_abonnement { get; set; }
	
		
		public double _abonnement_1_mois { get; set; }
	
		
		public int _abonnement_1_an { get; set; }
	
		
		public string _tarif_petit_rouleur { get; set; }
	
		
		public double _tarif_petits_rouleurs_annuel_minimum { get; set; }
	
		
		public double _tarif_petits_rouleurs_annuel_maximum { get; set; }
	
		
		public string _tarif_resident { get; set; }
	
		
		public string _tarif_resident_annuel { get; set; }
	
		
		public DateTime _date_d_application_du_tarif_horaire { get; set; }
	
		
		public string _tarif_1_4_heure { get; set; }
	
		
		public string _tarif_1_2_heure { get; set; }
	
		
		public string _tarif_1_heure { get; set; }
	
		
		public string _tarif_1_5_h { get; set; }
	
		
		public string _tarif_2h { get; set; }
	
		
		public string _tarif_3h { get; set; }
	
		
		public string _tarif_4h { get; set; }
	
		
		public string _tarif_7h { get; set; }
	
		
		public string _tarif_8h { get; set; }
	
		
		public string _tarif_9h { get; set; }
	
		
		public string _tarif_10h { get; set; }
	
		
		public string _tarif_11h { get; set; }
	
		
		public string _tarif_12h { get; set; }
	
		
		public string _tarif_24h { get; set; }
	
		
		public int _nombre_de_places_pmr_accessibles { get; set; }
	
		
		public string _abonnement_mensuel_pmr { get; set; }
	
		
		public string _abonnement_trimestriel_pmr { get; set; }
	
		
		public string _abonnement_annuel_pmr { get; set; }
	
		
		public string _ascenseur_pmr_debouchant_en_surface { get; set; }
	
		
		public string _abonnement_mensuel_vehicule_electrique { get; set; }
	
		
		public string _abonnement_trimestriel_vehicule_electrique { get; set; }
	
		
		public string _abonnement_annuel_vehicule_electrique { get; set; }
	
		
		public int _nombre_de_places_moto { get; set; }
	
		
		public string _tarif_1ere_heure_moto { get; set; }
	
		
		public string _abonnement_mensuel_moto { get; set; }
	
		
		public string _abonnement_trimestriel_moto { get; set; }
	
		
		public string _abonnement_annuel_moto { get; set; }
	
		
		public string _velo_mensuel { get; set; }
	
		
		public List<double> _xy { get; set; }
	
		
	}

	public class mobilierstationnementparis2011	
	{
		public string className {get {return "mobilierstationnementparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class troncon_voie	
	{
		public string className {get {return "troncon_voie" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public int _n_sq_tv { get; set; }
	
		
		public int _c_niveau { get; set; }
	
		
		public string _b_voiedup { get; set; }
	
		
		public int _n_voieaddg { get; set; }
	
		
		public string _c_suf1addg { get; set; }
	
		
		public int _n_voieadfg { get; set; }
	
		
		public string _c_suf1adfg { get; set; }
	
		
		public int _n_voieaddd { get; set; }
	
		
		public string _c_suf1addd { get; set; }
	
		
		public int _n_voieadfd { get; set; }
	
		
		public string _c_suf1adfd { get; set; }
	
		
		public int _c_coinsee { get; set; }
	
		
		public int _n_sq_vo { get; set; }
	
		
		public int _objectid { get; set; }
	
		
		public int _c_tvniv1 { get; set; }
	
		
		public int _c_tvniv2 { get; set; }
	
		
		public string _c_domofftv { get; set; }
	
		
		public int _n_sq_co { get; set; }
	
		
	}

	public class quartier_paris	
	{
		public string className {get {return "quartier_paris" ;} }
		
		public int _n_sq_qu { get; set; }
	
		
		public int _c_qu { get; set; }
	
		
		public int _c_quinsee { get; set; }
	
		
		public string _l_qu { get; set; }
	
		
		public int _c_ar { get; set; }
	
		
		public int _n_sq_ar { get; set; }
	
		
		public double _perimetre { get; set; }
	
		
		public double _surface { get; set; }
	
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public int _objectid { get; set; }
	
		
		public double _longueur { get; set; }
	
		
	}

	public class liste_des_places_de_livraison	
	{
		public string className {get {return "liste_des_places_de_livraison" ;} }
		
		public string _regpar { get; set; }
	
		
		public string _locnum { get; set; }
	
		
		public int _numvoi { get; set; }
	
		
		public string _type_de_voie { get; set; }
	
		
		public string _denomination_de_voie { get; set; }
	
		
		public int _arrdt { get; set; }
	
		
		public string _addresse_complete { get; set; }
	
		
		public int _bilan_nbre_de_place { get; set; }
	
		
		public List<double> _geo_coordinates { get; set; }
	
		
	}

	public class nomenclature_du_tri_selectif	
	{
		public string className {get {return "nomenclature_du_tri_selectif" ;} }
		
		public string _empty { get; set; }
	
		
		public string _file { get; set; }
	
		
	}

	public class duvertpresdechezmoi	
	{
		public string className {get {return "du-vert-pres-de-chez-moi" ;} }
		
		public string _etat_de_la_proposition { get; set; }
	
		
		public string _numero { get; set; }
	
		
		public int _arrd { get; set; }
	
		
		public string _type_de_vegetalisation { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _commentaire_accompagnant_la_proposition { get; set; }
	
		
		public string _propositions_non_realisables_avis_de_la_deve { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class bornes_et_arceaux_de_stationnement_a_paris	
	{
		public string className {get {return "bornes_et_arceaux_de_stationnement_a_paris" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class les_references_les_plus_reservees_en_2011	
	{
		public string className {get {return "les_references_les_plus_reservees_en_2011" ;} }
		
		public int _id { get; set; }
	
		
		public int _nombre_de_reservations { get; set; }
	
		
		public string _type { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class les_1000_titres_les_plus_empruntes_de_2013	
	{
		public string className {get {return "les_1000_titres_les_plus_empruntes_de_2013" ;} }
		
		public double _rang { get; set; }
	
		
		public string _type_de_document { get; set; }
	
		
		public double _nombre_de_prets { get; set; }
	
		
		public string _titre_avec_lien_vers_le_catalogue { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class poteaux_divers_sur_voie_publique	
	{
		public string className {get {return "poteaux_divers_sur_voie_publique" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class les_1000_titres_les_plus_reserves_en_2013	
	{
		public string className {get {return "les_1000_titres_les_plus_reserves_en_2013" ;} }
		
		public double _rang { get; set; }
	
		
		public string _type_de_document { get; set; }
	
		
		public double _nombre_de_reservations { get; set; }
	
		
		public string _titre_avec_lien_vers_le_catalogue { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class zonesderattachementdesbureauxdevoteen2012	
	{
		public string className {get {return "zones-de-rattachement-des-bureaux-de-vote-en-2012" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public int _arrondisse { get; set; }
	
		
		public int _num_bv { get; set; }
	
		
		public double _shape_leng { get; set; }
	
		
		public double _shape_area { get; set; }
	
		
	}

	public class resultatsdelelectionmunicipale20141ertour	
	{
		public string className {get {return "resultats-de-lelection-municipale-2014-1er-tour" ;} }
		
		public string _column_1 { get; set; }
	
		
		public DateTime _column_2 { get; set; }
	
		
		public string _column_3 { get; set; }
	
		
		public string _column_4 { get; set; }
	
		
		public string _column_5 { get; set; }
	
		
		public string _column_6 { get; set; }
	
		
		public string _column_7 { get; set; }
	
		
		public int _column_8 { get; set; }
	
		
		public int _column_9 { get; set; }
	
		
		public int _column_10 { get; set; }
	
		
		public string _column_13 { get; set; }
	
		
		public string _column_11 { get; set; }
	
		
		public int _column_16 { get; set; }
	
		
		public List<double> _coordonnees_geo_wgs84 { get; set; }
	
		
	}

	public class mobilierpropreteparis2011	
	{
		public string className {get {return "mobilierpropreteparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public double _nsq_ec { get; set; }
	
		
		public string _lb_etat_e { get; set; }
	
		
		public string _lb_comp { get; set; }
	
		
		public string _affecta { get; set; }
	
		
		public string _emplacemnt { get; set; }
	
		
		public int _ardt { get; set; }
	
		
		public int _frequence { get; set; }
	
		
		public string _dpe { get; set; }
	
		
		public int _pose { get; set; }
	
		
		public DateTime _datepose { get; set; }
	
		
		public DateTime _datedepose { get; set; }
	
		
		public double _ad_nvo { get; set; }
	
		
		public string _ad_clvo { get; set; }
	
		
		public string _voie { get; set; }
	
		
		public string _deplace { get; set; }
	
		
	}

	public class petits_marchands_sur_l_espace_public_en_2012	
	{
		public string className {get {return "petits_marchands_sur_l_espace_public_en_2012" ;} }
		
		public int _arrdt { get; set; }
	
		
		public string _emplacement { get; set; }
	
		
		public string _categorie_de_commerce { get; set; }
	
		
		public DateTime _plages_horaires { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class maneges_et_jeux_2012	
	{
		public string className {get {return "maneges_et_jeux_2012" ;} }
		
		public int _arrt { get; set; }
	
		
		public string _lieux { get; set; }
	
		
		public string _categorie_de_jeux_forains { get; set; }
	
		
		public string _horaires { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class adresses_des_panneaux_cq	
	{
		public string className {get {return "adresses_des_panneaux_cq" ;} }
		
		public string _arrondissement { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _precision { get; set; }
	
		
		public string _conseil_de_quartier_concerne { get; set; }
	
		
		public string _personnes_a_contacter { get; set; }
	
		
		public string _type_de_panneau_vitre_ou_sans_vitre { get; set; }
	
		
		public List<double> _latitude_longitude { get; set; }
	
		
	}

	public class liste_des_bureaux_de_vote_2013_liste_des_bureaux	
	{
		public string className {get {return "liste_des_bureaux_de_vote_2013_liste_des_bureaux" ;} }
		
		public int _bureau_id { get; set; }
	
		
		public int _bureau_arrondissement { get; set; }
	
		
		public int _bureau_numero { get; set; }
	
		
		public string _bureau_nom { get; set; }
	
		
		public string _bureau_localisation { get; set; }
	
		
		public string _bureau_addr_num { get; set; }
	
		
		public string _bureau_addr { get; set; }
	
		
		public int _bureau_addr_arron { get; set; }
	
		
		public string _column_9 { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class concessions_dans_les_jardins	
	{
		public string className {get {return "concessions_dans_les_jardins" ;} }
		
		public int _arrondt { get; set; }
	
		
		public string _adresse_de_l_activite { get; set; }
	
		
		public string _type { get; set; }
	
		
		public List<double> _xy_ { get; set; }
	
		
	}

	public class parcsetjardinsparis2010	
	{
		public string className {get {return "parcsetjardinsparis2010" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public int _annee_ouve { get; set; }
	
		
		public int _annee_reno { get; set; }
	
		
		public int _annee_chan { get; set; }
	
		
		public string _nom_ev { get; set; }
	
		
		public string _ancien_nom { get; set; }
	
		
		public int _adresse_nu { get; set; }
	
		
		public string _ouvert_fer { get; set; }
	
		
		public double _surface_to { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _ardt { get; set; }
	
		
	}

	public class mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo	
	{
		public string className {get {return "mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne_-_donnees_geo" ;} }
		
		public string _geometry { get; set; }
	
		
		public int _geometry_vertex_count { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
		public int _info_ft_style { get; set; }
	
		
		public int _libelle_ft_style { get; set; }
	
		
		public string _import_notes { get; set; }
	
		
	}

	public class relief_naturel	
	{
		public string className {get {return "relief_naturel" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class panneaux_indicateurs_de_signalisation_routiere_et_pietonne	
	{
		public string className {get {return "panneaux_indicateurs_de_signalisation_routiere_et_pietonne" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class arrondissements	
	{
		public string className {get {return "arrondissements" ;} }
		
		public int _n_sq_ar { get; set; }
	
		
		public int _c_ar { get; set; }
	
		
		public int _c_arinsee { get; set; }
	
		
		public string _l_ar { get; set; }
	
		
		public string _l_aroff { get; set; }
	
		
		public int _n_sq_co { get; set; }
	
		
		public double _surface { get; set; }
	
		
		public double _perimetre { get; set; }
	
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public int _objectid { get; set; }
	
		
		public double _longueur { get; set; }
	
		
	}

	public class volumesbatisparis2011	
	{
		public string className {get {return "volumesbatisparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _c_nat_b { get; set; }
	
		
		public string _l_nat_b { get; set; }
	
		
		public string _c_src { get; set; }
	
		
		public string _l_src { get; set; }
	
		
		public double _m2 { get; set; }
	
		
		public int _nb_pl { get; set; }
	
		
		public double _m2_pl_tot { get; set; }
	
		
		public int _b_rdc { get; set; }
	
		
		public int _c_plan_h_i { get; set; }
	
		
		public double _y { get; set; }
	
		
		public string _l_plan_h_i { get; set; }
	
		
		public double _x { get; set; }
	
		
		public DateTime _d_cre { get; set; }
	
		
		public string _l_b_u { get; set; }
	
		
		public DateTime _d_maj { get; set; }
	
		
		public int _n_ar { get; set; }
	
		
		public string _l_plan_h { get; set; }
	
		
		public int _h_et_max { get; set; }
	
		
		public int _n_qu { get; set; }
	
		
	}

	public class les1000titreslesplusreservesdanslesbibliothequesdepret	
	{
		public string className {get {return "les-1000-titres-les-plus-reserves-dans-les-bibliotheques-de-pret" ;} }
		
		public int _rang { get; set; }
	
		
		public string _support { get; set; }
	
		
		public int _nombre_de_reservations { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class listedesantenneswifi	
	{
		public string className {get {return "liste-des-antennes-wifi" ;} }
		
		public int _objectid { get; set; }
	
		
		public string _localisation { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public List<double> _geo_point_2d { get; set; }
	
		
	}

	public class comptederesultat	
	{
		public string className {get {return "compte-de-resultat" ;} }
		
		public string _type_de_resultat { get; set; }
	
		
		public string _produit_charge { get; set; }
	
		
		public string _poste { get; set; }
	
		
		public string _detail_postes { get; set; }
	
		
		public double _exercice_2013 { get; set; }
	
		
		public double _exercice_2012 { get; set; }
	
		
		public string _empty { get; set; }
	
		
		public string _empty0 { get; set; }
	
		
		public string _empty1 { get; set; }
	
		
		public string _empty2 { get; set; }
	
		
		public string _empty3 { get; set; }
	
		
		public string _empty4 { get; set; }
	
		
	}

	public class comptesadministratifsautorisationsdeprogrammesapvilledepartement	
	{
		public string className {get {return "comptes-administratifs-autorisations-de-programmes-ap-ville-departement" ;} }
		
		public DateTime _exercice_comptable { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_d_operation_r_o_i_m { get; set; }
	
		
		public string _mission_ap_cle { get; set; }
	
		
		public string _mission_ap_texte { get; set; }
	
		
		public string _activite_ap { get; set; }
	
		
		public string _mission_activite_texte { get; set; }
	
		
		public string _direction_gestionnaire_cle { get; set; }
	
		
		public string _direction_gestionnaire_texte { get; set; }
	
		
		public string _autorisation_de_programme_cle { get; set; }
	
		
		public string _autorisation_de_programme_texte { get; set; }
	
		
		public string _nature_budgetaire_cle { get; set; }
	
		
		public string _nature_budgetaire_texte { get; set; }
	
		
		public string _cle_fonction_reglementaire { get; set; }
	
		
		public string _texte_fonction_reglementaire { get; set; }
	
		
		public double _mandate_titre_apres_regul { get; set; }
	
		
	}

	public class reseaucyclable	
	{
		public string className {get {return "reseau-cyclable" ;} }
		
		public int _objectid { get; set; }
	
		
		public int _arrdt { get; set; }
	
		
		public string _bois { get; set; }
	
		
		public string _type_voie { get; set; }
	
		
		public string _nom_voie { get; set; }
	
		
		public string _statut { get; set; }
	
		
		public string _typologie { get; set; }
	
		
		public string _sens_velo { get; set; }
	
		
		public string _typologie_simple { get; set; }
	
		
		public double _shape_len { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public List<double> _geo_point_2d { get; set; }
	
		
	}

	public class arbresalignementparis2010	
	{
		public string className {get {return "arbresalignementparis2010" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public double _circonfere { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public double _hauteurenm { get; set; }
	
		
		public string _espece { get; set; }
	
		
		public string _varieteouc { get; set; }
	
		
		public DateTime _dateplanta { get; set; }
	
		
	}

	public class conseilsquartiers	
	{
		public string className {get {return "conseils-quartiers" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _no_consqrt { get; set; }
	
		
		public double _area { get; set; }
	
		
		public string _nom_quart { get; set; }
	
		
		public int _nar { get; set; }
	
		
		public double _nsq_ca { get; set; }
	
		
		public int _objectid { get; set; }
	
		
		public double _shape_area { get; set; }
	
		
		public double _shape_len { get; set; }
	
		
	}

	public class zonesderattachementdesbureauxdevoteen2014	
	{
		public string className {get {return "zones-de-rattachement-des-bureaux-de-vote-en-2014" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public int _arrondisse { get; set; }
	
		
		public int _num_bv { get; set; }
	
		
		public double _shape_leng { get; set; }
	
		
		public double _shape_area { get; set; }
	
		
	}

	public class liste_des_ouvrages_des_bibliotheques_en_janvier_2009	
	{
		public string className {get {return "liste_des_ouvrages_des_bibliotheques_en_janvier_2009" ;} }
		
		public string _langue { get; set; }
	
		
		public string _annee_d_edition { get; set; }
	
		
		public string _isbn { get; set; }
	
		
		public string _indice { get; set; }
	
		
		public string _auteur_personne_physique { get; set; }
	
		
		public string _auteur_collectivite { get; set; }
	
		
		public string _co_auteur { get; set; }
	
		
		public string _responsabilite { get; set; }
	
		
		public string _co_auteur_collectivite { get; set; }
	
		
		public string _co_auteur_congres { get; set; }
	
		
		public string _titre_de_forme { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _titre_parallele { get; set; }
	
		
		public string _mention_d_edition { get; set; }
	
		
		public string _editeur { get; set; }
	
		
		public string _annee_d_edition_bis { get; set; }
	
		
		public string _pagination { get; set; }
	
		
		public string _illustration { get; set; }
	
		
		public string _format { get; set; }
	
		
		public string _format_complementaire { get; set; }
	
		
		public string _materiel { get; set; }
	
		
		public string _materiel_complement { get; set; }
	
		
		public string _collection { get; set; }
	
		
		public string _ndeg_de_collection { get; set; }
	
		
		public string _sous_collection { get; set; }
	
		
		public int _ndeg_de_sous_collection { get; set; }
	
		
		public string _notes_generales { get; set; }
	
		
		public string _notes_de_contenu { get; set; }
	
		
		public string _note_d_histoire_de_l_edition { get; set; }
	
		
		public string _notes_sur_les_annexes { get; set; }
	
		
		public string _genre_ou_theme { get; set; }
	
		
		public string _public { get; set; }
	
		
		public string _titre_original { get; set; }
	
		
		public string _sujet_personne_physique { get; set; }
	
		
		public string _sujet_collecivite { get; set; }
	
		
		public string _sujet { get; set; }
	
		
		public string _sujet_geographique { get; set; }
	
		
		public string _titre_de_regroupement { get; set; }
	
		
		public string _ndeg_du_titre_de_regroupement { get; set; }
	
		
		public int _grandes_bibs { get; set; }
	
		
		public int _localisations_sections_adultes { get; set; }
	
		
		public int _localisations_discotheques { get; set; }
	
		
		public int _localisations_fonds_specialises_ou_reserves { get; set; }
	
		
		public int _localisations_sections_jeunesse { get; set; }
	
		
		public int _localisations_videotheques { get; set; }
	
		
		public int _localisations_sections_poles_thematiques_ou_partitions { get; set; }
	
		
		public int _nombre_d_exemplaires_dans_le_support_majoritaire { get; set; }
	
		
		public string _support { get; set; }
	
		
		public string _support_regroupe { get; set; }
	
		
		public string _categorie_statistique { get; set; }
	
		
		public string _classification_dewey { get; set; }
	
		
		public string _type_de_document_deduit_d_apres_la_categorie_statistique { get; set; }
	
		
		public int _nombre_d_exemplaires_pris_en_compte_pour_la_categorie_stat { get; set; }
	
		
		public int _nombre_d_exemplaires { get; set; }
	
		
		public double _prets_realises_en_6_mois { get; set; }
	
		
		public double _pret_moyen_par_exemplaire_sur_6_mois { get; set; }
	
		
		public int _localisations { get; set; }
	
		
		public int _localisations_hors_reserve_centrale { get; set; }
	
		
		public string _amelie { get; set; }
	
		
		public string _andre_malraux { get; set; }
	
		
		public string _baudoyer { get; set; }
	
		
		public string _batignolles { get; set; }
	
		
		public string _beaugrenelle { get; set; }
	
		
		public string _benjamin_rabier { get; set; }
	
		
		public string _brochant_colette_vivier { get; set; }
	
		
		public string _buffon { get; set; }
	
		
		public string _chaptal { get; set; }
	
		
		public string _chateau_d_eau { get; set; }
	
		
		public string _clignancourt { get; set; }
	
		
		public string _comptoir_lame { get; set; }
	
		
		public string _courcelles { get; set; }
	
		
		public string _couronnes { get; set; }
	
		
		public string _crimee { get; set; }
	
		
		public string _diderot { get; set; }
	
		
		public string _drouot { get; set; }
	
		
		public string _edmond_rostand { get; set; }
	
		
		public string _europe { get; set; }
	
		
		public string _faidherbe { get; set; }
	
		
		public string _fessart { get; set; }
	
		
		public string _flandre { get; set; }
	
		
		public string _francois_villon { get; set; }
	
		
		public string _georges_brassens { get; set; }
	
		
		public string _glaciere { get; set; }
	
		
		public string _goutte_d_or { get; set; }
	
		
		public string _gutenberg { get; set; }
	
		
		public string _herge { get; set; }
	
		
		public string _heure_joyeuse { get; set; }
	
		
		public string _isle_saint_louis { get; set; }
	
		
		public string _italie { get; set; }
	
		
		public string _jean_pierre_melville { get; set; }
	
		
		public string _la_fontaine { get; set; }
	
		
		public string _lancry { get; set; }
	
		
		public string _louvre { get; set; }
	
		
		public string _marguerite_audoux { get; set; }
	
		
		public string _marguerite_yourcenar { get; set; }
	
		
		public string _maurice_genevoix { get; set; }
	
		
		public string _mediatheque_musicale_de_paris { get; set; }
	
		
		public string _mortier { get; set; }
	
		
		public string _mouffetard { get; set; }
	
		
		public string _musset { get; set; }
	
		
		public string _parmentier { get; set; }
	
		
		public string _personnel { get; set; }
	
		
		public string _picpus_helene_berr { get; set; }
	
		
		public string _place_des_fetes { get; set; }
	
		
		public string _plaisance_aime_cesaire { get; set; }
	
		
		public string _porte_montmartre { get; set; }
	
		
		public string _port_royal_rainer_maria_rilke { get; set; }
	
		
		public string _reserve_centrale { get; set; }
	
		
		public string _reunion_prefiguration { get; set; }
	
		
		public string _saint_blaise_fermee_fin_2009_collections_marguerite_duras { get; set; }
	
		
		public string _saint_eloi { get; set; }
	
		
		public string _saint_fargeau { get; set; }
	
		
		public string _saint_simon { get; set; }
	
		
		public string _sorbier { get; set; }
	
		
		public string _trocadero_germaine_tillion { get; set; }
	
		
		public string _valeyre { get; set; }
	
		
		public string _vandamme { get; set; }
	
		
		public string _vaugirard { get; set; }
	
		
		public string _vivienne_charlotte_delbo { get; set; }
	
		
	}

	public class liste_des_associations_parisiennes	
	{
		public string className {get {return "liste_des_associations_parisiennes" ;} }
		
		public string _pr_nom_statutaire { get; set; }
	
		
		public int _cp_adresse_code_postal { get; set; }
	
		
		public string _cp_adresse_ville { get; set; }
	
		
		public string _sa_secteur_d_activit_1 { get; set; }
	
		
		public string _sa_secteur_d_activit_2 { get; set; }
	
		
		public string _sa_secteur_d_activit_3 { get; set; }
	
		
		public string _sa_libell_domaine_d_activit { get; set; }
	
		
		public string _sa_libell_secteur_d_activit { get; set; }
	
		
		public string _pv_public_vis { get; set; }
	
		
		public string _sg_secteur_gographique { get; set; }
	
		
		public int _cl_id_partenaire { get; set; }
	
		
	}

	public class petits_marchands_sur_l_espace_public	
	{
		public string className {get {return "petits_marchands_sur_l_espace_public" ;} }
		
		public int _arrdt { get; set; }
	
		
		public string _emplacement { get; set; }
	
		
		public string _adresse_complete { get; set; }
	
		
		public string _categorie_de_commerce { get; set; }
	
		
		public DateTime _plages_horaires_autorisees { get; set; }
	
		
		public string _column_6 { get; set; }
	
		
	}

	public class mobilierelectriqueparis2011	
	{
		public string className {get {return "mobilierelectriqueparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class accessibilite_des_equipements_de_la_ville_de_paris	
	{
		public string className {get {return "accessibilite_des_equipements_de_la_ville_de_paris" ;} }
		
		public string _type { get; set; }
	
		
		public string _nom { get; set; }
	
		
		public int _numero { get; set; }
	
		
		public string _voie { get; set; }
	
		
		public int _code_postal { get; set; }
	
		
		public string _remarques { get; set; }
	
		
		public int _handicap_moteur { get; set; }
	
		
		public int _handicap_visuel { get; set; }
	
		
		public int _handicap_auditif { get; set; }
	
		
		public string _lien { get; set; }
	
		
		public double _coordx_wgs { get; set; }
	
		
		public double _coordy_wgs { get; set; }
	
		
		public List<double> _column_14 { get; set; }
	
		
	}

	public class listedescafesauneuro	
	{
		public string className {get {return "liste-des-cafes-a-un-euro" ;} }
		
		public DateTime _date { get; set; }
	
		
		public string _nom_du_cafe { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _arrondissement { get; set; }
	
		
		public int _prix_comptoir { get; set; }
	
		
		public string _prix_salle { get; set; }
	
		
		public string _prix_terasse { get; set; }
	
		
		public List<double> _geoloc { get; set; }
	
		
	}

	public class liste_des_sites_des_hotspots_paris_wifi	
	{
		public string className {get {return "liste_des_sites_des_hotspots_paris_wifi" ;} }
		
		public int _objectid { get; set; }
	
		
		public string _nom_site { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _code_site { get; set; }
	
		
		public string _arrondissement { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public List<double> _geo_point_2d { get; set; }
	
		
	}

	public class postespublicsdesbibliothequesspecialisees	
	{
		public string className {get {return "postes-publics-des-bibliotheques-specialisees" ;} }
		
		public string _type_de_poste { get; set; }
	
		
		public string _localisation { get; set; }
	
		
		public int _nombre_d_ordinateurs { get; set; }
	
		
		public List<double> _position { get; set; }
	
		
	}

	public class promotionsdegradesuiteaexamenprofessionnel	
	{
		public string className {get {return "promotions-de-grade-suite-a-examen-professionnel" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public string _grade { get; set; }
	
		
		public int _inscrits_femmes { get; set; }
	
		
		public int _inscrits_hommes { get; set; }
	
		
		public int _nombre_de_postes_offerts { get; set; }
	
		
		public int _femmes_promues { get; set; }
	
		
		public int _hommes_promus { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class positionsstatutairesparticulieresdetachementsbilansocial	
	{
		public string className {get {return "positions-statutaires-particulieres-detachements-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _statut { get; set; }
	
		
		public string _type_de_detachement { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class promotionsparcategoriehommesfemmes	
	{
		public string className {get {return "promotions-par-categorie-hommes-femmes" ;} }
		
		public string _categorie { get; set; }
	
		
		public int _nombre_total_de_femmes { get; set; }
	
		
		public int _nombre_total_d_hommes { get; set; }
	
		
		public int _nombre_de_femmes_promouvables { get; set; }
	
		
		public int _nombre_d_hommes_promouvables { get; set; }
	
		
		public int _femmes_promues { get; set; }
	
		
		public int _hommes_promus { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class tempsdetravaildeseffectifsnontitulairespermanentsbilansocial	
	{
		public string className {get {return "temps-de-travail-des-effectifs-non-titulaires-permanents-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public double _quotite_de_temps_de_travail { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
		public DateTime _date { get; set; }
	
		
	}

	public class bilancomptable	
	{
		public string className {get {return "bilan-comptable" ;} }
		
		public string _actif_passif { get; set; }
	
		
		public string _poste { get; set; }
	
		
		public string _detail { get; set; }
	
		
		public string _2013_brut { get; set; }
	
		
		public string _2013_amortissements_et_provisions { get; set; }
	
		
		public double _2013_net { get; set; }
	
		
		public double _2012_net { get; set; }
	
		
		public string _empty { get; set; }
	
		
		public string _empty0 { get; set; }
	
		
		public string _empty1 { get; set; }
	
		
	}

	public class dettegarantie	
	{
		public string className {get {return "dette-garantie" ;} }
		
		public DateTime _annee_de_publication { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _nature { get; set; }
	
		
		public DateTime _annee_de_mobilisation { get; set; }
	
		
		public string _profil_d_amort_de_l_emprunt { get; set; }
	
		
		public string _designation_du_beneficiaire { get; set; }
	
		
		public string _objet_de_l_emprunt_garanti { get; set; }
	
		
		public string _organisme_preteur_ou_chef_de_file { get; set; }
	
		
		public double _montant_initial { get; set; }
	
		
		public double _capital_restant_du_au_31_12_de_l_annee_de_publication { get; set; }
	
		
		public double _duree_residuelle { get; set; }
	
		
		public string _periodicite_des_remboursements { get; set; }
	
		
		public string _taux_initial_taux { get; set; }
	
		
		public string _taux_initial_index { get; set; }
	
		
		public double _taux_initial_taux_actuariel { get; set; }
	
		
		public string _taux_a_la_date_du_vote_du_budget_ou_taux_moyen_constate_sur_l_annee_taux { get; set; }
	
		
		public string _taux_a_la_date_du_vote_du_budget_ou_taux_moyen_constate_sur_l_annee_index { get; set; }
	
		
		public double _taux_a_la_date_du_vote_du_budget_ou_taux_moyen_constate_sur_l_annee_niveau_de_taux { get; set; }
	
		
		public double _annuite_garantie_au_cours_de_l_exercice_en_interets { get; set; }
	
		
		public double _annuite_garantie_au_cours_de_l_exercice_en_capital { get; set; }
	
		
	}

	public class immobilisationsetatdesentrees	
	{
		public string className {get {return "immobilisations-etat-des-entrees" ;} }
		
		public string _publication { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _rubrique { get; set; }
	
		
		public string _detail { get; set; }
	
		
		public string _sous_detail { get; set; }
	
		
		public string _nature { get; set; }
	
		
		public string _ndeg_immobilisation { get; set; }
	
		
		public string _ndeg_subs { get; set; }
	
		
		public string _designation_du_bien_amenageurs { get; set; }
	
		
		public DateTime _date_d_acquisition { get; set; }
	
		
		public double _valeur_d_acquisition { get; set; }
	
		
		public double _variation_sur_exercice_en_cours { get; set; }
	
		
		public int _duree_d_amort { get; set; }
	
		
		public string _observations { get; set; }
	
		
	}

	public class immobilisationsetatdesamortissements	
	{
		public string className {get {return "immobilisations-etat-des-amortissements" ;} }
		
		public string _publication { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _nature { get; set; }
	
		
		public DateTime _date_d_acquisition { get; set; }
	
		
		public string _site { get; set; }
	
		
		public string _ndeg_immobilisation { get; set; }
	
		
		public string _ndeg_subs { get; set; }
	
		
		public string _designation_des_ensembles { get; set; }
	
		
		public string _observation { get; set; }
	
		
		public double _valeur_d_acquisition { get; set; }
	
		
		public string _duree_amort { get; set; }
	
		
		public double _cumul_amort_anterieurs { get; set; }
	
		
		public double _vnc_debut_exercice { get; set; }
	
		
		public double _amort_exercice { get; set; }
	
		
		public double _vnc_fin_exercice { get; set; }
	
		
	}

	public class statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement	
	{
		public string className {get {return "statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement" ;} }
		
		public string _type_d_acte { get; set; }
	
		
		public int _annee { get; set; }
	
		
		public string _arrondissement { get; set; }
	
		
		public int _nombre { get; set; }
	
		
	}

	public class concessionsredevancespercues	
	{
		public string className {get {return "concessions-redevances-percues" ;} }
		
		public int _numero { get; set; }
	
		
		public DateTime _exercice_comptable { get; set; }
	
		
		public string _direction { get; set; }
	
		
		public string _ndeg_contrat { get; set; }
	
		
		public string _nature_du_contrat { get; set; }
	
		
		public string _code_nature_du_contrat { get; set; }
	
		
		public DateTime _deb_valid { get; set; }
	
		
		public DateTime _fin_valid { get; set; }
	
		
		public string _objet_du_contrat { get; set; }
	
		
		public string _libelle_du_tiers { get; set; }
	
		
		public string _code_reference_du_tiers { get; set; }
	
		
		public string _redevance_disponible_non_disponible { get; set; }
	
		
		public double _somme_de_montant_liquide_2014 { get; set; }
	
		
	}

	public class subventionsversees	
	{
		public string className {get {return "subventions-versees" ;} }
		
		public string _publication { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public string _nature_juridique { get; set; }
	
		
		public string _nom_de_l_organisme_beneficiaire_d_une_subvention { get; set; }
	
		
		public string _nom_de_la_rue { get; set; }
	
		
		public string _ville { get; set; }
	
		
		public string _cp { get; set; }
	
		
		public int _montant_de_la_subvention { get; set; }
	
		
		public int _mise_a_disposition_locaux { get; set; }
	
		
		public int _mise_a_disposition_personnel { get; set; }
	
		
		public int _prestations_diverses { get; set; }
	
		
	}

	public class evolutiondescorpslesplusetlesmoinsfeminises	
	{
		public string className {get {return "evolution-des-corps-les-plus-et-les-moins-feminises" ;} }
		
		public string _type_de_corps { get; set; }
	
		
		public string _corps { get; set; }
	
		
		public int _femmes { get; set; }
	
		
		public int _hommes { get; set; }
	
		
		public DateTime _date { get; set; }
	
		
	}

	public class les1000titreslespluspretesparsupport	
	{
		public string className {get {return "les-1000-titres-les-plus-pretes-par-support" ;} }
		
		public string _support { get; set; }
	
		
		public string _auteur { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public double _prets_2014 { get; set; }
	
		
	}

	public class pim	
	{
		public string className {get {return "pim" ;} }
		
		public string _politique_publique { get; set; }
	
		
		public string _detail { get; set; }
	
		
		public int _pim { get; set; }
	
		
	}

	public class comptesadministratifsbudgetsannexes	
	{
		public string className {get {return "comptes-administratifs-budgets-annexes" ;} }
		
		public DateTime _exercice_comptable { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_d_operation_r_o_i_m { get; set; }
	
		
		public string _chapitre_budgetaire_cle { get; set; }
	
		
		public string _chapitre_budgetaire_texte { get; set; }
	
		
		public string _nature_budgetaire_cle { get; set; }
	
		
		public string _nature_budgetaire_texte { get; set; }
	
		
		public double _mandate_titre_apres_regul { get; set; }
	
		
		public string _empty { get; set; }
	
		
		public string _empty0 { get; set; }
	
		
	}

	public class statistiques_de_creation_d_actes_d_etat_civil_par_mois	
	{
		public string className {get {return "statistiques_de_creation_d_actes_d_etat_civil_par_mois" ;} }
		
		public string _mois { get; set; }
	
		
		public string _type_d_acte { get; set; }
	
		
		public string _annee { get; set; }
	
		
		public int _nombre { get; set; }
	
		
	}

	public class effectifspermanentspartranchedagebilansocial	
	{
		public string className {get {return "effectifs-permanents-par-tranche-dage-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _statut { get; set; }
	
		
		public string _nature_du_temps_de_travail { get; set; }
	
		
		public string _tranche_d_age { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class paris_taxis_data	
	{
		public string className {get {return "paris_taxis_data" ;} }
		
		public string _station_id { get; set; }
	
		
		public int _declared_taxis { get; set; }
	
		
		public int _declared_users { get; set; }
	
		
		public string _city { get; set; }
	
		
		public int _station_number { get; set; }
	
		
		public string _address_precision { get; set; }
	
		
		public string _address { get; set; }
	
		
		public List<double> _geo_coordinates { get; set; }
	
		
		public string _station_name { get; set; }
	
		
		public string _zip_code { get; set; }
	
		
		public DateTime _last_updated { get; set; }
	
		
	}

	public class listedesstationsdeservicesdevehicules	
	{
		public string className {get {return "liste-des-stations-de-services-de-vehicules" ;} }
		
		public int _arr { get; set; }
	
		
		public string _adresse_precision_streetview { get; set; }
	
		
		public string _commentaires { get; set; }
	
		
		public List<double> _geo_point { get; set; }
	
		
	}

	public class abrivoyageursecranstactilesconnectes	
	{
		public string className {get {return "abri-voyageurs-ecrans-tactiles-connectes" ;} }
		
		public string _ndeg_mobilier { get; set; }
	
		
		public string _latitude { get; set; }
	
		
		public string _longitude { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _codee_insee { get; set; }
	
		
		public string _code_postal { get; set; }
	
		
		public string _arrondissement { get; set; }
	
		
		public string _adresse0 { get; set; }
	
		
		public string _complement_adresse { get; set; }
	
		
		public List<double> _xy { get; set; }
	
		
	}

	public class profil_petite_ceinture	
	{
		public string className {get {return "profil_petite_ceinture" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public string _profil { get; set; }
	
		
		public double _longueur { get; set; }
	
		
		public int _ardt { get; set; }
	
		
	}

	public class lescimetieresemprises	
	{
		public string className {get {return "les-cimetieres-emprises" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public string _nom_ev { get; set; }
	
		
		public int _annee_crea { get; set; }
	
		
		public int _annee_reno { get; set; }
	
		
		public string _horaire { get; set; }
	
		
		public string _acces { get; set; }
	
		
		public int _nb_divisio { get; set; }
	
		
		public double _surf_divis { get; set; }
	
		
		public int _nb_sepult { get; set; }
	
		
		public double _surf_tot { get; set; }
	
		
	}

	public class domiciliationdesagentsbilansocial	
	{
		public string className {get {return "domiciliation-des-agents-bilan-social" ;} }
		
		public double _ndeg_enregitrement { get; set; }
	
		
		public DateTime _date { get; set; }
	
		
		public string _collectivite { get; set; }
	
		
		public string _sexe { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public string _nature { get; set; }
	
		
		public string _zone { get; set; }
	
		
		public int _code_postal { get; set; }
	
		
		public string _departement { get; set; }
	
		
		public string _ville { get; set; }
	
		
		public int _effectif { get; set; }
	
		
		public string _direction { get; set; }
	
		
		public List<double> _geoloc { get; set; }
	
		
	}

	public class lessurfacesboisees	
	{
		public string className {get {return "les-surfaces-boisees" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public double _surface { get; set; }
	
		
		public string _typo { get; set; }
	
		
		public string _bois { get; set; }
	
		
		public int _n_bois { get; set; }
	
		
	}

	public class lescimetieresdivisions	
	{
		public string className {get {return "les-cimetieres-divisions" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public int _num_div { get; set; }
	
		
		public double _shape_leng { get; set; }
	
		
		public double _surface { get; set; }
	
		
	}

	public class emargementmunicipal	
	{
		public string className {get {return "emargement-municipal" ;} }
		
		public string _elus { get; set; }
	
		
		public string _session { get; set; }
	
		
		public string _etat { get; set; }
	
		
		public int _nombre_de_demijournees_excusees { get; set; }
	
		
		public string _nombre_de_demijournees_ri { get; set; }
	
		
		public int _nombre_de_demijournees_absent { get; set; }
	
		
		public int _annee { get; set; }
	
		
	}

	public class effectifstitulairespermanents	
	{
		public string className {get {return "effectifs-titulaires-permanents" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _corps_et_emplois { get; set; }
	
		
		public string _grade { get; set; }
	
		
		public string _specialite { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class tempsdetravaildeseffectifstitulairespermanentsbilansocial	
	{
		public string className {get {return "temps-de-travail-des-effectifs-titulaires-permanents-bilan-social" ;} }
		
		public string _collectivite { get; set; }
	
		
		public string _categorie { get; set; }
	
		
		public int _quotite_de_temps_de_travail { get; set; }
	
		
		public int _nombre_de_femmes { get; set; }
	
		
		public int _nombre_d_hommes { get; set; }
	
		
		public DateTime _annee { get; set; }
	
		
	}

	public class mobiliers_de_voies_routieres_de_type_barriere	
	{
		public string className {get {return "mobiliers_de_voies_routieres_de_type_barriere" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class bilancomptablesynthetique	
	{
		public string className {get {return "bilan-comptable-synthetique" ;} }
		
		public string _actif_passif { get; set; }
	
		
		public string _detail { get; set; }
	
		
		public string _sous_detail { get; set; }
	
		
		public double _montant { get; set; }
	
		
		public string _empty1 { get; set; }
	
		
	}

	public class tonnages_des_dechets_bacs_verts	
	{
		public string className {get {return "tonnages_des_dechets_bacs_verts" ;} }
		
		public int _granularite { get; set; }
	
		
		public string _janv_11 { get; set; }
	
		
		public string _fevr_11 { get; set; }
	
		
		public string _mars_11 { get; set; }
	
		
		public string _avr_11 { get; set; }
	
		
		public string _mai_11 { get; set; }
	
		
		public string _juin_11 { get; set; }
	
		
		public string _juil_11 { get; set; }
	
		
		public string _aout_11 { get; set; }
	
		
		public string _sept_11 { get; set; }
	
		
		public string _oct_11 { get; set; }
	
		
		public string _nov_11 { get; set; }
	
		
		public string _dec_11 { get; set; }
	
		
		public string _total_arrondissement_2011 { get; set; }
	
		
	}

	public class plan_de_l_hemicycle_du_conseil_de_paris	
	{
		public string className {get {return "plan_de_l_hemicycle_du_conseil_de_paris" ;} }
		
		public int _place_dans_l_hemicycle { get; set; }
	
		
		public string _civilite { get; set; }
	
		
		public string _prenom { get; set; }
	
		
		public string _nom { get; set; }
	
		
		public string _groupe_politique { get; set; }
	
		
		public string _president_de_groupe { get; set; }
	
		
		public string _maire_de_paris_adjoint_e_au_maire_conseillere_deleguee { get; set; }
	
		
		public string _maire_d_arrondissement { get; set; }
	
		
	}

	public class consultations_des_centres_de_sante	
	{
		public string className {get {return "consultations_des_centres_de_sante" ;} }
		
		public string _nom_de_lactivite { get; set; }
	
		
		public string _specialite { get; set; }
	
		
		public string _description { get; set; }
	
		
		public string _nom_du_centre_de_sante { get; set; }
	
		
		public string _jour { get; set; }
	
		
		public string _heure_de_debut { get; set; }
	
		
		public string _heure_de_fin { get; set; }
	
		
		public string _adresse_nom_du_centre { get; set; }
	
		
		public string _adresse_rue { get; set; }
	
		
		public string _adresse_code_postal { get; set; }
	
		
		public string _adresse_ville { get; set; }
	
		
		public string _numero_de_telephone { get; set; }
	
		
		public string _adresse_mail { get; set; }
	
		
		public string _site_internet { get; set; }
	
		
		public double _latitude { get; set; }
	
		
		public double _longitude { get; set; }
	
		
		public List<double> _coordonnees_geographiques { get; set; }
	
		
	}

	public class tonnages_de_la_collecte_du_verre	
	{
		public string className {get {return "tonnages_de_la_collecte_du_verre" ;} }
		
		public int _granularite { get; set; }
	
		
		public string _janv_11 { get; set; }
	
		
		public string _fevr_11 { get; set; }
	
		
		public string _mars_11 { get; set; }
	
		
		public string _avr_11 { get; set; }
	
		
		public string _mai_11 { get; set; }
	
		
		public string _juin_11 { get; set; }
	
		
		public string _juil_11 { get; set; }
	
		
		public DateTime _aout_11 { get; set; }
	
		
		public string _sept_11 { get; set; }
	
		
		public string _oct_11 { get; set; }
	
		
		public string _nov_11 { get; set; }
	
		
		public string _dec_11 { get; set; }
	
		
		public List<double> _total_arrondissement_2011 { get; set; }
	
		
	}

	public class mobiliereaupotableparis2011	
	{
		public string className {get {return "mobiliereaupotableparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class plaques_commemoratives_19391945	
	{
		public string className {get {return "plaques_commemoratives_1939-1945" ;} }
		
		public int _identifiant { get; set; }
	
		
		public string _commemore { get; set; }
	
		
		public string _adresse_complete { get; set; }
	
		
		public string _precision_adresse { get; set; }
	
		
		public int _column_5 { get; set; }
	
		
		public List<double> _coordonnees_geo { get; set; }
	
		
	}

	public class etiquettes_energetiques_des_batiments_municipaux	
	{
		public string className {get {return "etiquettes_energetiques_des_batiments_municipaux" ;} }
		
		public int _ndeg_equipement { get; set; }
	
		
		public string _type_d_equipement { get; set; }
	
		
		public string _ndeg { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _code_postal { get; set; }
	
		
		public string _ville { get; set; }
	
		
		public string _annee { get; set; }
	
		
		public string _adresse_complete { get; set; }
	
		
		public string _etiquette_energie { get; set; }
	
		
		public string _etiquette_climat { get; set; }
	
		
		public string _observation { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class tonnages_des_dechets_bacs_jaunes	
	{
		public string className {get {return "tonnages_des_dechets_bacs_jaunes" ;} }
		
		public string _granularite { get; set; }
	
		
		public string _janv_11 { get; set; }
	
		
		public string _fevr_11 { get; set; }
	
		
		public string _mars_11 { get; set; }
	
		
		public string _avr_11 { get; set; }
	
		
		public string _mai_11 { get; set; }
	
		
		public string _juin_11 { get; set; }
	
		
		public string _juil_11 { get; set; }
	
		
		public string _aout_11 { get; set; }
	
		
		public string _sept_11 { get; set; }
	
		
		public string _oct_11 { get; set; }
	
		
		public string _nov_11 { get; set; }
	
		
		public string _dec_11 { get; set; }
	
		
		public List<double> _total_arrondissement_2011 { get; set; }
	
		
	}

	public class lesarbres	
	{
		public string className {get {return "les-arbres" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public string _localisati { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public double _circonfere { get; set; }
	
		
		public double _hauteurenm { get; set; }
	
		
		public string _espece { get; set; }
	
		
		public string _varieteouc { get; set; }
	
		
		public DateTime _dateplanta { get; set; }
	
		
	}

	public class hydro_ev	
	{
		public string className {get {return "hydro_ev" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public double _sum_area { get; set; }
	
		
		public string _milieu { get; set; }
	
		
		public string _faune { get; set; }
	
		
		public string _nom_ev { get; set; }
	
		
		public string _caract { get; set; }
	
		
		public string _type_zone { get; set; }
	
		
		public int _ardt { get; set; }
	
		
	}

	public class zonesderencontre	
	{
		public string className {get {return "zones-de-rencontre" ;} }
		
		public int _objectid { get; set; }
	
		
		public string _nom_zca { get; set; }
	
		
		public double _shape_area { get; set; }
	
		
		public double _shape_len { get; set; }
	
		
		public int _first_arrdt { get; set; }
	
		
		public DateTime _first_date_arr { get; set; }
	
		
		public string _first_type_arr { get; set; }
	
		
		public int _first_stv { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public List<double> _geo_point_2d { get; set; }
	
		
	}

	public class sanisettesparis2011	
	{
		public string className {get {return "sanisettesparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
	}

	public class liste_des_bureaux_de_vote_2013_voies_de_paris	
	{
		public string className {get {return "liste_des_bureaux_de_vote_2013_voies_de_paris" ;} }
		
		public string _voie_id { get; set; }
	
		
		public int _arrondissement { get; set; }
	
		
		public string _libelle_voie_long { get; set; }
	
		
		public string _type_voie_court { get; set; }
	
		
		public string _denomination_voie_court { get; set; }
	
		
		public List<double> _column_6 { get; set; }
	
		
	}

	public class attractions_foraines_sur_l_espace_public	
	{
		public string className {get {return "attractions_foraines_sur_l_espace_public" ;} }
		
		public int _arrt { get; set; }
	
		
		public string _lieux { get; set; }
	
		
		public string _categorie_de_jeux_forains { get; set; }
	
		
		public string _horaires_de_fin_d_activite { get; set; }
	
		
	}

	public class cheminement_d_assainissement	
	{
		public string className {get {return "cheminement_d_assainissement" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class les_1000_titres_les_plus_empruntes_de_2012	
	{
		public string className {get {return "les_1000_titres_les_plus_empruntes_de_2012" ;} }
		
		public int _rang { get; set; }
	
		
		public string _type_de_document { get; set; }
	
		
		public int _prets { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class les_1000_titres_les_plus_empruntes_2012_par_bibliotheque	
	{
		public string className {get {return "les_1000_titres_les_plus_empruntes_2012_par_bibliotheque" ;} }
		
		public string _bibliotheque { get; set; }
	
		
		public int _rang { get; set; }
	
		
		public int _prets { get; set; }
	
		
		public string _type_de_document { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class mobiliertransportsparis2011	
	{
		public string className {get {return "mobiliertransportsparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class distributeurspreservatifsmasculinsparis2012	
	{
		public string className {get {return "distributeurspreservatifsmasculinsparis2012" ;} }
		
		public string _annee_installation { get; set; }
	
		
		public string _site { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _arrond { get; set; }
	
		
		public string _adresse_complete { get; set; }
	
		
		public string _acces { get; set; }
	
		
		public string _horaires_normal { get; set; }
	
		
		public string _horaires_vacances_ete { get; set; }
	
		
		public string _horaires_vacances_hiver { get; set; }
	
		
		public List<double> _xy { get; set; }
	
		
	}

	public class resultats_electoraux	
	{
		public string className {get {return "resultats_electoraux" ;} }
		
		public string _libelle_du_scrutin { get; set; }
	
		
		public DateTime _date_du_scrutin_jj_mm_ssaa { get; set; }
	
		
		public int _numero_d_arrondissement_01_a_20 { get; set; }
	
		
		public int _numero_de_bureau_de_vote_000_a_999 { get; set; }
	
		
		public int _numero_de_la_circonscription_01_a_18_a_partir_de_2012_ou_21_avant_2012 { get; set; }
	
		
		public string _code_commune_insee_751_01_a_20 { get; set; }
	
		
		public List<double> _coordonnees_geo { get; set; }
	
		
		public string _commune_paris_01_a_20 { get; set; }
	
		
		public string _nombre_d_inscrits_du_bureau_de_vote { get; set; }
	
		
		public int _nombre_de_votants_du_bureau_de_vote { get; set; }
	
		
		public int _nombre_d_exprimes_du_bureau_de_vote { get; set; }
	
		
		public int _numero_de_depot_du_candidat_ou_liste { get; set; }
	
		
		public string _nom_du_candidat_ou_liste { get; set; }
	
		
		public string _prenom_du_candidat_ou_liste { get; set; }
	
		
		public int _nombre_de_voix_du_candidat_ou_liste_obtenues_pour_le_bureau_de_vote { get; set; }
	
		
		public string _nombre_de_blancs_uniquement_du_bureau_de_vote { get; set; }
	
		
		public string _nombre_de_nuls_uniquement_du_bureau_de_vote { get; set; }
	
		
		public string _nombre_de_procurations_du_bureau_de_vote { get; set; }
	
		
	}

	public class les_1000_titres_les_plus_recherches_en_2013	
	{
		public string className {get {return "les_1000_titres_les_plus_recherches_en_2013" ;} }
		
		public double _rang { get; set; }
	
		
		public string _type_de_document { get; set; }
	
		
		public double _nombre_de_recherches { get; set; }
	
		
		public string _titre_avec_lien_vers_le_catalogue { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret	
	{
		public string className {get {return "les-1000-titres-les-plus-recherches-au-catalogue-des-bibliotheques-de-pret" ;} }
		
		public int _rang { get; set; }
	
		
		public string _support { get; set; }
	
		
		public int _nombre_de_recherches { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class volumesnonbatisparis2011	
	{
		public string className {get {return "volumesnonbatisparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _c_nat_nb { get; set; }
	
		
		public string _l_nat_nb { get; set; }
	
		
		public string _c_src { get; set; }
	
		
		public string _l_src { get; set; }
	
		
		public double _m2 { get; set; }
	
		
		public double _x { get; set; }
	
		
		public double _y { get; set; }
	
		
		public int _n_ar { get; set; }
	
		
		public int _n_qu { get; set; }
	
		
		public DateTime _d_cre { get; set; }
	
		
		public DateTime _d_maj { get; set; }
	
		
	}

	public class voiesactuellesparis2012	
	{
		public string className {get {return "voiesactuellesparis2012" ;} }
		
		public string _typvoie { get; set; }
	
		
		public string _prevoie { get; set; }
	
		
		public string _nomvoie { get; set; }
	
		
		public string _typo { get; set; }
	
		
		public DateTime _date_arret { get; set; }
	
		
		public string _cdgi { get; set; }
	
		
		public string _histo { get; set; }
	
		
		public string _texte { get; set; }
	
		
		public string _quartier { get; set; }
	
		
		public string _arron { get; set; }
	
		
		public List<double> _geo_coordinates { get; set; }
	
		
	}

	public class resultatsdelelectionmunicipale20142emetour	
	{
		public string className {get {return "resultats-de-lelection-municipale-2014-2eme-tour" ;} }
		
		public string _column_1 { get; set; }
	
		
		public DateTime _column_2 { get; set; }
	
		
		public string _column_3 { get; set; }
	
		
		public string _column_4 { get; set; }
	
		
		public string _column_5 { get; set; }
	
		
		public string _column_6 { get; set; }
	
		
		public string _column_7 { get; set; }
	
		
		public int _column_8 { get; set; }
	
		
		public int _column_9 { get; set; }
	
		
		public int _column_10 { get; set; }
	
		
		public string _column_13 { get; set; }
	
		
		public string _column_11 { get; set; }
	
		
		public int _column_16 { get; set; }
	
		
		public List<double> _coordonnees_geo_wgs84 { get; set; }
	
		
	}

	public class liste_des_jardins_partages_a_paris	
	{
		public string className {get {return "liste_des_jardins_partages_a_paris" ;} }
		
		public List<double> _geo_point_2d { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public string _type_jard { get; set; }
	
		
		public string _nom_ev { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _arrdt { get; set; }
	
		
		public string _nom_gerant { get; set; }
	
		
		public string _adr_gerant { get; set; }
	
		
		public string _charte { get; set; }
	
		
	}

	public class liste_des_marches_de_quartier_a_paris	
	{
		public string className {get {return "liste_des_marches_de_quartier_a_paris" ;} }
		
		public string _type { get; set; }
	
		
		public string _societe_gestionnaire { get; set; }
	
		
		public string _marche { get; set; }
	
		
		public int _arrondissement { get; set; }
	
		
		public string _localisation { get; set; }
	
		
		public string _adresse_complete_poi_approchant { get; set; }
	
		
		public string _lundi { get; set; }
	
		
		public string _mardi { get; set; }
	
		
		public string _mercredi { get; set; }
	
		
		public string _jeudi { get; set; }
	
		
		public string _vendredi { get; set; }
	
		
		public string _samedi { get; set; }
	
		
		public string _dimanche { get; set; }
	
		
		public string _jour_ferie { get; set; }
	
		
		public List<double> _geo_coordinates { get; set; }
	
		
	}

	public class listemuseesdefranceaparis	
	{
		public string className {get {return "liste-musees-de-france-a-paris" ;} }
		
		public string _nomreg { get; set; }
	
		
		public string _nomdep { get; set; }
	
		
		public string _ferme { get; set; }
	
		
		public string _annreouv { get; set; }
	
		
		public string _annexe { get; set; }
	
		
		public string _nom_du_musee { get; set; }
	
		
		public string _adr { get; set; }
	
		
		public int _cp { get; set; }
	
		
		public string _ville { get; set; }
	
		
		public string _sitweb { get; set; }
	
		
		public string _fermeture_annuelle { get; set; }
	
		
		public string _periode_ouverture { get; set; }
	
		
		public string _jours_nocturnes { get; set; }
	
		
		public List<double> _coordonnees_ { get; set; }
	
		
	}

	public class liste_des_kiosques_presse_a_paris	
	{
		public string className {get {return "liste_des_kiosques_presse_a_paris" ;} }
		
		public string _adresse { get; set; }
	
		
		public int _arrdt { get; set; }
	
		
		public string _type_de_kiosque { get; set; }
	
		
	}

	public class eclairagepublicsignalisationtricolore	
	{
		public string className {get {return "eclairagepublicsignalisationtricolore" ;} }
		
		public int _objectid { get; set; }
	
		
		public string _cod_ouvrag { get; set; }
	
		
		public string _foyer { get; set; }
	
		
		public string _lib_domain { get; set; }
	
		
		public string _lib_ouvrag { get; set; }
	
		
		public string _observatio { get; set; }
	
		
		public double _posx_ouvra { get; set; }
	
		
		public double _posy_ouvra { get; set; }
	
		
		public string _lib_regime { get; set; }
	
		
		public string _lib_tarif { get; set; }
	
		
		public string _voieent_vo { get; set; }
	
		
		public string _faceop_ouv { get; set; }
	
		
		public string _numvoie_ou { get; set; }
	
		
		public string _bister_ouv { get; set; }
	
		
		public string _nature_voi { get; set; }
	
		
		public string _lib_voie { get; set; }
	
		
		public string _lib_voiedo { get; set; }
	
		
		public string _lib_secteu { get; set; }
	
		
		public string _lib_region { get; set; }
	
		
		public string _lib_regi_1 { get; set; }
	
		
		public string _cod_suppor { get; set; }
	
		
		public string _lib_suppor { get; set; }
	
		
		public double _hauteur_su { get; set; }
	
		
		public double _dureevie_s { get; set; }
	
		
		public string _unitevie_s { get; set; }
	
		
		public string _lib_supp_1 { get; set; }
	
		
		public string _cod_lumina { get; set; }
	
		
		public string _lib_lumina { get; set; }
	
		
		public string _modele_lum { get; set; }
	
		
		public double _dureevie_l { get; set; }
	
		
		public string _unitevie_l { get; set; }
	
		
		public string _lib_lumi_1 { get; set; }
	
		
		public string _lib_fourni { get; set; }
	
		
		public string _cod_lampe { get; set; }
	
		
		public string _lib_lampe { get; set; }
	
		
		public double _pw_lampe { get; set; }
	
		
		public string _lib_lampef { get; set; }
	
		
		public GeoShape _geo_shape { get; set; }
	
		
		public List<double> _geo_point_2d { get; set; }
	
		
	}

	public class panneaux_d_affichage_associatifs	
	{
		public string className {get {return "panneaux_d_affichage_associatifs" ;} }
		
		public string _localisation_des_panneaux_d_affichage { get; set; }
	
		
		public string _precision { get; set; }
	
		
		public int _r { get; set; }
	
		
		public int _format_1m2 { get; set; }
	
		
		public int _format_2m2 { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class cinemasaparis	
	{
		public string className {get {return "cinemas-a-paris" ;} }
		
		public int _ndegauto { get; set; }
	
		
		public string _nom_etablissement { get; set; }
	
		
		public int _ecrans { get; set; }
	
		
		public string _fauteuils { get; set; }
	
		
		public string _art_et_essai { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _arrondissement { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class mobilierenvironnementparis2011	
	{
		public string className {get {return "mobilierenvironnementparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class etalages_et_terrasses_autorisees_a_paris	
	{
		public string className {get {return "etalages_et_terrasses_autorisees_a_paris" ;} }
		
		public string _dossier { get; set; }
	
		
		public int _arrondissement { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _lieu { get; set; }
	
		
		public string _libelle_type_objet { get; set; }
	
		
		public double _dima { get; set; }
	
		
		public double _dimb { get; set; }
	
		
		public string _dosred { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class equipements_de_proximite	
	{
		public string className {get {return "equipements_de_proximite" ;} }
		
		public string _mairie_gestionnaire { get; set; }
	
		
		public string _type_d_equipement { get; set; }
	
		
		public string _designation_longue { get; set; }
	
		
		public int _ap_num { get; set; }
	
		
		public string _ap_cnu { get; set; }
	
		
		public int _ap_cp { get; set; }
	
		
		public string _ap_voie { get; set; }
	
		
	}

	public class liste_des_etablissements_scolaires2	
	{
		public string className {get {return "liste_des_etablissements_scolaires2" ;} }
		
		public string _n_etablissement { get; set; }
	
		
		public string _nom { get; set; }
	
		
		public string _type { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _ville { get; set; }
	
		
		public int _code_postal { get; set; }
	
		
		public List<double> _adresse_complete { get; set; }
	
		
	}

	public class bati_donnees_geographiques	
	{
		public string className {get {return "bati_donnees_geographiques" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _niveau { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}

	public class arbresremarquablesparis2011	
	{
		public string className {get {return "arbresremarquablesparis2011" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public string _arrondisse { get; set; }
	
		
		public string _genre { get; set; }
	
		
		public string _espece { get; set; }
	
		
		public string _famille { get; set; }
	
		
		public string _annee_pla { get; set; }
	
		
		public double _hauteur { get; set; }
	
		
		public double _circonf { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _nom_commun { get; set; }
	
		
		public string _variete { get; set; }
	
		
		public int _objectid { get; set; }
	
		
		public string _nom_ev { get; set; }
	
		
	}

	public class arretesinsalubriteparis2010	
	{
		public string className {get {return "arretesinsalubriteparis2010" ;} }
		
		public DateTime _date_controle { get; set; }
	
		
		public int _numero { get; set; }
	
		
		public string _type { get; set; }
	
		
		public string _voie { get; set; }
	
		
		public int _arrdt { get; set; }
	
		
		public string _arrete { get; set; }
	
		
		public DateTime _date_signature { get; set; }
	
		
		public DateTime _date_notification { get; set; }
	
		
		public List<double> _geo_coordinates { get; set; }
	
		
	}

	public class annuaire_immobilier_de_l_enseignement_superieur	
	{
		public string className {get {return "annuaire_immobilier_de_l_enseignement_superieur" ;} }
		
		public int _ndeg_identifiant { get; set; }
	
		
		public int _cp { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public string _parcelle { get; set; }
	
		
		public int _surface_de_la_parcelle { get; set; }
	
		
		public string _proprietaire { get; set; }
	
		
		public string _occupant { get; set; }
	
		
		public string _type { get; set; }
	
		
		public string _tutelle_pedagogique { get; set; }
	
		
		public string _statut_public_prive_ville_de_paris { get; set; }
	
		
		public string _pres { get; set; }
	
		
	}

	public class accidentologie	
	{
		public string className {get {return "accidentologie" ;} }
		
		public DateTime _date { get; set; }
	
		
		public string _heure { get; set; }
	
		
		public int _dept { get; set; }
	
		
		public int _com { get; set; }
	
		
		public string _adresse { get; set; }
	
		
		public int _code_postal { get; set; }
	
		
		public string _carr { get; set; }
	
		
		public int _segm { get; set; }
	
		
		public string _lieu_1_nomv { get; set; }
	
		
		public string _lieu_2_nomv { get; set; }
	
		
		public string _vehicule_1_cadmin { get; set; }
	
		
		public string _vehicule_1_lveh { get; set; }
	
		
		public string _vehicle_2_cadmin { get; set; }
	
		
		public string _vehicule_2_lveh { get; set; }
	
		
		public string _vehicule_3_cadmin { get; set; }
	
		
		public string _vehicule_3_lveh { get; set; }
	
		
		public string _usager_1_catu { get; set; }
	
		
		public string _usager_1_grav { get; set; }
	
		
		public string _usager_1_lveh { get; set; }
	
		
		public string _usager_2_catu { get; set; }
	
		
		public string _usager_2_grav { get; set; }
	
		
		public string _usager_2_lveh { get; set; }
	
		
		public string _usager_3_catu { get; set; }
	
		
		public string _usager_3_grav { get; set; }
	
		
		public string _usager_3_lveh { get; set; }
	
		
		public string _usager_4_catu { get; set; }
	
		
		public string _usager_4_grav { get; set; }
	
		
		public string _usager_4_lveh { get; set; }
	
		
		public List<double> _coordonnees { get; set; }
	
		
	}

	public class comptesadministratifsetatsspeciauxdarrondissement	
	{
		public string className {get {return "comptes-administratifs-etats-speciaux-darrondissement" ;} }
		
		public DateTime _exercice_comptable { get; set; }
	
		
		public string _budget { get; set; }
	
		
		public string _section_budgetaire_i_f { get; set; }
	
		
		public string _sens_depense_recette { get; set; }
	
		
		public string _type_d_operation_r_o_i_m { get; set; }
	
		
		public string _chapitre_budgetaire_cle { get; set; }
	
		
		public string _chapitre_budgetaire_texte { get; set; }
	
		
		public string _nature_budgetaire_cle { get; set; }
	
		
		public string _nature_budgetaire_texte { get; set; }
	
		
		public string _fonction_cle { get; set; }
	
		
		public string _fonction_texte { get; set; }
	
		
		public double _mandate_titre_apres_regul { get; set; }
	
		
	}

	public class stationsvelibdisponibilitesentempsreel	
	{
		public string className {get {return "stations-velib-disponibilites-en-temps-reel" ;} }
		
		public int _number { get; set; }
	
		
		public string _name { get; set; }
	
		
		public string _address { get; set; }
	
		
		public List<double> _position { get; set; }
	
		
		public string _banking { get; set; }
	
		
		public string _bonus { get; set; }
	
		
		public string _status { get; set; }
	
		
		public string _contract_name { get; set; }
	
		
		public int _bike_stands { get; set; }
	
		
		public int _available_bike_stands { get; set; }
	
		
		public int _available_bikes { get; set; }
	
		
		public DateTime _last_update { get; set; }
	
		
	}

	public class evenementsaparis	
	{
		public string className {get {return "evenements-a-paris" ;} }
		
		public string _uid { get; set; }
	
		
		public string _link { get; set; }
	
		
		public DateTime _updated_at { get; set; }
	
		
		public string _space_time_info { get; set; }
	
		
		public string _image { get; set; }
	
		
		public string _image_thumb { get; set; }
	
		
		public string _share_url { get; set; }
	
		
		public string _lang { get; set; }
	
		
		public string _title { get; set; }
	
		
		public string _description { get; set; }
	
		
		public string _free_text { get; set; }
	
		
		public string _tags { get; set; }
	
		
		public List<double> _latlon { get; set; }
	
		
		public string _placename { get; set; }
	
		
		public string _address { get; set; }
	
		
		public string _department { get; set; }
	
		
		public string _region { get; set; }
	
		
		public string _city { get; set; }
	
		
		public DateTime _date_start { get; set; }
	
		
		public DateTime _date_end { get; set; }
	
		
		public string _pricing_info { get; set; }
	
		
		public string _program_uid { get; set; }
	
		
	}

	public class stations_et_espaces_autolib_de_la_metropole_parisienne	
	{
		public string className {get {return "stations_et_espaces_autolib_de_la_metropole_parisienne" ;} }
		
		public string _id { get; set; }
	
		
		public string _identifiant_autolib { get; set; }
	
		
		public string _rue { get; set; }
	
		
		public int _code_postal { get; set; }
	
		
		public string _ville { get; set; }
	
		
		public List<double> _field13 { get; set; }
	
		
		public string _emplacement { get; set; }
	
		
		public int _autolib { get; set; }
	
		
		public int _tiers { get; set; }
	
		
		public int _abri { get; set; }
	
		
	}

	public class lestitreslespluspretes	
	{
		public string className {get {return "les-titres-les-plus-pretes" ;} }
		
		public string _support { get; set; }
	
		
		public int _nombre_de_prets { get; set; }
	
		
		public string _titre { get; set; }
	
		
		public string _auteur { get; set; }
	
		
	}

	public class liste_des_prenoms_2004_a_2012	
	{
		public string className {get {return "liste_des_prenoms_2004_a_2012" ;} }
		
		public string _prenoms { get; set; }
	
		
		public int _nombre { get; set; }
	
		
		public string _sexe { get; set; }
	
		
		public int _annee { get; set; }
	
		
	}

	public class detail_du_bati	
	{
		public string className {get {return "detail_du_bati" ;} }
		
		public List<double> _geom_x_y { get; set; }
	
		
		public GeoShape _geom { get; set; }
	
		
		public string _info { get; set; }
	
		
		public string _libelle { get; set; }
	
		
	}
	public class ParisOpenDataContext
	{
		public IEnumerable<postespublicsdesbibliothequesdepret> postespublicsdesbibliothequesdepretDataset { get; set;}
		public IEnumerable<bilansocialeffectifsnontitulairespermanents> bilansocialeffectifsnontitulairespermanentsDataset { get; set;}
		public IEnumerable<deliberationemploi> deliberationemploiDataset { get; set;}
		public IEnumerable<budgetsvotesannexes> budgetsvotesannexesDataset { get; set;}
		public IEnumerable<bugdetvotesprincipaux> bugdetvotesprincipauxDataset { get; set;}
		public IEnumerable<immobilisationsetatdessorties> immobilisationsetatdessortiesDataset { get; set;}
		public IEnumerable<comptesadministratifsprincipauxvilledepartement> comptesadministratifsprincipauxvilledepartementDataset { get; set;}
		public IEnumerable<pointsdevotedubudgetparticipatif> pointsdevotedubudgetparticipatifDataset { get; set;}
		public IEnumerable<formationparthemesbilansocial> formationparthemesbilansocialDataset { get; set;}
		public IEnumerable<titularisations> titularisationsDataset { get; set;}
		public IEnumerable<etatdupersonnel> etatdupersonnelDataset { get; set;}
		public IEnumerable<recrutementdirectbilansocial> recrutementdirectbilansocialDataset { get; set;}
		public IEnumerable<stationnementsurvoiepubliquezonestarifaires> stationnementsurvoiepubliquezonestarifairesDataset { get; set;}
		public IEnumerable<inventairedesdocumentsnumerisesenligne> inventairedesdocumentsnumerisesenligneDataset { get; set;}
		public IEnumerable<titreslesplusreservesbibliothequesspecialisees> titreslesplusreservesbibliothequesspecialiseesDataset { get; set;}
		public IEnumerable<titreslespluspretesbibliothequesspecialiseesen2014> titreslespluspretesbibliothequesspecialiseesen2014Dataset { get; set;}
		public IEnumerable<accidentdetravailetdetrajetparcorpsbilansocial> accidentdetravailetdetrajetparcorpsbilansocialDataset { get; set;}
		public IEnumerable<budgetsvotesetatsspeciauxdarrondissements> budgetsvotesetatsspeciauxdarrondissementsDataset { get; set;}
		public IEnumerable<dettepropre> dettepropreDataset { get; set;}
		public IEnumerable<budgetvotesapautotrisationsdeprogrammes> budgetvotesapautotrisationsdeprogrammesDataset { get; set;}
		public IEnumerable<lesparcellesforestieresdesbois> lesparcellesforestieresdesboisDataset { get; set;}
		public IEnumerable<lesconseillersdeparisde1977a2014> lesconseillersdeparisde1977a2014Dataset { get; set;}
		public IEnumerable<positionsstatutairesparticulieresautrequedetachementbilansocial> positionsstatutairesparticulieresautrequedetachementbilansocialDataset { get; set;}
		public IEnumerable<paris_taxis_stations> paris_taxis_stationsDataset { get; set;}
		public IEnumerable<recrutementsurconcoursbilansocial> recrutementsurconcoursbilansocialDataset { get; set;}
		public IEnumerable<subventionsaccordeesetrefusees> subventionsaccordeesetrefuseesDataset { get; set;}
		public IEnumerable<listedesmarchesdelacollectiviteparisienne> listedesmarchesdelacollectiviteparisienneDataset { get; set;}
		public IEnumerable<tranchedagedetailleespour15corpsbilansocial> tranchedagedetailleespour15corpsbilansocialDataset { get; set;}
		public IEnumerable<formationparcategoriesbilansocial> formationparcategoriesbilansocialDataset { get; set;}
		public IEnumerable<statistiquesdesvotesenlignedubudgetparticipatif2014> statistiquesdesvotesenlignedubudgetparticipatif2014Dataset { get; set;}
		public IEnumerable<lesjardinieres> lesjardinieresDataset { get; set;}
		public IEnumerable<zones30> zones30Dataset { get; set;}
		public IEnumerable<touspe3> touspe3Dataset { get; set;}
		public IEnumerable<voie> voieDataset { get; set;}
		public IEnumerable<horloges_exterieures_et_interieures> horloges_exterieures_et_interieuresDataset { get; set;}
		public IEnumerable<catalogue_des_cours_municipaux_d_adultes> catalogue_des_cours_municipaux_d_adultesDataset { get; set;}
		public IEnumerable<ordres_du_jour_du_conseil_general> ordres_du_jour_du_conseil_generalDataset { get; set;}
		public IEnumerable<ordres_du_jour_du_conseil_municipal> ordres_du_jour_du_conseil_municipalDataset { get; set;}
		public IEnumerable<statistiques_de_creation_d_actes_d_etat_civil> statistiques_de_creation_d_actes_d_etat_civilDataset { get; set;}
		public IEnumerable<filiationvoiesparis2012> filiationvoiesparis2012Dataset { get; set;}
		public IEnumerable<utilisations_mensuelles_des_hotspots_paris_wifi> utilisations_mensuelles_des_hotspots_paris_wifiDataset { get; set;}
		public IEnumerable<adresse_paris> adresse_parisDataset { get; set;}
		public IEnumerable<murs_et_clotures> murs_et_cloturesDataset { get; set;}
		public IEnumerable<touslesdocumentsdesbibliothequesdepret> touslesdocumentsdesbibliothequesdepretDataset { get; set;}
		public IEnumerable<volumes_d_eau_distribues> volumes_d_eau_distribuesDataset { get; set;}
		public IEnumerable<parcsdestationnementconcedesdelavilledeparis> parcsdestationnementconcedesdelavilledeparisDataset { get; set;}
		public IEnumerable<mobilierstationnementparis2011> mobilierstationnementparis2011Dataset { get; set;}
		public IEnumerable<troncon_voie> troncon_voieDataset { get; set;}
		public IEnumerable<quartier_paris> quartier_parisDataset { get; set;}
		public IEnumerable<liste_des_places_de_livraison> liste_des_places_de_livraisonDataset { get; set;}
		public IEnumerable<nomenclature_du_tri_selectif> nomenclature_du_tri_selectifDataset { get; set;}
		public IEnumerable<duvertpresdechezmoi> duvertpresdechezmoiDataset { get; set;}
		public IEnumerable<bornes_et_arceaux_de_stationnement_a_paris> bornes_et_arceaux_de_stationnement_a_parisDataset { get; set;}
		public IEnumerable<les_references_les_plus_reservees_en_2011> les_references_les_plus_reservees_en_2011Dataset { get; set;}
		public IEnumerable<les_1000_titres_les_plus_empruntes_de_2013> les_1000_titres_les_plus_empruntes_de_2013Dataset { get; set;}
		public IEnumerable<poteaux_divers_sur_voie_publique> poteaux_divers_sur_voie_publiqueDataset { get; set;}
		public IEnumerable<les_1000_titres_les_plus_reserves_en_2013> les_1000_titres_les_plus_reserves_en_2013Dataset { get; set;}
		public IEnumerable<zonesderattachementdesbureauxdevoteen2012> zonesderattachementdesbureauxdevoteen2012Dataset { get; set;}
		public IEnumerable<resultatsdelelectionmunicipale20141ertour> resultatsdelelectionmunicipale20141ertourDataset { get; set;}
		public IEnumerable<mobilierpropreteparis2011> mobilierpropreteparis2011Dataset { get; set;}
		public IEnumerable<petits_marchands_sur_l_espace_public_en_2012> petits_marchands_sur_l_espace_public_en_2012Dataset { get; set;}
		public IEnumerable<maneges_et_jeux_2012> maneges_et_jeux_2012Dataset { get; set;}
		public IEnumerable<adresses_des_panneaux_cq> adresses_des_panneaux_cqDataset { get; set;}
		public IEnumerable<liste_des_bureaux_de_vote_2013_liste_des_bureaux> liste_des_bureaux_de_vote_2013_liste_des_bureauxDataset { get; set;}
		public IEnumerable<concessions_dans_les_jardins> concessions_dans_les_jardinsDataset { get; set;}
		public IEnumerable<parcsetjardinsparis2010> parcsetjardinsparis2010Dataset { get; set;}
		public IEnumerable<mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geo> mobiliers_et_emprises_au_sol_de_signalisation_routiere_et_pietonne__donnees_geoDataset { get; set;}
		public IEnumerable<relief_naturel> relief_naturelDataset { get; set;}
		public IEnumerable<panneaux_indicateurs_de_signalisation_routiere_et_pietonne> panneaux_indicateurs_de_signalisation_routiere_et_pietonneDataset { get; set;}
		public IEnumerable<arrondissements> arrondissementsDataset { get; set;}
		public IEnumerable<volumesbatisparis2011> volumesbatisparis2011Dataset { get; set;}
		public IEnumerable<les1000titreslesplusreservesdanslesbibliothequesdepret> les1000titreslesplusreservesdanslesbibliothequesdepretDataset { get; set;}
		public IEnumerable<listedesantenneswifi> listedesantenneswifiDataset { get; set;}
		public IEnumerable<comptederesultat> comptederesultatDataset { get; set;}
		public IEnumerable<comptesadministratifsautorisationsdeprogrammesapvilledepartement> comptesadministratifsautorisationsdeprogrammesapvilledepartementDataset { get; set;}
		public IEnumerable<reseaucyclable> reseaucyclableDataset { get; set;}
		public IEnumerable<arbresalignementparis2010> arbresalignementparis2010Dataset { get; set;}
		public IEnumerable<conseilsquartiers> conseilsquartiersDataset { get; set;}
		public IEnumerable<zonesderattachementdesbureauxdevoteen2014> zonesderattachementdesbureauxdevoteen2014Dataset { get; set;}
		public IEnumerable<liste_des_ouvrages_des_bibliotheques_en_janvier_2009> liste_des_ouvrages_des_bibliotheques_en_janvier_2009Dataset { get; set;}
		public IEnumerable<liste_des_associations_parisiennes> liste_des_associations_parisiennesDataset { get; set;}
		public IEnumerable<petits_marchands_sur_l_espace_public> petits_marchands_sur_l_espace_publicDataset { get; set;}
		public IEnumerable<mobilierelectriqueparis2011> mobilierelectriqueparis2011Dataset { get; set;}
		public IEnumerable<accessibilite_des_equipements_de_la_ville_de_paris> accessibilite_des_equipements_de_la_ville_de_parisDataset { get; set;}
		public IEnumerable<listedescafesauneuro> listedescafesauneuroDataset { get; set;}
		public IEnumerable<liste_des_sites_des_hotspots_paris_wifi> liste_des_sites_des_hotspots_paris_wifiDataset { get; set;}
		public IEnumerable<postespublicsdesbibliothequesspecialisees> postespublicsdesbibliothequesspecialiseesDataset { get; set;}
		public IEnumerable<promotionsdegradesuiteaexamenprofessionnel> promotionsdegradesuiteaexamenprofessionnelDataset { get; set;}
		public IEnumerable<positionsstatutairesparticulieresdetachementsbilansocial> positionsstatutairesparticulieresdetachementsbilansocialDataset { get; set;}
		public IEnumerable<promotionsparcategoriehommesfemmes> promotionsparcategoriehommesfemmesDataset { get; set;}
		public IEnumerable<tempsdetravaildeseffectifsnontitulairespermanentsbilansocial> tempsdetravaildeseffectifsnontitulairespermanentsbilansocialDataset { get; set;}
		public IEnumerable<bilancomptable> bilancomptableDataset { get; set;}
		public IEnumerable<dettegarantie> dettegarantieDataset { get; set;}
		public IEnumerable<immobilisationsetatdesentrees> immobilisationsetatdesentreesDataset { get; set;}
		public IEnumerable<immobilisationsetatdesamortissements> immobilisationsetatdesamortissementsDataset { get; set;}
		public IEnumerable<statistiques_de_creation_d_actes_d_etat_civil_par_arrondissement> statistiques_de_creation_d_actes_d_etat_civil_par_arrondissementDataset { get; set;}
		public IEnumerable<concessionsredevancespercues> concessionsredevancespercuesDataset { get; set;}
		public IEnumerable<subventionsversees> subventionsverseesDataset { get; set;}
		public IEnumerable<evolutiondescorpslesplusetlesmoinsfeminises> evolutiondescorpslesplusetlesmoinsfeminisesDataset { get; set;}
		public IEnumerable<les1000titreslespluspretesparsupport> les1000titreslespluspretesparsupportDataset { get; set;}
		public IEnumerable<pim> pimDataset { get; set;}
		public IEnumerable<comptesadministratifsbudgetsannexes> comptesadministratifsbudgetsannexesDataset { get; set;}
		public IEnumerable<statistiques_de_creation_d_actes_d_etat_civil_par_mois> statistiques_de_creation_d_actes_d_etat_civil_par_moisDataset { get; set;}
		public IEnumerable<effectifspermanentspartranchedagebilansocial> effectifspermanentspartranchedagebilansocialDataset { get; set;}
		public IEnumerable<paris_taxis_data> paris_taxis_dataDataset { get; set;}
		public IEnumerable<listedesstationsdeservicesdevehicules> listedesstationsdeservicesdevehiculesDataset { get; set;}
		public IEnumerable<abrivoyageursecranstactilesconnectes> abrivoyageursecranstactilesconnectesDataset { get; set;}
		public IEnumerable<profil_petite_ceinture> profil_petite_ceintureDataset { get; set;}
		public IEnumerable<lescimetieresemprises> lescimetieresemprisesDataset { get; set;}
		public IEnumerable<domiciliationdesagentsbilansocial> domiciliationdesagentsbilansocialDataset { get; set;}
		public IEnumerable<lessurfacesboisees> lessurfacesboiseesDataset { get; set;}
		public IEnumerable<lescimetieresdivisions> lescimetieresdivisionsDataset { get; set;}
		public IEnumerable<emargementmunicipal> emargementmunicipalDataset { get; set;}
		public IEnumerable<effectifstitulairespermanents> effectifstitulairespermanentsDataset { get; set;}
		public IEnumerable<tempsdetravaildeseffectifstitulairespermanentsbilansocial> tempsdetravaildeseffectifstitulairespermanentsbilansocialDataset { get; set;}
		public IEnumerable<mobiliers_de_voies_routieres_de_type_barriere> mobiliers_de_voies_routieres_de_type_barriereDataset { get; set;}
		public IEnumerable<bilancomptablesynthetique> bilancomptablesynthetiqueDataset { get; set;}
		public IEnumerable<tonnages_des_dechets_bacs_verts> tonnages_des_dechets_bacs_vertsDataset { get; set;}
		public IEnumerable<plan_de_l_hemicycle_du_conseil_de_paris> plan_de_l_hemicycle_du_conseil_de_parisDataset { get; set;}
		public IEnumerable<consultations_des_centres_de_sante> consultations_des_centres_de_santeDataset { get; set;}
		public IEnumerable<tonnages_de_la_collecte_du_verre> tonnages_de_la_collecte_du_verreDataset { get; set;}
		public IEnumerable<mobiliereaupotableparis2011> mobiliereaupotableparis2011Dataset { get; set;}
		public IEnumerable<plaques_commemoratives_19391945> plaques_commemoratives_19391945Dataset { get; set;}
		public IEnumerable<etiquettes_energetiques_des_batiments_municipaux> etiquettes_energetiques_des_batiments_municipauxDataset { get; set;}
		public IEnumerable<tonnages_des_dechets_bacs_jaunes> tonnages_des_dechets_bacs_jaunesDataset { get; set;}
		public IEnumerable<lesarbres> lesarbresDataset { get; set;}
		public IEnumerable<hydro_ev> hydro_evDataset { get; set;}
		public IEnumerable<zonesderencontre> zonesderencontreDataset { get; set;}
		public IEnumerable<sanisettesparis2011> sanisettesparis2011Dataset { get; set;}
		public IEnumerable<liste_des_bureaux_de_vote_2013_voies_de_paris> liste_des_bureaux_de_vote_2013_voies_de_parisDataset { get; set;}
		public IEnumerable<attractions_foraines_sur_l_espace_public> attractions_foraines_sur_l_espace_publicDataset { get; set;}
		public IEnumerable<cheminement_d_assainissement> cheminement_d_assainissementDataset { get; set;}
		public IEnumerable<les_1000_titres_les_plus_empruntes_de_2012> les_1000_titres_les_plus_empruntes_de_2012Dataset { get; set;}
		public IEnumerable<les_1000_titres_les_plus_empruntes_2012_par_bibliotheque> les_1000_titres_les_plus_empruntes_2012_par_bibliothequeDataset { get; set;}
		public IEnumerable<mobiliertransportsparis2011> mobiliertransportsparis2011Dataset { get; set;}
		public IEnumerable<distributeurspreservatifsmasculinsparis2012> distributeurspreservatifsmasculinsparis2012Dataset { get; set;}
		public IEnumerable<resultats_electoraux> resultats_electorauxDataset { get; set;}
		public IEnumerable<les_1000_titres_les_plus_recherches_en_2013> les_1000_titres_les_plus_recherches_en_2013Dataset { get; set;}
		public IEnumerable<les1000titreslesplusrecherchesaucataloguedesbibliothequesdepret> les1000titreslesplusrecherchesaucataloguedesbibliothequesdepretDataset { get; set;}
		public IEnumerable<volumesnonbatisparis2011> volumesnonbatisparis2011Dataset { get; set;}
		public IEnumerable<voiesactuellesparis2012> voiesactuellesparis2012Dataset { get; set;}
		public IEnumerable<resultatsdelelectionmunicipale20142emetour> resultatsdelelectionmunicipale20142emetourDataset { get; set;}
		public IEnumerable<liste_des_jardins_partages_a_paris> liste_des_jardins_partages_a_parisDataset { get; set;}
		public IEnumerable<liste_des_marches_de_quartier_a_paris> liste_des_marches_de_quartier_a_parisDataset { get; set;}
		public IEnumerable<listemuseesdefranceaparis> listemuseesdefranceaparisDataset { get; set;}
		public IEnumerable<liste_des_kiosques_presse_a_paris> liste_des_kiosques_presse_a_parisDataset { get; set;}
		public IEnumerable<eclairagepublicsignalisationtricolore> eclairagepublicsignalisationtricoloreDataset { get; set;}
		public IEnumerable<panneaux_d_affichage_associatifs> panneaux_d_affichage_associatifsDataset { get; set;}
		public IEnumerable<cinemasaparis> cinemasaparisDataset { get; set;}
		public IEnumerable<mobilierenvironnementparis2011> mobilierenvironnementparis2011Dataset { get; set;}
		public IEnumerable<etalages_et_terrasses_autorisees_a_paris> etalages_et_terrasses_autorisees_a_parisDataset { get; set;}
		public IEnumerable<equipements_de_proximite> equipements_de_proximiteDataset { get; set;}
		public IEnumerable<liste_des_etablissements_scolaires2> liste_des_etablissements_scolaires2Dataset { get; set;}
		public IEnumerable<bati_donnees_geographiques> bati_donnees_geographiquesDataset { get; set;}
		public IEnumerable<arbresremarquablesparis2011> arbresremarquablesparis2011Dataset { get; set;}
		public IEnumerable<arretesinsalubriteparis2010> arretesinsalubriteparis2010Dataset { get; set;}
		public IEnumerable<annuaire_immobilier_de_l_enseignement_superieur> annuaire_immobilier_de_l_enseignement_superieurDataset { get; set;}
		public IEnumerable<accidentologie> accidentologieDataset { get; set;}
		public IEnumerable<comptesadministratifsetatsspeciauxdarrondissement> comptesadministratifsetatsspeciauxdarrondissementDataset { get; set;}
		public IEnumerable<stationsvelibdisponibilitesentempsreel> stationsvelibdisponibilitesentempsreelDataset { get; set;}
		public IEnumerable<evenementsaparis> evenementsaparisDataset { get; set;}
		public IEnumerable<stations_et_espaces_autolib_de_la_metropole_parisienne> stations_et_espaces_autolib_de_la_metropole_parisienneDataset { get; set;}
		public IEnumerable<lestitreslespluspretes> lestitreslespluspretesDataset { get; set;}
		public IEnumerable<liste_des_prenoms_2004_a_2012> liste_des_prenoms_2004_a_2012Dataset { get; set;}
		public IEnumerable<detail_du_bati> detail_du_batiDataset { get; set;}
		
	}
	
}

