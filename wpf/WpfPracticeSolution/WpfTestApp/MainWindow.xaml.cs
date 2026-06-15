using MahApps.Metro.Controls;
using NLog;
using System.Windows;
using System.Windows.Input;
using WpfTestApp.Helpers;
using WpfTestApp.Models;
using WpfTestApp.Services;

namespace WpfTestApp
{
    public partial class MainWindow : MetroWindow
    {
        private readonly TestAppApiService service;

        public MainWindow()
        {
            InitializeComponent();

            service = new TestAppApiService();
            Common.logger.Info("부산 쇼핑몰정보 앱 시작.");
        }

        private async void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Common.logger.Info("부산 쇼핑몰정보 앱 로드 시작");
            await SearchTestAppAsync();
            Common.logger.Info("공공데이터 쇼핑몰 API 데이터 로드 완료");
        }

        // 검색
        private async void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

            await SearchTestAppAsync();

        }

        // 검색기능 처리
        private async Task SearchTestAppAsync()
        {
            try
            {
                BtnSearch.IsEnabled = false;

                int pageNo = Convert.ToInt32(NumPageNo.Value ?? 1);
                int numOfRows = Convert.ToInt32(NumOfRows.Value ?? 10);

                var shopList = await service.GetTestAppsAsync(pageNo, numOfRows);

                System.Diagnostics.Debug.WriteLine($"받은 데이터 개수: {shopList.Count}");

                DgrTestApp.ItemsSource = shopList;

                Common.logger.Info($"Page : {pageNo}, Records : {shopList.Count} 로드 완료!");

                SbiStatus.Text =
                    $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {pageNo} 페이지 {shopList.Count} 건 로드 완료";
            }
            catch (Exception ex)
            {
                Common.logger.Error($"쇼핑몰 데이터 로드 실패 SearchTestAppAsync() : {ex.Message}");
                SbiStatus.Text = $"로드 실패!!";
            }
            finally
            {
                BtnSearch.IsEnabled = true;
            }
        }

        private void DgrTestApp_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DgrTestApp.SelectedItem == null)
                return;

            TestAppItem detailItem = DgrTestApp.SelectedItem as TestAppItem;

            TestAppDetailWindow win = new TestAppDetailWindow(detailItem);
            win.Owner = this;
            win.ShowDialog();
        }
    }
}