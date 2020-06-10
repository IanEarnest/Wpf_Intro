using Intro;
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

        // Create a list in the ComboBox
        // In XAML set ComboBox template then data then textblock
        // and set binding to Property/ Variable
        // Class Person = FirstName, LastName, FullName (both together)
        //  1. List of Person (named people)
        //  2. Add to list
        //  3. Set myCBBox.ItemSource to a list<>
        //  4. ComboBox, .ItemTemplate, DataTemplate, TextBlock {Binding FirstName}

        public List<Person> people = new List<Person>();

        public MainWindow()
        {
            // TODO start
            InitializeComponent();

            AddPeopleToList();
            myCBBox.ItemsSource = people; // Set combobox to list 
            // {Binding} // Outputs "Intro.Person"
            // {Binding FirstName} // Outputs "Steve"
        }

        //nameTxt = TextBlock
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello: {nameTxt.Text}");


            // UNDONE moved to its own method
            NewWindow();
        }

        private void NewWindow()
        {
            // Hide this window and open new one
            //this.Visibility = Visibility.Hidden;
            Window1 myWindow1 = new Window1(); // HACK showing a second window
            myWindow1.Show();
        }

        private void AddPeopleToList()
        {
            Person person1 = newPerson("Steve1", "Smith");
            Person person2 = newPerson("Steve2", "Smith");
            Person person3 = newPerson("Steve3", "Smith");
            //people.Add(new Person { FirstName = "Steve", LastName = "Smith"});
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
        }

        private Person newPerson(string firstName, string lastName)
        {
            return new Person { FirstName = firstName, LastName = lastName };
        }
    }
}
