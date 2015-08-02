using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RozgrywkiLigiKoszykowki.Model;
using System.ComponentModel;

namespace RozgrywkiLigiKoszykowki.ViewModel
{
    class RosterViewModel: INotifyPropertyChanged
    {
        private Roster _roster;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _teamName;

        public string TeamName
        {
            get { return _teamName; }
            set
            {
                _teamName = value;
                OnPropertyChanged("TeamName");
            }
        }


        public ObservableCollection<PlayerViewModel> Starters { get; private set; }
        public ObservableCollection<PlayerViewModel> Bench { get; private set; }

        public RosterViewModel(Roster roster)
        {
            _roster = roster;
            TeamName = roster.TeamName;

            Bench = new ObservableCollection<PlayerViewModel>();
            Starters = new ObservableCollection<PlayerViewModel>();

            UpdateRosters();
        }

        private void UpdateRosters()
        {
            var starters =
                from player in _roster.Players
                where player.Starter == true
                select player;
            Starters.Clear();

            foreach (var player in starters)
                Starters.Add(new PlayerViewModel(player.Name, player.Number));

            var bench =
                from player in _roster.Players
                where player.Starter == false
                orderby player.Number
                select new PlayerViewModel(player.Name, player.Number);
            Bench.Clear();

            foreach (var player in bench)
                Bench.Add(new PlayerViewModel(player.Name, player.Number));
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler eventHandler = PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
