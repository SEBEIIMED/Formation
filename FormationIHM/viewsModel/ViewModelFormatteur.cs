using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FormationIHM.viewsModel
{
 
    class ViewModelFormatteur : INotifyPropertyChanged 
    {
     private Formatteur formatteur;

        public ViewModelFormatteur()
        {
            formatteur = new Formatteur();
          //  this.AjouterFormateurCommand = new DelegateCommand(AjouterFormateur);
        }

        public string firstName
        {
            get { return formatteur.first_name; }
            set
            {
                if (formatteur.first_name != value)
                {
                    formatteur.first_name = value;
                    OnPropertyChanged();
                }
            }
        }


        public string lastName
        {
            get { return formatteur.last_name; }
            set
            {
                if (formatteur.last_name != value)
                {
                    formatteur.last_name = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public ICommand AjouterFormateurCommand
        {
            get;
            private set;
        }

        public void AjouterFormateur()
        {
             
        }
    }
}
