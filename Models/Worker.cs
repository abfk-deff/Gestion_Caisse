using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCaisse.Models
{
   public class Worker
    {
       public static List<Profil> SystemProfiles = new List<Profil>() { 
           new Profil(){nomProfil="Administrateur",habilitation=new List<string>(){"create_User","edit_User","delete_User","create_Profil_User", "setUserProfil"}},
           new Profil(){ nomProfil="Superviseur",habilitation= new List<string>(){"Valider_Demande","Voir_Balance"}},
           new Profil(){ nomProfil="Caissier",habilitation= new List<string>(){"Effectuer_Depot","Decaissement","imprimer_ticket"}},
           new Profil(){ nomProfil="Simple_Employe",habilitation= new List<string>(){"Rediger_Demande","Envoyer"}},
       };
       
    }
}
