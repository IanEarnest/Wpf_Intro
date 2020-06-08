using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // IAmTimCorey course
        // https://www.youtube.com/watch?v=gSfMNjWNoX0&list=PLLWMQd6PeGY3QEHCmCWaUKNhmFFdIDxE8

        // use MVVM with WPF - Caliburn Micro (NuGet)

        // Task List =  TODO, UNDONE, HACK

        // UNDONE this
        public MainWindow()
        {
            // TODO start
            InitializeComponent();
            // HACK quick print
        }

        //nameTxt = TextBlock
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello: {nameTxt.Text}");
        }
    }
}
