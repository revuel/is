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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace paintball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* -------------------------------------- ATRIBUTOS -------------------------------------- */
        List<Jugador> jugadores = new List<Jugador>();
        int contador = 0;
        int limite; // Para no duplicar comprobaciones * Esto os lo tengo que explicar más detalla-
                    // damente

        /* ------------------------------------- CONSTRUCTORES ------------------------------------ */

        public MainWindow()
        {
            InitializeComponent();
        }

        // Este es el constructor usado cuyo parametro de entrada es la lista de jugadores
        public MainWindow(List<Jugador> jugadores)
        {
            this.jugadores = jugadores;
            limite = (jugadores.Count)/2; // cuantas evaluaciones se harán
            InitializeComponent();

            // Timer
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            TimeSpan ts = new TimeSpan(200000);
            timer.Interval = ts;

            timer.Start();


        }

        /* --------------------------------------- EVENTOS --------------------------------------- */
        // EVENTO DE CARGA
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Jugador nuevo in jugadores) // Loop through List with foreach
            {
                comboBox1.Items.Add(nuevo.getId());

                /*comboBox1.Items.Add(nuevo.getPosx());
                comboBox1.Items.Add(nuevo.getPosy());
                comboBox1.Items.Add(nuevo.getEquipo());
                comboBox1.Items.Add(nuevo.getMovs().ToString()); */
            }
        }

        // EVENTO DEL RELOJ
        private void timer_Tick(object sender, EventArgs e)
        {
            picture.Children.Clear();

            foreach (Jugador nuevo in jugadores)
            {
                nuevo.dibujarJugador(picture);
                nuevo.dibujarInflu(picture); // Dibujar jugadores
                nuevo.dibujarVision(picture);
                nuevo.mover(contador); // Movimiento del jugador

                // Imprimir posicion actual del jugador del combobox
                if (nuevo.getId().ToString() == comboBox1.Text.ToString())
                {
                    label1.Content = nuevo.getPosx();
                    label2.Content = nuevo.getPosy();
                }
            }

            conflictos(jugadores); // Detectar enemigos

            contador++; // Siguiente posición (sin uso)
        }

        // COMBOBOX 
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            listBox1.Items.Clear();
            listBox1.Items.Add("DATOS");
            foreach (Jugador nuevo in jugadores)
            {
                if (nuevo.getId().ToString() == comboBox1.Text.ToString())
                {
                    listBox1.Items.Add("Equipo " + nuevo.getEquipo());
                    listBox1.Items.Add("Visión " + nuevo.getVision());
                    listBox1.Items.Add("Influencia " + nuevo.getInflu());
                    listBox1.Items.Add("Estado " + nuevo.getVivo());
                }
            }
        }

        /* -------------------------------------- FUNCIONES -------------------------------------- */

        /*void conflictos(List<Jugador> jugadores)
         {
            foreach (Jugador jugadorA in jugadores) // Loop through List with foreach
            {
                foreach (Jugador jugadorB in jugadores) // Loop through List with foreach
                {
                    if ((jugadorA.getEquipo() != jugadorB.getEquipo()) && (jugadorB.getVivo() == true && jugadorA.getVivo() == true))
                    {
                        double d = Math.Sqrt(((jugadorB.getPosx() - jugadorA.getPosx()) ^ 2) +  ((jugadorA.getPosy() - jugadorB.getPosy()) ^ 2));
                        MessageBox.Show(d.ToString());
                        if (jugadorA.getVision() + jugadorB.getInflu() >= d)
                        {
                            MessageBox.Show("MUERTOOO!!!");
                            comboBox1.Items.Add("contacto");
                            jugadorB.setVivo(false);
         * 
         * 
         * 
         * // Determinando el centro de las elipses (circunferencias)
                                int ax = jugadorA.getPosx() - 50;
                                int ay = jugadorA.getPosx() - 50;
                                int bx = jugadorB.getPosx() - 50;
                                int by = jugadorB.getPosx() - 50;

                                // Distancia entre dos puntos
                                double d = Math.Sqrt(((bx - ax) ^ 2) + ((by - ay) ^ 2));
                                
                                // Determinando si se han visto o no
                                if (((jugadorA.getVision()/2) + (jugadorB.getInflu()/2)) >= d)
                                {
                                    MessageBox.Show("MUERTOOO!!!");
                                    //jugadorB.setVivo(false);
                                }
                        }
                    }
                }
            }
        }*/
        void conflictos(List<Jugador> jugadores)
        {
            int ita = 0;

            foreach (Jugador jugadorA in jugadores) // Loop through List with foreach
            {
                if (ita < limite) // Para no duplicar evaluaciones
                {
                    // Comprobar primero que este jugador esté vivo para ahorrar iteraciones
                    if (jugadorA.getVivo() == true)
                    {
                        // Evaluar a los demás jugadores
                        foreach (Jugador jugadorB in jugadores) // Loop through List with foreach
                        {
                            // Primero comprobar que este vivo
                            if (jugadorB.getVivo() == true)
                            {
                                // Evaluar que sean enemigos
                                if (jugadorA.getEquipo() != jugadorB.getEquipo())
                                {
                                    // distancia de marcado, 10 es los radios de cada jugador
                                    int contacto = jugadorA.getVision() + jugadorB.getInflu() - 10 -2;

                                    // evaluación de las coordenadas y la distancia de marcado
                                    if ((jugadorB.getPosx() - jugadorA.getPosx() < contacto)
                                        && (jugadorB.getPosy() - jugadorA.getPosy() < contacto))
                                    {
                                        MessageBox.Show("MUERTOOO!!!");
                                        jugadorB.setVivo(false);
                                    }
                                }
                            }

                        }
                    }

                    ita++; // Este jugador ya hizo todas sus evaluaciones
                }
            }//end foreach
        }//end function
    }
}
