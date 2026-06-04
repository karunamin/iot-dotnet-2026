using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBasic02Navi
{
    /// <summary>
    /// Sub02Page.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Sub04Page : Page
    {
        public List<Employee> employees;

        public Employee SelectedEmployee { get; set; }
        public Sub04Page()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Car car = new Car
            {
                Speed = 10.0,
                Color = Colors.Black
            };

            this.DataContext = car;  // 전체 page에 데이터컨텍스트에 car을 지정
            GrbInfo.DataContext = car;  // 전체 page에 데이터컨텍스트에 car을 지정
        }

        private void TxtColor_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                Color color = (Color)ColorConverter.ConvertFromString(TxtColor.Text);

                ScbColor.Color = color;
            }
            catch(Exception)
            {
                Debug.WriteLine("색상변환 실패");
            }
        }

    }
}
