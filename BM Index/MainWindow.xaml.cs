using System.Windows;
using BM_Index.ViewModels;

namespace BM_Index
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Persone();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var windowActivity = new WindowActivity();
            windowActivity.ShowDialog();
        }
    }
}