using System;
using System.Collections;
using System.Windows;
using todosEjercicios.UI.Cap7;

namespace todosEjercicios.UI.Cap7
{
    public partial class Ejer1C7 : Window
    {
        //variables global
        public bool paso = false;
        public bool Agregar_Alumno = false;
        public int Cantidad_Alumno = 0;
        public int Suma_Calificaciones = 0;
        public int Calificacion_Maxima = 0;
        public int Calificacion_Minima = 0;
        public int Promedio_Calificaciones = 0;
        public ArrayList Alumnos = new ArrayList();
        public Ejer1C7()
        {
            InitializeComponent();
        }
        public void Click_btnAgregar(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TextBoxCantidadAlumnos.Text) || string.IsNullOrEmpty(TextBoxCantidadAlumnos.Text))
            {
                MessageBox.Show("Aun no a puesto un numero");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxCantidadAlumnos.Text, "[^0-9]"))
            {
                MessageBox.Show("Aun no a puesto un numero valido");
            }
            else
            {
                TextBoxCantidadAlumnos.IsEnabled = false;
                TextBoxCalificacionAlumno.IsEnabled = true;

                if (Agregar_Alumno == true)
                {
                    if (String.IsNullOrWhiteSpace(TextBoxCalificacionAlumno.Text) || string.IsNullOrEmpty(TextBoxCalificacionAlumno.Text))
                    {
                        MessageBox.Show("Aun no a puesto una calificacion");
                    }
                    else if (System.Text.RegularExpressions.Regex.IsMatch(TextBoxCalificacionAlumno.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Aun no a puesto una calificacion validad");
                    }
                    else
                    {
                        resultados();
                    }

                }
                else
                {
                    Agregar_Alumno = true;
                }
            }
        }

        public void resultados()
        {
           
            Alumnos.Add(Convert.ToInt32(TextBoxCalificacionAlumno.Text));

            if (paso == false)
            {
                Calificacion_Minima = Convert.ToInt32(TextBoxCalificacionAlumno.Text);
                paso = true;
                Cantidad_Alumno = Convert.ToInt32(TextBoxCantidadAlumnos.Text);
                TextBoxCalificacionAlumno.Text = "";
            }

            TextBoxCantidadAlumnos.Text = Convert.ToString(Convert.ToInt32(TextBoxCantidadAlumnos.Text) - 1);


            if (TextBoxCantidadAlumnos.Text == "0")
            {


                foreach (int i in Alumnos)
                {
                    if (i > Calificacion_Maxima)
                        Calificacion_Maxima = Convert.ToInt32(TextBoxCalificacionAlumno.Text);

                    if (i < Calificacion_Minima)
                        Calificacion_Minima = Convert.ToInt32(TextBoxCalificacionAlumno.Text);

                    Suma_Calificaciones += i;
                }

                Alumnos = new ArrayList();
                Promedio_Calificaciones = Suma_Calificaciones / Cantidad_Alumno;
                TextBoxCalificacionMaxAlumnos.Text = Convert.ToString(Calificacion_Maxima);
                TextBoxCalificacionMinAlumnos.Text = Convert.ToString(Calificacion_Minima);
                TextBoxPromedioAlumnos.Text = Convert.ToString(Promedio_Calificaciones);
            }

        }
        public void Click_btnLimpiar(object sender, RoutedEventArgs e)
        {

            TextBoxCantidadAlumnos.Text = "";
            TextBoxCalificacionAlumno.Text = "";
            TextBoxCantidadAlumnos.IsEnabled = true;
            TextBoxCalificacionAlumno.IsEnabled = false;
            TextBoxCalificacionMaxAlumnos.Text = "Calificacion Maxima";
            TextBoxCalificacionMinAlumnos.Text = "Calificacion Minima";
            TextBoxPromedioAlumnos.Text = "Promedio";
            paso = false;
            Agregar_Alumno = false;
            Cantidad_Alumno = 0;
            Suma_Calificaciones = 0;
            Calificacion_Maxima = 0;
            Calificacion_Minima = 0;
            Promedio_Calificaciones = 0;
        }

    }

}