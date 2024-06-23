using System;
using System.ComponentModel;

namespace MediaLibraryApp
{
    public class Item : INotifyPropertyChanged
    {
        private string title;
        private string creator;
        private string publisher;
        private MediaType mediaType;
        private DateTime releaseDate = DateTime.Now; // Default to today's date

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public string Creator
        {
            get => creator;
            set
            {
                creator = value;
                OnPropertyChanged(nameof(Creator));
            }
        }

        public string Publisher
        {
            get => publisher;
            set
            {
                publisher = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }

        public MediaType MediaType
        {
            get => mediaType;
            set
            {
                mediaType = value;
                OnPropertyChanged(nameof(MediaType));
            }
        }

        public DateTime ReleaseDate
        {
            get => releaseDate;
            set
            {
                releaseDate = value;
                OnPropertyChanged(nameof(ReleaseDate));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public enum MediaType
    {
        VHS,
        DVD,
        BlueRay,
        Kaseta,
        CD,
        Pendrive
    }
}