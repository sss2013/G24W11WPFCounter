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

namespace G24W11WPFCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int count = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            TextCount.Text = $"{++count}";
        }
        private void OnSub(object sender, RoutedEventArgs e)
        {
            if (count > 0)
            {
                TextCount.Text = $"{--count}";
            }
        }
     }
}