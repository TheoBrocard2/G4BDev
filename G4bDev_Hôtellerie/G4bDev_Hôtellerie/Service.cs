using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4bDev_Hôtellerie
{
    public class Service
    {
        private string nomService;
        private float cout;

        public Service(string nomService, float cout)
        {
            this.nomService = nomService;
            this.cout = cout;
        }

        public string NomService
        {
            get
            {
                return nomService;
            }
            set
            {
                nomService = value;
            }
        }

        public float Cout
        {
            get
            {
                return cout;
            }
            set
            {
                cout = value;
            }
        }
    }
}
