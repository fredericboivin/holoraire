﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HoraireBeta
{
    public class Equipe : Ressource
    {
        private List<Ressource> profils = new List<Ressource>();
        private String nom;
        private String description;

        public Equipe(int id, string nom, string description)
        {
            setId(id);
            setNom(nom);
            setDescription(description);
        }
        
        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }


        public void setEmploye(Ressource profil)
        {
            profils.Add(profil);
        }

        public string getNom()
        {
            return nom;
        }
        public List<Ressource> getProfils() 
        {
         return profils;
        }

        public void save(){
            DBConnect proc = new DBConnect();
            if (this.id < 0)
            {
                proc.addTeam(nom, description);
                id = Convert.ToInt32(proc.getLastStuff("Team").Rows[0]["last_insert_rowid()"].ToString());
            }
            else
            {
                proc.modifyTeam(id, nom, description);

                proc.deleteTeamProfile(id);
            }

            foreach (Ressource lui in profils)
            {
                proc.addTeamProfile(id, lui.getId(), -1);
            }
        }

        public void draw(Bloc bloc, int i, Graphics gfx)
        {
            Font laFont = new Font("Arial", 16);
            SolidBrush brush = new SolidBrush(Color.Red);


            int x = bloc.getX();
            int y = bloc.getY() + (i * 20) + 20;

            Point coin = new Point(x, y);

            gfx.DrawString(nom, laFont, brush, coin);

        }



    }
}
