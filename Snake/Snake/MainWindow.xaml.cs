using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace Snake
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region eigenes Zeug

        /// <summary>
        /// Speichert zu jedem Feld die Eigenschaften
        /// </summary>
        private FeldEigenschaft[] AlleFelder;

        /// <summary>
        /// Wenn true Spiel zu Ende 
        /// </summary>
        private bool GameOver;

        #endregion

        #region Aufbau des Playgrounds
        /// <summary>
        /// Spawn
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            //Array mit 256 leeren Feldern
            AlleFelder = new FeldEigenschaft[256];

            for (var i = 0; i < AlleFelder.Length; i++)
            {
                AlleFelder[i] = FeldEigenschaft.Leer;
            }

            //Felder zurücksetzen

            Playground.Children.Cast<Canvas>().ToList().ForEach(canvas =>
            {
                canvas.Background = Brushes.White;
            }
            );
            //Wand bauen
            //
            //Links + oben links + unten links
            s00z00.Background = Brushes.SlateGray;
            s00z01.Background = Brushes.SlateGray;
            s00z02.Background = Brushes.SlateGray;
            s00z03.Background = Brushes.SlateGray;
            s00z04.Background = Brushes.SlateGray;
            s00z05.Background = Brushes.SlateGray;
            s00z06.Background = Brushes.SlateGray;
            s00z07.Background = Brushes.SlateGray;
            s00z08.Background = Brushes.SlateGray;
            s00z09.Background = Brushes.SlateGray;
            s00z10.Background = Brushes.SlateGray;
            s00z11.Background = Brushes.SlateGray;
            s00z12.Background = Brushes.SlateGray;
            s00z13.Background = Brushes.SlateGray;
            s00z14.Background = Brushes.SlateGray;
            s00z15.Background = Brushes.SlateGray;
                                        
            //Rechts + oben rechts + unten rechts
            //                          
            s16z00.Background = Brushes.SlateGray;
            s16z01.Background = Brushes.SlateGray;
            s16z02.Background = Brushes.SlateGray;
            s16z03.Background = Brushes.SlateGray;
            s16z04.Background = Brushes.SlateGray;
            s16z05.Background = Brushes.SlateGray;
            s16z06.Background = Brushes.SlateGray;
            s16z07.Background = Brushes.SlateGray;
            s16z08.Background = Brushes.SlateGray;
            s16z09.Background = Brushes.SlateGray;
            s16z10.Background = Brushes.SlateGray;
            s16z11.Background = Brushes.SlateGray;
            s16z12.Background = Brushes.SlateGray;
            s16z13.Background = Brushes.SlateGray;
            s16z14.Background = Brushes.SlateGray;
            s16z15.Background = Brushes.SlateGray;

            //Oben                      
            //                          
            s01z00.Background = Brushes.SlateGray;
            s02z00.Background = Brushes.SlateGray;
            s03z00.Background = Brushes.SlateGray;
            s04z00.Background = Brushes.SlateGray;
            s05z00.Background = Brushes.SlateGray;
            s06z00.Background = Brushes.SlateGray;
            s07z00.Background = Brushes.SlateGray;
            s08z00.Background = Brushes.SlateGray;
            s09z00.Background = Brushes.SlateGray;
            s10z00.Background = Brushes.SlateGray;
            s11z00.Background = Brushes.SlateGray;
            s12z00.Background = Brushes.SlateGray;
            s13z00.Background = Brushes.SlateGray;
            s14z00.Background = Brushes.SlateGray;
            s15z00.Background = Brushes.SlateGray;

            //Unten
            //
            s01z15.Background = Brushes.SlateGray;
            s02z15.Background = Brushes.SlateGray;
            s03z15.Background = Brushes.SlateGray;
            s04z15.Background = Brushes.SlateGray;
            s05z15.Background = Brushes.SlateGray;
            s06z15.Background = Brushes.SlateGray;
            s07z15.Background = Brushes.SlateGray;
            s08z15.Background = Brushes.SlateGray;
            s09z15.Background = Brushes.SlateGray;
            s10z15.Background = Brushes.SlateGray;
            s11z15.Background = Brushes.SlateGray;
            s12z15.Background = Brushes.SlateGray;
            s13z15.Background = Brushes.SlateGray;
            s14z15.Background = Brushes.SlateGray;
            s15z15.Background = Brushes.SlateGray;
            Spawn();
        }
        #endregion

        #region Spawn der Schlange

        private void Spawn()
        {
            s01z01.Background = Brushes.DarkOliveGreen;
            W_Down();
        }

        #endregion

        #region Steuerung der Schlange
    
         private void W_Down(object sender, KeyEventArgs e)
         {
               if (e.Key == Key.D)
              {s01z01.Background = Brushes.White;
                s02z01.Background = Brushes.DarkOliveGreen;
            }
    }


     
      #endregion
    }
}
