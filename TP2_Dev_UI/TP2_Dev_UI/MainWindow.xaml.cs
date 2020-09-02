using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        ObservableCollection<ElementAjoute> elementAjoutes = new ObservableCollection<ElementAjoute>();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this.GetElements();
        }

        public ObservableCollection<ElementAjoute> GetElements()
        {

            Categorie installe = new Categorie() { imagePath = "1.png", Nom = "Installe" };
            installe.Noeuds.Add( new Categorie() { imagePath = "Image/AddClass.png", Nom = "General" });
            installe.Noeuds.Add(new Categorie() { imagePath = "Image/AddComponent.png", Nom = "WPF" });
                Categorie visualC = new Categorie() { imagePath = "Image/AddItem.png", Nom = "Element Visual C#" };
                installe.Noeuds.Add(visualC);
                visualC.Noeuds.Add(new Categorie() { imagePath = "Image/AddScreen.png", Nom = "General" });
                visualC.Noeuds.Add(new Categorie() { imagePath = "Image/AddTablet.png", Nom = "WPF" });
            Categorie enLigne = new Categorie() { imagePath = "Image/AddWindow.png", Nom = "En Ligne" };
                enLigne.Noeuds.Add(new Categorie() { imagePath = "Image/Interface.png", Nom = "General" });
                enLigne.Noeuds.Add(new Categorie() { imagePath = "Image/WPFApplication.png", Nom = "WPF" });

            /*child1.Noeuds.Add(new Categorie() { Nom = "Element Visual C" });
            racine1.Noeuds.Add(child1);*/

            //Categorie racine1 = new Categorie("Installé");
            //racine1.Noeuds.Add(new Categorie("Général"));

            TrvCategorie.Items.Add(installe);
            TrvCategorie.Items.Add(enLigne);

            listbox1.ItemsSource = elementAjoutes;

            return elementAjoutes;
        }
    }

}
