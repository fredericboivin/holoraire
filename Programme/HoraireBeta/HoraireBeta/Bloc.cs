﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace HoraireBeta
{

    public struct RessourceEntree
    {
        //struct qui sert a rentrer toutes les variables dans une liste   
        public Ressource voulue;
        public int nbVoulue;
        public int nbAffectee;
    }


    public class Bloc
    {



        private DateTime debut;
        private DateTime fin;
        private int typeBloc;
        private bool erreurExiste;
        private bool estComplet;
        private String jourText;
        private String nom;
        private int id;
        private int x;
        private int y;
        private int haut;
        private bool isSelected = false;
        private bool isPreset = false;

        private Boolean isdrawn = false;



        System.Globalization.CultureInfo info = new System.Globalization.CultureInfo("en-US", false);

        List<Ressource> ressourcesAffectes = new List<Ressource>();
        List<RessourceEntree> ressourcesVoulus = new List<RessourceEntree>();

        public Bloc(DateTime debut, DateTime fin, int type, int id, bool preset)
        {


            System.Globalization.Calendar calendar = info.Calendar;
            this.debut = debut;
            this.fin = fin;
            this.typeBloc = type;
            this.id = id;
            this.isPreset = preset;

            computePos();
            erreurExiste = false;
            estComplet = false;

        }

        public Bloc(DateTime debut, DateTime fin, int type, int id)
        {


            System.Globalization.Calendar calendar = info.Calendar;
            this.debut = debut;
            this.fin = fin;
            this.typeBloc = type;
            this.id = id;


            computePos();
            erreurExiste = false;
            estComplet = false;

        }
        
        public Bloc(DateTime debut, DateTime fin, int x, int type, int id)
        {


            System.Globalization.Calendar calendar = info.Calendar;
            this.debut = debut;
            this.fin = fin;
            this.typeBloc = type;
            this.id = id;
            /*
            y = (Convert.ToInt32(debut.ToString("HH")) * 20 + Convert.ToInt32(debut.ToString("MM")) / 20) + 20;

            this.x = x;


            haut = ((Convert.ToInt32(fin.ToString("HH")) * 20 + Convert.ToInt32(fin.ToString("MM")) / 20) - y) + 20;
            */
            computePos();
            erreurExiste = false;
            estComplet = false;

        }

        


        //public Bloc(int debutY, int finY, String jour, int type, int id);

        public Bloc(String jourText, int posX, int debutY, int finY, int jour, int type, int id)
        {


            System.Globalization.Calendar calendar = info.Calendar;

            this.jourText = jourText;


            this.typeBloc = type;
            this.id = id;
            int hh = debutY / 20;


            int mm = (debutY % 20) * 3;


            y = debutY;

            x = posX;

            haut = finY - debutY;


            erreurExiste = false;
            estComplet = false;

        }

        public int getType()
        {
            return typeBloc;
        }



        public void addRessourceVoulue(int nbvoulue, Ressource voulue)
        {
            //nom pas tant hot

            if (nbvoulue != 0)
            {
                RessourceEntree ressourceToAdd;
                ressourceToAdd.voulue = voulue;
                ressourceToAdd.nbVoulue = nbvoulue;
                ressourceToAdd.nbAffectee = 0;

                ressourcesVoulus.Add(ressourceToAdd);

            }
        }

        public void addRessourceVoulue(RessourceEntree ca)
        {


            ressourcesVoulus.Add(ca);
        }

        public List<RessourceEntree> getListRessourceVoulus()
        {
            return ressourcesVoulus;
        }

        public List<Ressource> getRessourceAffectes()
        {
            return ressourcesAffectes;
        }

        public void setRessourceVoulus(List<RessourceEntree> ressourceList)
        {
            ressourcesVoulus = ressourceList;
        }

        public void setRessourceAffectes(List<Ressource> ressourceList)
        {
            ressourcesAffectes = ressourceList;
        }

        public void setPreset(bool preset)
        {
            isPreset = preset;
        }

        public bool getPreset()
        {
            return isPreset;
        }

        public void addRessource(Profil newEmp, Poste poste)
        {


            if (ressourcesVoulus.Count != 0)
            {
                if (ressourcesAffectes.Count == 0)
                {
                    ressourcesAffectes.Add(newEmp);
                }
                else
                {
                    //trie l'employé dès son ajout
                    int coun = 0;
                    while (coun < ressourcesAffectes.Count && ((Profil)ressourcesAffectes[coun]).getAnciennete() <= newEmp.getAnciennete())
                    {
                        coun++;
                    }



                    ressourcesAffectes.Insert(coun, newEmp);


                }
                int i = 0;
                int j = 0;
                //parse la liste des ressources voulues et ensuite la liste des poste de l'employé pour essayer de trouver un match
                while (i < ressourcesVoulus.Count() && ressourcesVoulus[i++].voulue != poste) ;
                --i;

                if (i < ressourcesVoulus.Count())
                {
                    RessourceEntree ressourceAdded = ressourcesVoulus[i];
                    ressourceAdded.nbAffectee++;
                    ressourcesVoulus[i] = ressourceAdded;

                }
            }
            newEmp.setHeuresTravaillees((newEmp.getHeuresTravaillees() + ((Convert.ToInt32(fin.ToString("HH"))) - (Convert.ToInt32(debut.ToString("HH"))))));
            checkCompletion();
           // newEmp.SetPosteAssigne(poste);



        }

        public void addRessource(Equipe newEquipe)
        {
            ressourcesAffectes.Add(newEquipe);


            int i = 0;
            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i++].voulue != newEquipe) ;


            if (i < ressourcesVoulus.Count())
            {
                RessourceEntree ressourceAdded = ressourcesVoulus[--i];
                ressourceAdded.nbAffectee++;
                ressourcesVoulus[i] = ressourceAdded;
            }

            checkCompletion();

        }
        public void addProfil(Profil profil)
        {
            ressourcesAffectes.Add(profil);
        }

        public Profil removeEmplNouv(Poste poste)
        {
            //enlève l'employé le plus noob
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            foreach (Ressource ress in ressourcesAffectes)
            {
                if (ress.getPoste().Count > 0)
                {
                    while (l<ress.getPoste().Count && ress.getPoste()[l] != poste)
                    {
                        l++;

                    }
                }
            }
            if (k >= ressourcesAffectes.Count)
            {
                return null;
            }

            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[k]).getPoste(j))
            {

                j = 0;
                while (j < ((Profil)ressourcesAffectes[k]).getPoste().Count && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[0]).getPoste(j++)) ;
                j--;
                if (ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[k]).getPoste(j))
                    i++;
            }

            RessourceEntree ressourceAdded = ressourcesVoulus[i];
            ressourceAdded.nbAffectee--;
            ressourcesVoulus[i] = ressourceAdded;

            Profil emplKicked = (Profil)ressourcesAffectes[k];
            ressourcesAffectes.RemoveAt(k);
            checkCompletion();

            return (emplKicked);
        }

        public void removeEmpl(int position)
        {
            int j = 0;
            int i = 0;
            while (i < ressourcesVoulus.Count() && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[position]).getPoste(j))
            {

                j = 0;
                while (j < ((Profil)ressourcesAffectes[position]).getPoste().Count && ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[position]).getPoste(j++)) ;
                j--;
                if (ressourcesVoulus[i].voulue != ((Profil)ressourcesAffectes[position]).getPoste(j))
                    i++;
            };

            RessourceEntree ressourceAdded = ressourcesVoulus[i];
            ressourceAdded.nbAffectee--;
            ressourcesVoulus[i] = ressourceAdded;



            ressourcesAffectes.RemoveAt(position);
            checkCompletion();

        }

        public Boolean estVoulue(Ressource ress)
        {
            Boolean oui = false;
            for (int i = 0; i < ressourcesVoulus.Count; i++)
            {


                if (ress == ((Poste)ressourcesVoulus[i].voulue))
                    oui = true;
            }
            if (oui)
             oui = !estDejaPresent(ress);
            
            return oui;
        }

        public DateTime getDebut()
        {
            return debut;
        }

        public DateTime getFin()
        {
            return fin;
        }

        public void setDebut(DateTime laDate)
        {
            debut = laDate;
            computePos();
        }

        public void setFin(DateTime laDate)
        {
            fin = laDate;
            computePos();
        }

        public void computePos()
        {  
            y = (Convert.ToInt32(debut.ToString("HH")) * 20 + Convert.ToInt32(debut.ToString("mm")) / 3) + 40;

            x = ((Loader.SemaineToInt(debut) - 1) * 100) + 40;


            haut = ((Convert.ToInt32(fin.ToString("HH")) * 20 + Convert.ToInt32(fin.ToString("mm")) / 3) - y) + 40;
        return ;}

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getX()
        { return x; }

        public int getY()
        { return y; }

        public int getYFin()
        { return y + haut; }

        public void selectIt()
        { isSelected = true; }

        public void unSelectIt()
        { isSelected = false; }

        public Boolean isMyclick(int clickx, int clicky)
        {
            if (isdrawn)
            {
                if (clickx < this.x && clicky < this.y)
                    return (true);
                else return (false);
            }
            else return (false);

        }


        public RessourceEntree getRessourceVoulus(int position)
        {
            return ressourcesVoulus[position];
        }

        public RessourceEntree getRessourceVoulus(Ressource cellela)
        {
            
            int i=0;
            while(ressourcesVoulus[i++].voulue!=cellela);
            return ressourcesVoulus[--i];
        }

        public int getiRessourceVoulus(Ressource cellela)
        {

            int i = 0;
            while (ressourcesVoulus[i++].voulue != cellela) ;
            return --i;
        }

        public List<RessourceEntree> getRessourceVoulus()
        {
            return ressourcesVoulus;
        }

        public void removeRessourceVoulu(RessourceEntree lui)
        {
            ressourcesVoulus.Remove(lui);
        }

        public Profil getRessourceAffecte(int position)
        {
            if (position < ressourcesAffectes.Count)
            {
                return ((Profil)ressourcesAffectes[position]);
            }
            else
                return null;

        }
        public List<Ressource> getListRessourceAffecte()
        {
            return ressourcesAffectes;
        }
        public bool checkCompletion()
        {
            int i = -1;

            estComplet = true;

            while (++i != ressourcesVoulus.Count)
            {
                if (ressourcesVoulus[i].nbVoulue >= ressourcesVoulus[i].nbAffectee)
                {
                    estComplet = false;
                }
            }

            return estComplet;
        }

        public bool estDejaPresent(Ressource ress)
        {
            Boolean oui = false;
            foreach (Ressource assigne in ressourcesAffectes)
            {
                if (assigne == ress)
                    oui = true;
            }

            return oui;
        }

        public void save(Boolean removeP = false)
        {
            DBConnect proc = new DBConnect();
            if (this.id <= 0 || (this.isPreset && removeP))
            {
                proc.addBlock(debut.ToString("yyyy-MM-dd HH:mm:ss"), fin.ToString("yyyy-MM-dd HH:mm:ss"), typeBloc, isPreset);
                id = Convert.ToInt32(proc.getLastStuff("Block").Rows[0]["idBlock"].ToString());
                isPreset = false;

            }
            else
            {
                proc.modifyBlock(debut.ToString("yyyy-MM-dd HH:mm:ss"), fin.ToString("yyyy-MM-dd HH:mm:ss"), id, isPreset);

                proc.deleteRessource(id);

            }
            foreach (RessourceEntree lui in ressourcesVoulus)
            {
               
                if (lui.voulue is Equipe)
                    proc.addRessource(id, 0, lui.voulue.getId(), lui.nbVoulue);
                else
                    proc.addRessource(id, lui.voulue.getId(), 0, lui.nbVoulue);
            }


        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }
        public String getNom()
        {
            return nom;
        }

        public void draw(int laWidth, Graphics gfx)
        {
            Font laFont = new Font("Arial", 12);
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Cyan);
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            SolidBrush selectedBrush = new SolidBrush((Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(246)))), ((int)(((byte)(134)))))));

            


            if (isSelected == true)
            {
                gfx.DrawRectangle(pen, x, y, laWidth, haut);
                gfx.FillRectangle(selectedBrush, x + 1, y + 1, laWidth - 1, haut - 1);
                gfx.DrawString("(" + id + ")", laFont, fontBrush, x + 15, y + 2);
            }

            else
            {
                gfx.DrawRectangle(pen, x, y, laWidth, haut);
                gfx.FillRectangle(brush, x + 1, y + 1, laWidth - 1, haut - 1);
                gfx.DrawString("(" + id + ")", laFont, fontBrush, x + 15, y + 2);
            }
            isdrawn = true;


            for (int i = 0; i < ressourcesAffectes.Count; i++)
            {
                if (i * 20 < this.haut)
                {
                    ((ressourcesAffectes[i])).draw(this, i, gfx);


                }

            }
        }

        public void undraw()
        {
            isdrawn = false;
        }

        #region IComponent Membres

        public event EventHandler Disposed;

        public ISite Site
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IDisposable Membres

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
