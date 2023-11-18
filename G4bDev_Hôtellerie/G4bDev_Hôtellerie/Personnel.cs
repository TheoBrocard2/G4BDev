using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4bDev_Hôtellerie
{
    public class Personnel
    {
        private string nom;
        private string prenom;
        private string poste;

        public Personnel(string nom, string prenom, string poste)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.poste = poste;
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

        public string Poste
        {
            get
            {
                return poste;
            }
            set
            {
                poste = value;
            }
        }

        public void AjoutPersonnel()
        {
            throw new NotImplementedException();
        }

        public void ModifInfo()
        {
            throw new NotImplementedException();
        }

        public void SuppPersonnel()
        {
            throw new NotImplementedException();
        }
    }
}
