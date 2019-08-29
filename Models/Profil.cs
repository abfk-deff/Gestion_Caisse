using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCaisse.Models
{
    public class Profil
    {
        public Profil() {
            habilitation = new List<string>();
        }
        
        public string nomProfil { set; get; }
        public List<string> habilitation { set; get; }

    }
}
