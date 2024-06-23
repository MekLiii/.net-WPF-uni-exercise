using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace MediaLibraryApp
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Items = new ObservableCollection<Item>();
            DataContext = this; // Set DataContext for binding
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var newItem = new Item();
            var itemWindow = new ItemWindow(newItem);
            if (itemWindow.ShowDialog() == true)
            {
                Items.Add(newItem);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsListView.SelectedItem is Item selectedItem)
            {
                var itemWindow = new ItemWindow(selectedItem);
                itemWindow.ShowDialog();
                ItemsListView.Items.Refresh(); // Refresh the list to show edited changes
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ItemsListView.SelectedItem is Item selectedItem)
            {
                Items.Remove(selectedItem);
            }
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var json = File.ReadAllText(openFileDialog.FileName);
                var items = JsonSerializer.Deserialize<ObservableCollection<Item>>(json);
                Items.Clear();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                var json = JsonSerializer.Serialize(Items);
                File.WriteAllText(saveFileDialog.FileName, json);
            }
        }
    }
}
