using FormationWebServicesData.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FormationIHM.viewsModel
{
    /// <summary>
    /// Logique d'interaction pour AjouterFormateur.xaml
    /// </summary>
    public partial class AjouterFormateur : Window
    {
        private readonly ViewModelFormatteur _viewModel;
        public AjouterFormateur()
        {          
            InitializeComponent();
            _viewModel = new ViewModelFormatteur();
            DataContext = _viewModel;
            // Compléter l'interface (ajouter l'ensemble des attributs d'un formateur, ajouter la validation de dl'ensemble des attributs...)
            // Crée un custom UserControm Email
        }

        // mettre dans la commande (voir le lien https://www.c-sharpcorner.com/article/how-to-fire-button-click-event-in-mvvm-pattern-using-prism-l/ )
        private void BtnAjouter_Click(object sender, RoutedEventArgs e)
        {
            DataLayer.Context.DataContext dataContext = new DataLayer.Context.DataContext();
            FormationServicesReference.FormationServicesClient service = new  FormationServicesReference.FormationServicesClient ();
           // IFormateurRepository forrmateurRepository = new FormateurRepository(dataContext);
            service.AddFormateur( );
            MessageBox.Show("Le formateur " + _viewModel.firstName + " " + _viewModel.lastName+ " a été ajouté avec succès");
            txtNom.Text = string.Empty;
          //txtPrenom.Text = string.Empty;
           
        }
    }
}
