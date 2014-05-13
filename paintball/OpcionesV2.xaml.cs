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
using System.Threading;

namespace paintball
{
    /// <summary>
    /// Interaction logic for Opciones2.xaml
    /// </summary>
    public partial class OpcionesV2 : Window
    {
        List<Jugador> jugadores = new List<Jugador>();
        List<int> secmovimientos = new List<int>(); // Almacenamiento de los movimientos. (not working)
        int tacticaRojo = 2, tacticaAzul = 3;
        int numJugRojo = 0, numJugAzul = 0;

        Random rand = new Random();

        public OpcionesV2()
        {
            InitializeComponent();
        }

        #region Eventos de activación de checkBox

        //Este evento sucede cuando se hace click en el checkBox activo1
        private void activo1_Click(object sender, RoutedEventArgs e)
        {
            if (nombre1.IsEnabled == false)//Si están deshabilitadas...
            {
                nombre1.IsEnabled = true;//...se habilitan todas las posibilidades de configuración
                vision1.IsEnabled = true;
                influencia1.IsEnabled = true;
                arma1.IsEnabled = true;
                numJugRojo++;
            }
            else//Si están habilitadas...
            {
                nombre1.IsEnabled = false;//...se deshabilitan todas las posibilidades de configuración
                vision1.IsEnabled = false;
                influencia1.IsEnabled = false;
                arma1.IsEnabled = false;
                numJugRojo--;
            }
        }

        private void activo2_Click(object sender, RoutedEventArgs e)
        {
            if (nombre2.IsEnabled == false)
            {
                nombre2.IsEnabled = true;
                vision2.IsEnabled = true;
                influencia2.IsEnabled = true;
                arma2.IsEnabled = true;
                numJugRojo++;
            }
            else
            {
                nombre2.IsEnabled = false;
                vision2.IsEnabled = false;
                influencia2.IsEnabled = false;
                arma2.IsEnabled = false;
                numJugRojo--;
            }
        }

        private void activo3_Click(object sender, RoutedEventArgs e)
        {
            if (nombre3.IsEnabled == false)
            {
                nombre3.IsEnabled = true;
                vision3.IsEnabled = true;
                influencia3.IsEnabled = true;
                arma3.IsEnabled = true;
                numJugRojo++;
            }
            else
            {
                nombre3.IsEnabled = false;
                vision3.IsEnabled = false;
                influencia3.IsEnabled = false;
                arma3.IsEnabled = false;
                numJugRojo--;
            }
        }

        private void activo4_Click(object sender, RoutedEventArgs e)
        {
            if (nombre4.IsEnabled == false)
            {
                nombre4.IsEnabled = true;
                vision4.IsEnabled = true;
                influencia4.IsEnabled = true;
                arma4.IsEnabled = true;
                numJugRojo++;
            }
            else
            {
                nombre4.IsEnabled = false;
                vision4.IsEnabled = false;
                influencia4.IsEnabled = false;
                arma4.IsEnabled = false;
                numJugRojo--;
            }
        }

        private void activo5_Click(object sender, RoutedEventArgs e)
        {
            if (nombre5.IsEnabled == false)
            {
                nombre5.IsEnabled = true;
                vision5.IsEnabled = true;
                influencia5.IsEnabled = true;
                arma5.IsEnabled = true;
                numJugRojo++;
            }
            else
            {
                nombre5.IsEnabled = false;
                vision5.IsEnabled = false;
                influencia5.IsEnabled = false;
                arma5.IsEnabled = false;
                numJugRojo--;
            }
        }

        private void activo6_Click(object sender, RoutedEventArgs e)
        {
            if (nombre6.IsEnabled == false)
            {
                nombre6.IsEnabled = true;
                vision6.IsEnabled = true;
                influencia6.IsEnabled = true;
                arma6.IsEnabled = true;
                numJugRojo++;
            }
            else
            {
                nombre6.IsEnabled = false;
                vision6.IsEnabled = false;
                influencia6.IsEnabled = false;
                arma6.IsEnabled = false;
                numJugRojo--;
            }
        }

        private void activo7_Click(object sender, RoutedEventArgs e)
        {
            if (nombre7.IsEnabled == false)
            {
                nombre7.IsEnabled = true;
                vision7.IsEnabled = true;
                influencia7.IsEnabled = true;
                arma7.IsEnabled = true;

                numJugAzul++;
            }
            else
            {
                nombre7.IsEnabled = false;
                vision7.IsEnabled = false;
                influencia7.IsEnabled = false;
                arma7.IsEnabled = false;
                numJugAzul--;
            }
        }

        private void activo8_Click(object sender, RoutedEventArgs e)
        {
            if (nombre8.IsEnabled == false)
            {
                nombre8.IsEnabled = true;
                vision8.IsEnabled = true;
                influencia8.IsEnabled = true;
                arma8.IsEnabled = true;
                numJugAzul++;
            }
            else
            {
                nombre8.IsEnabled = false;
                vision8.IsEnabled = false;
                influencia8.IsEnabled = false;
                arma8.IsEnabled = false;
                numJugAzul--;
            }
        }

        private void activo9_Click(object sender, RoutedEventArgs e)
        {
            if (nombre9.IsEnabled == false)
            {
                nombre9.IsEnabled = true;
                vision9.IsEnabled = true;
                influencia9.IsEnabled = true;
                arma9.IsEnabled = true;
                numJugAzul++;
            }
            else
            {
                nombre9.IsEnabled = false;
                vision9.IsEnabled = false;
                influencia9.IsEnabled = false;
                arma9.IsEnabled = false;
                numJugAzul--;
            }
        }

        private void activo10_Click(object sender, RoutedEventArgs e)
        {
            if (nombre10.IsEnabled == false)
            {
                nombre10.IsEnabled = true;
                vision10.IsEnabled = true;
                influencia10.IsEnabled = true;
                arma10.IsEnabled = true;
                numJugAzul++;
            }
            else
            {
                nombre10.IsEnabled = false;
                vision10.IsEnabled = false;
                influencia10.IsEnabled = false;
                arma10.IsEnabled = false;
                numJugAzul--;
            }
        }

        private void activo11_Click(object sender, RoutedEventArgs e)
        {
            if (nombre11.IsEnabled == false)
            {
                nombre11.IsEnabled = true;
                vision11.IsEnabled = true;
                influencia11.IsEnabled = true;
                arma11.IsEnabled = true;
                numJugAzul++;
            }
            else
            {
                nombre11.IsEnabled = false;
                vision11.IsEnabled = false;
                influencia11.IsEnabled = false;
                arma11.IsEnabled = false;
                numJugAzul--;
            }
        }

        private void activo12_Click(object sender, RoutedEventArgs e)
        {
            if (nombre12.IsEnabled == false)
            {
                nombre12.IsEnabled = true;
                vision12.IsEnabled = true;
                influencia12.IsEnabled = true;
                arma12.IsEnabled = true;
                numJugAzul++;
            }
            else
            {
                nombre12.IsEnabled = false;
                vision12.IsEnabled = false;
                influencia12.IsEnabled = false;
                arma12.IsEnabled = false;
                numJugAzul--;
            }
        }
        #endregion

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            switch (tacticaRojo)
            { 
                case 1: //He dejado las que estaban default porque es libre y aun no esta implementado
                    for (int i = 1; i < numJugRojo; i++)
                   #region Configurar y añadir jugador 1 en caso de que esté activo
                        if (activo1.IsChecked == true)
                        {
                            Jugador jugador1 = new Jugador();
                            jugador1.setEquipo(0);
                            jugador1.setPosx(50);
                            jugador1.setPosy(50);
                            jugador1.setVivo(true);
                            jugador1.setId(nombre1.Text);
                            jugador1.setVision(int.Parse(vision1.Text));
                            jugador1.setInflu(int.Parse(influencia1.Text));
                            jugador1.setArma(int.Parse(arma1.Text));
                            //jugador1.setMovimientos
                            jugadores.Add(jugador1);

                        }
            #endregion
                   #region Configurar y añadir jugador 2 en caso de que esté activo
            if (activo2.IsChecked == true)
            {
                Jugador jugador2 = new Jugador();
                jugador2.setEquipo(0);
                jugador2.setPosx(50);
                jugador2.setPosy(175);
                jugador2.setVivo(true);
                jugador2.setId(nombre2.Text);
                jugador2.setVision(int.Parse(vision2.Text));
                jugador2.setInflu(int.Parse(influencia2.Text));
                jugador2.setArma(int.Parse(arma2.Text));
                //jugador2.setMovimientos
                jugadores.Add(jugador2);
            }
            #endregion
                   #region Configurar y añadir jugador 3 en caso de que esté activo
            if (activo3.IsChecked == true)
            {
                Jugador jugador3 = new Jugador();
                jugador3.setEquipo(0);
                jugador3.setPosx(50);
                jugador3.setPosy(300);
                jugador3.setVivo(true);
                jugador3.setId(nombre3.Text);
                jugador3.setVision(int.Parse(vision3.Text));
                jugador3.setInflu(int.Parse(influencia3.Text));
                jugador3.setArma(int.Parse(arma3.Text));
                //jugador3.setMovimientos
                jugadores.Add(jugador3);
            }
            #endregion
                   #region Configurar y añadir jugador 4 en caso de que esté activo
            if (activo4.IsChecked == true)
            {
                Jugador jugador4 = new Jugador();
                jugador4.setEquipo(0);
                jugador4.setPosx(125);
                jugador4.setPosy(100);
                jugador4.setVivo(true);
                jugador4.setId(nombre4.Text);
                jugador4.setVision(int.Parse(vision4.Text));
                jugador4.setInflu(int.Parse(influencia4.Text));
                jugador4.setArma(int.Parse(arma4.Text));
                //jugador6.setMovimientos
                jugadores.Add(jugador4);
            }
            #endregion
                   #region Configurar y añadir jugador 5 en caso de que esté activo
            if (activo5.IsChecked == true)
            {
                Jugador jugador5 = new Jugador();
                jugador5.setEquipo(0);
                jugador5.setPosx(125);
                jugador5.setPosy(250);
                jugador5.setVivo(true);
                jugador5.setId(nombre5.Text);
                jugador5.setVision(int.Parse(vision5.Text));
                jugador5.setInflu(int.Parse(influencia5.Text));
                jugador5.setArma(int.Parse(arma5.Text));
                //jugador5.setMovimientos
                jugadores.Add(jugador5);
            }
            #endregion
                   #region Configurar y añadir jugador 6 en caso de que esté activo
            if (activo6.IsChecked == true)
            {
                Jugador jugador6 = new Jugador();
                jugador6.setEquipo(0);
                jugador6.setPosx(125);
                jugador6.setPosy(175);
                jugador6.setVivo(true);
                jugador6.setId(nombre6.Text);
                jugador6.setVision(int.Parse(vision6.Text));
                jugador6.setInflu(int.Parse(influencia6.Text));
                jugador6.setArma(int.Parse(arma6.Text));
                //jugador6.setMovimientos
                jugadores.Add(jugador6);
            }
            #endregion
                    break;
                case 2: //Punta de flecha
                    #region Configurar y añadir jugador 1 en caso de que esté activo
            if (activo1.IsChecked==true)
            {
                Jugador jugador1 = new Jugador();
                jugador1.setEquipo(0);
                jugador1.setPosx(50);
                jugador1.setPosy(50);
                jugador1.setVivo(true);
                jugador1.setId(nombre1.Text);
                jugador1.setVision(int.Parse(vision1.Text));
                jugador1.setInflu(int.Parse(influencia1.Text));
                jugador1.setArma(int.Parse(arma1.Text));
                //jugador1.setMovimientos
                jugadores.Add(jugador1);

            }
            #endregion
                    #region Configurar y añadir jugador 2 en caso de que esté activo
            if (activo2.IsChecked == true)
            {
                Jugador jugador2 = new Jugador();
                jugador2.setEquipo(0);
                jugador2.setPosx(100);
                jugador2.setPosy(100);
                jugador2.setVivo(true);
                jugador2.setId(nombre2.Text);
                jugador2.setVision(int.Parse(vision2.Text));
                jugador2.setInflu(int.Parse(influencia2.Text));
                jugador2.setArma(int.Parse(arma2.Text));
                //jugador2.setMovimientos
                jugadores.Add(jugador2);
            }
            #endregion
                    #region Configurar y añadir jugador 3 en caso de que esté activo
            if (activo3.IsChecked == true)
            {
                Jugador jugador3 = new Jugador();
                jugador3.setEquipo(0);
                jugador3.setPosx(150);
                jugador3.setPosy(150);
                jugador3.setVivo(true);
                jugador3.setId(nombre3.Text);
                jugador3.setVision(int.Parse(vision3.Text));
                jugador3.setInflu(int.Parse(influencia3.Text));
                jugador3.setArma(int.Parse(arma3.Text));
                //jugador3.setMovimientos
                jugadores.Add(jugador3);
            }
            #endregion
                    #region Configurar y añadir jugador 4 en caso de que esté activo
            if (activo4.IsChecked == true)
            {
                Jugador jugador4 = new Jugador();
                jugador4.setEquipo(0);
                jugador4.setPosx(150);
                jugador4.setPosy(200);
                jugador4.setVivo(true);
                jugador4.setId(nombre4.Text);
                jugador4.setVision(int.Parse(vision4.Text));
                jugador4.setInflu(int.Parse(influencia4.Text));
                jugador4.setArma(int.Parse(arma4.Text));
                //jugador6.setMovimientos
                jugadores.Add(jugador4);
            }
            #endregion
                    #region Configurar y añadir jugador 5 en caso de que esté activo
            if (activo5.IsChecked == true)
            {
                Jugador jugador5 = new Jugador();
                jugador5.setEquipo(0);
                jugador5.setPosx(100);
                jugador5.setPosy(250);
                jugador5.setVivo(true);
                jugador5.setId(nombre5.Text);
                jugador5.setVision(int.Parse(vision5.Text));
                jugador5.setInflu(int.Parse(influencia5.Text));
                jugador5.setArma(int.Parse(arma5.Text));
                //jugador5.setMovimientos
                jugadores.Add(jugador5);
            }
            #endregion
                    #region Configurar y añadir jugador 6 en caso de que esté activo
            if (activo6.IsChecked == true)
            {
                Jugador jugador6 = new Jugador();
                jugador6.setEquipo(0);
                jugador6.setPosx(50);
                jugador6.setPosy(300);
                jugador6.setVivo(true);
                jugador6.setId(nombre6.Text);
                jugador6.setVision(int.Parse(vision6.Text));
                jugador6.setInflu(int.Parse(influencia6.Text));
                jugador6.setArma(int.Parse(arma6.Text));
                //jugador6.setMovimientos
                jugadores.Add(jugador6);
            }
            #endregion
                    break;
                case 3: //punta de flecha inversa
                    #region Configurar y añadir jugador 1 en caso de que esté activo
            if (activo1.IsChecked==true)
            {
                Jugador jugador1 = new Jugador();
                jugador1.setEquipo(0);
                jugador1.setPosx(150);
                jugador1.setPosy(50);
                jugador1.setVivo(true);
                jugador1.setId(nombre1.Text);
                jugador1.setVision(int.Parse(vision1.Text));
                jugador1.setInflu(int.Parse(influencia1.Text));
                jugador1.setArma(int.Parse(arma1.Text));
                //jugador1.setMovimientos
                jugadores.Add(jugador1);

            }
            #endregion
                    #region Configurar y añadir jugador 2 en caso de que esté activo
            if (activo2.IsChecked == true)
            {
                Jugador jugador2 = new Jugador();
                jugador2.setEquipo(0);
                jugador2.setPosx(100);
                jugador2.setPosy(100);
                jugador2.setVivo(true);
                jugador2.setId(nombre2.Text);
                jugador2.setVision(int.Parse(vision2.Text));
                jugador2.setInflu(int.Parse(influencia2.Text));
                jugador2.setArma(int.Parse(arma2.Text));
                //jugador2.setMovimientos
                jugadores.Add(jugador2);
            }
            #endregion
                    #region Configurar y añadir jugador 3 en caso de que esté activo
            if (activo3.IsChecked == true)
            {
                Jugador jugador3 = new Jugador();
                jugador3.setEquipo(0);
                jugador3.setPosx(50);
                jugador3.setPosy(150);
                jugador3.setVivo(true);
                jugador3.setId(nombre3.Text);
                jugador3.setVision(int.Parse(vision3.Text));
                jugador3.setInflu(int.Parse(influencia3.Text));
                jugador3.setArma(int.Parse(arma3.Text));
                //jugador3.setMovimientos
                jugadores.Add(jugador3);
            }
            #endregion
                    #region Configurar y añadir jugador 4 en caso de que esté activo
            if (activo4.IsChecked == true)
            {
                Jugador jugador4 = new Jugador();
                jugador4.setEquipo(0);
                jugador4.setPosx(50);
                jugador4.setPosy(200);
                jugador4.setVivo(true);
                jugador4.setId(nombre4.Text);
                jugador4.setVision(int.Parse(vision4.Text));
                jugador4.setInflu(int.Parse(influencia4.Text));
                jugador4.setArma(int.Parse(arma4.Text));
                //jugador6.setMovimientos
                jugadores.Add(jugador4);
            }
            #endregion
                    #region Configurar y añadir jugador 5 en caso de que esté activo
            if (activo5.IsChecked == true)
            {
                Jugador jugador5 = new Jugador();
                jugador5.setEquipo(0);
                jugador5.setPosx(100);
                jugador5.setPosy(250);
                jugador5.setVivo(true);
                jugador5.setId(nombre5.Text);
                jugador5.setVision(int.Parse(vision5.Text));
                jugador5.setInflu(int.Parse(influencia5.Text));
                jugador5.setArma(int.Parse(arma5.Text));
                //jugador5.setMovimientos
                jugadores.Add(jugador5);
            }
            #endregion
                    #region Configurar y añadir jugador 6 en caso de que esté activo
            if (activo6.IsChecked == true)
            {
                Jugador jugador6 = new Jugador();
                jugador6.setEquipo(0);
                jugador6.setPosx(150);
                jugador6.setPosy(300);
                jugador6.setVivo(true);
                jugador6.setId(nombre6.Text);
                jugador6.setVision(int.Parse(vision6.Text));
                jugador6.setInflu(int.Parse(influencia6.Text));
                jugador6.setArma(int.Parse(arma6.Text));
                //jugador6.setMovimientos
                jugadores.Add(jugador6);
            }
            #endregion
                    break;
            }
               
            switch(tacticaAzul)
            {
                case 1: //posicionamiento libre
                    #region Configurar y añadir jugador 7 en caso de que esté activo
            if (activo7.IsChecked == true)
            {
                Jugador jugador7 = new Jugador();
                jugador7.setEquipo(1);
                jugador7.setPosx(725);
                jugador7.setPosy(50);
                jugador7.setVivo(true);
                jugador7.setId(nombre7.Text);
                jugador7.setVision(int.Parse(vision7.Text));
                jugador7.setInflu(int.Parse(influencia7.Text));
                jugador7.setArma(int.Parse(arma7.Text));
                //jugador7.setMovimientos
                jugadores.Add(jugador7);
            }
            #endregion
                    #region Configurar y añadir jugador 8 en caso de que esté activo
            if (activo8.IsChecked == true)
            {
                Jugador jugador8 = new Jugador();
                jugador8.setEquipo(1);
                jugador8.setPosx(675);
                jugador8.setPosy(100);
                jugador8.setVivo(true);
                jugador8.setId(nombre8.Text);
                jugador8.setVision(int.Parse(vision8.Text));
                jugador8.setInflu(int.Parse(influencia8.Text));
                jugador8.setArma(int.Parse(arma8.Text));
                //jugador8.setMovimientos
                jugadores.Add(jugador8);
            }
            #endregion
                    #region Configurar y añadir jugador 9 en caso de que esté activo
            if (activo9.IsChecked == true)
            {
                Jugador jugador9 = new Jugador();
                jugador9.setEquipo(1);
                jugador9.setPosx(625);
                jugador9.setPosy(150);
                jugador9.setVivo(true);
                jugador9.setId(nombre9.Text);
                jugador9.setVision(int.Parse(vision9.Text));
                jugador9.setInflu(int.Parse(influencia9.Text));
                jugador9.setArma(int.Parse(arma9.Text));
                //jugador9.setMovimientos
                jugadores.Add(jugador9);
            }
            #endregion
                    #region Configurar y añadir jugador 10 en caso de que esté activo
            if (activo10.IsChecked == true)
            {
                Jugador jugador10 = new Jugador();
                jugador10.setEquipo(1);
                jugador10.setPosx(625);
                jugador10.setPosy(200);
                jugador10.setVivo(true);
                jugador10.setId(nombre10.Text);
                jugador10.setVision(int.Parse(vision10.Text));
                jugador10.setInflu(int.Parse(influencia10.Text));
                jugador10.setArma(int.Parse(arma10.Text));
                //jugador10.setMovimientos
                jugadores.Add(jugador10);
            }
            #endregion
                    #region Configurar y añadir jugador 11 en caso de que esté activo
            if (activo11.IsChecked == true)
            {
                Jugador jugador11 = new Jugador();
                jugador11.setEquipo(1);
                jugador11.setPosx(675);
                jugador11.setPosy(250);
                jugador11.setVivo(true);
                jugador11.setId(nombre11.Text);
                jugador11.setVision(int.Parse(vision11.Text));
                jugador11.setInflu(int.Parse(influencia11.Text));
                jugador11.setArma(int.Parse(arma11.Text));
                //jugador1.setMovimientos
                jugadores.Add(jugador11);
            }
            #endregion
                    #region Configurar y añadir jugador 12 en caso de que esté activo
            if (activo12.IsChecked == true)
            {
                Jugador jugador12 = new Jugador();
                jugador12.setEquipo(1);
                jugador12.setPosx(725);
                jugador12.setPosy(300);
                jugador12.setVivo(true);
                jugador12.setId(nombre12.Text);
                jugador12.setVision(int.Parse(vision12.Text));
                jugador12.setInflu(int.Parse(influencia12.Text));
                jugador12.setArma(int.Parse(arma12.Text));
                //jugador12.setMovimientos
                jugadores.Add(jugador12);
            }
            #endregion
                    break;
                case 2: //Punta de flecha
                    #region Configurar y añadir jugador 7 en caso de que esté activo
            if (activo7.IsChecked == true)
            {
                Jugador jugador7 = new Jugador();
                jugador7.setEquipo(1);
                jugador7.setPosx(725);
                jugador7.setPosy(50);
                jugador7.setVivo(true);
                jugador7.setId(nombre7.Text);
                jugador7.setVision(int.Parse(vision7.Text));
                jugador7.setInflu(int.Parse(influencia7.Text));
                jugador7.setArma(int.Parse(arma7.Text));
                //jugador7.setMovimientos
                jugadores.Add(jugador7);
            }
            #endregion
                    #region Configurar y añadir jugador 8 en caso de que esté activo
            if (activo8.IsChecked == true)
            {
                Jugador jugador8 = new Jugador();
                jugador8.setEquipo(1);
                jugador8.setPosx(675);
                jugador8.setPosy(100);
                jugador8.setVivo(true);
                jugador8.setId(nombre8.Text);
                jugador8.setVision(int.Parse(vision8.Text));
                jugador8.setInflu(int.Parse(influencia8.Text));
                jugador8.setArma(int.Parse(arma8.Text));
                //jugador8.setMovimientos
                jugadores.Add(jugador8);
            }
            #endregion
                    #region Configurar y añadir jugador 9 en caso de que esté activo
            if (activo9.IsChecked == true)
            {
                Jugador jugador9 = new Jugador();
                jugador9.setEquipo(1);
                jugador9.setPosx(625);
                jugador9.setPosy(150);
                jugador9.setVivo(true);
                jugador9.setId(nombre9.Text);
                jugador9.setVision(int.Parse(vision9.Text));
                jugador9.setInflu(int.Parse(influencia9.Text));
                jugador9.setArma(int.Parse(arma9.Text));
                //jugador9.setMovimientos
                jugadores.Add(jugador9);
            }
            #endregion
                    #region Configurar y añadir jugador 10 en caso de que esté activo
            if (activo10.IsChecked == true)
            {
                Jugador jugador10 = new Jugador();
                jugador10.setEquipo(1);
                jugador10.setPosx(625);
                jugador10.setPosy(200);
                jugador10.setVivo(true);
                jugador10.setId(nombre10.Text);
                jugador10.setVision(int.Parse(vision10.Text));
                jugador10.setInflu(int.Parse(influencia10.Text));
                jugador10.setArma(int.Parse(arma10.Text));
                //jugador10.setMovimientos
                jugadores.Add(jugador10);
            }
            #endregion
                    #region Configurar y añadir jugador 11 en caso de que esté activo
            if (activo11.IsChecked == true)
            {
                Jugador jugador11 = new Jugador();
                jugador11.setEquipo(1);
                jugador11.setPosx(675);
                jugador11.setPosy(250);
                jugador11.setVivo(true);
                jugador11.setId(nombre11.Text);
                jugador11.setVision(int.Parse(vision11.Text));
                jugador11.setInflu(int.Parse(influencia11.Text));
                jugador11.setArma(int.Parse(arma11.Text));
                //jugador1.setMovimientos
                jugadores.Add(jugador11);
            }
            #endregion
                    #region Configurar y añadir jugador 12 en caso de que esté activo
            if (activo12.IsChecked == true)
            {
                Jugador jugador12 = new Jugador();
                jugador12.setEquipo(1);
                jugador12.setPosx(725);
                jugador12.setPosy(300);
                jugador12.setVivo(true);
                jugador12.setId(nombre12.Text);
                jugador12.setVision(int.Parse(vision12.Text));
                jugador12.setInflu(int.Parse(influencia12.Text));
                jugador12.setArma(int.Parse(arma12.Text));
                //jugador12.setMovimientos
                jugadores.Add(jugador12);
            }
            #endregion
                    
                    break;
                case 3: //Punta de flecha inversa
                    #region Configurar y añadir jugador 7 en caso de que esté activo
            if (activo7.IsChecked == true)
            {
                Jugador jugador7 = new Jugador();
                jugador7.setEquipo(1);
                jugador7.setPosx(625);
                jugador7.setPosy(50);
                jugador7.setVivo(true);
                jugador7.setId(nombre7.Text);
                jugador7.setVision(int.Parse(vision7.Text));
                jugador7.setInflu(int.Parse(influencia7.Text));
                jugador7.setArma(int.Parse(arma7.Text));
                //jugador7.setMovimientos
                jugadores.Add(jugador7);
            }
            #endregion
                    #region Configurar y añadir jugador 8 en caso de que esté activo
            if (activo8.IsChecked == true)
            {
                Jugador jugador8 = new Jugador();
                jugador8.setEquipo(1);
                jugador8.setPosx(675);
                jugador8.setPosy(100);
                jugador8.setVivo(true);
                jugador8.setId(nombre8.Text);
                jugador8.setVision(int.Parse(vision8.Text));
                jugador8.setInflu(int.Parse(influencia8.Text));
                jugador8.setArma(int.Parse(arma8.Text));
                //jugador8.setMovimientos
                jugadores.Add(jugador8);
            }
            #endregion
                    #region Configurar y añadir jugador 9 en caso de que esté activo
            if (activo9.IsChecked == true)
            {
                Jugador jugador9 = new Jugador();
                jugador9.setEquipo(1);
                jugador9.setPosx(725);
                jugador9.setPosy(150);
                jugador9.setVivo(true);
                jugador9.setId(nombre9.Text);
                jugador9.setVision(int.Parse(vision9.Text));
                jugador9.setInflu(int.Parse(influencia9.Text));
                jugador9.setArma(int.Parse(arma9.Text));
                //jugador9.setMovimientos
                jugadores.Add(jugador9);
            }
            #endregion
                    #region Configurar y añadir jugador 10 en caso de que esté activo
            if (activo10.IsChecked == true)
            {
                Jugador jugador10 = new Jugador();
                jugador10.setEquipo(1);
                jugador10.setPosx(725);
                jugador10.setPosy(200);
                jugador10.setVivo(true);
                jugador10.setId(nombre10.Text);
                jugador10.setVision(int.Parse(vision10.Text));
                jugador10.setInflu(int.Parse(influencia10.Text));
                jugador10.setArma(int.Parse(arma10.Text));
                //jugador10.setMovimientos
                jugadores.Add(jugador10);
            }
            #endregion
                    #region Configurar y añadir jugador 11 en caso de que esté activo
            if (activo11.IsChecked == true)
            {
                Jugador jugador11 = new Jugador();
                jugador11.setEquipo(1);
                jugador11.setPosx(675);
                jugador11.setPosy(250);
                jugador11.setVivo(true);
                jugador11.setId(nombre11.Text);
                jugador11.setVision(int.Parse(vision11.Text));
                jugador11.setInflu(int.Parse(influencia11.Text));
                jugador11.setArma(int.Parse(arma11.Text));
                //jugador1.setMovimientos
                jugadores.Add(jugador11);
            }
            #endregion
                    #region Configurar y añadir jugador 12 en caso de que esté activo
            if (activo12.IsChecked == true)
            {
                Jugador jugador12 = new Jugador();
                jugador12.setEquipo(1);
                jugador12.setPosx(625);
                jugador12.setPosy(300);
                jugador12.setVivo(true);
                jugador12.setId(nombre12.Text);
                jugador12.setVision(int.Parse(vision12.Text));
                jugador12.setInflu(int.Parse(influencia12.Text));
                jugador12.setArma(int.Parse(arma12.Text));
                //jugador12.setMovimientos
                jugadores.Add(jugador12);
            }
            #endregion
                    break;
                
        }
            var batalla = new MainWindow(jugadores);
            batalla.Show();
            this.Close();
        }

        #region chekcers de las tácticas
        private void rbLibreRojo_Checked(object sender, RoutedEventArgs e)
        {
            tacticaRojo = 1;
        }

        private void rbEstacaRojo_Checked(object sender, RoutedEventArgs e)
        {
            tacticaRojo = 2;
        }

        private void rbEstacaiRojo_Checked(object sender, RoutedEventArgs e)
        {
            tacticaRojo = 3;
        }

        private void rbLibreAzul_Checked(object sender, RoutedEventArgs e)
        {
            tacticaAzul = 1;
        }

        private void rbEstacaA_Checked(object sender, RoutedEventArgs e)
        {
            tacticaAzul = 2;
        }

        private void rbEstacaiAzul_Checked(object sender, RoutedEventArgs e)
        {
            tacticaAzul = 3;
        }
        #endregion
    }
}
