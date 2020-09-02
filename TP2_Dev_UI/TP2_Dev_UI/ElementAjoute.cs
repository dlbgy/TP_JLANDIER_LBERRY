using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Media;

namespace TP2_Dev_UI
{


    public class ElementAjoute
    {
       public string NomIcone { get; set; }
       public string Nom { get; set; }
       public string TypeElement { get; set; }
       public string DescriptionElement { get; set; }
       
        //public string imagePath { get; set; }

        // Ajout du Constructeur par defaut sans arguments
        public ElementAjoute()
        { }

       public ElementAjoute(string nomIcone, string nom, string typeElement, string descriptionElement)
       {
            this.NomIcone = nomIcone;
            this.Nom = nom;
            this.TypeElement = typeElement;
            this.DescriptionElement = descriptionElement;
       }
    }

/*
    private void LoadImage(string imageName)
    {

        this.canvas.Children.Clear();

        Image image = new Image();

        string newImageName = "pack://application:,,,/Resources/" + imageName + ".png";

        image.Stretch = Stretch.Fill;
        image.Source = (new ImageSourceConverter()).ConvertFromString(newImageName) as ImageSource;

        this.canvas.Children.Add(image);

    }*/
}
