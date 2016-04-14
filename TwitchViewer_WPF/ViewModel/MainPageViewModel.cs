using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using TwitchViewerLib;

namespace TwitchViewer_WPF.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public MainPageViewModel()
        {
            Games = new ObservableCollection<Top>(TwitchImp.generateTopGames());
            Channels = new ObservableCollection<Stream>();
            SearchText = "Search...";
        }

        private ObservableCollection<Top> _games;

        private ObservableCollection<Stream> _channels;

        private string _searchText;

        public ObservableCollection<Top> Games
        {
            get
            {
                return _games;
            }

            set
            {
                if (value != _games)
                {
                    _games = value;
                    OnPropertyChanged("Games");
                }
            }
        }

        public ObservableCollection<Stream> Channels
        {
            get
            {
                return _channels;
            }

            set
            {
                if (value != _channels)
                {
                    _channels = value;
                    OnPropertyChanged("Channels");
                }
            }
        }

        public string SearchText
        {
            get
            {
                return _searchText;
            }

            set
            {
                if (value != _searchText)
                {
                    _searchText = value;
                    OnPropertyChanged("SearchText");
                }
            }
        }
    }
}
