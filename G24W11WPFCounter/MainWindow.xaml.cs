
using System.Windows;


namespace G24W11WPFCounter
{
    public partial class MainWindow : Window
    {
        CounterViewModel vm = new CounterViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext= vm;
        }
        

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            vm.Value += 1;
        }
        private void OnSub(object sender, RoutedEventArgs e)
        {
            vm.Value -= 1;
           
        }
     }
}