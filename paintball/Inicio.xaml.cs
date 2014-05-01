using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace paintball
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        /* --------------------------------------- EVENTOS --------------------------------------- */

        // BOTÓN NUEVA PARTIDA
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var opcions = new Opciones();
            opcions.Show();
            this.Close();
        }

        // BOTÓN DE SALIR
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
