using System.Collections.Generic;
using System.Windows;
using todosEjercicios.UI.Cap7;

namespace todosEjercicios.UI.Cap7
{
    public partial class Ejer5C7 : Window
    {
        List<AgendaDatos> agenda = new List<AgendaDatos>();
        public Ejer5C7()
        {
            InitializeComponent();
        }
        public void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            TextBoxNombre.Text = "";
            TextBoxTelefono.Text = "";
        }
        public void Click_btnAgregar(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) || string.IsNullOrWhiteSpace(TextBoxTelefono.Text))
            {
                MessageBox.Show("Introduce datos..");
            }
            else
            {
                AgendaDatos persona = new AgendaDatos();
                persona.nombre = TextBoxNombre.Text;
                persona.telefono = TextBoxTelefono.Text;
                agenda.Add(persona);

                TextBoxNombre.Text = "";
                TextBoxTelefono.Text = "";

                DatosDataGrid.ItemsSource = null;
                DatosDataGrid.ItemsSource = agenda;
            }
        }
    }
}