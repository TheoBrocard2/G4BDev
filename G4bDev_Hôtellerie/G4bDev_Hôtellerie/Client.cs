using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4bDev_Hôtellerie
{
    public class Client
    {
        private string nom;
        private string prenom;
        private string nbTel;
        private string adresse;

        public Client(string nom, string prenom, string nbTel, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.nbTel = nbTel;
        }

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        public string NbTel
        {
            get
            {
                return nbTel;
            }
            set
            {
                nbTel = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }
            set
            {
                adresse = value;
            }
        }


        public void Enregistrer()
        {
            throw new NotImplementedException();
        }

        public void ModifierInformations()
        {
            throw new NotImplementedException();
        }

        public void AnnulerReservation()
        {
            throw new NotImplementedException();
        }
    }
}



