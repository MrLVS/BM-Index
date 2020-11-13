using System;
using System.Collections.Generic;
using System.Linq;
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
using BM_Index.ViewModels;
using DevExpress.Xpf.Core;

namespace BM_Index
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Persone();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowActivity windowActivity = new WindowActivity();
            windowActivity.ShowDialog();
        }
    }
}
