using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Snake
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region eigenes Zeug

        /// <summary>
        /// Anzahl der Schlange ohne Kopf
        /// </summary>
        private FeldEigenschaft[] LängeDerSchlange;

        /// <summary>
        /// Speichert zu jedem Feld die Eigenschaften
        /// </summary>
        private FeldEigenschaft[] AlleFelder;

        /// <summary>
        /// Wenn true gerade gegessen
        /// </summary>
        private bool[] Essengegessen;

        /// <summary>
        /// Wenn true Spiel zu Ende 
        /// </summary>
        private bool GameOver;

        #endregion




        #region Spawn
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
        }
        #endregion
    }
}
