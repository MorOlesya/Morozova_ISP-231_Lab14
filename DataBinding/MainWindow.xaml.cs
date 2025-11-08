using DataBinding.Data;
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

namespace DataBinding
{
    public partial class MainWindow : Window
    {
        public List<Person> People = new List<Person>
        {
            new Person{Name = "Denis", Age = 15},
            new Person{Name = "Anton", Age = 13},
            new Person{Name = "Stat", Age = 15},
            new Person{Name = "Levi", Age = 21},
            new Person{Name = "Mikasa", Age = 18}
        };
        //Person person = new Person
        //{
        //    Name = "Ray",
        //    Age = 18
        //};
        public MainWindow()
        {
            InitializeComponent();
            ListBoxNames.ItemsSource = People;
            //this.DataContext = person;
            //ListBoxNames.ItemsSource = new List<string>()
            //{
            //    "Denis",
            //    "Anton",
            //    "Vlasimir",
            //    "Stas"
            //};
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxNames.SelectedItems;
            foreach (var item in selectedItems)
            {
                //MessageBox.Show(item.GetType().ToString());
                var person = (Person)item;
                MessageBox.Show(person.Name);
            }
        }
        //private void InfoClick_CLick(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show($"{person.Name} is {person.Age} years old.");
        //}
    }
}