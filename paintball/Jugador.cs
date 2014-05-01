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
    public class Jugador
    {
        /* --------------------------------------- ATRIBUTOS --------------------------------------- */
            // constantes
        private static int paso = 4; //Constante que determina cuanto avanza cada jugador en cada paso
        Random rand = new Random();
            // de la clase
        private int posx;
        private int posy;
        private int vision; // Radio de lo que puede VER
        private int influ;  // Radio en el que es VISTO
        private List<int> movs;
        private int equipo;
        private bool vivo;
        private string id;
        private int arma; // ARMA

        /* -------------------------------------- CONSTRUCTOR -------------------------------------- */
        // Vacío
        public Jugador()
        {
        
        }

        /* ------------------------------------ GETTERS & SETTERS ---------------------------------- */
            // posx
        public int  getPosx()
        {
            return posx;
        }

        public void setPosx(int posx)
        {
            this.posx = posx;
        }
            // posy
        public int getPosy()
        {
            return posy;
        }

        public void setPosy(int posy)
        {
            this.posy = posy;
        }
            // vision
        public int getVision()
        {
            return vision;
        }

        public void setVision(int vision)
        {
            this.vision = vision;
        }
            // influ
        public int getInflu()
        {
            return influ;
        }

        public void setInflu(int influ)
        {
            this.influ = influ;
        }
            // movs
        public List<int> getMovs()
        {
            return movs;
        }

        public void setMovs(List<int> movs)
        {
            this.movs = movs;
        }
            // equipo
        public int getEquipo()
        {
            return equipo;
        }

        public void setEquipo(int equipo)
        {
            this.equipo = equipo;
        }
            // vivo
        public bool getVivo()
        {
            return vivo;
        }

        public void setVivo(bool vivo)
        {
            this.vivo = vivo;
        }

        // id
        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        //---------------------------------ARMA------------------
        public int getArma()
        {
            return arma;
        }

        public void setArma(int arma)
        {
            this.arma = arma;
        }
        /* ---------------------------------------- MÉTODOS ---------------------------------------- */
            // avanzar a la proxima posición
        public void mover(int turno)
        {
            // Variables del método:
            int aux;
            
            //DIVISIÓN DE MOVIMIENTOS RANDOM SEGÚN EQUIPO
            if(equipo==0)
            {
                //MOVIENTOS NORTE,NORESTE,ESTE,SURESTE Y SUR
                aux = rand.Next(0,5);
                if (vivo == true) // Mueve solo a los que estén vivos
                {
                    switch (aux)
                    {
                        case 0: // Norte
                            posy -= paso;
                            break;
                        case 1: // Noreste
                            posx += paso / 2;
                            posy -= paso / 2;
                            break;
                        case 2: // Este
                            posx += paso;
                            break;
                        case 3: // Sureste
                            posx += paso / 2;
                            posy += paso / 2;
                            break;
                        case 4: // Sur
                            posy += paso;
                            break;
                        default:
                            break;
                    }
                }
            }else if (equipo==1)
            {
                //MOVIMIENTOS NORTE,NOROESTE,OESTE,SUROESTE Y SUR
                aux = rand.Next(0, 5);
                if (vivo == true) // Mueve solo a los que estén vivos
                {
                    switch (aux)
                    {
                        case 0: // Norte
                            posy -= paso;                        
                            break;
                        case 1: // Noroeste
                            posx -= paso / 2;
                            posy -= paso / 2;                        
                            break;
                        case 2: // Oeste
                            posx -= paso;
                            break;
                        case 3: // Suroeste
                            posx -= paso / 2;
                            posy += paso / 2;
                            break;
                        case 4: // Sur
                            posy += paso;
                            break;
                        default:
                            break;
                    }
                }
            }
           

            // Para no salirse del canvas (canvas: horizontal es X=800, vertical es Y=500)
            if (posx < 5) posx = 5;
            if (posy < 5) posy = 5; // Dejamos algo de espacio antes de los valores del tamaño del canvas
            if (posx > 795) posx = 795;
            if (posy > 495) posy = 495;
        }

        // Circulo que representa al jugador
        public void dibujarJugador(Canvas picture)
        {
            int radio = 5;
            Ellipse circulo = new Ellipse();
            if (equipo == 0) circulo.Fill = Brushes.Red; // Comentario aleatorio
            if (equipo == 1) circulo.Fill = Brushes.Blue;
            circulo.Width = radio * 2;
            circulo.Height = radio * 2;
            Canvas.SetTop(circulo, posy - radio); 
            Canvas.SetLeft(circulo, posx - radio);
            circulo.HorizontalAlignment = HorizontalAlignment.Center;
            circulo.VerticalAlignment = VerticalAlignment.Center;
            picture.Children.Add(circulo);
        }

        // Circunferencia que representa el alcance de visión del jugador
        public void dibujarVision(Canvas picture)
        {
            Ellipse circulo = new Ellipse();
            circulo.Stroke = Brushes.Green;
            circulo.Width = vision * 2;
            circulo.Height = vision * 2;
            Canvas.SetTop(circulo, posy - vision);
            Canvas.SetLeft(circulo, posx - vision);
            circulo.HorizontalAlignment = HorizontalAlignment.Center;
            circulo.VerticalAlignment = VerticalAlignment.Center;
            picture.Children.Add(circulo);
        }

        // Circunferencia que representa desde donde es visto el jugador
        public void dibujarInflu(Canvas picture)
        {
            Ellipse circulo = new Ellipse();
            circulo.Stroke = Brushes.Black;
            circulo.Width = influ * 2;
            circulo.Height = influ * 2;
            Canvas.SetTop(circulo, posy - influ);
            Canvas.SetLeft(circulo, posx - influ);
            circulo.HorizontalAlignment = HorizontalAlignment.Center;
            circulo.VerticalAlignment = VerticalAlignment.Center;
            picture.Children.Add(circulo);
        }

        //CIRCUNFERENCIA QUE REPRESENTA EL ALCANCE DEL ARMA
        public void dibujarArma(Canvas picture)
        {
            int alcance;
            alcance = 15 * arma;
            Ellipse circulo = new Ellipse();
            circulo.Stroke = Brushes.DarkOrange;
            circulo.Width = alcance * 2;
            circulo.Height= alcance * 2;
            Canvas.SetTop(circulo, posy - alcance);
            Canvas.SetLeft(circulo, posx - alcance);
            circulo.HorizontalAlignment = HorizontalAlignment.Center;
            circulo.VerticalAlignment = VerticalAlignment.Center;
            picture.Children.Add(circulo);

        }
        
    }

}


        
