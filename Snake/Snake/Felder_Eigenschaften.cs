using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum FeldEigenschaft
    {
        /// <summary>
        /// Graue Wand
        /// </summary>
        Barriere,
        /// <summary>
        /// Brauner Kopf
        /// </summary>
        Kopf,
        /// <summary>
        /// Dunkelgrüner Körper
        /// </summary>
        Körper,
        /// <summary>
        /// weißes Feld
        /// </summary>
        Leer,
        /// <summary>
        /// Rotes Feld (Apfel)
        /// </summary>
        Essen
    }
}
