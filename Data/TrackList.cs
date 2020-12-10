using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WpfApp12.Data {
    public static class TrackList {
        public static ObservableCollection<TrackInfo> CreateTrackList() {
            var list = new ObservableCollection<TrackInfo>();
            list.Add(new TrackInfo(1, "For Those About To Rock (We Salute You)", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 343719, 11170334));
            list.Add(new TrackInfo(2, "Fast As a Shark", 3, 2, 1, "F. Baltes, S. Kaufman, U. Dirkscneider & W. Hoffman", 230619, 3990994));
            list.Add(new TrackInfo(3, "Restless and Wild", 3, 2, 1, "F. Baltes, R.A. Smith-Diesel, S. Kaufman, U. Dirkscneider & W. Hoffman", 252051, 4331779));
            list.Add(new TrackInfo(4, "Princess of the Dawn", 3, 2, 1, "Deaffy & R.A. Smith-Diesel", 375418, 6290521));
            list.Add(new TrackInfo(5, "Put The Finger On You", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 205662, 6713451));
            list.Add(new TrackInfo(6, "Let's Get It Up", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 233926, 7636561));
            list.Add(new TrackInfo(7, "Inject The Venom", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 210834, 6852860));
            list.Add(new TrackInfo(8, "Snowballed", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 203102, 6599424));
            list.Add(new TrackInfo(9, "Evil Walks", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 263497, 8611245));
            list.Add(new TrackInfo(10, "C.O.D.", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 199836, 6566314));
            list.Add(new TrackInfo(11, "Breaking The Rules", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 263288, 8596840));
            list.Add(new TrackInfo(12, "Night Of The Long Knives", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 205688, 6706347));
            list.Add(new TrackInfo(13, "Spellbound", 1, 1, 1, "Angus Young, Malcolm Young, Brian Johnson", 270863, 8817038));
            list.Add(new TrackInfo(14, "Go Down", 4, 1, 1, "AC/DC", 331180, 10847611));
            list.Add(new TrackInfo(15, "Dog Eat Dog", 4, 1, 1, "AC/DC", 215196, 7032162));
            list.Add(new TrackInfo(16, "Let There Be Rock", 4, 1, 1, "AC/DC", 366654, 12021261));
            list.Add(new TrackInfo(17, "Bad Boy Boogie", 4, 1, 1, "AC/DC", 267728, 8776140));
            list.Add(new TrackInfo(18, "Problem Child", 4, 1, 1, "AC/DC", 325041, 10617116));
            list.Add(new TrackInfo(19, "Overdose", 4, 1, 1, "AC/DC", 369319, 12066294));
            list.Add(new TrackInfo(20, "Hell Ain't A Bad Place To Be", 4, 1, 1, "AC/DC", 254380, 8331286));
            list.Add(new TrackInfo(21, "Whole Lotta Rosie", 4, 1, 1, "AC/DC", 323761, 10547154));
            list.Add(new TrackInfo(22, "Walk On Water", 5, 1, 1, "Steven Tyler, Joe Perry, Jack Blades, Tommy Shaw", 295680, 9719579));
            list.Add(new TrackInfo(23, "Love In An Elevator", 5, 1, 1, "Steven Tyler, Joe Perry", 321828, 10552051));
            list.Add(new TrackInfo(24, "Rag Doll", 5, 1, 1, "Steven Tyler, Joe Perry, Jim Vallance, Holly Knight", 264698, 8675345));
            list.Add(new TrackInfo(25, "What It Takes", 5, 1, 1, "Steven Tyler, Joe Perry, Desmond Child", 310622, 10144730));
            list.Add(new TrackInfo(26, "Dude (Looks Like A Lady)", 5, 1, 1, "Steven Tyler, Joe Perry, Desmond Child", 264855, 8679940));
            list.Add(new TrackInfo(27, "Janie's Got A Gun", 5, 1, 1, "Steven Tyler, Tom Hamilton", 330736, 10869391));
            list.Add(new TrackInfo(28, "Cryin'", 5, 1, 1, "Steven Tyler, Joe Perry, Taylor Rhodes", 309263, 10056995));
            list.Add(new TrackInfo(29, "Amazing", 5, 1, 1, "Steven Tyler, Richie Supa", 356519, 11616195));
            list.Add(new TrackInfo(30, "Blind Man", 5, 1, 1, "Steven Tyler, Joe Perry, Taylor Rhodes", 240718, 7877453));
            return list;
        }
    }
}