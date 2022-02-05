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
using todosEjercicios.UI.Cap6;
using todosEjercicios.UI.Cap7;

namespace todosEjercicios
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Cpitulo 6
        public void Click_BtnEjercicioC6E1(object sender, RoutedEventArgs e)
        {
            var Ejer1C6 = new Ejer1C6();
            Ejer1C6.Show();
        }
        public void Click_BtnInformacionC6E1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Agregar el cálculo del promedio para el programa con arreglo jagged.");
        }

        public void Click_BtnEjercicioC6E2(object sender, RoutedEventArgs e)
        {
            var Ejer2C6 = new Ejer2C6();
            Ejer2C6.Show();
        }

        public void Click_BtnInformacionC6E2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Agregar el cálculo de la menor calificación para el programa con arreglo jagged.");
        }

        public void Click_BtnEjercicioC6E3(object sender, RoutedEventArgs e)
        {
            var Ejer3C6 = new Ejer3C6();
            Ejer3C6.Show();
        }
        public void Click_BtnInformacionC6E3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.");
        }

        public void Click_BtnEjercicioC6E4(object sender, RoutedEventArgs e)
        {
            var Ejer4C6 = new Ejer4C6();
            Ejer4C6.Show();
        }
        public void Click_BtnInformacionC6E4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Modificar el programa de la escuela para que utilice funciones.");
        }

        public void Click_BtnEjercicioC6E5(object sender, RoutedEventArgs e)
        {
            var Ejer5C6 = new Ejer5C6();
            Ejer5C6.Show();
        }

        public void Click_BtnInformacionC6E5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Crear un programa que pase un arreglo jagged como parámetro a una función.");
        }

        //Capitulo 7
        public void Click_BtnEjercicioC7E1(object sender, RoutedEventArgs e)
        {
            var Ejer1C7 = new Ejer1C7();
            Ejer1C7.Show();
        }
        public void Click_BtnInformacionC7E1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hacer el programa que calcula el promedio, calificación máxima y mínima de un salón de clases usando el ArrayList.");
        }

        public void Click_BtnEjercicioC7E2(object sender, RoutedEventArgs e)
        {
            var Ejer2C7 = new Ejer2C7();
            Ejer2C7.Show();
        }

        public void Click_BtnInformacionC7E2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hacer un programa que funcione como un diccionario, con palabra y definición, usando el Hashtable.");
        }

        public void Click_BtnEjercicioC7E5(object sender, RoutedEventArgs e)
        {
            var Ejer5C7 = new Ejer5C7();
            Ejer5C7.Show();
        }


        public void Click_BtnInformacionC7E5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hacer un programa que funcione como una agenda telefónica y que guarde el nombre de la persona y su número telefónico. ");
        }
    }
}
