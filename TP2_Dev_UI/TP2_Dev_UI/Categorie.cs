using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TP2_Dev_UI
{
    public class Categorie 
    {
        public string imagePath { get; set; }
        public string Nom { get; set; }
        public ObservableCollection<Categorie> Noeuds { get; set; } = new ObservableCollection<Categorie>();

        //public ElementAjoute elementAjoute;

        //Ajout du Constructeur par defaut sans arguments
        public Categorie()
        {

        }

        //public Categorie() {
        //    this.Noeuds = new ObservableCollection<Categorie>();
        //}
        public Categorie(string nom) { Nom = nom; }
    }
}
