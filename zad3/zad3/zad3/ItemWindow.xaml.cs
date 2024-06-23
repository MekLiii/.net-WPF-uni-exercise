using System.Collections.ObjectModel;
using System.Windows;
using zad3;

namespace MediaLibraryApp
{
    public partial class ItemWindow : Window
    {
        public Item Item { get; set; }
        public ObservableCollection<MediaType> MediaTypes { get; set; }

        public ItemWindow(Item item)
        {
            InitializeComponent();
            MediaTypes = new ObservableCollection<MediaType>
            {
                MediaType.VHS,
                MediaType.DVD,
                MediaType.BlueRay,
                MediaType.Kaseta,
                MediaType.CD,
                MediaType.Pendrive
            };
            Item = item;
            DataContext = this;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}