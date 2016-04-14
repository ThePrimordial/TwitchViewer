using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TwitchViewer_WPF.ViewModel;
using TwitchViewerLib;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;


namespace TwitchViewer_WPF.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private MainPageViewModel _defaultVM;
        private BackgroundWorker _worker;
        private Top _selectedTop;
        private List<Top> _games;
        public MainPage()
        {
            InitializeComponent();

            _defaultVM = new MainPageViewModel();
            _games = _defaultVM.Games.ToList();
            this.DataContext = _defaultVM;

            _worker = GetBgWorker();
        }
        
        private BackgroundWorker GetBgWorker()
        {
            BackgroundWorker bgWorker = new BackgroundWorker();
            bgWorker.DoWork += _workerRun;
            bgWorker.RunWorkerCompleted += _workerCompleted;
            bgWorker.WorkerSupportsCancellation = true;

            return bgWorker;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0) return;

            _selectedTop = e.AddedItems[0] as Top;
            Top top = _selectedTop.Copy();
            
            SetControlsVisibility(Visibility.Hidden);

            if (_worker.IsBusy)
            {
                _worker.CancelAsync();
                return;
            }
            _worker.RunWorkerAsync(top);
        }

        private void SetControlsVisibility(Visibility visibility)
        {
            channelListView.Visibility = visibility;

            switch (visibility)
            {
                case Visibility.Visible:
                    processRing.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    processRing.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void _workerRun(object sender, DoWorkEventArgs e)
        {
            if (e.Argument is Top)
            {
                e.Result = new ObservableCollection<Stream>(TwitchImp.generateStreams((e.Argument as Top).game.name));
            }

            if ((sender as BackgroundWorker).CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void _workerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //_worker = GetBgWorker();
                _worker.RunWorkerAsync(_selectedTop);
                return;
            }

            SetControlsVisibility(Visibility.Visible);
            if (e.Result == null) return;
            if (e.Result is ObservableCollection<Stream>)
            {
                _defaultVM.Channels = e.Result as ObservableCollection<Stream>;
                return;
            }
        }

        //private void searchButton_Click(object sender, RoutedEventArgs e)
        //{
        //    string searchText = searchBox.Text;

        //    _defaultVM.Games = new ObservableCollection<Top>(_games.Where(top => top.game.name.Trim().ToLower().Contains(searchText.Trim().ToLower())).ToList());

        //}

        //private void searchBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //    {
        //        searchButton_Click(sender, new RoutedEventArgs());
        //        return;
        //    }
        //}

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
             _defaultVM.Games = new ObservableCollection<Top>(_games.Where(top => top.game.name.Trim().ToLower().Contains(_defaultVM.SearchText.Trim().ToLower())).ToList());
        }

        private void channelListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Stream stream = null;
            try
            {
                stream = e.AddedItems[0] as Stream;
            }
            catch (Exception)
            {
                return;
            }

            if (stream != null)
            {
                StreamWindow sw = new StreamWindow(stream);
                sw.ShowDialog();
            }
        }

        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_defaultVM.SearchText.Equals("Search...") || string.IsNullOrEmpty(_defaultVM.SearchText))
            {
                return;
            }

            _defaultVM.SearchText = string.Empty;
        }

        private void searchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_defaultVM.SearchText)) _defaultVM.SearchText = "Search...";
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            _defaultVM.SearchText = string.Empty;
            searchBox_KeyUp(sender, null);

            _defaultVM.SearchText = "Search...";
        }
    }
}
