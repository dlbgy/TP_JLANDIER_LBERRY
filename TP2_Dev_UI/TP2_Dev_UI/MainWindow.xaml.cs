using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP2_Dev_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Categorie installe = new Categorie() { Nom = "Installe" };
            installe.Noeuds.Add( new Categorie() { Nom = "General" });
            installe.Noeuds.Add(new Categorie() { Nom = "WPF" });
                Categorie visualC = new Categorie() { Nom = "Element Visual C#" };
                installe.Noeuds.Add(visualC);
                visualC.Noeuds.Add(new Categorie() { Nom = "General" });
                visualC.Noeuds.Add(new Categorie() { Nom = "WPF" });
            Categorie enLigne = new Categorie() { Nom = "En Ligne" };
                enLigne.Noeuds.Add(new Categorie() { Nom = "General" });
                enLigne.Noeuds.Add(new Categorie() { Nom = "WPF" });

            /*child1.Noeuds.Add(new Categorie() { Nom = "Element Visual C" });
            racine1.Noeuds.Add(child1);*/

            //Categorie racine1 = new Categorie("Installé");
            //racine1.Noeuds.Add(new Categorie("Général"));

            TrvCategorie.Items.Add(installe);
            TrvCategorie.Items.Add(enLigne);
        }
    }

    //Un test
}
