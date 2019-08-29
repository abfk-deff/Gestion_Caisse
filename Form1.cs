using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCaisse.Models;
using System.IO;

namespace GestionCaisse
{
   
    public partial class Form1 : Form
    {
        Gestion_CaisseEntities db;
        Employe emp;
        public Form1()
        {
            InitializeComponent();
            //this.tabPage2.Parent = null; // hide    
            //this.tabPage1.Parent = this.materialTabControl; //show
            //tabPage2.Hide();
            
            panel1.Hide();
            idUser.Focus();
            //materialTabControl.SelectTab("redigerDmd");
            //materialTabControl.SelectTab("EnregistreEm");
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        List<TypeDemande> typD;
        List<DemandeDecaissement> dmD;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Gestion_CaisseEntities();
            dmD = new List<DemandeDecaissement>();
            emp = new Employe();
            employeBindingSource.DataSource = db.Employes.ToList();
            clear();
            typD = new List<TypeDemande>();
            using (Gestion_CaisseEntities dbs = new Gestion_CaisseEntities())
            {
                typD = db.TypeDemandes.ToList();
                dmD = db.DemandeDecaissements.ToList();
            }

            

            //foreach (TypeDemande ty in typD)
            //    comboBox1.Items.Add(ty.type);
            comboBox1.DataSource = typD;
            comboBox1.ValueMember = "idTypeDemande";
            comboBox1.DisplayMember = "type";
            demandeDecaissementBindingSource.DataSource = dmD;

            
            var req = from typ in db.TypeDemandes.DefaultIfEmpty()    
                      join ddc in db.DemandeDecaissements on typ.idTypeDemande equals ddc.idTypeDemande
                      join v in db.Employes on ddc.idEmploye equals v.idEmploye
                       join ps in db.PieceJointes on ddc.idDemandeDecaissement equals ps.idDemandeDecaissement
                      //where ddc.idEmploye == idEmploy
                      select new
                      {
                          Nom_Prenom = v.nomEmploye+" "+v.prenomEmploye,
                          Type_Demande = typ.type,
                          Motif = ddc.motif,
                          Montant_Demande = ddc.montantDemande,
                          Date_Demande = ddc.dateDemande,
                          Statut_Demande = ddc.statutDemande,
                          Piece_Jointe = ps.cheminFichier
                      };
            
            datagridListeDmd.DataSource = req.ToList();

            
            //datagridListeDmd.Columns[1].HeaderText = "Nom et prenom";
            datagridListeDmd.ColumnHeadersVisible = true;
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }
        void showDrawer()
        {


        }
        void hideDrawer()
        {


        }

        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            materieldesign.SelectTab("EnregistreEm");
            clear();
        }

        private void EnregistreEm_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        void clear()
        {
            nomE.Text = prenomE.Text = typeProfil.Text = numPhone.Text = mdp.Text = "";
            enregistrer.Text = "Enregistrer";
            emp.idEmploye = 0;
        }

        private void nomE_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {

            save();
            employeBindingSource.DataSource = db.Employes.ToList();
            clear();

        }

        void save()
        {
            // Profil profilUser = Worker.SystemProfiles.FirstOrDefault( p => p.nomProfil == emp.statut);

            if (emp.idEmploye == 0)
            {
                emp = new Employe();
                emp.mot_de_passe = psw.Text.Trim();
                emp.nomEmploye = nomE.Text.Trim();
                emp.prenomEmploye = prenomE.Text.Trim();
                emp.statut = typeProfil.selectedValue.Trim();
                emp.sexe = Masculin.Checked ? "M" : "F";
                emp.numeroTelephone = Convert.ToInt32(numPhone.Text.Trim());

                using (Gestion_CaisseEntities db = new Gestion_CaisseEntities())
                {
                    db.Employes.Add(emp);
                    db.SaveChanges();
                }
            }
            else
            {
                emp.nomEmploye = nomE.Text.Trim();
                emp.prenomEmploye = prenomE.Text.Trim();
                emp.statut = typeProfil.Text.Trim();
                emp.numeroTelephone = Convert.ToInt32(numPhone.Text.Trim());
                using (Gestion_CaisseEntities db = new Gestion_CaisseEntities())
                {
                    //db.Employes.Attach(emp);
                    db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }

            MessageBox.Show("L'enregistrement a été bien effectué");
            clear();

            nomE.Focus();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //materialTabControl1.SelectedTab = materialTabControl1.TabPages[3];

            materieldesign.SelectTab("EnregistreEm");
            this.Refresh();

        }

        private void listeEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            modification();
        }
        void modification()
        {
            emp = new Employe();

            if (listeEmp.CurrentRow.Index != -1)
            {
                materieldesign.SelectTab("EnregistreEm");
                this.Refresh();

                emp.idEmploye = Convert.ToInt32(listeEmp.CurrentRow.Cells["idEmployeDataGridViewTextBoxColumn"].Value);
                using (Gestion_CaisseEntities db = new Gestion_CaisseEntities())
                {
                    emp = db.Employes.Where(x => x.idEmploye == emp.idEmploye).FirstOrDefault();
                    nomE.Text = emp.nomEmploye;
                    prenomE.Text = emp.prenomEmploye;
                    typeProfil.Text = emp.statut;
                    numPhone.Text = emp.numeroTelephone != null ? emp.numeroTelephone.Value.ToString() : "";
                }
            }

        }

        void delete()
        {

            if (employeBindingSource.Current != null)
            {
                if (MessageBox.Show("Etes-vous sur de vouloir supprimer cet employe?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Employes.Remove(employeBindingSource.Current as Employe);
                    employeBindingSource.RemoveCurrent();
                    db.SaveChanges();

                }
            }
        }
        private void supprimer_Click(object sender, EventArgs e)
        {
            delete();
        }

        void gestionUtilisateur()
        {



        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //EspaceAdmin espa = new EspaceAdmin();
            //espa.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        void hideTab()
        {
            //materialTabControl.Appearance = TabAppearance.FlatButtons;
            //materialTabControl.ItemSize = new Size(0, 1);
            //materialTabControl.SizeMode = TabSizeMode.Fixed;
            materieldesign.TabPages.Remove(tabPage2);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            authentification();
        }
        
        public static int idEmploy;

        void authentification()
        {
            Employe empc = new Employe();
            using (Gestion_CaisseEntities db = new Gestion_CaisseEntities())
            {

                var req = from empr in db.Employes
                          where empr.nomEmploye == idUser.Text.Trim()
                          select empr;
                empc = req.FirstOrDefault();

                if (empc.nomEmploye == idUser.Text.Trim() && empc.mot_de_passe == mdp.Text.Trim())
                {
                    idEmploy = empc.idEmploye;
                    if (empc.statut == "Administrateur")
                    {
                        panel1.Show();
                        Balance.Hide();
                        RedigerDemande.Hide();
                        validerDemande.Hide();
                        materieldesign.SelectTab("listEmp1");
                        this.Refresh();
                    }
                    if (empc.statut == "Caissier")
                    {
                        panel1.Show();
                        approvisionnement.Show();
                        Balance.Hide();
                        RedigerDemande.Hide();
                        validerDemande.Hide();
                        EnreEmploy.Hide();
                        btnListEmploye.Hide();
                    }
                    if (empc.statut == "Chef_service")
                    {
                        panel1.Show();
                        Balance.Show();
                        validerDemande.Show();
                        approvisionnement.Hide();
                        RedigerDemande.Hide();
                        EnreEmploy.Hide();
                        btnListEmploye.Hide();
                        materieldesign.SelectTab("validDemd");
                        //materieldesign.SelectTab("validDemd");

                    }
                    if (empc.statut == "Simple_employe")
                    {
                        panel1.Show();
                        RedigerDemande.Show();
                        materieldesign.SelectTab("redigerDmd");

                        Balance.Hide();
                        approvisionnement.Hide();
                        validerDemande.Hide();
                        EnreEmploy.Hide();
                        btnListEmploye.Hide();
                    }

                }
                else
                {
                    panel1.Hide();
                    MessageBox.Show("mot de passe ou id invalide");
                }



            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void typeProfil_onItemSelected(object sender, EventArgs e)
        {

        }

        private void SelectEmploy_onItemSelected(object sender, EventArgs e)
        {

        }
        void profilHabilitation()
        {

            Profil profilUser = Worker.SystemProfiles.FirstOrDefault(p => p.nomProfil == emp.statut);

        }

        private void btnListEmploye_Click(object sender, EventArgs e)
        {
            materieldesign.SelectTab("listEmp1");
            this.Refresh();
        }

        private void prenomE_OnValueChanged(object sender, EventArgs e)
        {

        }
        string imgeLocation = "";

        void chargeImage()
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png| jpg file(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgeLocation = dialog.FileName;
                pictureBox.ImageLocation = imgeLocation;
                champFichier.Text = dialog.FileName;
            }

        }
        private void btnOploadeFile_Click(object sender, EventArgs e)
        {

            chargeImage();
        }

        string pstat = "Non validé" ;
        private void btnEnvoiDmd_Click(object sender, EventArgs e)
        {
            // allocation de la memoire des instances
            PieceJointe pc = new PieceJointe();
            DemandeDecaissement dmdD = new DemandeDecaissement();
            TypeDemande tD = new TypeDemande();
            byte[] imge = null;
            FileStream stream = new FileStream(imgeLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brd = new BinaryReader(stream);
            DateTime dte = DateTime.Today;

            // remplissage de valeur dans les instance

            imge = brd.ReadBytes((int)stream.Length);
            dmdD.dateDemande = dte;
            dmdD.montantDemande = Convert.ToInt32(mtn.Text.Trim());
            dmdD.motif = motif.Text.Trim();
            //authentification();
            dmdD.idEmploye = idEmploy;//ec.idEmploye;
            pc.cheminFichier = imge;
            pc.idDemandeDecaissement = dmdD.idDemandeDecaissement;
            tD.type = typdP;
            dmdD.idTypeDemande = idtypD;
            dmdD.statutDemande = pstat;



            // Ouverture et enregistrement dans la BD
            using (Gestion_CaisseEntities db = new Gestion_CaisseEntities())
            {
                db.DemandeDecaissements.Add(dmdD);
                db.PieceJointes.Add(pc);
                //db.TypeDemandes.Add(tD);
                db.SaveChanges();
                MessageBox.Show("Votre demande a été bien envoyé");
            }
            clearFrmDD();


        }
        void recuperDD() 
        { }
        void clearFrmDD()
        {
            comboBox1.Text = "";
            mtn.Text = "";
            motif.Text = "";
            champFichier.Text = "";
            pictureBox.ImageLocation = null;
        }


        Int32 idtypD ;
        string typdP;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.CanFocus)
            {
                var selectedItem = (TypeDemande)comboBox1.SelectedItem;
                if (selectedItem != null)
                {
                    idtypD = selectedItem.idTypeDemande;
                    typdP = selectedItem.type;

                    //MessageBox.Show("La valeur selectionné est : id : "+selectedItem.idTypeDemande+" type : "+selectedItem.type);
                }
            }
        }



        private void RedigerDemande_Click(object sender, EventArgs e)
        {
            materieldesign.SelectTab("redigerDmd");
        }

        private void btnConsulterListeDmd_Click(object sender, EventArgs e)
        {
            
            listeDemande frm = new listeDemande();
            //frm.MdiParent = this;
            frm.Show();

        }

        void valide() 
        {

        }

        private void validDemd_Click(object sender, EventArgs e)
        {

        }

        private void btnVoirD_Click(object sender, EventArgs e)
        {
            //var rec = datagridListeDmd.CurrentRow;
            //int column = ed.ColumnIndex;
            //int row = ed.RowIndex;
            //DataGridView dtg = new DataGridView();
            
            //dtg = datagridListeDmd ;
            
            
            //int index = 0;
            //datagridListeDmd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           // datagridListeDmd.Rows(indiceLigne).Selected = True
            //datagridListeDmd.FirstDisplayedScrollingRowIndex = index;
          
            //datagridListeDmd.Refresh();
            EspaceAdmin frmV = new EspaceAdmin();
            frmV.labelDem.Text = ligne.Cells[0].Value.ToString();
            frmV.labelTypeDm.Text = ligne.Cells[1].Value.ToString();
            frmV.labelMontanD.Text = ligne.Cells[3].Value.ToString();
            frmV.labelMotif.Text = ligne.Cells[2].Value.ToString();
            frmV.labelDate.Text = ligne.Cells[4].Value.ToString();
            //frmV.labelStatutD.Text = ligne.Cells[5].Value.ToString();
            //frmV.pictureBoxPj.Image = ligne.Cells[6].Value;
            
            
            frmV.Show();
            


            
        }

        private void validerDemande_Click(object sender, EventArgs e)
        {

        }
        public int IdxLigneActuelle; 
        public string currentrow;
        public DataGridViewRow ligne;
        
        private void datagridListeDmd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int IdxLigneActuelle = e.RowIndex;
            //DataGridViewRow ligne = datagridListeDmd.Rows[IdxLigneActuelle];
            //String valeurCellule = ligne.Cells[2].Value.ToString(); 
     
            //datagridListeDmd.CurrentCell = datagridListeDmd.Rows[e.RowIndex].Cells[0];
            datagridListeDmd.Rows[e.RowIndex].Selected = true;
        if(datagridListeDmd.Rows[e.RowIndex].Selected == true)
             ligne  = datagridListeDmd.Rows[e.RowIndex];
            //String valeurCellule = ligne.Cells[2].Value.ToString(); 
            //IdxLigneActuelle = e.RowIndex;
            //MessageBox.Show(valeurCellule);
        }

        private void datagridListeDmd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void datagridListeDmd_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void datagridListeDmd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void datagridListeDmd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int column = e.ColumnIndex;
            //int row = e.RowIndex;

            //if (column.Equals(-1))
            //    MessageBox.Show("Colonne : " + column + "| Ligne : " + row);
        }

    }
}

