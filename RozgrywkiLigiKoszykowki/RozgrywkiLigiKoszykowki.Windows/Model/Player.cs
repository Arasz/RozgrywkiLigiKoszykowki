using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozgrywkiLigiKoszykowki.Model
{
    class Player
    {
        /// <summary>
        /// Player name
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Player number
        /// </summary>
        public int Number { get; private set; }
        /// <summary>
        /// Determines if player plays in the next game
        /// </summary>
        public bool Starter { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Player name</param>
        /// <param name="number">Player number</param>
        /// <param name="starter">Determines if player plays in the next game</param>
        public Player(string name, int number, bool starter)
        {
            Name = name;
            Number = number;
            Starter = starter;
        }
    }
}
