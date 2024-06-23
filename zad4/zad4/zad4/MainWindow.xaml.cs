using System.Windows;
using VehicleCatalogApp.Data;
using VehicleCatalogApp.Models;

namespace VehicleCatalogApp
{
    public partial class MainWindow : Window
    {
        private VehicleCatalog catalog;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            catalog = DataLoader.LoadData("vehicles.xml");
            CategoryListBox.ItemsSource = catalog.Categories;
        }

        private void CategoryListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (CategoryListBox.SelectedItem is Category selectedCategory)
            {
                CategoryWindow categoryWindow = new CategoryWindow(selectedCategory);
                categoryWindow.Show();
            }
        }
    }
}