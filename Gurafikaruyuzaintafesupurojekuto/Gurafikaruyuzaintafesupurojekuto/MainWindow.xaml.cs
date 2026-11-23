using Gurafikaruyuzaintafesupurojekuto.Pages;
using Microsoft.UI.Xaml;
using System.Windows;

namespace Gurafikaruyuzaintafesupurojekuto
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new PageAdherents()); // Page affichée au démarrage
        }

        // ----- Administrateurs -----
        private void BtnPageAjoutAdmin_Click(object sender, RoutedEventArgs e)
        {

        }
            

        // ----- Adhérents -----
        private void BtnPageAdherents_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPageAjoutAdherent_Click(object sender, RoutedEventArgs e)
        {

        }

        // ----- Activités -----
        private void BtnPageActivites_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPageAjoutActivite_Click(object sender, RoutedEventArgs e)
        {

        }

        // ----- Séances -----
        private void BtnPageAjoutSeance_Click(object sender, RoutedEventArgs e)
        {

        }

        // ----- Statistiques -----
        private void BtnPageStatistiques_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}