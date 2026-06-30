using MahApps.Metro.Controls;
using System;
using System.Threading.Tasks;
using System.Windows;
using WpfProductAdmin.Models;
using WpfProductAdmin.Services;
using WpfToyProject.Models;

namespace WpfProductAdmin
{
    public partial class MainWindow : MetroWindow
    {
        ApiService service;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            service = new ApiService();
            await SearchProductsAsync();
        }

        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            await SearchProductsAsync();
        }

        private async Task SearchProductsAsync()
        {
            if (service == null)
                service = new ApiService();

            var result = await service.GetProductsAsync();
            DgrProduct.ItemsSource = result;
        }

        private async void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            var window = new ProductWindow
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
            };

            bool? result = window.ShowDialog();

            if (result == true)
                await SearchProductsAsync();
        }

        private async void DgrProduct_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (DgrProduct.SelectedItem is not Product product)
                return;

            var window = new ProductWindow(product)
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
            };

            bool? result = window.ShowDialog();

            if (result == true)
                await SearchProductsAsync();
        }
    }
}