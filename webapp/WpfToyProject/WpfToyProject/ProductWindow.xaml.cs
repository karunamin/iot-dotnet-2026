using System;
using System.Windows;
using MahApps.Metro.Controls;
using WpfToyProject.Models;
using WpfToyProject.Services;

namespace WpfToyProject
{
    public partial class ProductWindow : MetroWindow
    {
        private readonly ApiService service;
        private readonly Product edit;

        public ProductWindow()
        {
            InitializeComponent();
            service = new ApiService();
        }

        public ProductWindow(Product p)
        {
            InitializeComponent();
            service = new ApiService();

            edit = p;

            TxtName.Text = p.ProductName;
            TxtCategory.Text = p.Category;
            TxtPrice.Text = p.Price.ToString();
            TxtStock.Text = p.Stock.ToString();
        }

        private async void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var product = new Product
            {
                ProductName = TxtName.Text,
                Category = TxtCategory.Text,
                Price = int.Parse(TxtPrice.Text),
                Stock = int.Parse(TxtStock.Text),
                CreatedAt = DateTime.Now
            };

            if (edit == null)
            {
                await service.CreateProductAsync(product);
            }
            else
            {
                product.ProductId = edit.ProductId;
                await service.UpdateProductAsync(product);
            }

            DialogResult = true;
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}