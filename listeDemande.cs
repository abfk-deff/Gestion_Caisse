using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCaisse
{
    public partial class listeDemande : Form
    {
        
        Gestion_CaisseEntities d;
        public listeDemande()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int idE;
        List<DemandeDecaissement> ld;
        private void listeDemande_Load(object sender, EventArgs e)
        {
           

            idE = Form1.idEmploy;
            ld = new List<DemandeDecaissement>();
            d = new Gestion_CaisseEntities();
            //demandeDecaissementBindingSource.DataSource =  d.DemandeDecaissements.Where(x => x.idEmploye == idE).ToList();
            var req = from typ in d.TypeDemandes 
                      join ddc in d.DemandeDecaissements on typ.idTypeDemande equals ddc.idTypeDemande
                      where ddc.idEmploye == idE
                      select new
                      {
                         type =  typ.type,
                         motif= ddc.motif,
                         montantDemande= ddc.montantDemande,
                         dateDemande= ddc.dateDemande,
                         statutDemande= ddc.statutDemande,
                      };
            datagridListDemande .DataSource = req.ToList();
              
        }

        private void btnVoirD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
