using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfApp12.Data;

namespace WpfApp12.ViewModels {
    class MainViewModel: INotifyPropertyChanged {
        public MainViewModel() {
            Tracks = TrackList.CreateTrackList();
            SelectedTrack = Tracks[0];
            RevertTrackCommand = new RelayCommand(obj => RevertTrack(), obj => !string.Equals(Name, selectedTrack.Name) || !string.Equals(Composer, selectedTrack.Composer));
            ClearNameCommand = new RelayCommand(obj => ClearName(), obj => !string.IsNullOrEmpty(Name));
        }

        public ObservableCollection<TrackInfo> Tracks { get; set; }

        TrackInfo selectedTrack;
        public TrackInfo SelectedTrack {
            get { return selectedTrack; }
            set {
                selectedTrack = value;
                Load(value);
                OnPropertyChanged();
            }
        }       

        string name;
        public string Name {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged();
            }
        }

        string composer;
        public string Composer {
            get { return composer; }
            set {
                composer = value;
                OnPropertyChanged();
            }
        }

        void Load(TrackInfo track) {
            if (track != null) {                
                Name = track.Name;
                Composer = track.Composer;
            }
        }

        void ClearName() {
            if (selectedTrack != null)
                Name = "";
        }

        void RevertTrack() {
            Load(selectedTrack);
        }

        public RelayCommand ClearNameCommand { get; }        
        public RelayCommand SaveTrackCommand { get; }        
        public RelayCommand RevertTrackCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null) {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}