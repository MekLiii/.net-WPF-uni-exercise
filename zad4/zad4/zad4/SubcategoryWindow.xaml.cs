using System.Windows;
using VehicleCatalogApp.Models;

namespace VehicleCatalogApp
{
    public partial class SubcategoryWindow : Window
    {
        public SubcategoryWindow(Subcategory subcategory)
        {
            InitializeComponent();
            DataContext = subcategory;
        }
    }
}