using System.Windows;
using VehicleCatalogApp.Models;

namespace VehicleCatalogApp
{
    public partial class CategoryWindow : Window
    {
        public CategoryWindow(Category category)
        {
            InitializeComponent();
            DataContext = category;
            SubcategoryListBox.ItemsSource = category.Subcategories;
        }

        private void SubcategoryListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (SubcategoryListBox.SelectedItem is Subcategory selectedSubcategory)
            {
                SubcategoryWindow subcategoryWindow = new SubcategoryWindow(selectedSubcategory);
                subcategoryWindow.Show();
            }
        }
    }
}