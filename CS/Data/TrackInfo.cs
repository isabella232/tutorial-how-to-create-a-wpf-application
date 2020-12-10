using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp12.Data {
    public class TrackInfo : INotifyPropertyChanged {
        public TrackInfo() { }
        public TrackInfo(int trackId, string name, int albumId, int mediaTypeId, int genreId, string composer, double milliseconds, double bytes) {
            TrackId = trackId;
            Name = name;
            AlbumId = albumId;
            MediaTypeId = mediaTypeId;
            GenreId = genreId;
            Composer = composer;
            Milliseconds = milliseconds;
            Bytes = bytes;
        }

        int trackId;
        public int TrackId {
            get { return trackId; }
            set {
                if (trackId == value)
                    return;
                trackId = value;
                OnPropertyChanged();
            }
        }

        string name;
        public string Name {
            get { return name; }
            set {
                if (name == value)
                    return;
                name = value;
                OnPropertyChanged();
            }
        }
        int albumId;
        public int AlbumId {
            get { return albumId; }
            set {
                if (albumId == value)
                    return;
                albumId = value;
                OnPropertyChanged();
            }
        }
        int mediaTypeId;
        public int MediaTypeId {
            get { return mediaTypeId; }
            set {
                if (mediaTypeId == value)
                    return;
                mediaTypeId = value;
                OnPropertyChanged();
            }
        }
        int genreId;
        public int GenreId {
            get { return genreId; }
            set {
                if (genreId == value)
                    return;
                genreId = value;
                OnPropertyChanged();
            }
        }
        string composer;
        public string Composer {
            get { return composer; }
            set {
                if (composer == value)
                    return;
                composer = value;
                OnPropertyChanged();
            }
        }
        double milliseconds;
        public double Milliseconds {
            get { return milliseconds; }
            set {
                if (milliseconds == value)
                    return;
                milliseconds = value;
                OnPropertyChanged();
            }
        }
        double bytes;
        public double Bytes {
            get { return bytes; }
            set {
                if (bytes == value)
                    return;
                bytes = value;
                OnPropertyChanged();
            }
        }

        public override string ToString() {
            return String.Format("Name: {0}, Milliseconds: {1}, Composer: {2}",
              Name, Milliseconds, Composer);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
