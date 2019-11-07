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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(54);
            miLista.Add(69);
            miLista.Add(420);
            miLista.Add(666);
            miLista.Add(911);
            miLista.Add(1444);
            miLista.Add(13);
            miLista.Add(404);

            alumnos.Add(new Alumno("pepe", 9.1f, 2));
            alumnos.Add(new Alumno("Jose", 9.2f, 23));
            alumnos.Add(new Alumno("sara", 9.4f, 1));
            alumnos.Add(new Alumno("oscar", 9.6f, 0));
            alumnos.Add(new Alumno("juan", 9.3f, 3));
            alumnos.Add(new Alumno("Julio", 8.1f, 3));
            alumnos.Add(new Alumno("ramon", 5.1f, 7));
            alumnos.Add(new Alumno("pita", 4.1f, 8));

            lstNumeros.ItemsSource = alumnos;
            //lstNumeros.ItemsSource = miLista;
        }

        //Shell Promedio
        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLista[0];
            miLista[0] = miLista[3];
            miLista[3] = temp;*/

            int gap, i, j;
            gap = alumnos.Count / 2;
            //ahhh
            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].promedio > alumnos[gap + i].promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        //Bubble Promedio
        private void BtnOrdenarBubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < miLista.Count - 1; i++)
                {
                    if (alumnos[i].promedio > alumnos[i + 1].promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }

        //Shell Faltas
        private void BtnOrdenarShellFaltas_Click(object sender, RoutedEventArgs e)
        {
            int gap, i, j;
            gap = alumnos.Count / 2;
            //ahhh
            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].faltas > alumnos[gap + i].faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        //Bubble Faltas

        private void BtnOrdenarBubbleFaltas_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < miLista.Count - 1; i++)
                {
                    if (alumnos[i].faltas > alumnos[i + 1].faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }
    }
}
