﻿using System.Windows.Forms;
using System.Drawing;

namespace HoraireBeta
{
    partial class HoraireBeta
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Admin = new System.Windows.Forms.TabControl();
            this.horaire = new System.Windows.Forms.TabPage();
            this.panelCentral_Horaire = new System.Windows.Forms.Panel();
            this.panelGauche_Horaire = new System.Windows.Forms.Panel();
            this.employe = new System.Windows.Forms.TabPage();
            this.panelCentral_Employe = new System.Windows.Forms.Panel();
            this.panelGauche_Employe = new System.Windows.Forms.Panel();
            this.parametre = new System.Windows.Forms.TabPage();
            this.panelCentral_Parametre = new System.Windows.Forms.Panel();
            this.panelGauche_Parametre = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultDataGrid = new System.Windows.Forms.DataGridView();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Admin.SuspendLayout();
            this.horaire.SuspendLayout();
            this.employe.SuspendLayout();
            this.parametre.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Admin.Controls.Add(this.horaire);
            this.Admin.Controls.Add(this.employe);
            this.Admin.Controls.Add(this.parametre);
            this.Admin.Controls.Add(this.tabPage1);
            this.Admin.Location = new System.Drawing.Point(0, 0);
            this.Admin.Name = "Admin";
            this.Admin.SelectedIndex = 0;
            this.Admin.Size = new System.Drawing.Size(885, 561);
            this.Admin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Admin.TabIndex = 0;
            // 
            // horaire
            // 
            this.horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.horaire.Controls.Add(this.panelCentral_Horaire);
            this.horaire.Controls.Add(this.panelGauche_Horaire);
            this.horaire.Location = new System.Drawing.Point(4, 25);
            this.horaire.Name = "horaire";
            this.horaire.Padding = new System.Windows.Forms.Padding(3);
            this.horaire.Size = new System.Drawing.Size(877, 532);
            this.horaire.TabIndex = 0;
            this.horaire.Text = "Horaire";
            this.horaire.Click += new System.EventHandler(this.horaire_Click);
            // 
            // panelCentral_Horaire
            // 
            this.panelCentral_Horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Horaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Horaire.Location = new System.Drawing.Point(203, 7);
            this.panelCentral_Horaire.Name = "panelCentral_Horaire";
            this.panelCentral_Horaire.Size = new System.Drawing.Size(665, 515);
            this.panelCentral_Horaire.TabIndex = 1;
            this.panelCentral_Horaire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            this.panelCentral_Horaire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Horaire_OnMouseEvent);
            // 
            // panelGauche_Horaire
            // 
            this.panelGauche_Horaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Horaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Horaire.Location = new System.Drawing.Point(7, 7);
            this.panelGauche_Horaire.Name = "panelGauche_Horaire";
            this.panelGauche_Horaire.Size = new System.Drawing.Size(189, 515);
            this.panelGauche_Horaire.TabIndex = 0;
            this.panelGauche_Horaire.Paint += new System.Windows.Forms.PaintEventHandler(this.pCentral_Horaire_Paint);
            this.panelGauche_Horaire.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Horaire_OnMouseEvent);
            this.panelGauche_Horaire.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Horaire_OnMouseEvent);
            // 
            // employe
            // 
            this.employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.employe.Controls.Add(this.panelCentral_Employe);
            this.employe.Controls.Add(this.panelGauche_Employe);
            this.employe.Location = new System.Drawing.Point(4, 25);
            this.employe.Name = "employe";
            this.employe.Padding = new System.Windows.Forms.Padding(3);
            this.employe.Size = new System.Drawing.Size(877, 532);
            this.employe.TabIndex = 1;
            this.employe.Text = "Employé";
            this.employe.Click += new System.EventHandler(this.employe_Click);
            // 
            // panelCentral_Employe
            // 
            this.panelCentral_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Employe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Employe.Location = new System.Drawing.Point(204, 8);
            this.panelCentral_Employe.Name = "panelCentral_Employe";
            this.panelCentral_Employe.Size = new System.Drawing.Size(664, 514);
            this.panelCentral_Employe.TabIndex = 3;
            this.panelCentral_Employe.Paint += new System.Windows.Forms.PaintEventHandler(this.pCentral_Employe_Paint);
            this.panelCentral_Employe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Employe_OnMouseEvent);
            this.panelCentral_Employe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Employe_OnMouseEvent);
            // 
            // panelGauche_Employe
            // 
            this.panelGauche_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Employe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Employe.Location = new System.Drawing.Point(8, 8);
            this.panelGauche_Employe.Name = "panelGauche_Employe";
            this.panelGauche_Employe.Size = new System.Drawing.Size(189, 514);
            this.panelGauche_Employe.TabIndex = 2;
            this.panelGauche_Employe.Paint += new System.Windows.Forms.PaintEventHandler(this.pGauche_Employe_Paint);
            this.panelGauche_Employe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Employe_OnMouseEvent);
            this.panelGauche_Employe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Employe_OnMouseEvent);
            // 
            // parametre
            // 
            this.parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.parametre.Controls.Add(this.panelCentral_Parametre);
            this.parametre.Controls.Add(this.panelGauche_Parametre);
            this.parametre.Location = new System.Drawing.Point(4, 25);
            this.parametre.Name = "parametre";
            this.parametre.Padding = new System.Windows.Forms.Padding(3);
            this.parametre.Size = new System.Drawing.Size(877, 532);
            this.parametre.TabIndex = 2;
            this.parametre.Text = "Paramètre";
            // 
            // panelCentral_Parametre
            // 
            this.panelCentral_Parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelCentral_Parametre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral_Parametre.Location = new System.Drawing.Point(204, 8);
            this.panelCentral_Parametre.Name = "panelCentral_Parametre";
            this.panelCentral_Parametre.Size = new System.Drawing.Size(664, 514);
            this.panelCentral_Parametre.TabIndex = 3;
            this.panelCentral_Parametre.Paint += new System.Windows.Forms.PaintEventHandler(this.parametre_Paint);
            this.panelCentral_Parametre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pCentral_Parametre_OnMouseEvent);
            this.panelCentral_Parametre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCentral_Parametre_OnMouseEvent);
            // 
            // panelGauche_Parametre
            // 
            this.panelGauche_Parametre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelGauche_Parametre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGauche_Parametre.Location = new System.Drawing.Point(8, 8);
            this.panelGauche_Parametre.Name = "panelGauche_Parametre";
            this.panelGauche_Parametre.Size = new System.Drawing.Size(189, 514);
            this.panelGauche_Parametre.TabIndex = 2;
            this.panelGauche_Parametre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pGauche_Parametre_OnMouseEvent);
            this.panelGauche_Parametre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pGauche_Parametre_OnMouseEvent);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Green;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(877, 532);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 514);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.resultDataGrid);
            this.panel2.Controls.Add(this.sqlTextBox);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(204, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // resultDataGrid
            // 
            this.resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGrid.Location = new System.Drawing.Point(223, 145);
            this.resultDataGrid.Name = "resultDataGrid";
            this.resultDataGrid.Size = new System.Drawing.Size(215, 144);
            this.resultDataGrid.TabIndex = 7;
            this.resultDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGrid_CellContentClick);
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.Location = new System.Drawing.Point(223, 308);
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(215, 20);
            this.sqlTextBox.TabIndex = 6;
            this.sqlTextBox.TextChanged += new System.EventHandler(this.sqlTextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoraireBeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 559);
            this.Controls.Add(this.Admin);
            this.Name = "HoraireBeta";
            this.Text = "Form1";
            this.Admin.ResumeLayout(false);
            this.horaire.ResumeLayout(false);
            this.employe.ResumeLayout(false);
            this.parametre.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Admin;
        private System.Windows.Forms.TabPage horaire;
        private System.Windows.Forms.TabPage employe;
        private System.Windows.Forms.TabPage parametre;
        private System.Windows.Forms.Panel panelCentral_Horaire;
        private System.Windows.Forms.Panel panelGauche_Horaire;
        private System.Windows.Forms.Panel panelCentral_Employe;
        private System.Windows.Forms.Panel panelGauche_Employe;
        private System.Windows.Forms.Panel panelCentral_Parametre;
        private System.Windows.Forms.Panel panelGauche_Parametre;
        private TabPage tabPage1;
        private Panel panel2;
        private Panel panel1;
        private DataGridView resultDataGrid;
        private TextBox sqlTextBox;
        private Button button2;
        private Button button1;
    }
}

