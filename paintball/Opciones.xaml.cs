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

    public partial class Opciones : Window
    {
        //------------------------------------VARIABLE RANDOM DEL ARMA
        Random rand = new Random();
        
        public Opciones()
        {
            InitializeComponent();
        }

        /* -------------------------------------- ATRIBUTOS -------------------------------------- */

        List<Jugador> jugadores = new List<Jugador>();
        private int n; // Cantidad de jugadores en todo el mapa
        private int m; // Cantidad de movimientos
        List <int> secmovimientos = new List<int>(); // Almacenamiento de los movimientos.

        
        /* --------------------------------------- EVENTOS --------------------------------------- */
        // EVENTO DE CARGA
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        // BOTÓN CONTINUAR
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (controljugadores() == true)
            {
                var batalla = new MainWindow(jugadores);
                batalla.Show();
                this.Close();
            }
        }

        // BOTÓN parámetros elegidos
        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (controlgrupo1() == true)
            {
                // ## Variables de clase ##
                n = int.Parse(comboBox2.Text); // Determinando el número de jugadores total
                m = int.Parse(comboBox3.Text); // Cantidad de movimientos para cada jugador

                // ## Preparación del segundo groupbox ##
                for (int i = 0; i < (n * 2); i++)
                {
                    comboBox1.Items.Add(i); // Cargando el combobox 1 con todos los jugadores.
                }

                for (int i = 0; i < (n * 2); i++)
                {
                    comboBox4.Items.Add(i); // Cargando el combobox 4 un numero determinado de
                }                           // posiciones iniciales

                label7.Content = m; // Movimientos restantes asignables al jugador actual

                groupBox1.IsEnabled = true; // Activar el segundo grupo de controles
                groupBox2.IsEnabled = false; // Desactivar el primero
                desactivarbotonesmovimiento(); // Dejar botones desactivados
            }
        }

        // BOTÓN añadir objetos de la clase jugador al array de jugadores previa selección de
        //      los movimientos programados que realizarán.
        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (controlgrupo2() == true)
            {
                // Creando un nuevo jugador
                Jugador nuevo = new Jugador();


                // Setting atributos
                nuevo.setId("Jugador " + comboBox1.SelectedItem.ToString());
                nuevo.setEquipo(DeterminarEquipo());
                nuevo.setVivo(true);

                nuevo.setVision(50);
                nuevo.setInflu(25);

                //-------------------------------ARMA-----------------
                int auxiliar_arma;
                auxiliar_arma = rand.Next(1, 4);
                nuevo.setArma(auxiliar_arma);

                nuevo.setMovs(secmovimientos);

                // Posición inicial
                switch (comboBox4.Text)
                {
                    case "0":
                        nuevo.setPosx(50);
                        nuevo.setPosy(50);
                        break;
                    case "1":
                        nuevo.setPosx(50);
                        nuevo.setPosy(175);
                        break;
                    case "2":
                        nuevo.setPosx(50);
                        nuevo.setPosy(300);
                        break;
                    case "3":
                        nuevo.setPosx(125);
                        nuevo.setPosy(100);
                        break;
                    case "4":
                        nuevo.setPosx(125);
                        nuevo.setPosy(250);
                        break;
                    case "5":
                        nuevo.setPosx(125);
                        nuevo.setPosy(175);
                        break;
                    case "6":
                        nuevo.setPosx(575);
                        nuevo.setPosy(50);
                        break;
                    case "7":
                        nuevo.setPosx(575);
                        nuevo.setPosy(175);
                        break;
                    case "8":
                        nuevo.setPosx(575);
                        nuevo.setPosy(300);
                        break;
                    case "9":
                        nuevo.setPosx(475);
                        nuevo.setPosy(100);
                        break;
                    case "10":
                        nuevo.setPosx(475);
                        nuevo.setPosy(250);
                        break;
                    case "11":
                        nuevo.setPosx(475);
                        nuevo.setPosy(175);
                        break;
                    default:
                        break;
                }


                // Añadiendo el jugador al vector de jugadores
                jugadores.Add(nuevo);

                // Reiniciando vector de movimientos
                secmovimientos.Clear();

                // Determinando cuantos movimientos harán los jugadores
                m = int.Parse(comboBox3.Text);

                // Quitando elementos de selección de los combobox
                // Quitando al jugador añadido
                comboBox1.Items.Remove(comboBox1.SelectedValue);
                // Quitando la posición incial empleada
                comboBox4.Items.Remove(comboBox4.SelectedValue);
            }
        }

        // BOTONES DE DIRECCION
            // norte
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(0);
            m--;
            label7.Content = m;
        }
            // noreste
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(1);
            m--;
            label7.Content = m;
        }
            // este
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(2);
            m--;
            label7.Content = m;
        }
            // sureste
        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(3);
            m--;
            label7.Content = m;
        }
            // sur
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(4);
            m--;
            label7.Content = m;
        }
            // suroeste
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(5);
            m--;
            label7.Content = m;
        }
            // oeste
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(6);
            m--;
            label7.Content = m;
        }
            //noroeste
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            secmovimientos.Add(7);
            m--;
            label7.Content = m;
        }

        /* -------------------------------------- FUNCIONES -------------------------------------- */
            // asignar equipo
        int DeterminarEquipo()
        {
            if (radioButton1.IsChecked == true)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }
            // Deshabilitar botones de movimientos
        void desactivarbotonesmovimiento()
        {
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false; 
        }

        /* ---------------------------------- CONTROL DE ERRORES --------------------------------- */
        // Control del grouobox1 - parametros inciales
        bool controlgrupo1()
        {
            // Manda cojones que no se puedan usar operadores para concatenar comprobaciones de los
            // estados de los objetos, menuda jodida basura
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Elija número de jugadores por equipo", "CUIDADO", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Elija número de movimientos por jugador", "CUIDADO", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        // Control del groupbox2 - añadir jugador
        bool controlgrupo2()
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un jugador", "CUIDADO", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else if (comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Seleccione la posición inicial del jugador", "CUIDADO", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else if ((radioButton1.IsChecked == false) && (radioButton2.IsChecked == false))
            {
                MessageBox.Show("Debe elegir al menos un equipo", "CUIDADO", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return false;
            }
            else
                return true;
        }

        // Control de acceso a la pantalla de batalla
        bool controljugadores()
        {
            if (jugadores.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
