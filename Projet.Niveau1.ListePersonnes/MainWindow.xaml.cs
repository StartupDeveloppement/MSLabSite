using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projet.Niveau1.ListePersonnes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Personne> ListePersonnes
        {
            get; set;
        }

        public MainWindow()
        {
            InitializeComponent();
            ListePersonnes = new ObservableCollection<Personne>();
        }

        private void ButtonAjouter_Click(object sender, RoutedEventArgs e)
        {
            Personne personne = new Personne();
            personne.nom = ChampNom.Text;
            personne.prenom = ChampPrenom.Text;

            ListePersonnes.Add(personne);
        }
    }
}
