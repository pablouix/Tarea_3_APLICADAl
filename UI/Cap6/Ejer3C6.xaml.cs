using System;
using System.Windows;
using Microsoft.VisualBasic;

namespace todosEjercicios.UI.Cap6
{

    public partial class Ejer3C6 : Window
    {
        public int cantidad = 0; // Cantidad de alumnos
        public int salones = 0; // Cantidad de salones
        public int n = 0; // Variable de control de ciclo salones
        public int m = 0; // Variable de control del ciclo alumnos
        public string valor = "";
        // Variables para el promedio
        public float suma = 0.0f;
        public float promedio = 0.0f;
        public float maxima = 0.0f;
        public Ejer3C6()
        {
            InitializeComponent();
        }
        public void Click_btnAgregar(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxCantidadSalon.Text))
            {
                MessageBox.Show("Digita el numero");
            }
            else
            {
                salones = Convert.ToInt32(TextBoxCantidadSalon.Text);

                float[][] calif = new float[salones][];
                float[] promedio = new float[salones];

                for (n = 0; n < salones; n++) // Ciclo salones
                {
                    cantidad = Convert.ToInt32(Interaction.InputBox("Digita el numero de alumnos para el salon " + (n + 1), "Cantidad de Alumnos"));
                    // Instanciamos el arreglo
                    calif[n] = new float[cantidad];
                }


                // Capturamos la información
                for (n = 0; n < salones; n++) // Ciclo salones
                {
                    for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                    {
                        calif[n][m] = Convert.ToInt32(Interaction.InputBox("Digita la calificacion del alumno " + (m + 1) + " del salon " + (n + 1), "Calificacion de Alumno"));
                        suma += calif[n][m];
                        if (calif[n][m] > maxima)
                            maxima = calif[n][m];
                    }
                    promedio[n] = suma / calif[n].GetLength(0);
                    suma = 0;
                }

                for (int n = 0; n < salones; n++)
                {
                    ListViewPromedio.Items.Add("Promedio del salon " + (n + 1) + ": " + promedio[n].ToString());
                }

                TextBoxCalificacionMaximaSalon.Text = Convert.ToString(maxima);
            }
        }
        public void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {
            TextBoxCantidadSalon.Text = "";
            ListViewPromedio.Items.Clear();
            TextBoxCalificacionMaximaSalon.Text = "";
            maxima = 0;
        }
    }

}