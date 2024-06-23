using System;
using System.ComponentModel;

namespace zad3;

    public partial class Item : INotifyPropertyChanged
    {
        private string title;
        private string creator;
        private string publisher;
        private MediaType mediaType;
        private DateTime releaseDate;

        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Creator
        {
            get => creator;
            set
            {
                creator = value;
                OnPropertyChanged("Creator");
            }
        }

        public string Publisher
        {
            get => publisher;
            set
            {
                publisher = value;
                OnPropertyChanged("Publisher");
            }
        }

        public MediaType MediaType
        {
            get => mediaType;
            set
            {
                mediaType = value;
                OnPropertyChanged("MediaType");
            }
        }

        public DateTime ReleaseDate
        {
            get => releaseDate;
            set
            {
                releaseDate = value;
                OnPropertyChanged("ReleaseDate");
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
