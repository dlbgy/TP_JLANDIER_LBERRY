using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Media;

namespace TP2_Dev_UI
{
    class ElementAjoute
    {
       string NomIcone { get; set; }
       string NomElement { get; set; }
       string TypeElement { get; set; }
       string DescriptionElement { get; set; }

       ElementAjoute(string nomIcone, string nomElement, string typeElement, string descriptionElement)
       {
            this.NomIcone = nomIcone;
            this.NomElement = nomElement;
            this.TypeElement = typeElement;
            this.DescriptionElement = descriptionElement;
       }
    }
}
