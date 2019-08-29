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
    public partial class EspaceAdmin : Form
    {
        public EspaceAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EspaceAdmin_Load(object sender, EventArgs e)
        {
            int idx;
            //if (.CurrentRow.Index != -1)
                 
        }

        private void typeProfil_onItemSelected(object sender, EventArgs e)
        {

        }

        private void SelectEmploy_onItemSelected(object sender, EventArgs e)
        {
           List<Employe>  em = new List<Employe>();
            using( Gestion_CaisseEntities db = new Gestion_CaisseEntities()){
            //  em = db.Employes.Select<> 
          //  SelectEmploy.Items
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
