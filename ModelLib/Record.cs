using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class Record
    {
        public static int counter = 0;

        public int ID { get; set; }

        public string Title { get; set; }

        public int Duration { get; set; }

        public int YearOfPublication { get; set; }

        public string RecordStudio { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }
        public Record()
        {
            
        }

        public Record(string title, int duration, int yearOfPublication, string recordStudio, string artist, string album)
        {
            Title = title;
            Duration = duration;
            YearOfPublication = yearOfPublication;
            RecordStudio = recordStudio;
            Artist = artist;
            Album = album;
            ID = counter++;
        }
    }
}
