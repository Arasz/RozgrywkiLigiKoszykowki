using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RozgrywkiLigiKoszykowki.Model;

namespace RozgrywkiLigiKoszykowki.ViewModel
{
    class PlayerViewModel
    {
        public string Name { get; private set; }
        public int Number { get; private set; }

        public PlayerViewModel(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}
