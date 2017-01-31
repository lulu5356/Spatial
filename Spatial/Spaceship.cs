using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userflux
{
    class Spaceship
    {
        private int id;
        private string couleur;
        private int vitesse;
        private string agence;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Couleur
        {
            get
            {
                return couleur;
            }

            set
            {
                couleur = value;
            }
        }

        public int Vitesse
        {
            get
            {
                return vitesse;
            }

            set
            {
                vitesse = value;
            }
        }

        public string Agence
        {
            get
            {
                return agence;
            }

            set
            {
                agence = value;
            }
        }
    }
}
