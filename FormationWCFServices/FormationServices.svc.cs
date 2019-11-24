using BusinessLayer.FormationBusiness;
using FormationWebservicesShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "FormationServices" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez FormationServices.svc ou FormationServices.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class FormationServices : IFormationServices
    {
        public void AddFormateur(FormateurExchange formateur)
        {
            // déclaration de l'interface irepository
           // IFormateurBusiness forrmateurBusiness = new  FormateurBusiness( );
            //forrmateurBusiness.a ajoute AddFormateur dans le business
        }
    }
}
