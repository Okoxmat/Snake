using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Schlange
    {
        /// <summary>
        /// Länge der Schlange mit Kopf
        /// </summary>
        int länge;
        /// <summary>
        /// Wie Lange die Schlange für 1 Tick (1 Feld laufen) braucht
        /// </summary>
        int geschwindigkeit;


        public int Länge
        {
            get{ return länge; }
            set{ länge = value; }
        }
        
            /// <summary>
            /// Wächst nach Fressen um 1
            /// </summary>
            /// <returns></returns>
        public int Wachsen()
        {
            return ++Länge;
        }

        /// <summary>
        /// Wird nach 3 mal essen schneller
        /// </summary>
        /// <returns></returns>
        public int Beschleunigen()
        {
            return geschwindigkeit - 200;
        }

        public enum Richtung
        {
            Left,
            Right,
            Up,
            Down
        };

        public static Richtung richtung { get; set; }
    }
}
