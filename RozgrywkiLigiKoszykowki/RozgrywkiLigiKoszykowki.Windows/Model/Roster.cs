using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozgrywkiLigiKoszykowki.Model
{
    // Roster means "harmonogram dyżurów"
    class Roster
    {
        /// <summary>
        /// Team name
        /// </summary>
        public string TeamName { get; private set; }

        /// <summary>
        /// List of players in team.
        /// </summary>
        private readonly List<Player> _players = new List<Player>();

        /// <summary>
        /// Returns reference to new copy of players list
        /// </summary>
        public IEnumerable<Player> Players
        {
            get { return new List<Player>(_players); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="teamName">Team name</param>
        /// <param name="players">List of players in team</param>
        public Roster(string teamName, IEnumerable<Player> players)
        {
            TeamName = teamName;
            _players.AddRange(players);
        }
    }
}
