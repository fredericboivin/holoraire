﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
    public class Poste : Ressource
    {


        private Profil profil;
        private string description;

        public Poste(string nom, string description)
        {

            setNom(nom);
            setDescription(description);

        }

        public Poste(int id, string nom, string description)
        {
            setId(id);
            setNom(nom);
            setDescription(description);

        }

        public void save()
        {
            DBConnect proc = new DBConnect();
            if (this.id < 0)
            {
                proc.addPoste(nom, description);
                id = Convert.ToInt32(proc.getLastStuff("Poste").Rows[0]["last_insert_rowid()"].ToString());
            }
            else
            {
                proc.modifyPoste(id, nom, description);
            }
        }


        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setProfil(Profil profil)
        {
            this.profil = profil;
        }

        public Profil getProfil()
        {
            return profil;
        }


    }
}
