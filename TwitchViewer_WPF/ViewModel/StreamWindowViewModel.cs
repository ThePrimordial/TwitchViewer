using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchViewer_WPF.ViewModel
{
    public class StreamWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private string _headerText;
        private int _viewersNumber;
        private string _quality;
        private string _imgSource;

        public StreamWindowViewModel(string headerText, int viewersNumber, string quality, string imgSource)
        {
            HeaderText = headerText;
            ViewersNumber = viewersNumber;
            Quality = quality;
            ImgSource = imgSource;
        }

        public string HeaderText
        {
            get
            {
                return _headerText;
            }

            set
            {
                if (_headerText != value)
                {
                    _headerText = value;
                    OnPropertyChanged("HeaderText");
                }
            }
        }

        public int ViewersNumber
        {
            get
            {
                return _viewersNumber;
            }

            set
            {
                if (_viewersNumber != value)
                {
                    _viewersNumber = value;
                    OnPropertyChanged("ViewersNumber");
                }
            }
        }

        public string Quality
        {
            get
            {
                return _quality;
            }

            set
            {
                if (_quality != value)
                {
                    _quality = value;
                    OnPropertyChanged("Quality");
                }
            }
        }

        public string ImgSource
        {
            get
            {
                return _imgSource;
            }

            set
            {
                if (_imgSource != value)
                {
                    _imgSource = value;
                    OnPropertyChanged("ImgSource");
                }
            }
        }

        
    }
}
