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

            alumnos.Add(new Alumno("aaaa", 9.1f, 2));
            alumnos.Add(new Alumno("Jgse", 9.2f, 23));
            alumnos.Add(new Alumno("Joge", 9.4f, 1));
            alumnos.Add(new Alumno("Jgse", 9.6f, 0));
            alumnos.Add(new Alumno("Jose", 9.3f, 3));
            alumnos.Add(new Alumno("Joge", 8.1f, 3));
            alumnos.Add(new Alumno("Jdse", 5.1f, 7));
            alumnos.Add(new Alumno("Jofe", 4.1f, 8));

            lstNumeros.ItemsSource = alumnos;
            //lstNumeros.ItemsSource = miLista;
        }

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

        private void BtnOrdenarBubble_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < miLista.Count - 1; i++)
                {
                    if (miLista[i] > miLista[i + 1])
                    {
                        int temp = miLista[i];
                        miLista[i] = miLista[i + 1];
                        miLista[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } while (intercambio);
        }
    }
}
