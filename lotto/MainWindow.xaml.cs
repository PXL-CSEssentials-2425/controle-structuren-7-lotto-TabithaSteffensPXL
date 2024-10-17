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

namespace lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            number1Label.Content = "Getal 1:";
            number2Label.Content = "Getal 2:";
            number3Label.Content = "Getal 3:";
            number4Label.Content = "Getal 4:";
            number5Label.Content = "Getal 5:";
            number6Label.Content = "Getal 6:";

        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            Random numberGenerator = new Random();
            int number1 = numberGenerator.Next(1,45);
            int number2 = numberGenerator.Next(1, 45);
            int number3 = numberGenerator.Next(1, 45);
            int number4 = numberGenerator.Next(1, 45);
            int number5 = numberGenerator.Next(1, 45);
            int number6 = numberGenerator.Next(1, 45);
            number1Label.Content = $"Getal 1: {number1}";
            number2Label.Content = $"Getal 2: {number2}";
            number3Label.Content = $"Getal 3: {number3}";
            number4Label.Content = $"Getal 4: {number4}";
            number5Label.Content = $"Getal 5: {number5}";
            number6Label.Content = $"Getal 6: {number6}";

        }
    }
}