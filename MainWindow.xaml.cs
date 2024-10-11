using System.Windows;
using System.Windows.Media;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RedBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Red;
            StatusText.Text = "Фон установлен на красный";
        }

        private void GreenBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Green;
            StatusText.Text = "Фон установлен на зеленый";
        }

        private void BlueBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Blue;
            StatusText.Text = "Фон установлен на синий";
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Гарипов Камиль", "Информация о разработчике");
            StatusText.Text = "Открыто окно с информацией о разработчике";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
