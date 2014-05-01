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
    public partial class Window1 : Window
    {
        
        /* -------------------------------------- ATRIBUTOS -------------------------------------- */
        List<Jugador> jugadores = new List<Jugador>();
        List <int> secmovimientos = new List<int>(); // Almacenamiento de los movimientos. (not working)
        
        /* ------------------------------------- CONSTRUCTORES ------------------------------------ */
        public Window1()
        {
            InitializeComponent();
        }

        /* --------------------------------------- EVENTOS --------------------------------------- */

        // BOTÓN INICIO CON PARÁMETROS
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var opcions = new Opciones();
            opcions.Show();
            this.Close();
        }

        // BOTÓN INICIO RÁPIDO
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            inicioRapido();
            var batalla = new MainWindow(jugadores);
            batalla.Show();
            this.Close();
        }

        // BOTÓN DE SALIR
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /* -------------------------------------- FUNCIONES -------------------------------------- */
        
        // Función que crea una lista de jugadores con parámetros ya establecidos
        void inicioRapido()
        {

            for (int i = 0; i < 12; i++) // Setting atributos
            {
                // Creando un nuevo jugador
                Jugador nuevo = new Jugador();

                nuevo.setId("Jugador " + i);
                nuevo.setVivo(true);
                nuevo.setVision(50);
                nuevo.setInflu(25);
                nuevo.setMovs(secmovimientos);

                if (i < 6)
                {
                    nuevo.setEquipo(0);
                }
                else
                {
                    nuevo.setEquipo(1);
                }

                switch (i)
                {
                    case 0:
                        nuevo.setPosx(50);
                        nuevo.setPosy(50);
                        break;
                    case 1:
                        nuevo.setPosx(175);
                        nuevo.setPosy(50);
                        break;
                    case 2:
                        nuevo.setPosx(300);
                        nuevo.setPosy(50);
                        break;
                    case 3:
                        nuevo.setPosx(100);
                        nuevo.setPosy(150);
                        break;
                    case 4:
                        nuevo.setPosx(250);
                        nuevo.setPosy(150);
                        break;
                    case 5:
                        nuevo.setPosx(175);
                        nuevo.setPosy(150);
                        break;
                    case 6:
                        nuevo.setPosx(50);
                        nuevo.setPosy(475);
                        break;
                    case 7:
                        nuevo.setPosx(175);
                        nuevo.setPosy(475);
                        break;
                    case 8:
                        nuevo.setPosx(300);
                        nuevo.setPosy(475);
                        break;
                    case 9:
                        nuevo.setPosx(100);
                        nuevo.setPosy(375);
                        break;
                    case 10:
                        nuevo.setPosx(250);
                        nuevo.setPosy(375);
                        break;
                    case 11:
                        nuevo.setPosx(175);
                        nuevo.setPosy(375);
                        break;
                    default:
                        break;
                }

                // Añadiendo el jugador al vector de jugadores
                jugadores.Add(nuevo);
            }
        }
    }
}
