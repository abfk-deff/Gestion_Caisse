namespace GestionCaisse
{
    partial class listeDemande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeDemande));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.datagridListDemande = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.demandeDecaissementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoirD = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.datagridListDemande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeDecaissementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(27, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(312, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Liste des demande effectuées avec statut";
            // 
            // datagridListDemande
            // 
            this.datagridListDemande.AllowUserToAddRows = false;
            this.datagridListDemande.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridListDemande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridListDemande.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridListDemande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridListDemande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridListDemande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridListDemande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridListDemande.DoubleBuffered = true;
            this.datagridListDemande.EnableHeadersVisualStyles = false;
            this.datagridListDemande.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.datagridListDemande.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.datagridListDemande.Location = new System.Drawing.Point(4, 34);
            this.datagridListDemande.Name = "datagridListDemande";
            this.datagridListDemande.ReadOnly = true;
            this.datagridListDemande.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridListDemande.Size = new System.Drawing.Size(551, 417);
            this.datagridListDemande.TabIndex = 1;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(506, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(27, 27);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // demandeDecaissementBindingSource
            // 
            this.demandeDecaissementBindingSource.DataSource = typeof(GestionCaisse.DemandeDecaissement);
            // 
            // btnVoirD
            // 
            this.btnVoirD.ActiveBorderThickness = 1;
            this.btnVoirD.ActiveCornerRadius = 20;
            this.btnVoirD.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnVoirD.ActiveForecolor = System.Drawing.Color.White;
            this.btnVoirD.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoirD.BackColor = System.Drawing.SystemColors.Control;
            this.btnVoirD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoirD.BackgroundImage")));
            this.btnVoirD.ButtonText = "Quiter";
            this.btnVoirD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoirD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnVoirD.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnVoirD.IdleBorderThickness = 1;
            this.btnVoirD.IdleCornerRadius = 20;
            this.btnVoirD.IdleFillColor = System.Drawing.Color.White;
            this.btnVoirD.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnVoirD.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnVoirD.Location = new System.Drawing.Point(452, 459);
            this.btnVoirD.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoirD.Name = "btnVoirD";
            this.btnVoirD.Size = new System.Drawing.Size(81, 34);
            this.btnVoirD.TabIndex = 17;
            this.btnVoirD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoirD.Click += new System.EventHandler(this.btnVoirD_Click);
            // 
            // listeDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 496);
            this.Controls.Add(this.btnVoirD);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.datagridListDemande);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listeDemande";
            this.Text = "listeDemande";
            this.Load += new System.EventHandler(this.listeDemande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridListDemande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demandeDecaissementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagridListDemande;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.BindingSource demandeDecaissementBindingSource;
        private Bunifu.Framework.UI.BunifuThinButton2 btnVoirD;
    }
}