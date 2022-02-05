using System;
using System.Collections;
using System.Windows;

namespace todosEjercicios.UI.Cap7
{

    public partial class Ejer2C7 : Window
    {

        public Ejer2C7()
        {
            InitializeComponent();
        }

        Hashtable PalabrasDominicanas = new Hashtable();

        public void Click_btnBuscar(object sender, RoutedEventArgs e)
        {
            CargarDefiniciones();
            TextDeficinicion.Text = PalabrasDominicanas[TextBoxNombre.Text.ToUpper()] as string;

            if(!PalabrasDominicanas.Contains(TextBoxNombre.Text.ToUpper()))
                TextDeficinicion.Text = "Definicion no disponible.";
        
            PalabrasDominicanas = new Hashtable();
        }


        public void CargarDefiniciones()
        {
            PalabrasDominicanas.Add("DIMELO", "Expresión que vendría a significar ¿Cómo estás?.");
            PalabrasDominicanas.Add("GUAGUA", "Nombre con el que se conoce a los autobuses de transporte público.");
            PalabrasDominicanas.Add("PEJE", "Sinónimo de pez.");
            PalabrasDominicanas.Add("YALA", "Expresión que se usa para decir: vale.");
            PalabrasDominicanas.Add("COLMADO", "Un negocio familiar donde se venden artículos de conveniencia.");
            PalabrasDominicanas.Add("PIQUE", "Sinónimo de enfado.");
            PalabrasDominicanas.Add("VAINA", "Palabra genérica que sirve como sustitutivo de cualquier cosa.");
        }
        









        

    }

}